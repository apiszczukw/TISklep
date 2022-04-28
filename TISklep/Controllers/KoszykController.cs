using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;
using TISklep.Infrastructure;
using TISklep.Models;

namespace TISklep.Controllers
{
    public class KoszykController : Controller
    {
        FilmyContext db;

        public KoszykController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);

            if (cart == null)
                cart = new List<CartItem>();

            ViewBag.total = cart.Sum(item => item.Ilosc * item.Film.Cena);

            return View(cart);
        }

        public IActionResult DodajDoKoszyka(int idFilmu)
        {
            var film = db.Filmy.Find(idFilmu);

            if(SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey) == null)
            {
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem()
                {
                    Film = film,
                    Ilosc = 1,
                    Wartosc = (decimal)film.Cena
                });

                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.CartSessionKey, cart);
            }
            else
            {
                List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);

                int index = GetIndex(idFilmu); 

                if(index != -1)
                {
                    cart[index].Ilosc++;
                }
                else
                {
                    cart.Add(new CartItem()
                    {
                        Film = film,
                        Ilosc = 1,
                        Wartosc = (decimal)film.Cena
                    });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.CartSessionKey, cart);
            }

            return RedirectToAction("Index");
        }

        private int GetIndex(int idFilmu)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);

            for (int i = 0; i < cart.Count; i++)
            {
                if(cart[i].Film.Id.Equals(idFilmu))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

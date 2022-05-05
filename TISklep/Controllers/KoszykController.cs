using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;
using TISklep.Infrastructure;
using TISklep.Models;
using TISklep.ViewModels;

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
            var cart = CartManager.GetItems(HttpContext.Session);

            ViewBag.total = CartManager.GetCartValue(HttpContext.Session);

            return View(cart);
        }

        public IActionResult DodajDoKoszyka(int idFilmu)
        {
            CartManager.AddToCart(HttpContext.Session, db, idFilmu);

            return RedirectToAction("Index");
        }

        public IActionResult UsunZKoszyka(int id)
        {
            var model = new UsuwanieElementuKoszykaViewModel()
            {
                Id = id,
                Ilosc = CartManager.RemoveFromCart(HttpContext.Session, id),
                WartoscKoszyka = CartManager.GetCartValue(HttpContext.Session)
            };

            return Json(model);
        }

    }
}

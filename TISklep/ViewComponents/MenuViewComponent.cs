using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;
using TISklep.Infrastructure;
using TISklep.Models;

namespace TISklep.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmyContext db;

        public MenuViewComponent(FilmyContext db)
        {
            this.db = db;
        }

        int GetCartQuantity()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);

            if (cart == null) cart = new List<CartItem>();

            return cart.Sum(item => item.Ilosc);
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var kategorie = db.Kategorie.ToList();

            ViewBag.quantity = GetCartQuantity();

            return await Task.FromResult((IViewComponentResult)View("_Menu", kategorie));
        }
    }
}

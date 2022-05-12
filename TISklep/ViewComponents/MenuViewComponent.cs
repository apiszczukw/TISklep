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


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var kategorie = db.Kategorie.ToList();

            ViewBag.quantity = CartManager.GetCartQuantity(HttpContext.Session);

            return await Task.FromResult((IViewComponentResult)View("_Menu", kategorie));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;

namespace TISklep.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;

        public FilmyController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult ListaFilmow(string nazwaKategorii)
        {
            var kategoria = db.Kategorie.Include("Filmy").Where(k => k.Nazwa == nazwaKategorii).Single();
            var filmy = kategoria.Filmy.ToList();

            return View(filmy);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

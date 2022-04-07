﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;
using TISklep.ViewModels;

namespace TISklep.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;
        IWebHostEnvironment hostEnvironment;

        public FilmyController(FilmyContext db, IWebHostEnvironment hostEnvironment)
        {
            this.db = db;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult ListaFilmow(string nazwaKategorii)
        {
            KategoriaViewModel vm = new KategoriaViewModel();

            var kategoria = db.Kategorie.Include("Filmy").Where(k => k.Nazwa == nazwaKategorii).Single();
            var filmy = kategoria.Filmy.ToList();
            

            vm.FilmyKategorii = filmy;
            vm.Kategoria = kategoria;
            vm.FilmyTop3Najnowsze = db.Filmy.OrderByDescending(f => f.DataDodania).Take(3);

            return View(vm);
        }

        public IActionResult Szczegoly(int idFilmu)
        {
            var kategoria = db.Kategorie.Find(db.Filmy.Find(idFilmu).KategoriaId);
            var film = db.Filmy.Find(idFilmu);

            return View(film);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WszystkieFilmy()
        {
            return View(db.Filmy.ToList());
        }

        [HttpGet]
        public IActionResult DodajFilm()
        {
            var model = new DodawanieFilmowViewModel();
            model.Kategorie = db.Kategorie.ToList();
                
            return View(model);
        }

        [HttpPost]
        public IActionResult DodajFilm(DodawanieFilmowViewModel obj)
        {
            obj.Film.DataDodania = DateTime.Now;

            var posterPath = Path.Combine(hostEnvironment.WebRootPath, "content");
            var posterName = Guid.NewGuid() + "_" + obj.Plakat.FileName;

            var filePath = Path.Combine(posterPath, posterName);
            obj.Plakat.CopyTo(new FileStream(filePath, FileMode.Create));

            obj.Film.Plakat = posterName;

            db.Filmy.Add(obj.Film);
            db.SaveChanges();

            return RedirectToAction("WszystkieFilmy");
        }
    }
}

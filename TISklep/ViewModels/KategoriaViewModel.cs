using System.Collections.Generic;
using TISklep.Models;

namespace TISklep.ViewModels
{
    public class KategoriaViewModel
    {

        public Kategoria Kategoria { get; set; }

        public IEnumerable<Film> FilmyKategorii { get; set; }

        public IEnumerable<Film> FilmyTop3Najnowsze { get; set; }
    }
}

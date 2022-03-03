using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TISklep.Models
{
    public class Kategoria
    {
        public int Id { get; set; }

        //public int KategoriaId { get; set; }

        //[Key]
        //public int IdKategorii { get; set; }

        public string Nazwa { get; set; }

        public string Opis { get; set; }

        public ICollection<Film> Filmy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TISklep.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nie podano tytułu")]
        public string Tytul { get; set; }

        public string Rezyser { get; set; }
        
        [StringLength(1000)]
        public string Opis { get; set; }

        public decimal? Cena { get; set; }

        public DateTime? DataProdukcji { get; set; }

        [ForeignKey("Kategoria")]
        public int KategoriaId { get; set; }

        public Kategoria Kategoria { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TISklep.Models
{
    public class CartItem
    {
        public Film Film { get; set; }

        public int Ilosc { get; set; }

        public decimal? Wartosc { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurcauIulia_Pizzerie.Models
{
    public class Aluat
    {
        public int ID { get; set; }
        public string TipAluat { get; set; }
        public ICollection<AluatPizza> BookCategories { get; set; }
    }
}

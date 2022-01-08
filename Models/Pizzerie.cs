using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurcauIulia_Pizzerie.Models
{
    public class Pizzerie
    {
        public int ID { get; set; }
        public string NumePizzerie { get; set; }
        public ICollection<Pizza> Pizzas { get; set; } //navigation property
    }
}

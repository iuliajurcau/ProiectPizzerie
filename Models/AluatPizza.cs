using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurcauIulia_Pizzerie.Models
{
    public class AluatPizza
    {
        public int ID { get; set; }
        public int PizzaID { get; set; }
        public Pizza Pizza { get; set; }
        public int AluatID { get; set; }
        public Aluat Aluat { get; set; }
    }
}

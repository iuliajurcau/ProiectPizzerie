using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JurcauIulia_Pizzerie.Models
{
    public class Pizza
    {
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 3)]
        [Display(Name = "Denumire Pizza")]
        public string Denumire { get; set; }
        public string Incrediente { get; set; }

        [Range(1, 200)]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataPlasareComanda { get; set; }

        public int PizzerieID { get; set; }
        public Pizzerie Pizzerie { get; set; }

        public ICollection<AluatPizza> AluatPizzas { get; set; }
    } 
}


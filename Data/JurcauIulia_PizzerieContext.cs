using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JurcauIulia_Pizzerie.Models;

namespace JurcauIulia_Pizzerie.Data
{
    public class JurcauIulia_PizzerieContext : DbContext
    {
        public JurcauIulia_PizzerieContext (DbContextOptions<JurcauIulia_PizzerieContext> options)
            : base(options)
        {
        }

        public DbSet<JurcauIulia_Pizzerie.Models.Pizza> Pizza { get; set; }

        public DbSet<JurcauIulia_Pizzerie.Models.Pizzerie> Pizzerie { get; set; }

        public DbSet<JurcauIulia_Pizzerie.Models.Aluat> Aluat { get; set; }
    }
}

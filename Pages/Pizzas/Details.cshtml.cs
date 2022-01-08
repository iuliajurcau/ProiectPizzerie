using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JurcauIulia_Pizzerie.Data;
using JurcauIulia_Pizzerie.Models;

namespace JurcauIulia_Pizzerie.Pages.Pizzas
{
    public class DetailsModel : PageModel
    {
        private readonly JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext _context;

        public DetailsModel(JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext context)
        {
            _context = context;
        }

        public Pizza Pizza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizza = await _context.Pizza.FirstOrDefaultAsync(m => m.ID == id);

            if (Pizza == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

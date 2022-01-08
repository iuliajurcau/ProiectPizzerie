using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JurcauIulia_Pizzerie.Data;
using JurcauIulia_Pizzerie.Models;

namespace JurcauIulia_Pizzerie.Pages.Pizzas
{
    public class CreateModel : PageModel
    {
        private readonly JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext _context;

        public CreateModel(JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PizzerieID"] = new SelectList(_context.Set<Pizzerie>(), "ID", "NumePizzerie");
            return Page();
        }

        [BindProperty]
        public Pizza Pizza { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pizza.Add(Pizza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

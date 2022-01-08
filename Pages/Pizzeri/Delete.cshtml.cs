using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JurcauIulia_Pizzerie.Data;
using JurcauIulia_Pizzerie.Models;

namespace JurcauIulia_Pizzerie.Pages.Pizzeri
{
    public class DeleteModel : PageModel
    {
        private readonly JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext _context;

        public DeleteModel(JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pizzerie Pizzerie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizzerie = await _context.Pizzerie.FirstOrDefaultAsync(m => m.ID == id);

            if (Pizzerie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizzerie = await _context.Pizzerie.FindAsync(id);

            if (Pizzerie != null)
            {
                _context.Pizzerie.Remove(Pizzerie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

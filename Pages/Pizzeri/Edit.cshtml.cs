using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JurcauIulia_Pizzerie.Data;
using JurcauIulia_Pizzerie.Models;

namespace JurcauIulia_Pizzerie.Pages.Pizzeri
{
    public class EditModel : PageModel
    {
        private readonly JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext _context;

        public EditModel(JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pizzerie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzerieExists(Pizzerie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PizzerieExists(int id)
        {
            return _context.Pizzerie.Any(e => e.ID == id);
        }
    }
}

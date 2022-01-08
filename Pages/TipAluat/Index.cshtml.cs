﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JurcauIulia_Pizzerie.Data;
using JurcauIulia_Pizzerie.Models;

namespace JurcauIulia_Pizzerie.Pages.TipAluat
{
    public class IndexModel : PageModel
    {
        private readonly JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext _context;

        public IndexModel(JurcauIulia_Pizzerie.Data.JurcauIulia_PizzerieContext context)
        {
            _context = context;
        }

        public IList<Aluat> Aluat { get;set; }

        public async Task OnGetAsync()
        {
            Aluat = await _context.Aluat.ToListAsync();
        }
    }
}

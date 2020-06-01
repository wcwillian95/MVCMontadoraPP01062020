using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVCMontadoraPP.Data;
using MVCMontadoraPP.Models;

namespace MVCMontadoraPP.Views.Pecas
{
    public class DetailsModel : PageModel
    {
        private readonly MVCMontadoraPP.Data.MVCMontadoraPPContext _context;

        public DetailsModel(MVCMontadoraPP.Data.MVCMontadoraPPContext context)
        {
            _context = context;
        }

        public Peca Peca { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Peca = await _context.Peca.FirstOrDefaultAsync(m => m.ID == id);

            if (Peca == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

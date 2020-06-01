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
    public class DeleteModel : PageModel
    {
        private readonly MVCMontadoraPP.Data.MVCMontadoraPPContext _context;

        public DeleteModel(MVCMontadoraPP.Data.MVCMontadoraPPContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Peca = await _context.Peca.FindAsync(id);

            if (Peca != null)
            {
                _context.Peca.Remove(Peca);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

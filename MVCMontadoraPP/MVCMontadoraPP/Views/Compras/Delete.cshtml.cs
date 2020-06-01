using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVCMontadoraPP.Data;
using MVCMontadoraPP.Models;

namespace MVCMontadoraPP.Views.Compras
{
    public class DeleteModel : PageModel
    {
        private readonly MVCMontadoraPP.Data.MVCMontadoraPPContext _context;

        public DeleteModel(MVCMontadoraPP.Data.MVCMontadoraPPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Compra Compra { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Compra = await _context.Compra.FirstOrDefaultAsync(m => m.Id == id);

            if (Compra == null)
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

            Compra = await _context.Compra.FindAsync(id);

            if (Compra != null)
            {
                _context.Compra.Remove(Compra);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

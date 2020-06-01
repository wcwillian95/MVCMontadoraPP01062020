using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVCMontadoraPP.Data;
using MVCMontadoraPP.Models;

namespace MVCMontadoraPP.Views.Vendas
{
    public class DetailsModel : PageModel
    {
        private readonly MVCMontadoraPP.Data.MVCMontadoraPPContext _context;

        public DetailsModel(MVCMontadoraPP.Data.MVCMontadoraPPContext context)
        {
            _context = context;
        }

        public Venda Venda { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Venda = await _context.Venda.FirstOrDefaultAsync(m => m.ID == id);

            if (Venda == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

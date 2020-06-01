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
    public class IndexModel : PageModel
    {
        private readonly MVCMontadoraPP.Data.MVCMontadoraPPContext _context;

        public IndexModel(MVCMontadoraPP.Data.MVCMontadoraPPContext context)
        {
            _context = context;
        }

        public IList<Peca> Peca { get;set; }

        public async Task OnGetAsync()
        {
            Peca = await _context.Peca.ToListAsync();
        }
    }
}

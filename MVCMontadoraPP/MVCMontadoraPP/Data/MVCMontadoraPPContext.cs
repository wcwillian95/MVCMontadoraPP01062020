using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMontadoraPP.Models;

namespace MVCMontadoraPP.Data
{
    public class MVCMontadoraPPContext : DbContext
    {
        public MVCMontadoraPPContext (DbContextOptions<MVCMontadoraPPContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMontadoraPP.Models.Cliente> Cliente { get; set; }

        public DbSet<MVCMontadoraPP.Models.Compra> Compra { get; set; }

        public DbSet<MVCMontadoraPP.Models.Fornecedor> Fornecedor { get; set; }

        public DbSet<MVCMontadoraPP.Models.Funcionario> Funcionario { get; set; }

        public DbSet<MVCMontadoraPP.Models.Peca> Peca { get; set; }

        public DbSet<MVCMontadoraPP.Models.Venda> Venda { get; set; }
    }
}

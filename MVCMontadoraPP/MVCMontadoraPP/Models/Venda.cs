using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMontadoraPP.Models
{
    public class Venda
    {
        [Display(Name = "Nº do Pedido")]
        public int ID { get; set; }
        [Display(Name = "Vendedor")]
        public string Vendedor_Venda { get; set; }
        [Display(Name = "Cliente")]
        public string Cliente_Venda { get; set; }
        [Display(Name = "Peça")]
        public string Peca_Venda { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade_Venda { get; set; }
        [Display(Name = "Valor Unitário")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ValorUnit_Venda { get; set; }
        [Display(Name = "Valor Total")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ValorFinal_Venda { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMontadoraPP.Models
{
    public class Compra
    {
        public int Id { get; set; }
        [Display(Name = "Peça")]
        public string Peca_Compra { get; set; }
        [Display(Name = "Fornecedor")]
        public string Fornecedor_Compra { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade_Compra { get; set; }
        [Display(Name = "Valor")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ValorUnitatio_Compra { get; set; }
        [Display(Name = "Total")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ValorTotal_Compra { get; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastroCompra { get; set; }
    }
}

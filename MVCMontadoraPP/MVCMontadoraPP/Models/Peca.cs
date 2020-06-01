using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMontadoraPP.Models
{
    public class Peca
    {
        public int ID { get; set; }
        [Display(Name = "Nome")]
        public string Nome_Peca { get; set; }
        [Display(Name = "Fornecedor")]
        public string Fornecedor_Peca { get; set; }
        [Display(Name = "Valor do Produto")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor_peca { get; set; }
        [Display(Name = "Código Produto")]
        public string Codigo_Peca { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMontadoraPP.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        [Display(Name = "Nome Completo")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Nome inválido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho inválido")]
        public string Nome_Cliente { get; set; }
        [Display(Name = "CPF")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "CPF inválido")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Tamanho do CPF inválido")]
        public string CPF_Cliente { get; set; }
        [Display(Name = "Telefone")]
        [DataType(DataType.Text)]
        public string Contato_Cliente { get; set; }
        [Display(Name = "Celular")]
        [DataType(DataType.Text)]
        public string Contatodois_Cliente { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email_Cliente { get; set; }
        [Display(Name = "CEP")]
        [DataType(DataType.Text)]
        public string CEP_Cliente { get; set; }
        [Display(Name = "Rua")]
        [DataType(DataType.Text)]
        public string Rua_Cliente { get; set; }
        [Display(Name = "Bairro")]
        [DataType(DataType.Text)]
        public string Bairro_Cliente { get; set; }
        [Display(Name = "Cidade")]
        [DataType(DataType.Text)]
        public string Cidade_Cliente { get; set; }
        [Display(Name = "Estado")]
        [DataType(DataType.Text)]
        public string Estado_Cliente { get; set; }
    }
}

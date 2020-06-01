using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMontadoraPP.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        [Display(Name = "Nome")]
        public string Nome_Funcionario { get; set; }
        [Display(Name = "Cargo")]
        public string Cargo_Funcionario { get; set; }
        [Display(Name = "CPF")]
        public string CPF_Funcionario { get; set; }
        [Display(Name = "Telefone")]
        public string Contato_Funcionario { get; set; }
        [Display(Name = "Celular")]
        public string Contatodois_Funcionario { get; set; }
        [Display(Name = "E-mail")]
        public string Email_Funcionario { get; set; }
        [Display(Name = "CEP")]
        public string CEP_Funcionario { get; set; }
        [Display(Name = "Rua")]
        public string Rua_Funcionario { get; set; }
        [Display(Name = "Bairro")]
        public string Bairro_Funcionario { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade_Funcionario { get; set; }
        [Display(Name = "Estado")]
        public string Estado_Funcionario { get; set; }
    }
}

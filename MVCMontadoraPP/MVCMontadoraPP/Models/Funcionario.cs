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
        [Display(Name = "Nome Completo")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Nome inválido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho inválido")] public string Nome_Funcionario { get; set; }
        [Display(Name = "Cargo")]
        public string Cargo_Funcionario { get; set; }
        [Display(Name = "CPF")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "CPF inválido")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Tamanho do CPF inválido")]
        public string CPF_Funcionario { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento_Funcionario { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Tamanho do Telefone inválido")]
        [Display(Name = "Telefone")]
        public string Contato_Funcionario { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Tamanho do Celular inválido")]
        [Display(Name = "Celular")]
        public string Contatodois_Funcionario { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "E-mail")]
        public string Email_Funcionario { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Tamanho do CEP inválido")]
        [Display(Name = "CEP")]
        public string CEP_Funcionario { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Rua")]
        public string Rua_Funcionario { get; set; }
        [Display(Name = "Bairro")]
        public string Bairro_Funcionario { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade_Funcionario { get; set; }
        [Display(Name = "Estado")]
        public string Estado_Funcionario { get; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastroFuncionario { get; set; }
    }
}

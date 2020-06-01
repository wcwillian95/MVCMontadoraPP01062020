﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMontadoraPP.Models
{
    public class Fornecedor
    {
        public int ID { get; set; }
        [Display(Name = "Empresa")]
        public string Nome_Fornecedor { get; set; }
        [Display(Name = "CNPJ")]
        public string CNPJ_Fornecedor { get; set; }
        [Display(Name = "Telefone")]
        public string Contato_Fornecedor { get; set; }
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email_Fornecedor { get; set; }
        [Display(Name = "CEP")]
        public string CEP_Fornecedor { get; set; }
        [Display(Name = "Rua")]
        public string Rua_Fornecedor { get; set; }
        [Display(Name = "Bairro")]
        public string Bairro_Fornecedor { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade_Fornecedor { get; set; }
        [Display(Name = "Estádo")]
        public string Estado_Fornecedor { get; set; }
    }
}

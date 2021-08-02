//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoTCC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Estudante
    {
        public int idFuncionario { get; set; }
        [Required(ErrorMessage = "Esse campo � obrigat�rio")]
        public string Nome_Instituicao { get; set; }
        [Required(ErrorMessage = "Esse campo � obrigat�rio")]
        [RegularExpression("(^[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2})$", ErrorMessage = "Por favor, preencha o campo no formato: 000.000.000-00")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Esse campo � obrigat�rio")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Esse campo � obrigat�rio")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Esse campo � obrigat�rio")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Esse campo � obrigat�rio")]
        [RegularExpression("(^[0-9]{5}[-][0-9]{3})$", ErrorMessage = "Por favor, preencha o campo no formato: 00000-000")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Esse campo � obrigat�rio")]
        [RegularExpression("^([^0-9])*$", ErrorMessage = "Esse campo n�o deve conter n�meros")]
        public string Nome_Aluno { get; set; }
        [Required(ErrorMessage = "Esse campo � obrigat�rio no formato: 00/00/0000")]
        public string Data_Nascimento { get; set; }
        [Required(ErrorMessage = "Esse campo � obrigat�rio")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Formato do Email Inv�lido")]
        public string Email { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace PizzariaPremiato.Controllers
{
    public class ContatoModel
    {
        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo nome deve ter no máximo 50 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo telefone é obrigatório!")]
        [MaxLength(20, ErrorMessage = "O campo Telefone deve ter no máximo 20 caracteres!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório!")]
        [MaxLength(70, ErrorMessage = "O campo E-mail deve ter no máximo 70 caracteres!")]
        [EmailAddress(ErrorMessage = "O campo email é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo mensagem é obrigatório!")]
        [MaxLength(2000, ErrorMessage = "O campo Mensagem deve ter no máximo 20 caracteres!")]
        public string Mensagem { get; set; }
    }
}
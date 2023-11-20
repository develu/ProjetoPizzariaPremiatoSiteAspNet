using System.ComponentModel.DataAnnotations;

namespace PizzariaPremiato.Models
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "O campo Email é obrigatório!")]
        [EmailAddress(ErrorMessage = "O Email é inválido!")]
        public string Email { get; set; }

       [Required(ErrorMessage = "O campo Senha é obrigatório!")]
       public string Senha { get; set; }
    }
}

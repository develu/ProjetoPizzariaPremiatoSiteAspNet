using System.ComponentModel.DataAnnotations.Schema;

namespace PizzariaPremiatoRepositorio.Entidades
{
    [Table("UsuarioLogin")]
    public class UsuarioLogin
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}

using PizzariaPremiatoDTO.UsuarioLogin;
using PizzariaPremiatoRepositorio.Database;
using PizzariaPremiatoRepositorio.Entidades;
using PizzariaPremiatoRepositorio.interfaces;
using System.Linq;

namespace PizzariaPremiatoRepositorio.repositorio
{
    public class UsuarioLoginRepositorio : IUsuarioLoginRepositorio
    {
        private DatabaseContext _contexto;
        public UsuarioLoginRepositorio(DatabaseContext context)
        {
            _contexto = context;
        }
        public UsuarioLogin LoginUsuario(UsuarioLoginDTO usuarioLogin)
        {
            var dadosUsuario = _contexto.UsuarioLogin.Where(usuario => usuario.Email == usuarioLogin.Email && usuario.Senha == usuarioLogin.Senha).FirstOrDefault();
            return dadosUsuario;
        }
    }
}

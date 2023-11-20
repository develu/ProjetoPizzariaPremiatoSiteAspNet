using PizzariaPremiatoDTO.UsuarioLogin;
using PizzariaPremiatoRepositorio.Entidades;

namespace PizzariaPremiatoRepositorio.interfaces
{
    public interface IUsuarioLoginRepositorio
    {
        UsuarioLogin LoginUsuario(UsuarioLoginDTO usuarioLogin);
    }
}

using PizzariaPremiatoDTO.UsuarioLogin;

namespace PizzariaPremiatoServicos.Interfaces.UsuarioLogin
{
    public interface IUsuarioLoginServico
    {
        UsuarioLoginResponse LoginUsuario(UsuarioLoginDTO usuarioLogin);
    }
}

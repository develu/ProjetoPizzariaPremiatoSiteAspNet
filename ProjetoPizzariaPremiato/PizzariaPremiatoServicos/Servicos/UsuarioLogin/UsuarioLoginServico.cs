using PizzariaPremiatoDTO.UsuarioLogin;
using PizzariaPremiatoRepositorio.interfaces;
using PizzariaPremiatoServicos.Interfaces.UsuarioLogin;

namespace PizzariaPremiatoServicos.Servicos.UsuarioLogin
{
    public class UsuarioLoginServico : IUsuarioLoginServico
    {
        private IUsuarioLoginRepositorio _UsuarioLoginRepositorio;
        public UsuarioLoginServico(IUsuarioLoginRepositorio usuarioLoginRepositorio)
        {
            this._UsuarioLoginRepositorio = usuarioLoginRepositorio;
        }
        public UsuarioLoginResponse LoginUsuario(UsuarioLoginDTO usuarioLogin)
        {
            var usuario = _UsuarioLoginRepositorio.LoginUsuario(usuarioLogin);

            if (usuario == null) return null;

            var usuarioResposta = new UsuarioLoginResponse();
            usuarioResposta.Email = usuario.Email;
            usuarioResposta.NomeUsuario = usuario.Nome;

            return usuarioResposta;
        }
    }
}

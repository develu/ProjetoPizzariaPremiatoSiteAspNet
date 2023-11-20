using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzariaPremiato.Biblioteca.Mail.Filters;
using PizzariaPremiato.Models;
using PizzariaPremiatoDTO.UsuarioLogin;
using PizzariaPremiatoServicos.Interfaces.UsuarioLogin;
using PizzariaPremiatoUtils.Cripto;
using System;


namespace PizzariaPremiato.Controllers
{
    public class AdminController : Controller
    {

        private IUsuarioLoginServico _UsuarioLoginServico;

        public AdminController(IUsuarioLoginServico usuarioLoginServico)
        {
            this._UsuarioLoginServico = usuarioLoginServico;
        }

        [Login]
        public IActionResult Index()
        {            
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm] UsuarioModel usuario)
        {

            try
            {

                if (ModelState.IsValid)
                {
                    var usuarioLogin = _UsuarioLoginServico.LoginUsuario(new UsuarioLoginDTO() { Email = usuario.Email, Senha = CriptografarSenha.codificarSenha(usuario.Senha) });

                    if (usuarioLogin == null)
                    {
                        ViewBag.Mensagem = "Os dados informados são inválidos!";
                        return View();
                    }
                    else
                    {
                        HttpContext.Session.SetString("Login", "true");
                        HttpContext.Session.SetString("NomeUsuario", usuarioLogin.NomeUsuario);
                        return RedirectToAction("Index", "Admin");
                    }
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Mensagem = "Erro para acessar o sistema, tente novamente mais tarde!";
                return View();
            }

        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("login", "Admin");
        }

    }
}

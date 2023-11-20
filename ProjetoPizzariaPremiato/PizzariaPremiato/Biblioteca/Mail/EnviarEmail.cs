using PizzariaPremiato.Controllers;
using System.Net;
using System.Net.Mail;

namespace PizzariaPremiato.Biblioteca.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(ContatoModel contato)
        {
            string conteudo = string.Format("Nome: {0}<br/> E-mail: {1}<br/> Telefone: {2}<br/> Mensagem: {3}", contato.Nome, contato.Email, contato.Telefone, contato.Mensagem);

            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("veluccg@gmail.com");
            mensagem.To.Add("veluccg@gmail.com");
            mensagem.Subject = "Formulário de Contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de Contato</h1>" + conteudo;

            smtp.Send(mensagem);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PizzariaPremiato.Biblioteca.Mail;


namespace PizzariaPremiato.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Contato = new ContatoModel();
            return View();
        }

        public IActionResult ReceberContato([FromForm] ContatoModel contato)
        {
            if (ModelState.IsValid)
            {                                

                ViewBag.Contato = new ContatoModel();
                EnviarEmail.EnviarMensagemContato(contato);
                ViewBag.Mensagem = "Mensagem enviada com sucesso!";
                return View("Index");
            }
            else
            {
                ViewBag.Contato = contato;

                return View("Index");
            }
        
           
        }
       
    }
}
/* public IActionResult ReceberContato()
        {
            Contato contato =  new Contato();
            
            
             contato.Nome = Request.Form["nome"];
             contato.Email = Request.Form["email"];
             contato.Email = Request.Form["telefone"];
             contato.Mensagem = Request.Form["mensagem"];

            string conteudo = string.Format( "Nome: {0}, E-mail: {1}, Telefone: {2}, Mensagem: {3}",contato.Nome, contato.Email, contato.Telefone, contato.Mensagem );
            return new ContentResult() { Content = conteudo};
        }*/
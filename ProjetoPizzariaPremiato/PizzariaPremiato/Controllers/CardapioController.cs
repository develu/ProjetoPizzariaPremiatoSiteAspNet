using Microsoft.AspNetCore.Mvc;
using PizzariaPremiato.Models;
using PizzariaPremiatoServicos.Interfaces.Pizza;
using System.Collections.Generic;

namespace PizzariaPremiato.Controllers
{
    public class CardapioController : Controller
    {
        private IPizzaServico _pizzaServico;

        public CardapioController(IPizzaServico pizzariaServico)
        {
            this._pizzaServico = pizzariaServico;
        }
        public IActionResult Index()
        {
            var lstPizzaDto = _pizzaServico.ListarPizza();
            var lstPizzaModel = new List<PizzaModel>();

            foreach (var dto in lstPizzaDto)
            {
                lstPizzaModel.Add((PizzaModel)dto);
            }

            return View(lstPizzaModel);
        }
    }
}

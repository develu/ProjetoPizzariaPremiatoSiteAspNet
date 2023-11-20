using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaPremiato.Controllers
{
    public class SobreNosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

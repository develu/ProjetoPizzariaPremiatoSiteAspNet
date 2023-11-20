using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzariaPremiato.Biblioteca.Mail.Filters;
using PizzariaPremiato.Models;
using PizzariaPremiato.Models.Request;
using PizzariaPremiatoDTO.Categoria;
using PizzariaPremiatoDTO.Pizza;
using PizzariaPremiatoServicos.Interfaces.Categoria;
using PizzariaPremiatoServicos.Interfaces.Pizza;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzariaPremiato.Controllers
{
    [Login]
    public class PizzaController : Controller
    {
        
        private IPizzaServico _pizzaServico;
        private ICategoriaServico _categoriaServico;

        string[] imageTypes = new string[]{
                    "image/jpeg",
                    "image/pjpeg",
                    "image/png"
            };

        public PizzaController(IPizzaServico pizzaServico, ICategoriaServico categoriaServico)
        {
            this._pizzaServico = pizzaServico;
            this._categoriaServico = categoriaServico;

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

        public IActionResult Cadastrar()
        {
            TempData["lstCategoria"] = CategoriaDtoToModel(_categoriaServico.ListarCategoria());
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(PizzaRequest request)
        {

            try
            {
                _validarFoto(request.Foto);
                string fotoBase64 = "";

                if (ModelState.IsValid)
                {
                    var file = request.Foto;
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        file.CopyTo(memoryStream);
                        byte[] fileBytes = memoryStream.ToArray();
                        fotoBase64 = Convert.ToBase64String(fileBytes);

                    }

                    _pizzaServico.Cadastrar(new PizzaDTO()
                    {
                        Nome = request.Nome,
                        Descricao = request.Descricao,
                        Categoria = new CategoriaDTO()
                        {
                            Id = request.CategoriaId
                        },
                        DataCadastro = DateTime.Now,
                        Foto = "data:image/jpeg;base64," + fotoBase64,
                        Valor = request.Valor
                    });

                    TempData["Mensagem"] = "Cadastro realizado com sucesso!";
                }
                else
                {
                    TempData["lstCategoria"] = CategoriaDtoToModel(_categoriaServico.ListarCategoria());
                    return View();
                }
            }
            catch (Exception ex)
            {

                TempData["Mensagem"] = "Erro para realizar cadastro!";
            }

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int idPizza)
        {
            TempData["lstCategoria"] = CategoriaDtoToModel(_categoriaServico.ListarCategoria());
            var pizzaDto = _pizzaServico.BuscarPizzaPorId(idPizza);            
            return View((PizzaModel)pizzaDto);
        }

        [HttpPost]
        public IActionResult Editar(PizzaRequest request)
        {

            try
            {
                if (request.UpdateFoto == true)
                {
                    _validarFoto(request.Foto);                    
                }

                string fotoBase64 = "";

                if (ModelState.IsValid)
                {

                    if (request.UpdateFoto == true)
                    {
                        var file = request.Foto;
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            file.CopyTo(memoryStream);
                            byte[] fileBytes = memoryStream.ToArray();
                            fotoBase64 = Convert.ToBase64String(fileBytes);

                        }
                    }

                    _pizzaServico.Editar(new PizzaDTO()
                    {
                        Id = (int)request.Id,
                        Nome = request.Nome,
                        Descricao = request.Descricao,
                        Foto = string.IsNullOrEmpty(fotoBase64) ? string.Empty : "data:image/jpeg;base64," + fotoBase64,
                        Valor = request.Valor,
                        Categoria = new CategoriaDTO()
                        {
                            Id = request.CategoriaId
                        }
                    });

                    TempData["Mensagem"] = "Atualização realizada com sucesso!";
                }
                else
                {
                    TempData["lstCategoria"] = CategoriaDtoToModel(_categoriaServico.ListarCategoria());
                    var pizzaModel = _pizzaServico.BuscarPizzaPorId((int)request.Id);
                    return View((PizzaModel)pizzaModel);
                }
            }
            catch (Exception ex)
            {

                TempData["Mensagem"] = "Erro para realizar atualização!";
            }

            return RedirectToAction("Index");
        }


        public IActionResult Deletar(int idPizza)
        {
            try
            {
                _pizzaServico.Deletar(idPizza);
                TempData["Mensagem"] = "Removido com sucesso!";
            }
            catch (Exception ex)
            {
                TempData["Mensagem"] = "Erro para remover pizza!";
            }

            return RedirectToAction("Index");
        }

        private List<CategoriaModel> CategoriaDtoToModel(List<CategoriaDTO> lstDto)
        {

            var lstModel = new List<CategoriaModel>();

            foreach (var x in lstDto)
            {
                lstModel.Add((CategoriaModel)x);
            }

            return lstModel;
        }

        private void _validarFoto(IFormFile foto)
        {
            if (foto == null || foto.Length == 0)
            {
                ModelState.AddModelError("Foto", "Este campo é obrigatório");
            }
            else if (!imageTypes.Contains(foto.ContentType))
            {
                ModelState.AddModelError("Foto", "Escolha uma imagem JPG ou PNG.");
            }
        }
    }
}

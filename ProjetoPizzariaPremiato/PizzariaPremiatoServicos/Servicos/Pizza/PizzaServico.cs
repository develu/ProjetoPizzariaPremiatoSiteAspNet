using PizzariaPremiatoDTO.Categoria;
using PizzariaPremiatoDTO.Pizza;
using PizzariaPremiatoRepositorio.interfaces;
using PizzariaPremiatoServicos.Interfaces.Pizza;
using System.Collections.Generic;

namespace PizzariaPremiatoServicos.Servicos.Pizza
{
    public class PizzaServico : IPizzaServico
    {
        private IPizzaRepositorio _pizzaRepositorio;

        public PizzaServico(IPizzaRepositorio pizzaRepositorio)
        {
            this._pizzaRepositorio = pizzaRepositorio;
        }

        public void Cadastrar(PizzaDTO dto)
        {
            _pizzaRepositorio.Cadastrar(dto);
        }

        public void Editar(PizzaDTO dto)
        {
            _pizzaRepositorio.Editar(dto);
        }

        public List<PizzaDTO> ListarPizza()
        {
            var lstEntidade = _pizzaRepositorio.ListarPizza();

            var lstPizzaDto = new List<PizzaDTO>();

            foreach (var pizzaEnt in lstEntidade)
            {
                lstPizzaDto.Add(
                    new PizzaDTO()
                    {
                        Id = pizzaEnt.Id,
                        Nome = pizzaEnt.Nome,
                        Descricao = pizzaEnt.Descricao,
                        DataCadastro = pizzaEnt.DataCadastro,
                        Foto = pizzaEnt.FotoBase64,
                        Valor = pizzaEnt.Valor,
                        Categoria = new CategoriaDTO()
                        {
                            Id = pizzaEnt.Categoria.Id,
                            Nome = pizzaEnt.Categoria.Nome,
                            Descricao = pizzaEnt.Categoria.Descricao,
                            DataCadastro = pizzaEnt.Categoria.DataCadastro
                        }
                    }
                    );
            }

            return lstPizzaDto;
        }

        public void Deletar(int idPizza)
        {
            _pizzaRepositorio.Deletar(idPizza);
        }

        public PizzaDTO BuscarPizzaPorId(int idPizza)
        {
            return _pizzaRepositorio.BuscarPizzaPorId(idPizza);
        }
     
    }
}

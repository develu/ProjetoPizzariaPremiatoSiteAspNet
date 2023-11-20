using PizzariaPremiatoDTO.Pizza;
using PizzariaPremiatoRepositorio.Entidades;
using System.Collections.Generic;

namespace PizzariaPremiatoRepositorio.interfaces
{
    public interface IPizzaRepositorio
    {
        List<Pizza> ListarPizza();

        PizzaDTO BuscarPizzaPorId(int idPizza);

        void Cadastrar(PizzaDTO dto);

        void Editar(PizzaDTO dto);

        void Deletar(int idPizza);
    }
}

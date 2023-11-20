using PizzariaPremiatoDTO.Pizza;
using System.Collections.Generic;

namespace PizzariaPremiatoServicos.Interfaces.Pizza
{
    public interface IPizzaServico
    {
        List<PizzaDTO> ListarPizza();

        PizzaDTO BuscarPizzaPorId(int idPizza);

        void Cadastrar(PizzaDTO dto);

        void Editar(PizzaDTO dto);

        void Deletar(int idPizza);        
          
    }
}

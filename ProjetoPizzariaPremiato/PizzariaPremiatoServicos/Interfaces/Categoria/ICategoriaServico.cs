using PizzariaPremiatoDTO.Categoria;
using System.Collections.Generic;

namespace PizzariaPremiatoServicos.Interfaces.Categoria
{
    public interface ICategoriaServico
    {
        List<CategoriaDTO> ListarCategoria();
    }
}

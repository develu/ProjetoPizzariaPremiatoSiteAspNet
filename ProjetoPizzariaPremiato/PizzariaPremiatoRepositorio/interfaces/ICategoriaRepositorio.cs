using PizzariaPremiatoDTO.Categoria;
using System.Collections.Generic;

namespace PizzariaPremiatoRepositorio.interfaces
{
    public interface ICategoriaRepositorio
    {
        List<CategoriaDTO> ListarCategoria();
    }
}

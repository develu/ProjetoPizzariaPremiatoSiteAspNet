using PizzariaPremiatoDTO.Categoria;
using PizzariaPremiatoRepositorio.interfaces;
using PizzariaPremiatoServicos.Interfaces.Categoria;
using System.Collections.Generic;

namespace PizzariaPremiatoServicos.Servicos.Categoria
{
    public class CategoriaServico : ICategoriaServico
    {
        private ICategoriaRepositorio _ICategoriaRepositorio;

        public CategoriaServico(ICategoriaRepositorio iCategoriaRepositorio)
        {
            this._ICategoriaRepositorio = iCategoriaRepositorio;
        }
        public List<CategoriaDTO> ListarCategoria()
        {
            return _ICategoriaRepositorio.ListarCategoria();
        }
    }
}

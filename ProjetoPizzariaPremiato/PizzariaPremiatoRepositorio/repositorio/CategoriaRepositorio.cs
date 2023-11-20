using PizzariaPremiatoDTO.Categoria;
using PizzariaPremiatoRepositorio.Database;
using PizzariaPremiatoRepositorio.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzariaPremiatoRepositorio.repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private DatabaseContext _contexto;

        public CategoriaRepositorio(DatabaseContext contexto)
        {
            this._contexto = contexto;
        }

        public List<CategoriaDTO> ListarCategoria()
        {
            var lstEntity = _contexto.CategoriaEntity.ToList();
            var lstDto = new List<CategoriaDTO>();

            foreach (var e in lstEntity)
            {
                lstDto.Add(new CategoriaDTO()
                {
                    Id = e.Id,
                    Nome = e.Nome,
                    Descricao = e.Descricao,
                    DataCadastro = e.DataCadastro
                }
                );
            }

            return lstDto;
        }
    }
}

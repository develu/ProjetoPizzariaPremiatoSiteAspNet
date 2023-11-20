using PizzariaPremiatoDTO.Categoria;
using System;

namespace PizzariaPremiato.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }

        public static explicit operator CategoriaModel(CategoriaDTO dto)
        {
            return new CategoriaModel()
            {

                Id = dto.Id,
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                DataCadastro = dto.DataCadastro
            };
        }
    }
}

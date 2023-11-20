using PizzariaPremiatoDTO.Pizza;
using System;

namespace PizzariaPremiato.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public CategoriaModel Categoria { get; set; }
        public string Foto { get; set; }
        public Decimal Valor { get; set; }

        public static explicit operator PizzaModel(PizzaDTO dto)
        {

            return new PizzaModel()
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                DataCadastro = dto.DataCadastro,
                Foto = dto.Foto,
                Valor = dto.Valor,
                Categoria = new CategoriaModel()
                {

                    Id = dto.Categoria.Id,
                    Nome = dto.Categoria.Nome,
                    Descricao = dto.Categoria.Descricao,
                    DataCadastro = dto.Categoria.DataCadastro
                }
            };
        }
    }
}

using PizzariaPremiatoDTO.Categoria;
using System;

namespace PizzariaPremiatoDTO.Pizza
{
    public class PizzaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public CategoriaDTO Categoria { get; set; }

        public Decimal Valor { get; set; }

        public string Foto { get; set; }
    }
}

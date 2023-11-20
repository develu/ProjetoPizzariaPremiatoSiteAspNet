using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzariaPremiatoRepositorio.Entidades
{
    [Table("Categoria")]
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}

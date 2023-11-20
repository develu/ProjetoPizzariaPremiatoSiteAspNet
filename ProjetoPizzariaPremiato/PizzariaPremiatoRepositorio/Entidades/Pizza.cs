using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzariaPremiatoRepositorio.Entidades
{
    [Table("Pizza")]
    public class Pizza
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string FotoBase64 { get; set; }

        public DateTime DataCadastro { get; set; }

        public Decimal Valor { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}

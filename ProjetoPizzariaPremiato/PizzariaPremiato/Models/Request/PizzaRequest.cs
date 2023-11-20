using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace PizzariaPremiato.Models.Request
{
    public class PizzaRequest
    {        
        public int? Id { get; set; } = null;

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [MaxLength(30)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório!")]
        [MaxLength(200)]
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Selecione uma Categoria!")]        
        public int CategoriaId { get; set; }

        public IFormFile Foto { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Valor inválido!")]
        [Range(0, 9999999999999999.99, ErrorMessage = "Valor inválido!")]
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        public decimal Property { get; set; }
        public Decimal Valor { get; set; }

        public bool UpdateFoto { get; set; } = false;

    }
}

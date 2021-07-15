using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_Produtos.Data
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 80 caracteres")]
        [MaxLength(80, ErrorMessage = "Esse campo deve conter entre 3 e 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Preco { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Status { get; set; }

    }
}

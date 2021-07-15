using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Meus_Produtos.Data
{
    public class Usuarios
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 20 caracteres")]
        [MaxLength(20, ErrorMessage = "Esse campo deve conter entre 3 e 20 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Email { get; set; }

        public bool IsValidEmail(string Email)
        {
            return new EmailAddressAttribute().IsValid(Email);
        }



        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(8, ErrorMessage = "Esse campo deve conter entre 8 e 20 caracteres")]
        [MaxLength(20, ErrorMessage = "Esse campo deve conter entre 8 e 20 caracteres")]
        public string Senha { get; set; }

        public string CriarHash(string Senha)
        {
            var md5 = MD5.Create();
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(Senha);
            byte[] hash = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}

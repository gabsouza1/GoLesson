using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(256, ErrorMessage = "Máximo de 256 caracteres", MinimumLength = 3)]
        public string NomeCompleto { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare(nameof(Email), ErrorMessage = "Os endereços de e-mail não correspondem.")]
        public string ConfirmarEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Senha), ErrorMessage = "As senhas não correspondem")]
        public string ConfirmarSenha { get; set; }
    }
}

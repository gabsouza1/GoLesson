using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class CadastroViewModel
    {
        [Required(ErrorMessage = "O campo {0} obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string SobreNome { get; set; }
        [Required(ErrorMessage = "O campo {0} obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} é invalido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo {0} obrigatório")]
        [Compare(nameof(Email), ErrorMessage = "Email não coincidem")]
        public string ConfirmarEmail { get; set; }
        [Required(ErrorMessage = "O campo {0} obrigatório")]
        [PasswordPropertyText]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo {0} obrigatório")]
        [Compare(nameof(Senha), ErrorMessage = "Senhas não coincidem")]
        [PasswordPropertyText]
        public string ConfirmarSenha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [Required(ErrorMessage = "Campo Obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Compare(nameof(Email), ErrorMessage = "Os endereços de e-mail não correspondem.")]
        public string ConfirmarEmail { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Genero { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("Código Postal")]
        public string CodigoPostal { get; set; }

        public string Numero { get; set; }

        public string UF { get; set; }

        public string Logradouro { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }
        public string? Foto { get; set; }
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNasc { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Password)]
        [Compare(nameof(Senha), ErrorMessage = "As senhas não correspondem")]
        public string ConfirmarSenha { get; set; }
    }
}

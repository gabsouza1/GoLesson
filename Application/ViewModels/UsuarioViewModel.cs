using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; } 
        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(256, ErrorMessage = "Máximo de 256 caracteres", MinimumLength = 3)]
        public string NomeCompleto { get; set; }

        [EmailAddress(ErrorMessage = "Formato de Email inválido")]
        public string? Email { get; set; }

        [Compare(nameof(Email), ErrorMessage = "Os endereços de e-mail não correspondem.")]
        public string? ConfirmarEmail { get; set; }

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
        public string? Foto {  get; set; }

        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNasc { get; set; }

        [DataType(DataType.Password)]
        public string? Senha { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(Senha), ErrorMessage = "As senhas não correspondem")]
        public string? ConfirmarSenha { get; set; }
        [NotMapped]
        public virtual ICollection<UsuarioCursoViewModel>? UsuarioCursos { get; set; }
    }
}

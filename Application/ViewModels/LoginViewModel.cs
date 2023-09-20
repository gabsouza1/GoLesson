using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Preencha o email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Lembrar de mim?")]
        public bool LembrarDeMim { get; set; }
    }
}

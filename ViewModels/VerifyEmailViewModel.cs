using System.ComponentModel.DataAnnotations;

namespace EspaçoVerdeLogin.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }
    }
}

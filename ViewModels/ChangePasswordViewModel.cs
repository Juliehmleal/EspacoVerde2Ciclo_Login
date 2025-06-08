using System.ComponentModel.DataAnnotations;

namespace EspaçoVerdeLogin.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha obrigatória")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Minimo de {0} caracteres e máximo de {1}")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Senhas não estão iguais")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirmação de senha obrigatória")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme a nova senha")]
        public string ConfirmNewPassword { get; set; }
    }
}

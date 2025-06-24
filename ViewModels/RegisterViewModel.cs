using System.ComponentModel.DataAnnotations;

namespace EspaçoVerdeLogin.ViewModels
{
    public class RegisterViewModel
    {
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Razão Social deve ter entre 10 a 50 caracteres")]
        [Required(ErrorMessage = "Razão Social Obrigatória")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O CNPJ é obrigatório.")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$",
                           ErrorMessage = "Formato de CNPJ inválido. Use XX.XXX.XXX/XXXX-XX.")]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "a senha deve ter no minimo 8 e no máximo 40 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [Compare("ConfirmPassword", ErrorMessage = "Senhas não estão iguais")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmação de senha necessária")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmPassword { get; set; }
    }
}

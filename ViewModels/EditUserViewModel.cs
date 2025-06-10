// EspaçoVerdeLogin.Models/EditUserViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace EspaçoVerdeLogin.Models
{
    public class EditUserViewModel
    {
        [Required]
        public string Id { get; set; } // O Id é necessário para identificar o usuário a ser editado

        [Required(ErrorMessage = "A Razão Social é obrigatória.")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O CNPJ é obrigatório.")]
        // Adicione uma expressão regular mais robusta para CNPJ se desejar
        //[RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$", ErrorMessage = "Formato de CNPJ inválido. Use XX.XXX.XXX/XXXX-XX")]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Por favor, insira um endereço de email válido.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        // Não inclua propriedades que você não quer que o usuário edite diretamente
        // como senhas, roles, etc.
    }
}
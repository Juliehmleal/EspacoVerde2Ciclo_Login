// EspaçoVerdeLogin.Models/DeleteUserViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace EspaçoVerdeLogin.Models
{
    public class DeleteUserViewModel
    {
        [Required]
        public string Id { get; set; } // Necessário para identificar qual usuário será excluído

        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        // Você pode adicionar mais propriedades aqui se quiser exibí-las para confirmação antes da exclusão
    }
}
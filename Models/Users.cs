using Microsoft.AspNetCore.Identity;

namespace EspaçoVerdeLogin.Models
{
    public class Users : IdentityUser
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public ICollection<Residuo> Residuos { get; set; }
        public ICollection<Transacao> TransacoesComoComprador { get; set; }
    }
}

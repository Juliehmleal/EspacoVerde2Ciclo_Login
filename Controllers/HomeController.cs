using System.Diagnostics;
using EspaçoVerdeLogin.Data;
using EspaçoVerdeLogin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EspaçoVerdeLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Users> _userManager;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, UserManager<Users> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            // Buscar resíduos com os dados do usuário dono e transação (se houver)
            var residuos = _context.Residuos
                .Include(r => r.Usuario)
                .Include(r => r.Transacao)
                .Include(r => r.Localizacao)
                .ToList();

            return View(residuos);
        }

        public IActionResult SobreNos()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public  async Task<IActionResult> Usuarios()
        {
            return View(await _context.Users.ToListAsync());
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> EditarUsuario(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var usuario = await _userManager.FindByIdAsync(id); // Use _userManager para buscar o usuário
                                                                // porque ele pode carregar mais informações relacionadas
                                                                // do que _context.Users.FindAsync(id) em alguns cenários.

            if (usuario == null)
            {
                return NotFound();
            }

            // Mapeie o objeto Users para o ViewModel
            var model = new EditUserViewModel
            {
                Id = usuario.Id,
                RazaoSocial = usuario.RazaoSocial,
                CNPJ = usuario.CNPJ,
                Email = usuario.Email
            };

            return View(model); // Passe o ViewModel para a View
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarUsuario(string id, EditUserViewModel model)
        {
            // Primeira validação: o ID na URL deve corresponder ao ID no formulário
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid) // Agora o ModelState.IsValid deve funcionar corretamente para o ViewModel
            {
                var usuario = await _userManager.FindByIdAsync(id);
                if (usuario == null)
                {
                    return NotFound();
                }

                // Atualize as propriedades do objeto 'usuario' (IdentityUser) com os dados do ViewModel
                usuario.Email = model.Email;
                usuario.UserName = model.Email; // UserManager geralmente usa Email como UserName para login
                usuario.RazaoSocial = model.RazaoSocial;
                usuario.CNPJ = model.CNPJ;

                // Tente atualizar o usuário usando UserManager
                var result = await _userManager.UpdateAsync(usuario);
                if (result.Succeeded)
                {
                    // Se a atualização for bem-sucedida, redirecione para a lista de usuários
                    return RedirectToAction(nameof(Usuarios));
                }

                // Se houver erros do UserManager (ex: email já em uso), adicione ao ModelState
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // Se o ModelState for inválido (erros de validação do ViewModel ou do UserManager),
            // retorne a View com o ViewModel para exibir os erros.
            return View(model);
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ExcluirUsuario(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var usuario = await _userManager.FindByIdAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            // Mapeia o objeto Users para o DeleteUserViewModel antes de passar para a View
            var model = new DeleteUserViewModel
            {
                Id = usuario.Id,
                RazaoSocial = usuario.RazaoSocial,
                CNPJ = usuario.CNPJ,
                Email = usuario.Email
            };

            return View(model); // Passa o DeleteUserViewModel para a View
        }

        [Authorize]
        [HttpPost, ActionName("ExcluirUsuario")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmarExclusaoUsuario(string id) // Removido o 'DeleteUserViewModel model' do parâmetro
        {
            // O ViewModel não é necessário como parâmetro de entrada para um POST de exclusão,
            // pois o formulário de exclusão geralmente envia apenas o ID.
            // O ID já vem da rota (string id).

            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var usuario = await _userManager.FindByIdAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(usuario);

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Usuarios)); // Redireciona para a lista após a exclusão
            }

            // Se houver erros, adicione-os ao ModelState
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            // Se a exclusão falhar, você precisa criar um novo DeleteUserViewModel
            // para retornar à View e exibir os dados do usuário que não pôde ser excluído
            // juntamente com os erros.
            var viewModelParaRetorno = new DeleteUserViewModel
            {
                Id = usuario.Id,
                RazaoSocial = usuario.RazaoSocial,
                CNPJ = usuario.CNPJ,
                Email = usuario.Email
            };

            return View(viewModelParaRetorno); // Retorna a View de confirmação com os erros e o ViewModel preenchido
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

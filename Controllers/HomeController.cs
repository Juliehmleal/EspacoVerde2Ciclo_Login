using System.Diagnostics;
using EspaçoVerdeLogin.Data;
using EspaçoVerdeLogin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EspaçoVerdeLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

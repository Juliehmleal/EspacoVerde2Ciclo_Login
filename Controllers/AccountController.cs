using EspaçoVerdeLogin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using EspaçoVerdeLogin.Models;
using Microsoft.AspNetCore.Identity;

namespace EspaçoVerdeLogin.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Users> _signInManager;
        private readonly UserManager<Users> _userManager;

        public AccountController(SignInManager<Users> signInManager, UserManager<Users> userManager)
        {
            this._signInManager = signInManager;
            this._userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email or password is incorrect.");
                    return View(model);
                }
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                Users user = new Users
                {
                    UserName = model.Email,
                    RazaoSocial = model.RazaoSocial,
                    Email = model.Email,
                    CNPJ = model.CNPJ,
                };
                
                var result = await _userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    return View(model);
                }
            }
            return View(model);
        }

        public IActionResult VerifyEmail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VerifyEmail(VerifyEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Email);

                if (user == null)
                {
                    ModelState.AddModelError("", "Something is wrong!");
                    return View(model);
                }
                else
                {
                    return RedirectToAction("ChangePassword", "Account", new { username = user.UserName });
                }
            }
            return View(model);
        }

        public IActionResult ChangePassword(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("VerifyEmail", "Account");
            }
            return View(new ChangePasswordViewModel { Email = username });
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Email);
                if (user != null)
                {
                    var result = await _userManager.RemovePasswordAsync(user);
                    if (result.Succeeded)
                    {
                        result = await _userManager.AddPasswordAsync(user, model.NewPassword);
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {

                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email not found!");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Something went wrong. try again.");
                return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

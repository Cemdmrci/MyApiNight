using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyApiNight.EntityLayer.Concrete;
using MyApiNight.WebUI.Models;

namespace MyApiNight.WebUI.Controllers
{
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(LoginViewModel model)
		{
			var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);//false:Beni hatırlar mısın,True:Kullanıcı her bir yanlış girdiği zaman bunun arka planda yanlış girdiği giriş sayısı sayılsın 
			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Category");
			}
			else
			{
				return View();
			}
		}
            public async Task<IActionResult> LogOut()
            {
                // Oturumdan çıkış yap
                await HttpContext.SignOutAsync();
                // Kullanıcıyı bir sayfaya yönlendir (örneğin, giriş sayfası veya ana sayfa)
                return RedirectToAction("Index", "Login");

            }
        }
	}


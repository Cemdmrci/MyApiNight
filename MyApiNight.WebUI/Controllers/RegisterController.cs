﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyApiNight.EntityLayer.Concrete;
using MyApiNight.WebUI.Models;

namespace MyApiNight.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index() //.Net core projesi olduğundan IActionresult
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model) //programlamada birden fazla işin yapılması async
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Email = model.Email,
                Surname = model.Surname,
                UserName = model.Username,
                ImageUrl = "https://cdn.create.vista.com/api/media/small/397022190/stock-vector-user-profile-icon-vector-marketing-entertainment-concept-thin-line-illustration"
            };
            var result = await _userManager.CreateAsync(appUser, model.Password);//password appuserla beraber kabul edilmedğinden böyle yaptık şifreyi şifreler formatta göndermek istiyorum.heşleyerek göndermesiiçin createasync içinde gönderiyoruz.

            if (result.Succeeded) //Kullanıcı başarılı bir şekilde kayıt işlemi gerçekleştirirse
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in result.Errors)//resulttan gelen hataları bana gösterir.
                {
                    ModelState.AddModelError("", item.Description);//Modelstate bize formumuzdaki şeylerin doğru olup olmadığını belirler.
                }
            }
            return View();
        }
    }
}

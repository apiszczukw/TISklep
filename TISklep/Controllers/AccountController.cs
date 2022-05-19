using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.Models.Identity;
using TISklep.ViewModels;

namespace TISklep.Controllers
{
    public class AccountController : Controller
    {
        UserManager<AppUser> userManager { get; }

        SignInManager<AppUser> signInManager { get; }

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Zarejestruj()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Zarejestruj(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    UserName = model.UserName,
                    Password = model.Password
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    ViewBag.message = "Użytkownik utworzony! \n" + result;

                    await signInManager.SignInAsync(user, false);

                    return RedirectToAction("Index", "Home");
                }

                var errorList = result.Errors.ToList();
                ViewBag.message = string.Join("\n", errorList.Select(e => e.Description));
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Zaloguj()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Zaloguj(LoginViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

            if(result.Succeeded)
            {
                ViewBag.message = result;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.message = result;
                ModelState.AddModelError("", "Nieudana próba logowania");
            }

            return View(model);
        }

        public async Task<IActionResult> Wyloguj()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

            public IActionResult Index()
        {
            return View();
        }
    }
}

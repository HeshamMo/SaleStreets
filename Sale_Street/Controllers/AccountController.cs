using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Sale_Street.Models;
using Sale_Street.ViewModels;

namespace Sale_Street.Controllers
{
	[AllowAnonymous]
	public class AccountController:Controller
	{
		private readonly UserManager<AppUser> userManager;
		private readonly SignInManager<AppUser> signInManger;
		public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManger)
		{
			this.userManager = userManager;
			this.signInManger = signInManger;
		}

		[HttpGet]
		public IActionResult Register()
		{
			if (User.Identity.IsAuthenticated)
			{
				return RedirectToAction("index", "Home"); 
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel loginViewModel)
		{
			if(!ModelState.IsValid)
			{
				return View(loginViewModel);
			}
			AppUser user = new AppUser() {
				Name = loginViewModel.Name,
				UserName = loginViewModel.Email,
				Email = loginViewModel.Email,
				Country = loginViewModel.Country,
				Age = loginViewModel.Age,
				PhoneNumber = loginViewModel.PhoneNumber

            };

			IdentityResult result = await userManager.CreateAsync(user, loginViewModel.Password);
			if(result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "User");
				await signInManger.SignInAsync(user, isPersistent: false);
			}
			else
			{
				foreach(var Error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, Error.Description);
					return View(loginViewModel);
				}
			}

			return RedirectToAction("Index", "Home");

		}


		[HttpGet]
		public ActionResult LogIn()
		{
			if (User.Identity.IsAuthenticated)
			{
				return RedirectToAction("index", "Home"); 
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> LogIn(SignInViewModel signInViewModel)
		{
			if (User.Identity.IsAuthenticated)
			{
				return RedirectToAction("index", "Home"); 
			}
			if (!ModelState.IsValid)
			{
				return View(signInViewModel); 
			}
			var result = await signInManger.PasswordSignInAsync(signInViewModel.Email, signInViewModel.Passowrd
				,isPersistent:signInViewModel.RememberMe,lockoutOnFailure:false);
			if(result.Succeeded)
			{
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ModelState.AddModelError("", "UserName or Passowrd is Incorrect! . ");
			}
			return View();
		}

		
		public async Task<IActionResult> SignOut()
		{
			
			await signInManger.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

	}
}

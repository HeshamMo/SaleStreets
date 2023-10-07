using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sale_Street.Models;
using Sale_Street.ViewModels;

namespace Sale_Street.Controllers
{
	[Authorize(Roles = "Admin")]
	public class RoleController:Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;

		public RoleController(UserManager<AppUser> _userManager, RoleManager<IdentityRole> _roleManager)
		{
			this._userManager = _userManager;
			this._roleManager = _roleManager;
		}
		[HttpGet]
		//[Authorize(Roles = "Admin")]
		public async Task<IActionResult> GetAllRoles()
		{
			IEnumerable<IdentityRole> model = await _roleManager.Roles.ToListAsync();
			return View("RolesDashBoard", model);
		}

		[HttpGet]
		public IActionResult CreateRole()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateRole([FromForm(Name = "name")] string roleName)
		{
			if(roleName == null)
			{
				ModelState.AddModelError("", "this Field is required");
				return View();
			}
			IdentityRole role = new IdentityRole()
			{
				Name = roleName
			};
			IdentityResult result = await _roleManager.CreateAsync(role);
			if(result.Succeeded)
			{
				return RedirectToAction("GetAllRoles");

			}

			foreach(var error in result.Errors)
			{
				ModelState.AddModelError("", error.Description);
			}

			return View(role);

		}



		[HttpGet("{controller}/GetRoleUsers/{id}")]
		public async Task<IActionResult> GetRoleUsers(string id)
		{
			if(!_roleManager.Roles.Any(r => r.Id == id))
			{
				return BadRequest("No Role With the supplied Name");
			}

			var role = await _roleManager.FindByIdAsync(id);
			IEnumerable<AppUser> users = await _userManager.GetUsersInRoleAsync(role.Name);
			@ViewData["roleName"] = role.Name;
			@ViewData["RoleId"] = id;
			return View("RoleUsers", users);
		}

		public async Task<IActionResult> DeleteRole(string id)
		{
			if(!_roleManager.Roles.Any(r => r.Id == id))
			{
				return BadRequest("No Role with the Specified Name");

			}

			IdentityRole role = await _roleManager.FindByIdAsync(id);
			IdentityResult result = await _roleManager.DeleteAsync(role);
			if(result.Succeeded)
			{
				return RedirectToAction("GetAllRoles");
			}

			return BadRequest("Deleting Failed");

		}


		[HttpGet]


		public async Task<IActionResult> EditRole(string id)
		{
			if(!_roleManager.Roles.Any(r => r.Id == id))
			{
				return BadRequest("Role not Found");
			}

			IdentityRole role = await _roleManager.FindByIdAsync(id); 
			return View(role);
		}


		[HttpPost]
		public async Task<IActionResult> EditRole([FromForm]string name , [FromForm] string id)
		{
			if(!_roleManager.Roles.Any(r => r.Id == id))
			{
				return BadRequest("Role not Found");
			}

			IdentityRole role = await _roleManager.FindByIdAsync(id);
			role.Name= name;
			IdentityResult result = await _roleManager.UpdateAsync(role);
			if (result.Succeeded)
			{
			return RedirectToAction("GetAllRoles","Role");

			}

			foreach (var error in result.Errors)
			{
				ModelState.AddModelError("",error.Description);
			}
			return View(role);
		}


		[HttpGet]
		public IActionResult AddUserToRole(string id)
		{
			AddUserToRoleViewModel model = new AddUserToRoleViewModel();
			model.RoleId = id;
			return View(model); 
		}
		
		[HttpPost]
		public async Task<IActionResult> AddUserToRole(AddUserToRoleViewModel model)
		{
			if(!_roleManager.Roles.Any(r => r.Id == model.RoleId))
			{
				return BadRequest("Role not Found");
			}

			IdentityRole role = await _roleManager.FindByIdAsync(model.RoleId);

			AppUser user = await _userManager.FindByNameAsync(model.UserName);
			if (user is null)
			{
				ModelState.AddModelError("","No User with the Supplied Name Exsists1");
				return View(model);
			}
			IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
			if (!result.Succeeded)
			{
				foreach (var error in result.Errors)
				{
				ModelState.AddModelError(string.Empty,error.Description);	
				}

				return View(model);
			}

			return RedirectToAction("GetRoleUsers", new { id = role.Id }); 
		}


		public async Task<ActionResult> RemoveUserFromRole([FromRoute(Name ="Id")]string UserID , [FromQuery] string RoleId)
		{
			var user = await _userManager.FindByIdAsync(UserID);
			var role = await _roleManager.FindByIdAsync(RoleId); 
			if (user == null || role == null )
			{
				return BadRequest("No User or Role with the Supplied IDs"); 
			}
				

			IdentityResult result = await _userManager.RemoveFromRoleAsync(user, role.Name);
			if (result.Succeeded)
			{
				
				return RedirectToAction("GetRoleUsers", new { id = role.Id }); 
			}
			else
			{
				return BadRequest("SomeThing Went Wrong");
			}
		}
	}
}

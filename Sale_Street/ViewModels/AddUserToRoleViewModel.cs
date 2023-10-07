using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Sale_Street.ViewModels
{
	public class AddUserToRoleViewModel
	{
		[Required]
		public string RoleId { get; set; }

		[Required]
		public string UserName { get; set; }
	}

}

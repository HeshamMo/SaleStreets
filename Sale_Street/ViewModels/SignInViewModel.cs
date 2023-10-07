using System.ComponentModel.DataAnnotations;

namespace Sale_Street.ViewModels
{
	public class SignInViewModel
	{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Passowrd { get; set; }

		public bool RememberMe { get; set; }
	}
}

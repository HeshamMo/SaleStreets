using System.ComponentModel.DataAnnotations;
using Sale_Street.Helpers;

namespace Sale_Street.ViewModels
{
	public class RegisterViewModel
	{

		[Required]
		public string Email { get; set; }


		[Required]
		[DataType(DataType.Password)]
		[Display(Name="Password")]
		public string Password { get; set; }


		[Required] 
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Password must Match")]
		[Display(Name = "ConfirmPassword")]
		public string ConfirmedPassword { get; set; }

		[Required]
		public string Name { get; set; }
		[Required]
		[RestrictAge(18, ErrorMessage = "Age must be at least 18")]
		public int Age { get; set; }
		[Required]

		public string Country { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "required")]
        public string PhoneNumber { get; set; }

    }
}

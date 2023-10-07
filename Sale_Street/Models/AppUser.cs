using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sale_Street.Helpers;

namespace Sale_Street.Models
{
	public class AppUser:IdentityUser
	{
		[Required]
		[MaxLength(256)]
		public string Name { get; set; }


		[Required]
		[RestrictAge(18,ErrorMessage ="Error must be at least 18")]
		public int Age { get; set; }


        [MaxLength(256)]
        [Required]
		public string Country { get; set; }
		[Column(name:"phoneNumber")]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }

		public virtual List<Product> Products { get; set; }


	}
}

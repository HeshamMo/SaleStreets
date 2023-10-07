using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Sale_Street.Models
{
	
	public class Product
	{

		public int id { get; set; }
		[Required]
        [StringLength(255,ErrorMessage = "Length cannot be more than 255 character")]
		public string Name { get; set; }
        [Required]
        [StringLength(512, ErrorMessage = "Length cannot be more than 255 character")]
        public string Description { get; set; }
        [Required]
        public  virtual Category Category { get; set; }
        public List<ConvertImgToArr> Images { get; set; }
        [Required]
        [StringLength(255,ErrorMessage = "cannot be more than 255 character")]
        public string Location { get; set; }
        [Required]
        public virtual AppUser publisher { get; set; }

        public DateTime publishedAt { get; set; }
        public Decimal price { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sale_Street.Models;

namespace Sale_Street.ViewModels
{
    public class CreateProductViewModel
    {
        [Required(ErrorMessage = "required")]

        [StringLength(255, ErrorMessage = "Length cannot be more than 255 character")]
        public string Name { get; set; }
        [Required(ErrorMessage = "required")]

        [StringLength(512, ErrorMessage = "Length cannot be more than 255 character")]
        public string Description { get; set; }
        [Required(ErrorMessage = "required")]
        public string CategoryName { get; set; }
        
        public List<ConvertImgToArr> Images { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "cannot be more than 255 character")]
        public string Location { get; set; }
        public virtual AppUser publisher { get; set; }
        public DateTime publishedAt
        {
            get { return DateTime.Now; }
        }

        [Required]
        public Decimal price { get; set; }
    }
}

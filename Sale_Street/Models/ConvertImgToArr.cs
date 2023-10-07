using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Net.Mime;
using System.Drawing;

namespace Sale_Street.Models
{
    [Owned]
    [Table(name: "Image")]
    public class ConvertImgToArr
    {
        public int id { get; set; }

        [NotMapped] public IFormFile[] FormFile { get; set; }
        [Column("byte[]")] public byte[]? imageArr { get; set; }

        [NotMapped]
        public string ActualImage
        {
            get
            {
                if(imageArr != null)
                {
                    string base64String = Convert.ToBase64String(imageArr, 0, imageArr.Length);
                    return $"data:image/jpg;base64,{base64String}";
                }
                return null ;
            }
        }

        public ConvertImgToArr()
        {
            
        }
        public ConvertImgToArr(IFormFile image)
        {
            using MemoryStream stream = new MemoryStream();

            image.CopyTo(stream);
            imageArr = stream.ToArray();
            
        }

       
    }
}

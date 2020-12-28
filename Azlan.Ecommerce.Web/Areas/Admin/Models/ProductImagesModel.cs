using Azlan.Ecommerce.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Web.Areas.Admin.Models
{
    public class ProductImagesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FeaturedImageId { get; set; }
        public List<ProductImage> ProductImages { get; set; }

        // For image upload;
        [Required(ErrorMessage = "Please choose one or more files to upload")]
        public List<IFormFile> Files { get; set; }
    }
}

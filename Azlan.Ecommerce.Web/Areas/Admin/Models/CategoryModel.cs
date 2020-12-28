using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Web.Areas.Admin.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
    }
}

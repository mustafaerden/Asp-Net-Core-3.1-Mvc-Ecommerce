using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }

        public List<Category> SubCategories { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}

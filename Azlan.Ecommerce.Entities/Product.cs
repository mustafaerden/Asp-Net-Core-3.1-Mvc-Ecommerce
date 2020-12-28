using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int StockCount { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public bool Featured { get; set; } = false;
        public int? FeaturedImageId { get; set; }

        public List<ProductImage> ProductImages { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}

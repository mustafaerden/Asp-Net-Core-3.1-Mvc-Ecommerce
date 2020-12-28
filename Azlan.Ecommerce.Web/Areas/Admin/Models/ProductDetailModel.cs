using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Web.Areas.Admin.Models
{
    public class ProductDetailModel
    {
        public int Id { get; set; }
        public int StockCount { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public bool Featured { get; set; }

        public List<string> ProductImages { get; set; }
    }
}

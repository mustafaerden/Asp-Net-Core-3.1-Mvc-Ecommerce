using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Web.Models
{
    public class ProductListViewModel
    {
        public List<Product> LastFiveProducts { get; set; }
        public List<Product> FeaturedProducts { get; set; }
    }
}

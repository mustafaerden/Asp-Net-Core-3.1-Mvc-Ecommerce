using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;

namespace Azlan.Ecommerce.Web.Models
{
    public class PageInfo
    {
        public int TotalProducts { get; set; }
        public int ProductsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }

        // Toplam kac sayfamiz var;
        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalProducts / ProductsPerPage);
        }
    }

    public class ProductListByCategoryViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}

using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Web.Areas.Admin.Models
{
    public class EditProductModel
    {
        public int Id { get; set; }
        [Required]
        public int StockCount { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal? Price { get; set; }
        public bool Featured { get; set; }
        // product in ait oldugu kategorileri controller da alip buna atiycaz ve view de o kategorileri secili olarak gostericez;
        public List<Category> SelectedCategories { get; set; }
    }
}

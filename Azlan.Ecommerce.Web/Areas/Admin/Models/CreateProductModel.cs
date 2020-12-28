using System.ComponentModel.DataAnnotations;

namespace Azlan.Ecommerce.Web.Areas.Admin.Models
{
    public class CreateProductModel
    {
        [Required]
        public int StockCount { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal? Price { get; set; }
        public bool Featured { get; set; } = false;
    }
}

using System.Threading.Tasks;
using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Azlan.Ecommerce.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;

        public ShopController(IProductService productService)
        {
            _productService = productService;
        }

        // This will be all products with pagination;
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ProductDetail(int? id, string slug)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productService.GetByIdWithProductImages((int)id);

            if (product == null)
            {
                return NotFound();
            }

            return View(new ProductDetailViewModel()
            {
                Product = product
            });
        }

        // Product List By Category With Pagination;
        // localhost:5000/products veya localhost:5000/products/{categoryName} seklinde calisiyor.
        // localhost:5000/products/{categoryName}?page=1 seklinde olacak
        // localhost:5000/products?page=1 seklinde de calisiyor
        public IActionResult List(string category, int page =1)
        {
            const int productsPerPage = 3;

            ProductListByCategoryViewModel productListByCategoryViewModel = new ProductListByCategoryViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalProducts = _productService.GetProductsCountByCategory(category),
                    CurrentPage = page,
                    ProductsPerPage = productsPerPage,
                    CurrentCategory = category
                },
                Products = _productService.GetProductsByCategory(category, page, productsPerPage)
            };

            return View(productListByCategoryViewModel);
        }
    }
}

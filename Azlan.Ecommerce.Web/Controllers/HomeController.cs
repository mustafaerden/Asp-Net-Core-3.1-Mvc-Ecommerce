using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Azlan.Ecommerce.Web.Models;
using Azlan.Ecommerce.Business.Abstract;

namespace Azlan.Ecommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            // Last 5 products;
            var lastFiveProducts = await _productService.GetLastFiveProductsWithImages();
            var featuredProducts = await _productService.GetFeaturedProductsWithImages();

            return View(new ProductListViewModel() 
            {
                LastFiveProducts = lastFiveProducts,
                FeaturedProducts = featuredProducts
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

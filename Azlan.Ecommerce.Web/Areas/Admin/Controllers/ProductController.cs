using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.Entities;
using Azlan.Ecommerce.Web.Areas.Admin.Models;
using Azlan.Ecommerce.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SlugGenerator;

namespace Azlan.Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProductImageService _productImageService;

        public ProductController(IProductService productService, ICategoryService categoryService, IProductImageService productImageService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productImageService = productImageService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAll();
            return View(new ProductListModel()
            {
                Products = products
            });
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductModel model, int[] categoryIds)
        {
            if (ModelState.IsValid)
            {
                var entity = new Product()
                {
                    Name = model.Name,
                    StockCount = model.StockCount,
                    Price = model.Price,
                    Description = model.Description,
                    Featured = model.Featured,
                    Slug = model.Name.GenerateSlug()
                };
                await _productService.Create(entity, categoryIds);

                TempData.Put("message", new ResultMessageModel()
                {
                    Title = "Success",
                    Message = "Product created successfully.",
                    Css = "success"
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = await _productService.GetByIdWithCategories((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new EditProductModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                StockCount = entity.StockCount,
                Description = entity.Description,
                Featured = entity.Featured,
                SelectedCategories = entity.ProductCategories.Select(I => I.Category).ToList()
            };

            ViewBag.Categories = await _categoryService.GetAll();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductModel model, int[] categoryIds)
        {
            if (ModelState.IsValid)
            {
                var entity = await _productService.GetById(model.Id);
                if (entity == null)
                {
                    return NotFound();
                }

                entity.Name = model.Name;
                entity.StockCount = model.StockCount;
                entity.Price = model.Price;
                entity.Description = model.Description;
                entity.Featured = model.Featured;
                entity.Slug = model.Name.GenerateSlug();

                await _productService.Update(entity, categoryIds);

                TempData.Put("message", new ResultMessageModel()
                {
                    Title = "Success",
                    Message = "Product updated successfully.",
                    Css = "success"
                });

                return RedirectToAction("Index");
            }

            ViewBag.Categories = await _categoryService.GetAll();

            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var product = await _productService.GetByIdWithProductImages(id);
            return View(new ProductDetailModel()
            {
                Id = product.Id,
                Name = product.Name,
                StockCount = product.StockCount,
                Description = product.Description,
                Slug = product.Slug,
                Price = product.Price,
                Featured = product.Featured,
                ProductImages = product.ProductImages.Select(I => I.Url).ToList()
            });
        }

        public async Task<IActionResult> Images(int id)
        {
            var product = await _productService.GetByIdWithProductImages(id);
            return View(new ProductImagesModel()
            {
                Id = product.Id,
                Name = product.Name,
                FeaturedImageId = product.FeaturedImageId,
                ProductImages = product.ProductImages
            });
        }

        [HttpPost]
        public async Task<IActionResult> Images(ProductImagesModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Files.Any())
                {
                    foreach (var file in model.Files)
                    {
                        var applicationPath = Directory.GetCurrentDirectory();
                        var fileExtension = Path.GetExtension(file.FileName);
                        var imageName = Guid.NewGuid() + fileExtension;
                        var whereToUpload = applicationPath + "/wwwroot/uploads/products/" + imageName;

                        using var stream = new FileStream(whereToUpload, FileMode.Create);
                        await file.CopyToAsync(stream);
                        var productImages = new ProductImage()
                        {
                            ProductId = model.Id,
                            Url = imageName
                        };
                        await _productImageService.Create(productImages);
                    }
                }

                return RedirectToAction("Images");
            }

            return View(model);
        }

        // Setting Featured Image;
        public async Task<IActionResult> SetFeaturedImage(int imageId, int productId, bool isChecked)
        {
            // first find the product;
            var product = await _productService.GetById(productId);

            if(product == null)
            {
                return NotFound();
            }

            if (isChecked)
            {
                product.FeaturedImageId = imageId;
            }
            else
            {
                product.FeaturedImageId = null;
            }

            _productService.Update(product);

            TempData.Put("message", new ResultMessageModel()
            {
                Title = "Success",
                Message = "Product featured image updated successfully.",
                Css = "success"
            });

            return Json(null);
        }

        public async Task<IActionResult> DeleteImage(int id)
        {
            var image = await _productImageService.GetById(id);

            if (image == null)
            {
                return NotFound();
            }

            if (image.Url != null)
            {
                try
                {

                    if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads\\products\\", image.Url)))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads\\products\\", image.Url));
                    }
                }
                catch (IOException e)
                {

                    TempData.Put("message", new ResultMessageModel()
                    {
                        Title = "Error",
                        Message = "An error occured. Try again.",
                        Css = "danger"
                    });
                    return Json("An error occured while deleting the script. Please try again!");
                }
            }

            await _productImageService.Delete(image);

            TempData.Put("message", new ResultMessageModel()
            {
                Title = "Success",
                Message = "Product image deleted successfully.",
                Css = "success"
            });

            return Json(null);
        }

        public async Task<IActionResult> Delete(int id)
        {

            var entity = await _productService.GetByIdWithProductImages(id);

            if (entity == null)
            {
                return NotFound();
            }

            if (entity.ProductImages.Any())
            {
                foreach (var image in entity.ProductImages)
                {
                    try
                    {

                        if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads\\products\\", image.Url)))
                        {
                            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads\\products\\", image.Url));
                        }
                    }
                    catch (IOException e)
                    {

                        TempData.Put("message", new ResultMessageModel()
                        {
                            Title = "Error",
                            Message = "An error occured. Try again.",
                            Css = "danger"
                        });
                        return Json("An error occured while deleting the script. Please try again!");
                    }
                }
            }

            await _productService.Delete(entity);

            TempData.Put("message", new ResultMessageModel()
            {
                Title = "Success",
                Message = "Product deleted successfully.",
                Css = "success"
            });

            return Json(null);
        }
    }
}

using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.DataAccess.Concrete.EfCore.Context;
using Azlan.Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.DataAccess.Concrete.EfCore.Repositories
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product>, IProductDal
    {
        public async Task Create(Product entity, int[] categoryIds)
        {
            using var context = new ApplicationDbContext();

            //product kaydettiğin zaman id döner geri.
            var product = await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();
            

            foreach(var categoryId in categoryIds)
            {
                await context.ProductCategories.AddAsync(new ProductCategory
                {
                    ProductId = product.Entity.Id,
                    CategoryId = categoryId
                });
            }

            await context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllWithProductImages()
        {
            using var context = new ApplicationDbContext();

            return await context.Products.Include(I => I.ProductImages).ToListAsync();
        }

        public async Task<Product> GetByIdWithCategories(int id)
        {
            using var context = new ApplicationDbContext();

            return await context.Products
                .Where(I => I.Id == id)
                .Include(I => I.ProductCategories)
                .ThenInclude(I => I.Category)
                .FirstOrDefaultAsync();
        }

        public async Task<Product> GetByIdWithProductImages(int id)
        {
            using var context = new ApplicationDbContext();

            return await context.Products
                .Where(I => I.Id == id)
                .Include(I => I.ProductImages)
                .FirstOrDefaultAsync();
        }

        public async Task Update(Product entity, int[] categoryIds)
        {
            using var context = new ApplicationDbContext();

            var product = context.Products
                    .Include(i => i.ProductCategories)
                    .FirstOrDefault(i => i.Id == entity.Id);

            if (product != null)
            {
                product.Name = entity.Name;
                product.StockCount = entity.StockCount;
                product.Description = entity.Description;
                product.Price = entity.Price;
                product.Featured = entity.Featured;
                product.Slug = entity.Slug;

                // product in bagli oldugu kategorilerin update islemi;
                product.ProductCategories = categoryIds.Select(catId => new ProductCategory()
                {
                    CategoryId = catId,
                    ProductId = entity.Id
                }).ToList();

                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Product>> GetLastFiveProductsWithImages()
        {
            using var context = new ApplicationDbContext();

            return await context.Products
                .Include(I => I.ProductImages)
                .OrderByDescending(I => I.Id)
                .Take(5).ToListAsync();
        }

        public async Task<List<Product>> GetFeaturedProductsWithImages()
        {
            using var context = new ApplicationDbContext();

            return await context.Products
                .Where(I => I.Featured)
                .Include(I => I.ProductImages)
                .OrderByDescending(I => I.Id)
                .ToListAsync();
        }

        public int GetProductsCountByCategory(string category)
        {
            using var context = new ApplicationDbContext();

            var products = context.Products.AsQueryable();

            // eger category parametresi gonderilirse o kategoriye ait olan product lari getiriyoruz;
            if (!string.IsNullOrEmpty(category))
            {
                products = products
                            .Include(I => I.ProductCategories)
                            .ThenInclude(I => I.Category)
                            .Where(I => I.ProductCategories.Any(a => a.Category.Name.ToLower() == category.ToLower()));
            }

            return products.Count();
        }

        // localhost:5000/products/{category}?page=1&pageSize3
        public List<Product> GetProductsByCategory(string category, int page, int productsPerPage)
        {
            using var context = new ApplicationDbContext();

            var products = context.Products
                                    .Include(I => I.ProductImages)
                                    .AsQueryable();

            // eger category parametresi gonderilirse o kategoriye ait olan product lari getiriyoruz;
            if (!string.IsNullOrEmpty(category))
            {
                products = products
                            .Include(I => I.ProductImages)
                            .Include(I => I.ProductCategories)
                            .ThenInclude(I => I.Category)
                            .Where(I => I.ProductCategories.Any(a => a.Category.Name.ToLower() == category.ToLower()));
            }

            return products.Skip((page - 1) * productsPerPage).Take(productsPerPage).ToList();
        }
    }
}

using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Business.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IGenericDal<Product> genericDal, IProductDal productDal) : base(genericDal)
        {
            _productDal = productDal;
        }

        public async Task Create(Product entity, int[] categoryIds)
        {
            await _productDal.Create(entity, categoryIds);
        }

        public async Task<List<Product>> GetAllWithProductImages()
        {
            return await _productDal.GetAllWithProductImages();
        }

        public async Task<Product> GetByIdWithCategories(int id)
        {
            return await _productDal.GetByIdWithCategories(id);
        }

        public async Task<Product> GetByIdWithProductImages(int id)
        {
            return await _productDal.GetByIdWithProductImages(id);
        }

        public async Task<List<Product>> GetFeaturedProductsWithImages()
        {
            return await _productDal.GetFeaturedProductsWithImages();
        }

        public async Task<List<Product>> GetLastFiveProductsWithImages()
        {
            return await _productDal.GetLastFiveProductsWithImages();
        }

        public List<Product> GetProductsByCategory(string category, int page, int productsPerPage)
        {
            return _productDal.GetProductsByCategory(category, page, productsPerPage);
        }

        public int GetProductsCountByCategory(string category)
        {
            return _productDal.GetProductsCountByCategory(category);
        }

        public async Task Update(Product entity, int[] categoryIds)
        {
            await _productDal.Update(entity, categoryIds);
        }
    }
}

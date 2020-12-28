using Azlan.Ecommerce.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.DataAccess.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        Task<List<Product>> GetAllWithProductImages();

        // To able to choose categories which product will belongs to while creating a new product;
        Task Create(Product entity, int[] categoryIds);

        Task Update(Product entity, int[] categoryIds);

        Task<Product> GetByIdWithCategories(int id);

        Task<Product> GetByIdWithProductImages(int id);

        // Get Last 5 products with images;
        Task<List<Product>> GetLastFiveProductsWithImages();

        // Get Featured products with images;
        Task<List<Product>> GetFeaturedProductsWithImages();

        // categoriye gore toplam products sayisini veren metot;
        int GetProductsCountByCategory(string category);

        // Get Products By Category;
        List<Product> GetProductsByCategory(string category, int page, int productsPerPage);
    }
}

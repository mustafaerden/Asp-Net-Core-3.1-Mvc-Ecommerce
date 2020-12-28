using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.Entities;

namespace Azlan.Ecommerce.Business.Concrete
{
    public class ProductImageManager : GenericManager<ProductImage>, IProductImageService
    {
        public ProductImageManager(IGenericDal<ProductImage> genericDal) : base(genericDal)
        {
        }
    }
}

using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.DataAccess.Abstract;
using Azlan.Ecommerce.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(IGenericDal<Category> genericDal, ICategoryDal categoryDal) : base(genericDal)
        {
            
            _categoryDal = categoryDal;
        }

        public async Task<List<Category>> GetAllWithSubCategories(int? parentId)
        {
            return await _categoryDal.GetAllWithSubCategories(parentId);
        }
    }
}

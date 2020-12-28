using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<Category>> GetAllWithSubCategories(int? parentId);
    }
}

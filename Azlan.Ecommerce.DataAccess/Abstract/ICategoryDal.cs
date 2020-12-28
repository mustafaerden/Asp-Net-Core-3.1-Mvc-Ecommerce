using Azlan.Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.DataAccess.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Category>> GetAllWithSubCategories(int? parentId);
    }
}

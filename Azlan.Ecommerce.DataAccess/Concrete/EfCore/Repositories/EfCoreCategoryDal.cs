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
    public class EfCoreCategoryDal : EfCoreGenericRepository<Category>, ICategoryDal
    {

        public async Task<List<Category>> GetAllWithSubCategories(int? parentId)
        {
            List<Category> result = new List<Category>();
            await GetCategories(parentId, result);
            return result;
        }

        private async Task GetCategories(int? parentId, List<Category> result)
        {
            using var context = new ApplicationDbContext();

            var categories = await context.Categories.Where(I => I.ParentCategoryId == parentId).ToListAsync();

            if (categories.Count > 0)
            {
                foreach (var category in categories)
                {
                    if (category.SubCategories == null)
                        category.SubCategories = new List<Category>();

                    // burda amac SubCategorileri doldurmak;
                    await GetCategories(category.Id, category.SubCategories);

                    if (!result.Contains(category))
                    {
                        result.Add(category);
                    }
                }
            }
        }
    }
}

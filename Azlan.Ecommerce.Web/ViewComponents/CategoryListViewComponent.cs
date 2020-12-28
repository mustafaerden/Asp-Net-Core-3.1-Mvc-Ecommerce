using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Web.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? parentCategoryId)
        {
            var categories = await _categoryService.GetAllWithSubCategories(parentCategoryId);

            return View(new CategoryListViewModel()
            {
                Categories = categories
            });
        }

    }
}

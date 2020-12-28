using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Azlan.Ecommerce.Business.Abstract;
using Azlan.Ecommerce.Entities;
using Azlan.Ecommerce.Web.Areas.Admin.Models;
using Azlan.Ecommerce.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Internal;
using SlugGenerator;

namespace Azlan.Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index(int? parentCategoryId)
        {
            var categories = await _categoryService.GetAllWithSubCategories(parentCategoryId);

            return View(new CategoryListModel() 
            {
                Categories = categories
            });
        }

        public async Task<IActionResult> Create()
        {
            // To able to select parent category we need to send all categories with select box;
            ViewBag.Categories = new SelectList(await _categoryService.GetAll(), "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category()
                {
                    Name = model.Name,
                    ParentCategoryId = model.ParentCategoryId != -1 ? model.ParentCategoryId : null,
                    Slug = model.Name.GenerateSlug()
                };

                await _categoryService.Create(entity);

                TempData.Put("message", new ResultMessageModel()
                {
                    Title = "Success",
                    Message = "Category created successfully.",
                    Css = "success"
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var entity = await _categoryService.GetById(id);

            if (entity == null)
            {
                return NotFound();
            }

            ViewBag.Categories = new SelectList(await _categoryService.GetAll(), "Id", "Name");

            return View(new CategoryModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                ParentCategory = entity.ParentCategory,
                ParentCategoryId = entity.ParentCategoryId
            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = await _categoryService.GetById(model.Id);

                if (entity == null)
                {
                    return NotFound();
                }

                entity.Name = model.Name;
                entity.Slug = model.Name.GenerateSlug();
                entity.ParentCategoryId = model.ParentCategoryId != -1 ? model.ParentCategoryId : null;
                _categoryService.Update(entity);

                TempData.Put("message", new ResultMessageModel()
                {
                    Title = "Success",
                    Message = "Category updated successfully.",
                    Css = "success"
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            //var entity = await _categoryService.GetAllWithSubCategories(id);
            //if (entity == null)
            //{
            //    return NotFound();
            //}

            //await _categoryService.DeleteRange(entity);

            //TempData.Put("message", new ResultMessageModel()
            //{
            //    Title = "Success",
            //    Message = "Category deleted successfully.",
            //    Css = "success"
            //});

            return Json(null);
        }
    }
}

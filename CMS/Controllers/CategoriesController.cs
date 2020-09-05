using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Helpers;
using CMS.Models;
using CMS.ViewModels;
using DAL.Dto;
using DAL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]

    public class CategoriesController : Controller
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly ModelValidations _modelValidations;
        private readonly ImageUploader _imageUploader;
        private static string Path = "Banner";

        public CategoriesController(ICategoriesRepository categoriesRepository, ModelValidations modelValidations, ImageUploader imageUploader)
        {
            _categoriesRepository = categoriesRepository;
            _modelValidations = modelValidations;
            _imageUploader = imageUploader;
        }


        public IActionResult Index()
        {
            var categories = _categoriesRepository.GetCategories();
            var model = new CategoriesViewModel();
            var list = new List<CategoryViewModel>();
            foreach (var elem in categories)
            {
                var category = new CategoryViewModel { Arabic = elem.NameAr, English = elem.NameEn, CreatedAt = elem.CreatedAt, Id = elem.Id, Banner = elem.Banner };
                list.Add(category);
            }

            model.Categories = list;
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Action(CategoryModel model, IFormFile Banner)
        {
            if (_modelValidations.IsObjectNull(model))
                return RedirectToAction("Add", "Categories");

            if (!_modelValidations.IsValid(model))
                return RedirectToAction("Add", "Categories");

            var imageUrl = _imageUploader.Upload(Banner, Path);

            var dto = new CategoryDto { NameAr = model.NameAr, NameEn = model.NameEn, Banner = imageUrl };

            var category = _categoriesRepository.Insert(dto);

            return RedirectToAction("Index", "Categories");
        }

        public IActionResult Delete(int Id)
        {
            _categoriesRepository.Delete(Id);
            return RedirectToAction("Index", "Categories");
        }

        public IActionResult Edit(int Id)
        {
            var category = _categoriesRepository.GetCategoryById(Id);
            var model = new CategoryModel { NameEn = category.NameEn, NameAr = category.NameAr, Id = Id, CreatedAt = category.CreatedAt, UpdatedAt = category.UpdatedAt };
            return View(model);
        }

        public IActionResult EditAction(CategoryModel model, IFormFile Banner)
        {
            var imageUrl = _imageUploader.Upload(Banner, Path);

            var category = new Category { Id = model.Id, NameAr = model.NameAr, NameEn = model.NameEn, UpdatedAt = DateTime.Now, CreatedAt = model.CreatedAt, Banner = imageUrl };
            _categoriesRepository.Update(category);
            return RedirectToAction("Index", "Categories");
        }
    }
}
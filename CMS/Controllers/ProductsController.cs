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

    public class ProductsController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly ICountriesRepository _countriesRepository;
        private readonly ModelValidations _modelValidations;
        private readonly ImageUploader _imageUploader;
        private static string Path = "Products";

        public ProductsController(ICategoriesRepository categoriesRepository, ICountriesRepository countriesRepository, IProductsRepository productsRepository, ModelValidations modelValidations, ImageUploader imageUploader)
        {
            _productsRepository = productsRepository;
            _countriesRepository = countriesRepository;
            _categoriesRepository = categoriesRepository;
            _modelValidations = modelValidations;
            _imageUploader = imageUploader;
        }

        public IActionResult Index()
        {
            var products = _productsRepository.GetProducts();
            var model = new ProductsViewModel();
            var list = new List<ProductViewModel>();
            foreach (var elem in products)
            {
                var category = _categoriesRepository.GetCategoryById(elem.CategoryId);
                var country = _countriesRepository.GetCountryById(elem.CountryId);

                var product = new ProductViewModel();
                product.Id = elem.Id;
                product.NameAr = elem.NameAr;
                product.NameEn = elem.NameEn;
                product.DescreptionAr = elem.DescreptionAr;
                product.DescreptionEn = elem.DescreptionEn;
                product.CreatedAt = elem.CreatedAt;
                product.CountryName = country.NameEn;
                product.CategoryName = category.NameEn;

                list.Add(product);
            }

            model.Products = list;
            return View(model);
        }

        public IActionResult Add()
        {
            var model = new ProductModel();
            var measurments = _productsRepository.GetMeasurments();
            var categories = _categoriesRepository.GetCategories();
            var countries = _countriesRepository.GetCountries();
            var measurmentList = new List<Measurment>();
            var categoryList = new List<Category>();
            var countryList = new List<Country>();

            foreach (var elem in measurments)
            {
                var measurment = new Measurment { Id = elem.Id, UnitEn = elem.UnitEn, UnitAr = elem.UnitAr};
                measurmentList.Add(measurment);
            }

            foreach (var elem in categories)
            {
                var category = new Category { Id = elem.Id, NameEn = elem.NameEn, NameAr = elem.NameAr };
                categoryList.Add(category);
            }

            foreach (var elem in countries)
            {
                var country = new Country { Id = elem.Id, NameAr = elem.NameAr, NameEn = elem.NameEn };
                countryList.Add(country);
            }

            model.Measurments = measurmentList;
            model.Categories = categoryList;
            model.Countries = countryList;
            return View(model);
        }

        public IActionResult Action(ProductModel model, IFormFile Image, List<IFormFile> Images)
        {
            if (_modelValidations.IsObjectNull(model))
                return RedirectToAction("Add", "Products");

            var imageUrl = _imageUploader.Upload(Image, Path);

            var productDto = new ProductDto { NameAr = model.NameAr, NameEn = model.NameEn, DescreptionAr = model.DescreptionAr, DescreptionEn = model.DescreptionEn, CategoryId = model.CategoryId, CountryId = model.CountryId, Quantity = model.Quantity };
            var product = _productsRepository.Insert(productDto);

            var imageDto = new ProductPictureDto { ProductId = product.Id, Image = imageUrl, IsMain = true};
            _productsRepository.InsertProductPicture(imageDto);

            foreach(var elem in Images)
            {
                var url = _imageUploader.Upload(elem, Path);
                var newImageDto = new ProductPictureDto { ProductId = product.Id, Image = url, IsMain = false };
                _productsRepository.InsertProductPicture(newImageDto);
            }

            var measurmentDto = new ProductSpecificationDto { ProductId = product.Id, MeasurmentId = model.MeasurmentId, Price = model.Price };
            _productsRepository.InsertProductMeasurment(measurmentDto);

            return RedirectToAction("Index", "Products");
        }

        public IActionResult Delete(int Id)
        {
            _productsRepository.Delete(Id);
            return RedirectToAction("Index", "Products");
        }

        public IActionResult Edit(int Id)
        {
            var product = _productsRepository.GetProductById(Id);
            var model = new ProductModel { NameEn = product.NameEn, NameAr = product.NameAr, Id = Id, CreatedAt = product.CreatedAt, UpdatedAt = product.UpdatedAt, DescreptionAr = product.DescreptionAr, DescreptionEn = product.DescreptionEn };
            return View(model);
        }

        public IActionResult EditAction(ProductModel model, IFormFile Image)
        {
            var imageUrl = _imageUploader.Upload(Image, Path);

           // var category = new Category { Id = model.Id, NameAr = model.NameAr, NameEn = model.NameEn, UpdatedAt = DateTime.Now, CreatedAt = model.CreatedAt, Banner = imageUrl };
           // _productsRepository.Update(category);
            return RedirectToAction("Index", "Products");
        }
    }
}
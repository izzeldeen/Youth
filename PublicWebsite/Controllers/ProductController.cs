using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;
using PublicWebsite.Models;
using PublicWebsite.ViewModels;

namespace PublicWebsite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductsRepository _productRepository;
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly ICountriesRepository _countryRepository;  
        public ProductController(IProductsRepository productsRepository, ICategoriesRepository categoriesRepository , ICountriesRepository countriesRepository)
        {
            _productRepository = productsRepository;
            _categoriesRepository = categoriesRepository;
            _countryRepository = countriesRepository;
        }

        public IActionResult Index(int productPage , int PageSize = 5 , int CategoryId = 0)
        {
            int countryId = 1;
            if (Request.Cookies["Contry"] != null) { countryId = Convert.ToInt32(Request.Cookies["Contry"]); }
            var products = _productRepository.GetProductByContry(countryId , CategoryId);
            var category = _categoriesRepository.GetCategories();
            var CategoryVM = new List<CategoryViewModel>();
            foreach(var item in category) { 
                if(Request.Cookies["Language"] == "ar")
                {
                var CategoryViewModel = new CategoryViewModel() {Id = item.Id , Name = item.NameAr};
                CategoryVM.Add(CategoryViewModel);
                }else
                {
                    var CategoryViewModel = new CategoryViewModel() {Id = item.Id , Name = item.NameEn};
                CategoryVM.Add(CategoryViewModel);
                }
            } 
            StringBuilder param = new StringBuilder();
            param.Append("/Product?productPage=:");
            var count = products.Count();
           var Countries =  _countryRepository.GetCountries();
           List<CountryVM> CountriesList = new List<CountryVM>();
           foreach(var item in Countries)
           {
               CountryVM country = new CountryVM(); 
                 if (Request.Cookies["Language"] == "en")
                {
                   country.Id = item.Id; country.Name = item.NameEn;
                }
                else
                {
                    country.Id = item.Id; country.Name = item.NameAr;
                }
                CountriesList.Add(country);
           }
            ListProductVM listPorductVM = new ListProductVM();
            List<ProductViewModel> ListProducts = new List<ProductViewModel>();
            foreach (var item in products)
            {
                var ProductPictuer = _productRepository.GetProductPictuerById(item.Id);
                var ProductSpecification = _productRepository.GetProductSpecification(item.Id);
                if (Request.Cookies["Language"] == "en")
                {
                    ProductViewModel product = new ProductViewModel()
                    { Id = item.Id, CategoryId = item.CategoryId, Contry = countryId, Name = item.NameEn, Description = item.DescreptionEn, PictuerUrl = ProductPictuer.Image, Price = ProductSpecification.Price }; ListProducts.Add(product);
                   
                }
                else
                {
                    ProductViewModel product = new ProductViewModel()
                    { Id = item.Id, CategoryId = item.CategoryId, Contry = countryId, Name = item.NameAr, Description = item.DescreptionAr, PictuerUrl = ProductPictuer.Image, Price = ProductSpecification.Price }; ListProducts.Add(product);
                }
            }
            listPorductVM.ProductViewModel = ListProducts;
            listPorductVM.Categories = CategoryVM;
            listPorductVM.Countries = CountriesList;
            listPorductVM.PagingInfo = new PagingInfo { CurrentPage = productPage, ItemsPerPage = PageSize, TotalItems = count, urlParam = param.ToString() };
            listPorductVM.ProductViewModel = listPorductVM.ProductViewModel.OrderBy(x => x.Name).Skip((productPage - 1) * PageSize)
             .Take(PageSize).ToList(); 
            return View(listPorductVM);
        }
        public IActionResult Details(int Id)
        {
            var product = _productRepository.GetProductById(Id);
            var ProductSpecification = _productRepository.GetProductSpecification(Id);
            ProductViewModel productVM = new ProductViewModel();
            if (Request.Cookies["Language"] == "en")
            {
                productVM.Id = product.Id; productVM.CategoryId = product.CategoryId; productVM.Name = product.NameEn;  productVM.Contry = product.CountryId; productVM.Description = product.DescreptionEn; productVM.ListPictuerUrl = _productRepository.GetProductPictuerIsNotMain(Id); productVM.Price = ProductSpecification.Price; productVM.Message = product.Message;
            }
            else
            {
                productVM.Id = product.Id; productVM.CategoryId = product.CategoryId; productVM.Name = product.NameAr; productVM.Contry = product.CountryId; productVM.Description = product.DescreptionAr; productVM.ListPictuerUrl = _productRepository.GetProductPictuerIsNotMain(Id); productVM.Price = ProductSpecification.Price; productVM.Message = product.Message;
            }
            return View(productVM);
        }
    }   
}

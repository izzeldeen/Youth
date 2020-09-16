using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using PublicWebsite.Models;
using DAL.Interfaces;
using PublicWebsite.ViewModels;
using System.Threading.Tasks;
using RestSharp;
using System;
using Microsoft.AspNetCore.Http;

namespace PublicWebsite.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IUsersRepository _usersRepository;
        private readonly ICountriesRepository _countriesRepository;
        private readonly IProductsRepository _productRepository;
        private readonly ICategoriesRepository _categriesRepository;
        public HomeController( IUsersRepository usersRepository, ICountriesRepository countriesRepository ,IProductsRepository productsRepository , ICategoriesRepository categriesRepository  )
        {
            _usersRepository = usersRepository;
            _countriesRepository = countriesRepository;
            _productRepository = productsRepository;
            _categriesRepository = categriesRepository;
        }

        public async Task<IActionResult> Index()
        {
            if (Request.Cookies["Language"] == null)
            {
                var locale = Request.HttpContext.Features.Get<IRequestCultureFeature>();
                var BrowserCulture = locale.RequestCulture.UICulture.ToString();
                  CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(30); 
                Response.Cookies.Append("Language", BrowserCulture , option);
            }

        
            var countries = _countriesRepository.GetCountries();
            var  products = await   _productRepository.GetFeaturedProducts();
            var categories = _categriesRepository.GetLastFourCategories();
            List<CategoryViewModel> CategorysVM = new List<CategoryViewModel>();
            List<ProductViewModel> productsVM = new List<ProductViewModel>();
            if(Request.Cookies["Language"] == "ar")
            {
                foreach (var item in products)
                {
                    ProductViewModel product = new ProductViewModel() { Id = item.Id, CategoryId = item.CategoryId, Description = item.DescreptionAr, Name = item.NameAr, Price = _productRepository.GetProductSpecification(item.Id).Price, PictuerUrl = _productRepository.GetProductPictuerById(item.Id).Image };
                    productsVM.Add(product);
                }
                 foreach(var item in categories)
                {
                    CategoryViewModel CategoryVM = new CategoryViewModel() { Banner = item.Banner, Name = item.NameAr };
                    CategorysVM.Add(CategoryVM);
                }
            }
            else
            {
                foreach (var item in products)
                {
                    ProductViewModel product = new ProductViewModel() { Id = item.Id, CategoryId = item.CategoryId, Description = item.DescreptionEn, Name = item.NameEn, Price = _productRepository.GetProductSpecification(item.Id).Price, PictuerUrl = _productRepository.GetProductPictuerById(item.Id).Image };
                    productsVM.Add(product);
                }
                foreach (var item in categories)
                {
                    CategoryViewModel CategoryVM = new CategoryViewModel() { Banner = item.Banner, Name = item.NameEn };
                    CategorysVM.Add(CategoryVM);
                }
            }
            var model = new CountriesViewModel();
            var list = new List<CountryViewModel>();
            foreach (var elem in countries)
            {
                var country = new CountryViewModel { Arabic = elem.NameAr, English = elem.NameEn, CreatedAt = elem.CreatedAt, Id = elem.Id };
                list.Add(country);
            }
            model.Countries = list;
            model.products = productsVM;
            model.Categries = CategorysVM;
            return View(model);
        }

      


        public IActionResult About()
        {
            return View();
        }
        // public IActionResult Blog()
        // {

        //     return View();
        // }
        public IActionResult BlogSingle()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Product(int Id)
        {
            var product = _productRepository.GetProductSpecification(Id);  ProductViewModel productVM = new ProductViewModel();
            if(Request.Cookies["Language"] != "ar")
            {
             productVM = new ProductViewModel() {Id = product.Id , CategoryId = product.Product.CategoryId , Description = product.Product.DescreptionEn , Name = product.Product.NameEn , Price = product.Price, PictuerUrl = _productRepository.GetProductPictuerById(Id).Image };     
            }
            else
            {
             productVM = new ProductViewModel() {Id = product.Id , CategoryId = product.Product.CategoryId , Description = product.Product.DescreptionAr , Name = product.Product.NameAr , Price = product.Price, PictuerUrl = _productRepository.GetProductPictuerById(Id).Image }; 
            }
            return View(productVM);
        }

        
        public IActionResult Blog(int Id)
        {
           
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult WishList()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

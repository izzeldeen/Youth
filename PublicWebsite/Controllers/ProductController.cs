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
        public ProductController(IProductsRepository productsRepository, ICategoriesRepository categoriesRepository)
        {
            _productRepository = productsRepository;
            _categoriesRepository = categoriesRepository;
        }

        public IActionResult Index(int productPage , int PageSize = 5 , int CategoryId = 0 )
        {
            int countryId = 1;
            if (Request.Cookies["Contry"] != null) { countryId = Convert.ToInt32(Request.Cookies["Contry"]); }
            var products = _productRepository.GetProductByContry(countryId , CategoryId);
            var category = _categoriesRepository.GetCategories(); 
            StringBuilder param = new StringBuilder();
            param.Append("/Product?productPage=:");
            var count = products.Count();
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
            listPorductVM.Categories = category;
            listPorductVM.PagingInfo = new PagingInfo { CurrentPage = productPage, ItemsPerPage = PageSize, TotalItems = count, urlParam = param.ToString() };
            listPorductVM.ProductViewModel = listPorductVM.ProductViewModel.OrderBy(x => x.Name).Skip((productPage - 1) * PageSize)
                .Take(PageSize).ToList(); 
            return View(listPorductVM);
        }

        public IActionResult Details(int Id)
        {
            var product = _productRepository.GetProductById(Id);
            var ProductPictuer = _productRepository.GetProductPictuerById(Id);
            var ProductSpecification = _productRepository.GetProductSpecification(Id);
            ProductViewModel productVM = new ProductViewModel();
            if (Request.Cookies["Language"] == "en")
            {
                productVM.Id = product.Id; productVM.CategoryId = product.CategoryId; productVM.Name = product.NameEn;  productVM.Contry = product.CountryId; productVM.Description = product.DescreptionEn; productVM.PictuerUrl = ProductPictuer.Image; productVM.Price = ProductSpecification.Price;
            }
            else
            {
                productVM.Id = product.Id; productVM.CategoryId = product.CategoryId; productVM.Name = product.NameAr; productVM.Contry = product.CountryId; productVM.Description = product.DescreptionAr; productVM.PictuerUrl = ProductPictuer.Image; productVM.Price = ProductSpecification.Price;
            }
            return View(productVM);
        }
      
    }   
}

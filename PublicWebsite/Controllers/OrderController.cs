using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace PublicWebsite.Controllers
{
    public class OrderController : Controller
    {
          private readonly IProductsRepository _productRepository;
          public OrderController(IProductsRepository productsRepository)
          {
              _productRepository = productsRepository;
          }
        public IActionResult Index()
        {
            return View();   
        }
        [HttpGet]
        public IActionResult Cart()
        {

            var CartItems = Request.Cookies["Cart"];
            ShoppingCart shoppingCart = new ShoppingCart();
            if (CartItems == null) return View(shoppingCart);
            var Items = CartItems.Split("-");
            List<ShoppingCartItem> shoppingCartItems = new List<ShoppingCartItem>();
            double TotalPrice = 0.00;
            foreach(var item in Items)
            {
                 var product = _productRepository.GetProductSpecification(Convert.ToInt32(item));
                 if(product != null)
                 {
                     TotalPrice += product.Price;
                     if(shoppingCartItems != null)
                    {
                          var CheckIfProductExisit = shoppingCartItems.FirstOrDefault(x=> x.ProductSpecification.Product.Id == product.Product.Id);
                     if(CheckIfProductExisit != null)
                     {
                         shoppingCartItems.FirstOrDefault(x=>x.ProductSpecification.Product.Id == product.Product.Id).Quntity +=1;
                     }
                      else
                       {
                           if(Request.Cookies["Language"] == "ar")
                           {
                             ShoppingCartItem shoppingCartItem = new  ShoppingCartItem() {ProductSpecification = product, Quntity =1 , PictuerUrl = _productRepository.GetProductPictuerById(product.ProductId).Image , ProductId = product.ProductId , Name = product.Product.NameAr , Description = product.Product.DescreptionAr  };
                             shoppingCartItems.Add(shoppingCartItem);
                           }
                           else
                           {
                               ShoppingCartItem shoppingCartItem = new  ShoppingCartItem() {ProductSpecification = product, Quntity =1 , PictuerUrl = _productRepository.GetProductPictuerById(product.ProductId).Image , ProductId = product.ProductId , Name = product.Product.NameEn , Description = product.Product.DescreptionEn  };
                               shoppingCartItems.Add(shoppingCartItem);
                           }
                        
                      }  
                 }
            }
            }
            shoppingCart.ShoppingCartItems = shoppingCartItems;
            shoppingCart.Price = TotalPrice;
            return View(shoppingCart);
        }
    }
}

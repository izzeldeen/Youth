using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using DAL.Dto;
using DAL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PublicWebsite.Models;

namespace PublicWebsite.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductsRepository _productRepository;
        private readonly IUsersRepository _usersRepository;
        private readonly IOrdersRepository _orederRepository;
        public OrderController(IProductsRepository productsRepository , IUsersRepository usersRepository , IOrdersRepository ordersRepository)
        {
              _productRepository = productsRepository;
              _usersRepository = usersRepository;
              _orederRepository = ordersRepository;
        }
        public IActionResult Index()
        {
            return View();   
        }

        public IActionResult Details()
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
                if(item != "0" && item != "" )
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
            }
            shoppingCart.ShoppingCartItems = shoppingCartItems;
            shoppingCart.Price = TotalPrice;
            return View(shoppingCart);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Order(decimal TotalPrice)
        {
            ViewBag.TotalPrice = TotalPrice;
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Order(OrderModel model)
        {
            List<OrderItem> ListOrderItem = new List<OrderItem>();
             var CartItems = Request.Cookies["Cart"];
             var productIds = CartItems.Split("-").Select(x=> int.Parse(x)).ToList();
             var productItem = _productRepository.GetProductByIDS(productIds.Distinct().ToList());
            foreach(var item in productIds) {
                  if(ListOrderItem.FirstOrDefault(x=>x.ProductId == item) != null)
                  {
                         var  product =  ListOrderItem.FirstOrDefault(x=>x.ProductId == item);
                         product.Quantity += 1;
                         product.TotalPrice = product.Quantity * product.ItemPrice;  
                  }
                  else
                  {
                      var product = _productRepository.GetProductById(item);
                      if(product != null) {
                      OrderItem orderItem = new OrderItem(){ ProductId=item , Product =  product, Quantity =1, ItemPrice= _productRepository.GetProductSpecification(item).Price };
                      orderItem.TotalPrice = orderItem.ItemPrice * orderItem.Quantity;
                      ListOrderItem.Add(orderItem);
                      }
                     
                  }         
              }
              var TotalPrice = 0;
              foreach(var item in ListOrderItem) { TotalPrice += item.TotalPrice; }
            var order = new OrderDto(){DeliveryLatitude = model.DeliveryLatitude , DeliveryLongitude = model.DeliveryLongitude , DeliveryTime = model.DeliveryTime , DeliveryInfo = model.DeliveryInfo , OrderItems = ListOrderItem ,TotalPrice = TotalPrice ,  UserId = int.Parse(((ClaimsIdentity)User.Identity).FindFirst("UserId").Value) ,StatusId = 1 , DeliveryDate = model.DeliveryDate};
            var NewOrder =  _orederRepository.Insert(order);
            if(NewOrder != null) { Response.Cookies.Append("Cart", "0"); }
            return RedirectToAction("Index" , "Home");
        }
    }
}

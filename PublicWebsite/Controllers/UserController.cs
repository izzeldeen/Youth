
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using DAL.Dto;
using DAL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PublicWebsite.Helpers;
using PublicWebsite.Models;
using PublicWebsite.ViewModels;

namespace PublicWebsite.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IOrdersRepository _ordersRepository;
        private readonly ImageUploader _imageUploader;
        private readonly IProductsRepository _productsRepository;
        private static string Path = "Avatar";
        public UserController(IUsersRepository usersRepository , ImageUploader imageUploader , IOrdersRepository ordersRepository , IProductsRepository productsRepository )
        {
            _usersRepository = usersRepository;
            _imageUploader = imageUploader;
            _ordersRepository = ordersRepository;
            _productsRepository = productsRepository;
        }
        public IActionResult Index()
        {
           int userId = int.Parse(((ClaimsIdentity)User.Identity).FindFirst("UserId").Value);
           var user =   _usersRepository.GetUserById(userId);
           EditProfileDto profile = new EditProfileDto(){  Id = userId,  Phonenumber = user.Phonenumber ,Firstname = user.Firstname , Lastname = user.Lastname , Avatar = user.Avatar};
           return View(profile);
        }
        [HttpPost]
        public IActionResult Index(EditProfileDto profile , IFormFile avatar){
            if (!ModelState.IsValid) return View(profile);
            var user = _usersRepository.GetUserById(profile.Id);
            if (avatar != null)
            {
                var imageUrl = _imageUploader.Upload(avatar, Path, profile.Id);
                user.Avatar = imageUrl;
               
            }
            user.Firstname = profile.Firstname;
            user.Lastname = profile.Lastname;
            user.Phonenumber = profile.Phonenumber;
            _usersRepository.ChangeAvatar(user);
            var cookie = new CookieDto() { RoleId = user.RoleId, UserId = user.Id, Fullname = user.Firstname + user.Lastname, Phonenumber = user.Phonenumber, Avatar = user.Avatar };
            CreateAuthCookie(cookie);
            return View(profile);
        }

        public IActionResult UserOrders()
        {
            int userId = int.Parse(((ClaimsIdentity)User.Identity).FindFirst("UserId").Value);
            var orders =  _ordersRepository.GetUserOrders(userId);
            List<Status> status = _ordersRepository.GetStatus();
            List<OrderViewModel> OrderVM = new List<OrderViewModel>();
            foreach (var item in orders)
            {
                var user = _usersRepository.GetUserById(item.UserId);
                OrderViewModel orderVM = new OrderViewModel() {Id = item.Id , OrderStatus = status.Find(x=>x.Id == item.StatusId).NameEn, TotalPrice = item.TotalPrice , UserId = item.UserId , Username = user.Firstname + " " + user.Lastname, CreatedAt = item.CreatedAt , StatusId = item.StatusId };
                OrderVM.Add(orderVM);
            }
            return View(OrderVM);
        }

        public IActionResult Details(int Id)
        {
            var order = _ordersRepository.GetOrderById(Id);
            var user = _usersRepository.GetUserById(order.UserId);
            var status = _ordersRepository.GetStatusById(order.StatusId);

            string username = user.Firstname + " " + user.Lastname;
            var model = new OrderModel { CreatedAt = order.CreatedAt, Id = order.Id, OrderStatus = status.NameEn, TotalPrice = order.TotalPrice, Username = username, Phonenumber = user.Phonenumber, DeliveryInfo = order.DeliveryInfo, DeliveryLatitude = order.DeliveryLatitude, DeliveryLongitude = order.DeliveryLongitude };

            var orderItems = _ordersRepository.GetOrderItems(Id);
            var list = new List<OrderItemsModel>();
            foreach (var elem in orderItems)
            {
                var product = _productsRepository.GetProductById(elem.ProductId);
                var item = new OrderItemsModel { TotalPrice = elem.TotalPrice, Quantity = elem.Quantity, ItemName = product.NameEn };
                list.Add(item);
            }

            model.OrderItems = list;
            return View(model);
        }


        private async void CreateAuthCookie(CookieDto cookieModel)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, cookieModel.Fullname),
                    new Claim("Image", cookieModel.Avatar),
                    new Claim(ClaimTypes.Role, "Admin"),
                    new Claim("Phonenumber", cookieModel.Phonenumber),
                    new Claim("UserId", cookieModel.UserId.ToString()),
                };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMonths(3),
                IsPersistent = true,
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using PublicWebsite.Models;
using DAL.Dto;
using DAL.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PublicWebsite.Helpers;


namespace PublicWebsite.Controllers
{
    public class AuthController : Controller
    {

            private readonly IUsersRepository _usersRepository;
            private readonly ModelValidations _modelValidations;
            private readonly ImageUploader _imageUploader;
            private static string Path = "Avatar";


            public AuthController(IUsersRepository usersRepository, ModelValidations modelValidations, ImageUploader imageUploader)
            {
                _usersRepository = usersRepository;
                _modelValidations = modelValidations;
                _imageUploader = imageUploader;
            }

            public IActionResult Index()
            {
                return PartialView();
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

                await  HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
            }

            public IActionResult Login(LoginModel model)
            {

                if (_modelValidations.IsObjectNull(model))
                    return View();

                if (!_modelValidations.IsValid(model))
                    View();

                var user = _usersRepository.Login(new LoginDto { Phonenumber = model.Phonenumber, Password = model.Password });

            if (user == null || user.IsBlocked == true)
                return View();

                string fullname = user.Firstname + " " + user.Lastname;

                var cookie = new CookieDto { UserId = user.Id, Avatar = user.Avatar, Phonenumber = user.Phonenumber, RoleId = user.RoleId, Fullname = fullname };

                CreateAuthCookie(cookie);


            return RedirectToAction("Index", "Home");
            }

            public IActionResult Register(RegisterModel model, IFormFile avatar)
            {
                if (_modelValidations.IsObjectNull(model))
                    return View();

                if (!_modelValidations.IsValid(model))
                    return View();

                var user = _usersRepository.Register(new RegisterDto { Phonenumber = model.Phonenumber, Firstname = model.Firstname, Lastname = model.Lastname, Password = model.Password, RoleId = 1 });

                if (user == null)
                    return View();

                var imageUrl = _imageUploader.Upload(avatar, Path, user.Id);

                user.Avatar = imageUrl;

                _usersRepository.ChangeAvatar(user);

                string fullname = user.Firstname + " " + user.Lastname;

                var cookie = new CookieDto { UserId = user.Id, Avatar = user.Avatar, Phonenumber = user.Phonenumber, RoleId = user.RoleId, Fullname = fullname };

                CreateAuthCookie(cookie);
            return RedirectToAction("Index", "Home");
            }

            public async Task<IActionResult> Logout()
            {
                int userId = Int32.Parse(((ClaimsIdentity)User.Identity).FindFirst("UserId").Value);

                _usersRepository.Logout(userId);

                await HttpContext.SignOutAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme);

                return RedirectToAction("Index", "Home");
            }
        }



        //public IActionResult Register(RegisterDto model, IFormFile avatar)
        //{
        //    if (_modelValidations.IsObjectNull(model))
        //        return RedirectToAction("Register", "Auth");

        //    if (!_modelValidations.IsValid(model))
        //        return RedirectToAction("Register", "Home");


        //    var user = _usersRepository.Register(new RegisterDto { Phonenumber = model.Phonenumber, Firstname = model.Firstname, Lastname = model.Lastname, Password = model.Password, RoleId = model.RoleId });

        //    if (user == null)
        //        return RedirectToAction("Register", "Home");

        //    var imageUrl = _imageUploader.Upload(avatar, Path, user.Id);

        //    user.Avatar = imageUrl;

        //    _usersRepository.ChangeAvatar(user);
        //    var cookie = new CookieDto() { Fullname = user.Firstname + " " + user.Lastname, Avatar = user.Avatar, Phonenumber = user.Phonenumber, UserId = user.Id, RoleId = user.RoleId };
        //    CreateAuthCookie(cookie);

        //    return RedirectToAction("Login", "Auth");


        //}


        //public IActionResult Login(LoginModel model)
        //{
        //    if (_modelValidations.IsObjectNull(model))
        //        return View();

        //    if (!_modelValidations.IsValid(model))
        //        return View();

        //    var user = _usersRepository.Login(new LoginDto { Phonenumber = model.Phonenumber, Password = model.Password });

        //    if (user == null ||  user.IsBlocked == true)
        //        return RedirectToAction("Login", "Auth");

        //    string fullname = user.Firstname + " " + user.Lastname;

        //    var cookie = new CookieDto { UserId = user.Id, Avatar = user.Avatar, Phonenumber = user.Phonenumber, RoleId = user.RoleId, Fullname = fullname };

        //CreateAuthCookie(cookie);

        //    return RedirectToAction("Index", "Home");
        //}

    
}
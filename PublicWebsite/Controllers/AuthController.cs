using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
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

        private async void CreateAuthCookie(CookieDto cookieModel)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, cookieModel.Fullname),
                    new Claim("Image", cookieModel.Avatar),
                    new Claim(ClaimTypes.Role, cookieModel.RoleId.ToString()),
                    new Claim("Phonenumber", cookieModel.Phonenumber),
                    new Claim("UserId", cookieModel.UserId.ToString()),
                };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                //AllowRefresh = <bool>,
                // Refreshing the authentication session should be allowed.

                ExpiresUtc = DateTimeOffset.UtcNow.AddMonths(3),
                // The time at which the authentication ticket expires. A 
                // value set here overrides the ExpireTimeSpan option of 
                // CookieAuthenticationOptions set with AddCookie.

                IsPersistent = true,
                // Whether the authentication session is persisted across 
                // multiple requests. When used with cookies, controls
                // whether the cookie's lifetime is absolute (matching the
                // lifetime of the authentication ticket) or session-based.

                //IssuedUtc = <DateTimeOffset>,
                // The time at which the authentication ticket was issued.

                //RedirectUri = <string>
                // The full path or absolute URI to be used as an http 
                // redirect response value.
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(RegisterDto model, IFormFile avatar)
        {
            if (_modelValidations.IsObjectNull(model))
                return RedirectToAction("Register", "Home");

            if (!_modelValidations.IsValid(model))
                return RedirectToAction("Register", "Home");

            var user = _usersRepository.Register(model);

            if (user == null)
                return RedirectToAction("Register", "Home");

            var imageUrl = _imageUploader.Upload(avatar, Path, user.Id);

            user.Avatar = imageUrl;

            _usersRepository.ChangeAvatar(user);

            string fullname = user.Firstname + " " + user.Lastname;

            var cookie = new CookieDto { UserId = user.Id, Avatar = user.Avatar, Phonenumber = user.Phonenumber, RoleId = user.RoleId, Fullname = fullname };

            CreateAuthCookie(cookie);

            return RedirectToAction("Index", "Home");
        }
    }
}
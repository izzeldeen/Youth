using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Helpers;
using CMS.Models;
using CMS.ViewModels;
using DAL.Dto;
using DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]

    public class UsersController : Controller
    {
        private readonly IUsersRepository _usersRepository;
        private readonly ImageUploader _imageUploader;
        private static string Path = "Avatar";


        public UsersController(IUsersRepository usersRepository, ImageUploader imageUploader)
        {
            _usersRepository = usersRepository;
            _imageUploader = imageUploader;
        }

        public IActionResult Index()
        {
            var users = _usersRepository.GetUsers();
            var model = new UsersViewModel();
            var list = new List<UserViewModel>();
            foreach (var elem in users)
            {
                var user = new UserViewModel { Firstname = elem.Firstname, Lastname = elem.Lastname, CreatedAt = elem.CreatedAt, Id = elem.Id, IsActive = elem.IsActive, IsBlocked = elem.IsBlocked, Phonenumber = elem.Phonenumber, RoleId = elem.RoleId };
                list.Add(user);
            }

            model.Users = list;
            return View(model);
        }

        public IActionResult Block(int Id)
        {
            _usersRepository.Block(Id);
            return RedirectToAction("Index", "Users");
        }

        public IActionResult UnBlock(int Id)
        {
            _usersRepository.UnBlock(Id);
            return RedirectToAction("Index", "Users");
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Action(UserModel model, IFormFile Avatar)
        {

            var user = _usersRepository.Register(new RegisterDto { Phonenumber = model.Phonenumber, Firstname = model.Firstname, Lastname = model.Lastname, Password = model.Password, RoleId = model.RoleId });

            if (user == null)
                return RedirectToAction("Add", "Users");

            var imageUrl = _imageUploader.Upload(Avatar, Path, user.Id);

            user.Avatar = imageUrl;

            _usersRepository.ChangeAvatar(user);

            return RedirectToAction("Index", "Users");
        }
    }
}
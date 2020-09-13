using System.Security.Claims;
using DAL.Dto;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PublicWebsite.Controllers
{
    public class UserController : Controller
    {
       private readonly IUsersRepository _usersRepository;
       private readonly IProductsRepository _productRepository;
       public UserController(IUsersRepository usersRepository , IProductsRepository productsRepository)
       {
           _usersRepository = usersRepository;
           _productRepository = productsRepository;
       }
        public IActionResult Index()
        {
           int userId = int.Parse(((ClaimsIdentity)User.Identity).FindFirst("UserId").Value);
           var user =   _usersRepository.GetUserById(userId);
           EditProfileDto profile = new EditProfileDto(){  Id = userId,  Phonenumber = user.Phonenumber ,Firstname = user.Firstname , Lastname = user.Lastname , Avatar = user.Avatar};
           return View(profile);
        }

        [HttpPost]
        public IActionResult Index(EditProfileDto profile){
            if(!ModelState.IsValid) return View(profile);
            _usersRepository.EditProfile(profile);
            return RedirectToAction();
        }

    }
}
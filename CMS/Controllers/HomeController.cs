using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CMS.Models;
using Microsoft.AspNetCore.Authorization;
using CMS.ViewModels;
using DAL.Interfaces;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUsersRepository _usersRepository;
        private readonly ICountriesRepository _countriesRepository;
        private readonly IOrdersRepository _ordersRepository;
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IProductsRepository _productsRepository;


        public HomeController(ILogger<HomeController> logger, IUsersRepository usersRepository, ICategoriesRepository categoriesRepository, ICountriesRepository countriesRepository, IOrdersRepository ordersRepository, IProductsRepository productsRepository)
        {
            _logger = logger;
            _usersRepository = usersRepository;
            _countriesRepository = countriesRepository;
            _ordersRepository = ordersRepository;
            _categoriesRepository = categoriesRepository;
            _productsRepository = productsRepository;
        }

        public IActionResult Index()
        
        {
            return View(new IndexViewModel { Products = _productsRepository.GetProducts().Count(), Orders = _ordersRepository.GetOrders().Count(), Categories = _categoriesRepository.GetCategories().Count(), Countries = _countriesRepository.GetCountries().Count(), Users = _usersRepository.GetUsers().Count()});
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

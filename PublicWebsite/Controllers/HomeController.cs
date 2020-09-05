using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PublicWebsite.Models;

namespace PublicWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var locale = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            //var BrowserCulture = locale.RequestCulture.UICulture.ToString();
            //if (Request.Cookies["Language"] == null)
            //{
            //    Response.Cookies.Append("Language", BrowserCulture);

            //}
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {

            return View();
        }

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

        public IActionResult Product()
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

        public IActionResult Register()
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

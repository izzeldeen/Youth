using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Models;
using CMS.ViewModels;
using DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]

    public class OrdersController : Controller
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IUsersRepository _usersRepository;
        private readonly IProductsRepository _productsRepository;

        public OrdersController(IOrdersRepository ordersRepository, IUsersRepository usersRepository, IProductsRepository productsRepository)
        {
            _ordersRepository = ordersRepository;
            _usersRepository = usersRepository;
            _productsRepository = productsRepository;
        }
        public IActionResult Index(int Id = 0)
        {
            if (Id == 0)
            {
                var orders = _ordersRepository.GetOrders();

                var model = new OrdersViewModel();
                var list = new List<OrderViewModel>();

                if (orders.Any())
                {
                    foreach (var elem in orders)
                    {
                        var user = _usersRepository.GetUserById(elem.UserId);
                        string username = user.Firstname + " " + user.Lastname;
                        var status = _ordersRepository.GetStatusById(elem.StatusId);
                        var order = new OrderViewModel { Id = elem.Id, TotalPrice = elem.TotalPrice, CreatedAt = elem.CreatedAt, UserId = elem.UserId, StatusId = elem.StatusId, Username = username, OrderStatus = status.NameEn };
                        list.Add(order);
                    }
                }

                model.Orders = list;
                return View(model);
            }
            else {

                var orders = _ordersRepository.GetUserOrders(Id);

                var model = new OrdersViewModel();
                var list = new List<OrderViewModel>();

                if (orders.Any())
                {
                    foreach (var elem in orders)
                    {
                        var user = _usersRepository.GetUserById(elem.UserId);
                        string username = user.Firstname + " " + user.Lastname;
                        var status = _ordersRepository.GetStatusById(elem.StatusId);
                        var order = new OrderViewModel { Id = elem.Id, TotalPrice = elem.TotalPrice, CreatedAt = elem.CreatedAt, UserId = elem.UserId, StatusId = elem.StatusId, Username = username, OrderStatus = status.NameEn };
                        list.Add(order);
                    }
                }

                model.Orders = list;
                return View(model);
            }

        }



        public IActionResult Details(int Id)
        {
            var order = _ordersRepository.GetOrderById(Id);
            var user = _usersRepository.GetUserById(Id);
            var status = _ordersRepository.GetStatusById(order.StatusId);

            string username = user.Firstname + " " + user.Lastname;
            string deliveryDate = order.DeliveryDate.ToString("MM/dd/yyyy");
            string deliveryTime = order.DeliveryClock.ToString("HH:mm:ss");

            var model = new OrderModel { CreatedAt = order.CreatedAt, Id = order.Id, OrderStatus = status.NameEn, TotalPrice = order.TotalPrice, Username = username, Phonenumber = user.Phonenumber, DeliveryInfo = order.DeliveryInfo, DeliveryLatitude = order.DeliveryLatitude, DeliveryLongitude = order.DeliveryLongitude, DeliveryDate = deliveryDate, DeliveryTime = deliveryTime};

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

        public IActionResult Location(float Latitude, float Longitude)
        {
            return View(new LocationModel { Latitude = Latitude, Longitude = Longitude});
        }

        public IActionResult ChangeOrderStatus(string Status, int Id)
        {
            if(Status == "Decline")
            {
                _ordersRepository.Update(Id, 3);

            }
            else
            {
                _ordersRepository.Update(Id, 2);
            }

            return RedirectToAction("Index", "Orders");
        }

    }
}
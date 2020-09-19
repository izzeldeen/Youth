using Context;
using DAL.Dto;
using DAL.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implemntations
{
    public class OrdersRepository : IOrdersRepository
    {
        protected static readonly DataContext context = new DataContext();

        protected static IRepository<Order> _repository;

        public OrdersRepository(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public void Delete(int orderId)
        {
            _repository.Delete(orderId);
        }

        public Order GetOrderById(int orderId)
        {
            
            return _repository.GetById(orderId);
        }

        public IEnumerable<OrderItem> GetOrderItems(int orderId)
        {
            return context.OrderItems.Where(x => x.OrderId == orderId).AsEnumerable();
        }

        public IEnumerable<Order> GetOrders()
        {
            return _repository.GetAll();
        }

        public Status GetStatusById(int statusId)
        {
            return  context.Status.FirstOrDefault(x => x.Id == statusId);
        }

        public IEnumerable<Order> GetUserOrders(int userId)
        {
            return context.Orders.Where(x => x.UserId == userId).AsEnumerable();
        }

        public Order Insert(OrderDto model)
        {
            var order = new Order { CreatedAt = DateTime.Now, StatusId = model.StatusId, UserId = model.UserId, TotalPrice = model.TotalPrice, DeliveryInfo = model.DeliveryInfo, DeliveryLatitude = model.DeliveryLatitude, DeliveryLongitude = model.DeliveryLongitude, DeliveryDate = model.DeliveryDate, DeliveryTime = model.DeliveryTime};
            _repository.Insert(order);

            foreach(var elem in model.OrderItems)
            {
                var orderItem = new OrderItem { ItemPrice = elem.ItemPrice, CreatedAt = DateTime.Now, OrderId = order.Id, ProductId = elem.ProductId, Quantity = elem.Quantity, TotalPrice = elem.TotalPrice };
                context.OrderItems.Add(orderItem);
            }

            context.SaveChanges();

            return order;
        }

        public void Update(int orderId, int statusId)
        {
            var order = _repository.GetById(orderId);
            order.StatusId = statusId;
            order.UpdatedAt = DateTime.Now;
            _repository.Update(order);
        }

        public List<Status> GetStatus() => context.Status.ToList();
        

       
    }
}

using DAL.Dto;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IOrdersRepository
    {
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetUserOrders(int userId);
        Order GetOrderById(int orderId);
        Status GetStatusById(int statusId);
        IEnumerable<OrderItem> GetOrderItems(int orderId);
        Order Insert(OrderDto model);
        void Delete(int orderId);
        void Update(int orderId, int statusId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Phonenumber { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryInfo { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public float DeliveryLatitude { get; set; }
        public float DeliveryLongitude { get; set; }
        public int TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<OrderItemsModel> OrderItems { get; set; }
    }

    public class OrderItemsModel
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}

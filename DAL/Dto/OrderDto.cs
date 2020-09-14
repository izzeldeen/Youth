using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dto
{
    public class OrderDto
    {
        public int UserId { get; set; }
        public int TotalPrice { get; set; }
        public int StatusId { get; set; }
        public string DeliveryInfo { get; set; }
        public float DeliveryLatitude { get; set; }
        public float DeliveryLongitude { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TotalPrice { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public string DeliveryInfo { get; set; }
        public float DeliveryLatitude { get; set; }
        public float DeliveryLongitude { get; set; }
        public DateTime DeliveryDate { get; set;}
        public DateTime DeliveryTime { get; set; }

    }
}

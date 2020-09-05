﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class OrderItem : BaseEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int ItemPrice { get; set; }
        public int TotalPrice { get; set; }

    }
}

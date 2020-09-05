using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ProductSpecification : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int MeasurmentId { get; set; }
        public Measurment Measurment { get; set; }
        public int Price { get; set; }
    }
}

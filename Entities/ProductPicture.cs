using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ProductPicture : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Image { get; set; }
    }
}

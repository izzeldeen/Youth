using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dto
{
    public class ProductDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescreptionAr { get; set; }
        public string DescreptionEn { get; set; }
        public string Image { get; set; }
        public int MeasurmentId { get; set; }
        public int? Quantity { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int CountryId { get; set; }
        public bool IsFeatured { get; set; }
        public string Message { get; set; }
    }
}

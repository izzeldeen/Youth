using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DescreptionAr { get; set; }
        public string DescreptionEn { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int MeasurmentId { get; set; }
        public int CategoryId { get; set; }
        public int CountryId { get; set; }
        public bool IsFeatured { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Measurment> Measurments { get; set; }
        public List<Category> Categories { get; set; }
        public List<Country> Countries { get; set; }
    }

}

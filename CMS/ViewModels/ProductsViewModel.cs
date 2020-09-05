using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.ViewModels
{
    public class ProductsViewModel
    {
        public List<ProductViewModel> Products { get; set; }
    }

    public class ProductViewModel
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescreptionAr { get; set; }
        public string DescreptionEn { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

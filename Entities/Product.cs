using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product : BaseEntity
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescreptionAr { get; set; }
        public string DescreptionEn { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}

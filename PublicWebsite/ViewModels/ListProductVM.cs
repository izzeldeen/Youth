using Entities;
using PublicWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWebsite.ViewModels
{
    public class ListProductVM
    {
        public List<ProductViewModel> ProductViewModel { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; } 

        public List<CountryVM> Countries {get; set;}
        public PagingInfo PagingInfo { get; set; }
    }
}

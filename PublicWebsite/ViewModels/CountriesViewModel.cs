using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWebsite.ViewModels
{
    public class CountriesViewModel
    {
        public List<CountryViewModel> Countries { get; set; }
        public List<ProductViewModel> products { get; set; }
        public List<CategoryViewModel> Categries { get; set; }
    }

    public class CountryViewModel
    {
        public int Id { get; set; }
        public string English { get; set; }
        public string Arabic { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CountryVM 
    {
        public int Id {get; set;}

        public string Name {get; set;}
    }
}

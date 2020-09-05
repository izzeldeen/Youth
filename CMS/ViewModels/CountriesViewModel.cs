using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.ViewModels
{
    public class CountriesViewModel
    {
        public List<CountryViewModel> Countries { get; set; }
    }

    public class CountryViewModel
    {
        public int Id { get; set; }
        public string English { get; set; }
        public string Arabic { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

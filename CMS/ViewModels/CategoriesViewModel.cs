using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.ViewModels
{
    public class CategoriesViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }
    }

    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string English { get; set; }
        public string Arabic { get; set; }
        public string Banner { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

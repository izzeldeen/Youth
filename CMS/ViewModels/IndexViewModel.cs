using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.ViewModels
{
    public class IndexViewModel
    {
        public int Products { get; set; }
        public int Orders { get; set; }
        public int Categories { get; set; }
        public int Countries { get; set; }
        public int Users { get; set; }
    }
}

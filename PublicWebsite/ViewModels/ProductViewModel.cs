﻿using Entities;
using PublicWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWebsite.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int Contry { get; set; }

        public string PictuerUrl { get; set; }


        public List<ProductPicture>  ListPictuerUrl { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Message {get; set;}
    
    }
}

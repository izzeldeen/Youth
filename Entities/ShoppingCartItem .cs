using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class ShoppingCartItem 
    {
        public ProductSpecification ProductSpecification { get; set; }
         
         public int ProductSpecificationId  {get;  set;}
        public int ProductId {get; set;} 
        public string PictuerUrl {get; set;}
        public int Quntity { get; set; }

        public string Name  {get; set;}

        public string Description {get; set;}

    }
}

using System.Collections.Generic;

namespace Entities
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> ShoppingCartItems {get; set;}

        public double Price {get; set;}
    }
}
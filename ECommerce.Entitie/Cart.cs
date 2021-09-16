using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
   public class Cart
    {
        public List<CartItem> cartItems { get; set; } = new List<CartItem>();
    }
}

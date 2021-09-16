using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
    public class CartItem
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal ProductTotal
        {
            get
            {
                return Price * Quantity;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
  public  class OrderItem:BaseEntity
    {
        public int OrderID  { get; set; }

        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public Product product { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }


    }
}

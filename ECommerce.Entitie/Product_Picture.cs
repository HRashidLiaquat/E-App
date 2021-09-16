using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
  public  class Product_Picture: BaseEntity
    {
        public int ProductID { get; set; }
        public int PictureID { get; set; }
        public Picture Picture { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
   public class CategoryWithChildern: BaseEntity
    {
        public Category Category { get; set; }
        public List<Category> Children { get; set; }

    }
}

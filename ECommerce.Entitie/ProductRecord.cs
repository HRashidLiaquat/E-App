using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
   public class ProductRecord:BaseEntity
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public List<ProductSpecification> ProductSpecifications { get; set; }

    }
}

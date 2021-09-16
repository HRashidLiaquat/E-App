using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
   public class ProductSpecification: BaseEntity
    {
        public int ProductRecordID { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public int ProductSpecifications { get; set; }

    }
}

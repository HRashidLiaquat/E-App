using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
  public class CategoryRecord:BaseEntity
    {
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }

    }
}

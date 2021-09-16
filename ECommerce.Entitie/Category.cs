using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
 public   class Category: BaseEntity
    {
        public int ParentCategoryID { get; set; }
        public Category ParentCategory { get; set; }
        public bool isFeatured { get; set; }
        public string SanitizedName { get; set; }
        public int DisplaySeqNo { get; set; }
        public int PictureID { get; set; }
        public Picture picture { get; set; }
        public List<Product> Products { get; set; }
        public List<CategoryRecord> CategoryRecord { get; set; }

    }
}

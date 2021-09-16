using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
   public class LanguageResource: BaseEntity
    {
        public string Key { get; set; }
        public int LanguageID { get; set; }
        public string Value { get; set; }


    }
}

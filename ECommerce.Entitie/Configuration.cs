using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
   public class Configuration
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int ConfigurationType { get; set; }
        public DateTime? ModifiedOn { get; set; }


    }
}

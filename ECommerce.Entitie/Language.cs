using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
  public  class Language: BaseEntity
    {
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public bool IsEnabled { get; set; }
        public string ResouresFileName { get; set; }
        public bool IsRTL { get; set; }
        public bool IsDefault { get; set; }
        public string IconCode { get; set; }

    }
}

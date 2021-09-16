using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Modifiedon { get; set; }
    }
}

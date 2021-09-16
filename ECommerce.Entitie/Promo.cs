using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
    public class Promo : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int PromoType { get; set; }
        public decimal Value { get; set; }
        public Nullable<DateTime> ValidTill { get; set; }

    }
}

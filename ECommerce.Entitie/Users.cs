using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
    public class Users : BaseEntity
    {
        public string FullName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public int? PictureID { get; set; }
        public Picture Picture { get; set; }
        public DateTime? RegisteredOn { get; set; }



    }
}

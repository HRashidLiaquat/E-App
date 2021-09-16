using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
    public class NewsletterSubscription : BaseEntity
    {
        public string EmailAddress { get; set; }
        public bool IsVerified { get; set; }
        public string UserID { get; set; }

    }
}

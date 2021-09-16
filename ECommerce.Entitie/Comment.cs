using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
    public class Comment : BaseEntity
    {
        public DateTime TimeStamp { get; set; }
        public Users Users { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }
        public int EntityID { get; set; }
        public int RecordID { get; set; }
        public int LanguageID { get; set; }


    }
}

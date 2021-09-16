using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entitie
{
    public class Product : BaseEntity
    {
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Cost { get; set; }
        public bool isFeatured { get; set; }
        public int ThumbnailPictureID { get; set; }
        public string SKU { get; set; }
        public string Tages { get; set; }
        public string BarCode { get; set; }
        public string Supplier { get; set; }
        public int StockQuantity { get; set; }
        public List<Product_Picture> Product_Picture { get; set; }
        public List<ProductRecord> ProductRecords { get; set; }

    }
}

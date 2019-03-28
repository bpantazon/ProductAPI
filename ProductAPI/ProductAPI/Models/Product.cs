using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
        public string SKU { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
    }
}
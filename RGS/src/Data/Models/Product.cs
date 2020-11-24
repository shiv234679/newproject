using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Product : BaseModel
    {
        [Key]
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public long ProductQty { get; set; }
        public string ImageUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(ProductCategory))]
        public long? CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class ProductCategory : BaseModel
    {
        [Key]
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
    }
}

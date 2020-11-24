using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Cart : BaseModel
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey(nameof(Product))]
        public long? ProductId { get; set; }
        public Product Product { get; set; }
        public long ProductQty { get; set; }

        [ForeignKey(nameof(Account))]
        public long? UserId { get; set; }
        public Account Account { get; set; }
    }
}

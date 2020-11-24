using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Models
{
    public class CartListViewModel
    {
        public List<CartViewModel> CartViewModels { get; set; }
    }
    public class CartViewModel
    {
        public long Id { get; set; }
        public long? ProductId { get; set; }
        public long ProductQty { get; set; }
        public long? UserId { get; set; }
        public ProductViewModel Product { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Models
{
    public class ProductListViewModel : BaseViewModel
    {
        public List<ProductViewModel> productViewModels { get; set; }
    }
    public class ProductViewModel : BaseViewModel
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public long ProductQty { get; set; }
        public string ImageUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public long? CategoryId { get; set; }
        public List<ProductCatViewModel> productCatViewModels { get; set; }
    }
    public class ProductRequestViewModel
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public long ProductQty { get; set; }
        public IFormFile Image { get; set; }
        public long? CategoryId { get; set; }
    }
}

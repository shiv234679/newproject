using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Models
{
    public class ProductCatListViewModel : BaseViewModel
    {
        public List<ProductCatViewModel> productCatViewModels { get; set; }
    }
    public class ProductCatViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class ProductCatReqViewModel
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public IFormFile Image { get; set; }
    }
}

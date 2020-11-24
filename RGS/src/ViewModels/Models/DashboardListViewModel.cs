using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Models
{
    public class DashboardListViewModel
    {
        public List<ProductCatViewModel> productCatViewModels { get; set; }
        public List<ProductViewModel> productViewModels { get; set; }
    }
}

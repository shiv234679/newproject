using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Models
{
    public class BaseViewModel
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Services.ProductCategories
{
    public interface IProductCatService
    {
        Task<ProductCatListViewModel> GetAllProductCategory();
        Task<ProductCatViewModel> GetProductCategoryById(long id);
        Task<bool> AddProductCategory(ProductCatReqViewModel model);
        Task<bool> UpdateProductCategory(ProductCatReqViewModel model);
    }
}

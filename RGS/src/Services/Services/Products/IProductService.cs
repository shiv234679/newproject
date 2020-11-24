using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Services.Products
{
    public interface IProductService
    {
        Task<ProductListViewModel> GetAllProduct();
        Task<ProductViewModel> GetProductById(long id);
        Task<bool> AddProduct(ProductRequestViewModel model);
        Task<bool> UpdateProduct(ProductRequestViewModel model);
        Task<ProductListViewModel> GetProductByCategoryId(long id);
        Task<ProductListViewModel> GetProductByCategoryId(string text);
    }
}

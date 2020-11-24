using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Services.Carts
{
    public interface ICartService
    {
        Task<int> AddCart(CartViewModel model);
        Task<int> GetCartItemCount(long UserId);
        Task<CartListViewModel> GetAllCartItem(int? userId);
    }
}

using AutoMapper;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Services.Carts
{
    public class CartService : ICartService
    {
        private readonly RGSDbContext _rGSDbContext;
        private readonly IMapper _mapper;
        public CartService(RGSDbContext rGSDbContext, IMapper mapper)
        {
            _rGSDbContext = rGSDbContext;
            _mapper = mapper;
        }
        public async Task<CartListViewModel> GetAllCartItem(int? userId)
        {
            try
            {
                var data = await this._rGSDbContext.Carts.Include(x=>x.Product).Where(x => x.UserId == userId).ToListAsync();
                if (data?.Count > 0)
                {
                    var mappedData = _mapper.Map<List<CartViewModel>>(data);
                    return new CartListViewModel { CartViewModels = mappedData };
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddCart(CartViewModel model)
        {
            try
            {
                var data = await this._rGSDbContext.Carts.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == model.UserId && x.ProductId == model.ProductId);
                var cart = new Cart();
                if (data != null)
                {
                    cart.Id = data.Id;
                    cart.CreatedDate = data.CreatedDate;
                    cart.ProductId = data.ProductId;
                    cart.UserId = data.UserId;
                    cart.ProductQty = data.ProductQty + 1;
                    cart.UpdatedDate = DateTime.Now;
                    this._rGSDbContext.Carts.Update(cart);
                    int result = await this._rGSDbContext.SaveChangesAsync();
                    if (result != 0)
                        return 1;
                    return 0;
                }
                else
                {
                    cart.ProductId = model.ProductId;
                    cart.UserId = model.UserId;
                    cart.ProductQty = 1;
                    cart.CreatedDate = DateTime.Now;
                    this._rGSDbContext.Carts.Add(cart);
                    int result = await this._rGSDbContext.SaveChangesAsync();
                    if (result != 0)
                        return 1;
                    return 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> GetCartItemCount(long UserId)
        {
            try
            {
                var data = await this._rGSDbContext.Carts.Where(x => x.UserId == UserId).ToListAsync();
                if (data != null)
                {
                    return data.Count;
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

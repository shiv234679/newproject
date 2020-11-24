using AutoMapper;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Schema;
using Services.Cloud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Services.Products
{
    public class ProductService : IProductService
    {
        private readonly RGSDbContext _rGSDbContext;
        private readonly IMapper _mapper;
        private readonly ICloudinaryService _cloudinaryService;
        public ProductService(RGSDbContext rGSDbContext, IMapper mapper, ICloudinaryService cloudinaryService)
        {
            _rGSDbContext = rGSDbContext;
            _mapper = mapper;
            _cloudinaryService = cloudinaryService;
        }
        public async Task<ProductListViewModel> GetAllProduct()
        {
            try
            {
                var data = await this._rGSDbContext.Products.Where(x => x.IsActive == true && x.IsDeleted == false).ToListAsync();
                if (data.Count > 0)
                {
                    var mappedData = _mapper.Map<List<ProductViewModel>>(data);
                    return new ProductListViewModel { productViewModels = mappedData };
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ProductViewModel> GetProductById(long Id)
        {
            try
            {
                var data = await this._rGSDbContext.Products.FirstOrDefaultAsync(x => x.ProductId == Id && x.IsActive == true && x.IsDeleted == false);
                if (data != null)
                {
                    var mappedData = _mapper.Map<ProductViewModel>(data);
                    return mappedData;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> AddProduct(ProductRequestViewModel model)
        {
            try
            {
                var imageUrl = string.Empty;
                if (model.Image != null)
                {
                    imageUrl = await this._cloudinaryService.AddPhotoForUser(model.Image);
                }
                var mappedData = _mapper.Map<Product>(model);
                mappedData.ImageUrl = imageUrl;
                mappedData.IsActive = true;
                mappedData.IsDeleted = false;
                mappedData.CreatedDate = DateTime.Now;
                await this._rGSDbContext.Products.AddAsync(mappedData);
                var data = await this._rGSDbContext.SaveChangesAsync();
                if (data > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> UpdateProduct(ProductRequestViewModel model)
        {
            try
            {
                var data = await this._rGSDbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.ProductId == model.ProductId);
                if (data != null)
                {
                    var imageUrl = string.Empty;
                    if (model.Image != null)
                    {
                        imageUrl = await this._cloudinaryService.AddPhotoForUser(model.Image);
                    }
                    else
                    {
                        imageUrl = data.ImageUrl;
                    }
                    var mappedData = _mapper.Map<Product>(model);
                    mappedData.ImageUrl = imageUrl;
                    mappedData.IsActive = data.IsActive;
                    mappedData.IsDeleted = data.IsDeleted;
                    mappedData.CreatedDate = data.CreatedDate;
                    mappedData.UpdatedDate = DateTime.Now;
                    this._rGSDbContext.Products.Update(mappedData);
                    var result = await this._rGSDbContext.SaveChangesAsync();
                    if (result > 0)
                        return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ProductListViewModel> GetProductByCategoryId(long id)
        {
            try
            {
                var data = await this._rGSDbContext.Products.Where(x => x.CategoryId == id && x.IsActive == true && x.IsDeleted == false).ToListAsync();
                if (data.Count>0)
                {
                    var mappedData = _mapper.Map<List<ProductViewModel>>(data);
                    return new ProductListViewModel { productViewModels = mappedData };
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ProductListViewModel> GetProductByCategoryId(string text)
        {
            try
            {
                var data = await this._rGSDbContext.Products.Where(x => x.ProductName.Contains(text) && x.IsActive == true && x.IsDeleted == false).ToListAsync();
                if (data?.Count > 0)
                {
                    var mappedData = _mapper.Map<List<ProductViewModel>>(data);
                    return new ProductListViewModel { productViewModels = mappedData };
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

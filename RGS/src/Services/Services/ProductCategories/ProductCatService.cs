using AutoMapper;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Services.Cloud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Services.ProductCategories
{
    public class ProductCatService : IProductCatService
    {
        private readonly RGSDbContext _rGSDbContext;
        private readonly IMapper _mapper;
        private readonly ICloudinaryService _cloudinaryService;
        public ProductCatService(RGSDbContext rGSDbContext, IMapper mapper, ICloudinaryService cloudinaryService)
        {
            _rGSDbContext = rGSDbContext;
            _mapper = mapper;
            _cloudinaryService = cloudinaryService;
        }
        public async Task<ProductCatListViewModel> GetAllProductCategory()
        {
            try
            {
                var data = await this._rGSDbContext.ProductCategories.Where(x => x.IsActive == true && x.IsDeleted == false).ToListAsync();
                if (data.Count > 0)
                {
                    var mappedData = _mapper.Map<List<ProductCatViewModel>>(data);
                    return new ProductCatListViewModel { productCatViewModels = mappedData };
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ProductCatViewModel> GetProductCategoryById(long Id)
        {
            try
            {
                var data = await this._rGSDbContext.ProductCategories.FirstOrDefaultAsync(x => x.Id == Id && x.IsActive == true && x.IsDeleted == false);
                if (data != null)
                {
                    var mappedData = _mapper.Map<ProductCatViewModel>(data);
                    return mappedData;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> AddProductCategory(ProductCatReqViewModel model)
        {
            try
            {
                var imageUrl = string.Empty;
                if (model.Image != null)
                {
                    imageUrl = await this._cloudinaryService.AddPhotoForUser(model.Image);
                }
                var mappedData = _mapper.Map<ProductCategory>(model);
                mappedData.ImageUrl = imageUrl;
                mappedData.IsActive = true;
                mappedData.IsDeleted = false;
                mappedData.CreatedDate = DateTime.Now;
                await this._rGSDbContext.ProductCategories.AddAsync(mappedData);
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
        public async Task<bool> UpdateProductCategory(ProductCatReqViewModel model)
        {
            try
            {
                var data = await this._rGSDbContext.ProductCategories.AsNoTracking().FirstOrDefaultAsync(x => x.Id == model.Id);
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
                    var mappedData = _mapper.Map<ProductCategory>(model);
                    mappedData.ImageUrl = imageUrl;
                    mappedData.IsActive = data.IsActive;
                    mappedData.IsDeleted = data.IsDeleted;
                    mappedData.CreatedDate = data.CreatedDate;
                    mappedData.UpdatedDate = DateTime.Now;
                    this._rGSDbContext.ProductCategories.Update(mappedData);
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
    }
}

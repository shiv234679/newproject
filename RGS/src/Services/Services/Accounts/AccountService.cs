using AutoMapper;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Services.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly RGSDbContext _rGSDbContext;
        private readonly IMapper _mapper;
        //private readonly ICloudinaryService _cloudinaryService;
        public AccountService(RGSDbContext rGSDbContext, IMapper mapper)
        {
            _rGSDbContext = rGSDbContext;
            _mapper = mapper;
            //_cloudinaryService = cloudinaryService;
        }

        public async Task<AccountViewModel> LogIn(AccountReqViewModel model)
        {
            try
            {
                //await Task.Factory.StartNew(() => model);
                var user = await _rGSDbContext.Accounts.AsNoTracking()
                  .FirstOrDefaultAsync(u => u.EmailId == model.EmailId && u.IsDeleted == false && u.IsActive == true);

                // return 0 if user not found.
                if (user == null)
                    return new AccountViewModel { UserId = 0 };

                // return -1 if password doesnot match.
                if (user.Password != model.Password)
                    return new AccountViewModel { UserId = -1 };

                // return -3 if user is blocked.
                if (user.IsActive == false)
                    return new AccountViewModel { UserId = -2 };
                var response = new AccountViewModel()
                {
                    UserId = user.UserId,
                    UserType=user.UserType,
                    UserName = user.UserName,
                    EmailId = user.EmailId,
                    MobileNumber = user.MobileNumber
                };
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> SignUp(AccountReqViewModel model)
        {
            try
            {
                var data = await this._rGSDbContext.Accounts.FirstOrDefaultAsync(x => x.EmailId == model.EmailId || x.MobileNumber == model.MobileNumber);
                if (data != null)
                    return 0;
                var mappedData = _mapper.Map<Account>(model);
                mappedData.CreatedDate = DateTime.Now;
                mappedData.UserType = Core.Enums.UserType.User;
                this._rGSDbContext.Accounts.Add(mappedData);
                int num = await this._rGSDbContext.SaveChangesAsync();
                if (num != 0)
                    return 1;
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

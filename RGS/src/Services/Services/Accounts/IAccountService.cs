using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Models;

namespace Services.Accounts
{
    public interface IAccountService
    {
        Task<int> SignUp(AccountReqViewModel model);
        Task<AccountViewModel> LogIn(AccountReqViewModel model);
    }
}

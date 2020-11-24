using AutoMapper;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Models;

namespace ViewModels.MapperConfiguration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<AccountReqViewModel, Account>(MemberList.None);
            CreateMap<Account, AccountViewModel>(MemberList.None);

            CreateMap<ProductRequestViewModel, Product>(MemberList.None);
            CreateMap<Product, ProductViewModel>(MemberList.None);

            CreateMap<ProductCatReqViewModel, ProductCategory>(MemberList.None);
            CreateMap<ProductCategory, ProductCatViewModel>(MemberList.None);

            CreateMap<Cart, CartViewModel>(MemberList.None);
                //.ForMember(x => x.Product, opt => opt.MapFrom(y => y.Product));
        }
    }
}

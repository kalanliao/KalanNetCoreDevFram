using AutoMapper;
using Kalan.Lib.Mapper.AutoMapper;
using Kalan.Module.Admin.Application.AccountService.ResultModels;
using Kalan.Module.Admin.Application.AccountService.ViewModels;
using Kalan.Module.Admin.Domain.Account;
using Kalan.Module.Admin.Domain.Menu;

namespace Kalan.Module.Admin.Application.AccountService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<MenuEntity, AccountMenuItem>();
            cfg.CreateMap<AccountAddModel, AccountEntity>().ForMember(m => m.Roles, opt => opt.Ignore());
            cfg.CreateMap<AccountEntity, AccountUpdateModel>();
            cfg.CreateMap<AccountUpdateModel, AccountEntity>().ForMember(m => m.Roles, opt => opt.Ignore());
        }
    }
}

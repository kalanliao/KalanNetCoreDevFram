using AutoMapper;
using Kalan.Lib.Mapper.AutoMapper;
using Kalan.Module.Admin.Application.RoleService.ViewModels;
using Kalan.Module.Admin.Domain.Role;
using Kalan.Module.Admin.Domain.RoleMenuButton;

namespace Kalan.Module.Admin.Application.RoleService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<RoleAddModel, RoleEntity>();
            cfg.CreateMap<RoleEntity, RoleUpdateModel>();
            cfg.CreateMap<RoleUpdateModel, RoleEntity>();
            cfg.CreateMap<RoleMenuButtonBindModel, RoleMenuButtonEntity>();
        }
    }
}

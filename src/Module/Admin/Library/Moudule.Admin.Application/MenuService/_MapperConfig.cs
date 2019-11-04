using AutoMapper;
using Kalan.Lib.Mapper.AutoMapper;
using Kalan.Module.Admin.Application.MenuService.ResultModels;
using Kalan.Module.Admin.Application.MenuService.ViewModels;
using Kalan.Module.Admin.Domain.Menu;

namespace Kalan.Module.Admin.Application.MenuService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<MenuAddModel, MenuEntity>();
            cfg.CreateMap<MenuEntity, MenuUpdateModel>();
            cfg.CreateMap<MenuUpdateModel, MenuEntity>();
            cfg.CreateMap<MenuEntity, MenuTreeResultModel>();
        }
    }
}

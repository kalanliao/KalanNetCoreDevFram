using AutoMapper;
using Kalan.Lib.Mapper.AutoMapper;
using Kalan.Module.Quartz.Application.GroupService.ViewModels;
using Kalan.Module.Quartz.Domain.Group;

namespace Kalan.Module.Quartz.Application.GroupService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<GroupAddModel, GroupEntity>();
        }
    }
}

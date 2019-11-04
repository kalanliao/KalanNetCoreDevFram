using AutoMapper;
using Kalan.Lib.Mapper.AutoMapper;
using Kalan.Module.Quartz.Application.JobService.ViewModels;
using Kalan.Module.Quartz.Domain.Job;

namespace Kalan.Module.Quartz.Application.JobService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<JobAddModel, JobEntity>();
            cfg.CreateMap<JobEntity, JobUpdateModel>();
            cfg.CreateMap<JobUpdateModel, JobEntity>();
        }
    }
}

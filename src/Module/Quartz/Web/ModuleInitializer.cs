using System.Collections.Specialized;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Kalan.Lib.Data.Abstractions.Enums;
using Kalan.Lib.Data.Abstractions.Options;
using Kalan.Lib.Module.AspNetCore;
using Kalan.Lib.Quartz.Abstractions;
using Kalan.Lib.Quartz.Web;
using Kalan.Lib.Utils.Core.Extensions;
using Kalan.Module.Quartz.Infrastructure.Options;
using Kalan.Module.Quartz.Web.Core;
using Quartz;

namespace Kalan.Module.Quartz.Web
{
    public class ModuleInitializer : IModuleInitializer
    {
        /// <summary>
        /// 注入服务
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            var sp = services.BuildServiceProvider();
            var options = sp.GetService<IOptionsMonitor<QuartzOptions>>().CurrentValue;
            //未启用
            if (!options.Enabled)
                return;

            var dbOptions = sp.GetService<DbOptions>();

            services.AddTransient<IJobLogger, JobLogger>();
            services.AddSingleton<ISchedulerListener, SchedulerListener>();

            var quartzProps = GetQuartzProps(options, dbOptions);

            services.AddQuartz(quartzProps);
        }

        /// <summary>
        /// 配置中间件
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
        }

        /// <summary>
        /// 配置MVC功能
        /// </summary>
        /// <param name="mvcOptions"></param>
        public void ConfigureMvc(MvcOptions mvcOptions)
        {

        }

        /// <summary>
        /// 获取Quartz属性
        /// </summary>
        /// <returns></returns>
        private NameValueCollection GetQuartzProps(QuartzOptions options, DbOptions dbOptions)
        {

            var quartzProps = new NameValueCollection();
            var quartzDbOptions = dbOptions.Modules.FirstOrDefault(m => m.Name.EqualsIgnoreCase("quartz"));
            if (quartzDbOptions != null)
            {
                quartzProps["quartz.scheduler.instanceName"] = options.InstanceName;
                quartzProps["quartz.jobStore.type"] = "Quartz.Impl.AdoJobStore.JobStoreTX,Quartz";
                quartzProps["quartz.jobStore.driverDelegateType"] = "Quartz.Impl.AdoJobStore.StdAdoDelegate,Quartz";
                quartzProps["quartz.jobStore.tablePrefix"] = options.TablePrefix;
                quartzProps["quartz.jobStore.dataSource"] = "default";
                quartzProps["quartz.dataSource.default.connectionString"] = quartzDbOptions.ConnectionString;
                quartzProps["quartz.dataSource.default.provider"] = GetProvider(dbOptions.Dialect);
                quartzProps["quartz.serializer.type"] = options.SerializerType;
            }

            return quartzProps;
        }

        private string GetProvider(SqlDialect dialect)
        {
            switch (dialect)
            {
                case SqlDialect.SqlServer:
                    return "SqlServer";
                case SqlDialect.MySql:
                    return "MySql";
                case SqlDialect.SQLite:
                    return "SQLite-Microsoft";
                case SqlDialect.Oracle:
                    return "OracleODP";
            }

            return "";
        }
    }
}

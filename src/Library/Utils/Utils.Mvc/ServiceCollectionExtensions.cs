﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Kalan.Lib.Utils.Core;

namespace Kalan.Lib.Utils.Mvc
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加MVC相关基础工具
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddUtilsMvc(this IServiceCollection services)
        {
            return services.AddSingletonFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

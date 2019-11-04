﻿using System.Threading.Tasks;
using Kalan.Lib.Utils.Core.Result;
using Kalan.Module.Admin.Application.SystemService.ViewModels;

namespace Kalan.Module.Admin.Application.SystemService
{
    /// <summary>
    /// 系统相关服务
    /// </summary>
    public interface ISystemService
    {
        /// <summary>
        /// 获取系统配置信息
        /// </summary>
        /// <returns></returns>
        Task<IResultModel<SystemConfigModel>> GetConfig(string host = null);

        /// <summary>
        /// 更改系统配置
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        IResultModel UpdateConfig(SystemConfigModel model);
    }
}

using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;
using Kalan.Lib.Auth.Abstractions;
using Kalan.Lib.Auth.Web;
using Kalan.Lib.Utils.Core.Enums;
using Kalan.Lib.Utils.Core.Extensions;
using Kalan.Module.Admin.Application.AccountService;
using Kalan.Module.Admin.Application.SystemService;
using Kalan.Module.Admin.Application.SystemService.ViewModels;
using Kalan.Module.Admin.Infrastructure.Options;

namespace Kalan.Module.Admin.Web.Core
{
    /// <summary>
    /// 权限验证
    /// </summary>
    public class PermissionValidateHandler : IPermissionValidateHandler
    {
        private readonly AdminOptions _options;
        private readonly ILoginInfo _loginInfo;
        private readonly IAccountService _accountService;
        private readonly SystemConfigModel _systemConfig;
        public PermissionValidateHandler(IOptionsMonitor<AdminOptions> optionsAccessor, IAccountService accountService, ILoginInfo loginInfo, ISystemService systemService)
        {
            _options = optionsAccessor.CurrentValue;
            _accountService = accountService;
            _loginInfo = loginInfo;
            _systemConfig = systemService.GetConfig().Result.Data;
        }

        public bool Validate(IDictionary<string, string> routeValues, HttpMethod httpMethod)
        {
            if (!_options.PermissionValidate || !_systemConfig.PermissionValidate)
                return true;

            var permissions = _accountService.QueryPermissionList(_loginInfo.AccountId).Result;

            var area = routeValues["area"];
            var controller = routeValues["controller"];
            var action = routeValues["action"];
            return permissions.Any(m => m.ModuleCode.EqualsIgnoreCase(area) && m.Controller.EqualsIgnoreCase(controller) && m.Action.EqualsIgnoreCase(action) && m.HttpMethod == httpMethod);
        }
    }
}

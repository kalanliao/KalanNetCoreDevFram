﻿using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kalan.Lib.Utils.Core.Result;
using Kalan.Lib.Utils.Mvc.Helpers;
using Kalan.Module.Admin.Application.PermissionService;
using Kalan.Module.Admin.Domain.Permission.Models;
using Kalan.Module.Admin.Web.Core;

namespace Kalan.Module.Admin.Web.Controllers
{
    [Description("权限接口")]
    public class PermissionController : ModuleController
    {
        private readonly PermissionHelper _permissionHelper;
        private readonly IPermissionService _service;

        public PermissionController(IPermissionService service, MvcHelper mvcHelper, PermissionHelper permissionHelper)
        {
            _service = service;
            _permissionHelper = permissionHelper;
        }

        [HttpGet]
        [Description("查询")]
        public Task<IResultModel> Query([FromQuery]PermissionQueryModel model)
        {
            return _service.Query(model);
        }

        [HttpPost]
        [Description("同步")]
        public Task<IResultModel> Sync()
        {
            return _service.Sync(_permissionHelper.GetAllPermission());
        }
    }
}

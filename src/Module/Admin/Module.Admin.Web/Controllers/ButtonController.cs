﻿using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kalan.Lib.Utils.Core.Result;
using Kalan.Module.Admin.Application.ButtonService;
using Kalan.Module.Admin.Domain.Button.Models;

namespace Kalan.Module.Admin.Web.Controllers
{
    [Description("按钮管理")]
    public class ButtonController : ModuleController
    {
        private readonly IButtonService _service;

        public ButtonController(IButtonService service)
        {
            _service = service;
        }

        [HttpGet]
        [Description("查询")]
        public Task<IResultModel> Query([FromQuery]ButtonQueryModel model)
        {
            return _service.Query(model);
        }
    }
}

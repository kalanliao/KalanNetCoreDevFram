using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Kalan.Lib.Auth.Web.Attributes;
using Kalan.Lib.Module.AspNetCore.Attributes;
using Kalan.Lib.Utils.Core.Result;
using Kalan.Module.Admin.Application.AuditInfoService;
using Kalan.Module.Admin.Domain.AuditInfo.Models;

namespace Kalan.Module.Admin.Web.Controllers
{
    [Description("审计信息")]
    public class AuditInfoController : ModuleController
    {
        private readonly IAuditInfoService _service;

        public AuditInfoController(IAuditInfoService service)
        {
            _service = service;
        }

        [HttpGet]
        [DisableAuditing]
        [Description("查询")]
        public Task<IResultModel> Query([FromQuery]AuditInfoQueryModel model)
        {
            return _service.Query(model);
        }

        [HttpGet]
        [DisableAuditing]
        [Description("详情")]
        public Task<IResultModel> Details([BindRequired]int id)
        {
            return _service.Details(id);
        }

        [HttpGet]
        [DisableAuditing]
        [Common]
        public Task<IResultModel> QueryLatestWeekPv()
        {
            return _service.QueryLatestWeekPv();
        }
    }
}

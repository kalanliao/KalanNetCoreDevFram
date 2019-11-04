using Microsoft.AspNetCore.Mvc;
using Kalan.Lib.Auth.Web.Attributes;
using Kalan.Lib.Validation.Abstractions;

namespace Kalan.Lib.Auth.Web
{
    /// <summary>
    /// 控制器抽象
    /// </summary>
    [Route("api/[area]/[controller]/[action]")]
    [ApiController]
    [PermissionValidate]
    [ValidateResultFormat]
    public abstract class ControllerAbstract : ControllerBase
    {
       
    }
}

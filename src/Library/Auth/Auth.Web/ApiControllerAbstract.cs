using Microsoft.AspNetCore.Mvc;
using Kalan.Lib.Module.AspNetCore.Attributes;
using Kalan.Lib.Validation.Abstractions;

namespace Kalan.Lib.Auth.Web
{
    /// <summary>
    /// 控制器抽象
    /// </summary>
    [Route("api/[area]/[controller]/[action]")]
    [ApiController]
    [ValidateResultFormat]
    [DisableAuditing]
    public abstract class ApiControllerAbstract : ControllerBase
    {
       
    }
}

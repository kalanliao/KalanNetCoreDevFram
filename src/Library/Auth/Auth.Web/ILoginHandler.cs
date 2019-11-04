using System.Security.Claims;
using Kalan.Lib.Utils.Core.Result;

namespace Kalan.Lib.Auth.Web
{
    /// <summary>
    /// 登录处理
    /// </summary>
    public interface ILoginHandler
    {
        IResultModel Hand(Claim[] claims);
    }
}

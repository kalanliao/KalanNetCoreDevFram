using System;
using System.Threading.Tasks;
using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Domain.AccountConfig
{
    /// <summary>
    /// 账户配置仓储
    /// </summary>
    public interface IAccountConfigRepository : IRepository<AccountConfigEntity>
    {
        /// <summary>
        /// 查询指定账户的配置信息
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<AccountConfigEntity> GetByAccount(Guid accountId);
    }
}

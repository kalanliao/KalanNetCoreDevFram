using System.Collections.Generic;
using System.Threading.Tasks;
using Kalan.Lib.Data.Abstractions;
using Kalan.Lib.Utils.Core.Result;
using Kalan.Module.Admin.Domain.AuditInfo.Models;

namespace Kalan.Module.Admin.Domain.AuditInfo
{
    /// <summary>
    /// 审计信息仓储
    /// </summary>
    public interface IAuditInfoRepository : IRepository<AuditInfoEntity>
    {
        Task<IList<AuditInfoEntity>> Query(AuditInfoQueryModel model);

        Task<AuditInfoEntity> Details(int id);

        /// <summary>
        /// 查询最近一周访问量
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ChatDataRow>> QueryLatestWeekPv();
    }
}

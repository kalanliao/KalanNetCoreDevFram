using System.Collections.Generic;
using System.Threading.Tasks;
using Kalan.Lib.Data.Abstractions;
using Kalan.Module.Quartz.Domain.Group.Models;

namespace Kalan.Module.Quartz.Domain.Group
{
    /// <summary>
    /// 任务组仓储
    /// </summary>
    public interface IGroupRepository : IRepository<GroupEntity>
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IList<GroupEntity>> Query(GroupQueryModel model);

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> Exists(GroupEntity entity);
    }
}

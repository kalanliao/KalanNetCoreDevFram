using Kalan.Lib.Data.Abstractions.Attributes;
using Kalan.Lib.Data.Core.Entities.Extend;

namespace Kalan.Module.Quartz.Domain.Group
{
    /// <summary>
    /// 任务组
    /// </summary>
    [Table("Group")]
    public partial class GroupEntity : EntityBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Length(100)]
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [Length(100)]
        public string Code { get; set; }
    }
}

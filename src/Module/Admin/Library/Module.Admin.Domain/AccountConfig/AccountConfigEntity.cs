using System;
using Kalan.Lib.Data.Abstractions.Attributes;
using Kalan.Lib.Data.Core.Entities;

namespace Kalan.Module.Admin.Domain.AccountConfig
{
    /// <summary>
    /// 账户配置信息
    /// </summary>
    [Table("Account_Config")]
    public class AccountConfigEntity : Entity<int>
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// 皮肤
        /// </summary>
        public string Skin { get; set; }

        /// <summary>
        /// 主题
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// 字号
        /// </summary>
        public string FontSize { get; set; }
    }
}

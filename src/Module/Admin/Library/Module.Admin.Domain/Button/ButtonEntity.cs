﻿using Kalan.Lib.Data.Abstractions.Attributes;
using Kalan.Lib.Data.Core.Entities.Extend;

namespace Kalan.Module.Admin.Domain.Button
{
    /// <summary>
    /// 按钮
    /// </summary>
    [Table("Button")]
    public partial class ButtonEntity : EntityBase
    {
        /// <summary>
        /// 菜单编码
        /// </summary>
        public string MenuCode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [Nullable]
        public string Icon { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
    }
}

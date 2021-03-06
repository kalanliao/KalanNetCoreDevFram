﻿using System.Collections.Generic;
using Kalan.Lib.Data.Abstractions.Attributes;
using Kalan.Lib.Utils.Core.Extensions;

namespace Kalan.Module.Admin.Domain.Menu
{
    public partial class MenuEntity
    {
        /// <summary>
        /// 父节点名称
        /// </summary>
        [Ignore]
        public string ParentName { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [Ignore]
        public string TypeName => Type.ToDescription();

        /// <summary>
        /// 打开方式名称
        /// </summary>
        [Ignore]
        public string TargetName => Target.ToDescription();

        /// <summary>
        /// 子菜单
        /// </summary>
        public IList<MenuEntity> Children { get; set; }
    }
}

using System.Collections.Generic;
using Kalan.Lib.Data.Abstractions.Attributes;
using Kalan.Lib.Utils.Core.Extensions;
using Kalan.Lib.Utils.Core.Result;

namespace Kalan.Module.Admin.Domain.Account
{
    public partial class AccountEntity
    {
        /// <summary>
        /// 关联角色
        /// </summary>
        [Ignore]
        public List<OptionResultModel> Roles { get; set; }

        /// <summary>
        /// 账户类型名称
        /// </summary>
        [Ignore]
        public string TypeName => Type.ToDescription();
    }
}

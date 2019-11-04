using System;
using Kalan.Lib.Data.Abstractions.Attributes;

namespace Kalan.Module.Admin.Domain.Button
{
    public partial class ButtonEntity
    {
        [Ignore]
        public Guid RoleId { get; set; }
    }
}

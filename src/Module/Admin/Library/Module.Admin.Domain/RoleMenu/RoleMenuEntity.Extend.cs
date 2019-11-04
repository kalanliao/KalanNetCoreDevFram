using Kalan.Lib.Data.Abstractions.Attributes;
using Kalan.Module.Admin.Domain.Menu;

namespace Kalan.Module.Admin.Domain.RoleMenu
{
    public partial class RoleMenuEntity
    {
        [Ignore]
        public MenuType MenuType { get; set; }
    }
}

using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.MySql
{
    public class RoleMenuRepository : SqlServer.RoleMenuRepository
    {
        public RoleMenuRepository(IDbContext context) : base(context)
        {
        }
    }
}

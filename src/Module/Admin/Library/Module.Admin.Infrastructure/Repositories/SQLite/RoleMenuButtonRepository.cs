using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.SQLite
{
    public class RoleMenuButtonRepository : SqlServer.RoleMenuButtonRepository
    {
        public RoleMenuButtonRepository(IDbContext context) : base(context)
        {
        }
    }
}

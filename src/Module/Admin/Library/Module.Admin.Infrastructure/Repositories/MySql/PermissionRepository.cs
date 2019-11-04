using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.MySql
{
    public class PermissionRepository : SqlServer.PermissionRepository
    {
        public PermissionRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}

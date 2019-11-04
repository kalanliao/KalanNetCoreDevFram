using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.SQLite
{
    public class AccountRoleRepository : SqlServer.AccountRoleRepository
    {
        public AccountRoleRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}

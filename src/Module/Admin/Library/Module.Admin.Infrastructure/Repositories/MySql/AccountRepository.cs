using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.MySql
{
    public class AccountRepository : SqlServer.AccountRepository
    {
        public AccountRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}

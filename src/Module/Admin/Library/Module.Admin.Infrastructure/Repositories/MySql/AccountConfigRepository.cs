using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.MySql
{
    public class AccountConfigRepository : SqlServer.AccountConfigRepository
    {
        public AccountConfigRepository(IDbContext context) : base(context)
        {
        }
    }
}

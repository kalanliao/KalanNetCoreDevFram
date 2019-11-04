using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.SQLite
{
    public class MenuRepository : SqlServer.MenuRepository
    {
        public MenuRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}

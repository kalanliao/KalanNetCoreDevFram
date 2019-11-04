using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Quartz.Infrastructure.Repositories.SQLite
{
    public class GroupRepository : SqlServer.GroupRepository
    {
        public GroupRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}

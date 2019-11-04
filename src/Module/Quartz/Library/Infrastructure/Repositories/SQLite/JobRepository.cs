using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Quartz.Infrastructure.Repositories.SQLite
{
    public class JobRepository : SqlServer.JobRepository
    {
        public JobRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}

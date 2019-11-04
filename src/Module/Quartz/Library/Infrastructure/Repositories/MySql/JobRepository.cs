using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Quartz.Infrastructure.Repositories.MySql
{
    public class JobRepository : SqlServer.JobRepository
    {
        public JobRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
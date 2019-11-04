using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Quartz.Infrastructure.Repositories.SQLite
{
    public class JobLogRepository : SqlServer.JobLogRepository
    {
        public JobLogRepository(IDbContext context) : base(context)
        {
        }
    }
}

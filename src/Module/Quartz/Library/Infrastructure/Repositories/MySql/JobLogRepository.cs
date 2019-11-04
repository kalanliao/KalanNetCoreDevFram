using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Quartz.Infrastructure.Repositories.MySql
{
    public class JobLogRepository : SqlServer.JobLogRepository
    {
        public JobLogRepository(IDbContext context) : base(context)
        {
        }
    }
}

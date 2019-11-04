using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.SQLite
{
    public class ModuleInfoRepository : SqlServer.ModuleInfoRepository
    {
        public ModuleInfoRepository(IDbContext context) : base(context)
        {
        }
    }
}

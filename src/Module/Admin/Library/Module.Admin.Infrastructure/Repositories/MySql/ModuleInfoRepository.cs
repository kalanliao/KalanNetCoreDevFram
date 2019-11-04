using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.MySql
{
    public class ModuleInfoRepository : SqlServer.ModuleInfoRepository
    {
        public ModuleInfoRepository(IDbContext context) : base(context)
        {
        }
    }
}

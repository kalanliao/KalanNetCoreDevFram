using Kalan.Lib.Data.Abstractions;

namespace Kalan.Module.Admin.Infrastructure.Repositories.SQLite
{
    public class ButtonRepository : SqlServer.ButtonRepository
    {
        public ButtonRepository(IDbContext context) : base(context)
        {
        }
    }
}

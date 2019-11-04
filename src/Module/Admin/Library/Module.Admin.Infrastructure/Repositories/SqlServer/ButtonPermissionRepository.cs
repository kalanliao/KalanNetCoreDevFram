using System.Threading.Tasks;
using Kalan.Lib.Data.Abstractions;
using Kalan.Lib.Data.Core;
using Kalan.Module.Admin.Domain.ButtonPermission;

namespace Kalan.Module.Admin.Infrastructure.Repositories.SqlServer
{
    public class ButtonPermissionRepository : RepositoryAbstract<ButtonPermissionEntity>, IButtonPermissionRepository
    {
        public ButtonPermissionRepository(IDbContext context) : base(context)
        {
        }

        public Task<bool> ExistsBindPermission(string permissionCode)
        {
            return Db.Find(m => m.PermissionCode.Equals(permissionCode)).ExistsAsync();
        }

        public Task<bool> DeleteByButton(string buttonCode, IUnitOfWork uow)
        {
            return Db.Find(e => e.ButtonCode == buttonCode).UseUow(uow).DeleteAsync();
        }
    }
}

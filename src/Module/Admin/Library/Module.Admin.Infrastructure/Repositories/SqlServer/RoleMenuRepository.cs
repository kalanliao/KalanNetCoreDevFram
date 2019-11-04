using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kalan.Lib.Data.Abstractions;
using Kalan.Lib.Data.Core;
using Kalan.Module.Admin.Domain.Menu;
using Kalan.Module.Admin.Domain.RoleMenu;

namespace Kalan.Module.Admin.Infrastructure.Repositories.SqlServer
{
    public class RoleMenuRepository : RepositoryAbstract<RoleMenuEntity>, IRoleMenuRepository
    {
        public RoleMenuRepository(IDbContext context) : base(context)
        {
        }
        public Task<IList<RoleMenuEntity>> GetByRoleId(Guid roleId)
        {
            return Db.Find(e => e.RoleId == roleId)
                .LeftJoin<MenuEntity>((x, y) => x.MenuId == y.Id)
                .Select((x, y) => new { x, MenuType = y.Type })
                .ToListAsync();
        }

        public Task<bool> DeleteByMenuId(Guid menuId, IUnitOfWork uow)
        {
            return Db.Find(e => e.MenuId == menuId).UseUow(uow).DeleteAsync();
        }

        public Task<bool> ExistsWidthMenu(Guid menuId)
        {
            return Db.Find(e => e.MenuId == menuId).ExistsAsync();
        }

        public Task<bool> DeleteByRoleId(Guid roleId, IUnitOfWork uow)
        {
            return Db.Find(e => e.RoleId == roleId).UseUow(uow).DeleteAsync();
        }
    }
}

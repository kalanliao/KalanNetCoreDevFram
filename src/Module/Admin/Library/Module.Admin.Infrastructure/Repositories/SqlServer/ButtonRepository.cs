﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kalan.Lib.Data.Abstractions;
using Kalan.Lib.Data.Core;
using Kalan.Lib.Data.Query;
using Kalan.Module.Admin.Domain.Account;
using Kalan.Module.Admin.Domain.AccountRole;
using Kalan.Module.Admin.Domain.Button;
using Kalan.Module.Admin.Domain.Button.Models;
using Kalan.Module.Admin.Domain.RoleMenuButton;

namespace Kalan.Module.Admin.Infrastructure.Repositories.SqlServer
{
    public class ButtonRepository : RepositoryAbstract<ButtonEntity>, IButtonRepository
    {
        public ButtonRepository(IDbContext context) : base(context)
        {
        }

        public async Task<IList<ButtonEntity>> Query(ButtonQueryModel model)
        {
            var paging = model.Paging();

            var query = Db.Find(m => m.MenuCode == model.MenuCode)
                .WhereNotNull(model.Name, m => m.Name.Contains(model.Name));

            var list = await query.LeftJoin<AccountEntity>((x, y) => x.CreatedBy == y.Id)
                .Select((x, y) => new { x, Creator = y.Name })
                .PaginationAsync(paging);
            model.TotalCount = paging.TotalCount;
            return list;
        }

        public Task<IList<ButtonEntity>> QueryByMenu(string menuCode, IUnitOfWork uow)
        {
            return Db.Find(m => m.MenuCode == menuCode).UseUow(uow).ToListAsync();
        }

        public Task<IList<string>> QueryCodeByAccount(Guid accountId)
        {
            return Db.Find()
                .InnerJoin<RoleMenuButtonEntity>((x, y) => x.Id == y.ButtonId)
                .InnerJoin<AccountRoleEntity>((x, y, z) => y.RoleId == z.RoleId && z.AccountId == accountId)
                .Select((x, y, z) => x.Code)
                .ToListAsync<string>();
        }

        public Task<bool> ExistsByCode(string code, IUnitOfWork uow)
        {
            return Db.Find(m => m.Code == code).UseUow(uow).ExistsAsync();
        }
    }
}

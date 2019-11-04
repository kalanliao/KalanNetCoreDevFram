using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kalan.Lib.Data.Abstractions;
using Kalan.Lib.Data.Core;
using Kalan.Lib.Data.Query;
using Kalan.Module.Admin.Domain.Account;
using Kalan.Module.Quartz.Domain.Group;
using Kalan.Module.Quartz.Domain.Group.Models;

namespace Kalan.Module.Quartz.Infrastructure.Repositories.SqlServer
{
    public class GroupRepository : RepositoryAbstract<GroupEntity>, IGroupRepository
    {
        public GroupRepository(IDbContext context) : base(context)
        {
        }

        public async Task<IList<GroupEntity>> Query(GroupQueryModel model)
        {
            var paging = model.Paging();

            var query = Db.Find();
            query.WhereNotNull(model.Name, m => m.Name.Contains(model.Name));
            query.WhereNotNull(model.Code, m => m.Code.Contains(model.Code));

            var joinQuery = query.LeftJoin<AccountEntity>((x, y) => x.CreatedBy == y.Id);
            if (!paging.OrderBy.Any())
            {
                joinQuery.OrderByDescending((x, y) => x.Id);
            }

            joinQuery.Select((x, y) => new { x, Creator = y.Name });

            var result = await joinQuery.PaginationAsync(paging);
            model.TotalCount = paging.TotalCount;

            return result;
        }

        public Task<bool> Exists(GroupEntity entity)
        {
            var query = Db.Find(m => m.Code == entity.Code);
            query.WhereNotEmpty(entity.Id, m => m.Id != entity.Id);
            return query.ExistsAsync();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Kalan.Lib.Data.Abstractions;
using Kalan.Lib.Utils.Core.Result;
using Kalan.Module.Admin.Infrastructure.Repositories.MySql.Sql;

namespace Kalan.Module.Admin.Infrastructure.Repositories.MySql
{
    public class AuditInfoRepository : SqlServer.AuditInfoRepository
    {
        public AuditInfoRepository(IDbContext context) : base(context)
        {
        }

        public override Task<IEnumerable<ChatDataRow>> QueryLatestWeekPv()
        {
            var sql = string.Format(AuditInfoSql.QueryLatestWeekPv, Db.EntityDescriptor.TableName);
            return Db.QueryAsync<ChatDataRow>(sql);
        }
    }
}

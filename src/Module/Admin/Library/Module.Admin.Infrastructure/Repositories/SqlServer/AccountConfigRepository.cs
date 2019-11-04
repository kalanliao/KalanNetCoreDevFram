using System;
using System.Threading.Tasks;
using Kalan.Lib.Data.Abstractions;
using Kalan.Lib.Data.Core;
using Kalan.Module.Admin.Domain.AccountConfig;

namespace Kalan.Module.Admin.Infrastructure.Repositories.SqlServer
{
    public class AccountConfigRepository : RepositoryAbstract<AccountConfigEntity>, IAccountConfigRepository
    {
        public AccountConfigRepository(IDbContext context) : base(context)
        {
        }

        public Task<AccountConfigEntity> GetByAccount(Guid accountId)
        {
            return GetAsync(m => m.AccountId == accountId);
        }
    }
}

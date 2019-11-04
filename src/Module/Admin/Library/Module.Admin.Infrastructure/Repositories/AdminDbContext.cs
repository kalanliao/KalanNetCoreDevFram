using System;
using Kalan.Lib.Data.Abstractions;
using Kalan.Lib.Data.Core;

namespace Kalan.Module.Admin.Infrastructure.Repositories
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(IDbContextOptions options, IServiceProvider serviceProvider) : base(options, serviceProvider)
        {
        }
    }
}

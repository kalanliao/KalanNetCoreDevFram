using System;
using Kalan.Lib.Data.Abstractions;
using Kalan.Lib.Data.Core;

namespace Kalan.Module.Quartz.Infrastructure.Repositories
{
    public class QuartzDbContext : DbContext
    {
        public QuartzDbContext(IDbContextOptions options, IServiceProvider serviceProvider) : base(options, serviceProvider)
        {
        }
    }
}

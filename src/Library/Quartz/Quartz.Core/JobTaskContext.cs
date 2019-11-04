using System;
using Kalan.Lib.Quartz.Abstractions;
using Quartz;

namespace Kalan.Lib.Quartz.Core
{
    public class JobTaskContext : IJobTaskContext
    {
        public Guid JobId { get; set; }
        public IJobExecutionContext JobExecutionContext { get; set; }
    }
}

using Kalan.Lib.Utils.Core.Options;

namespace Kalan.Module.Quartz.Infrastructure.Options
{
    /// <summary>
    /// 任务调度配置项
    /// </summary>
    public class QuartzOptions : IModuleOptions
    {
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// 表前缀
        /// </summary>
        public string TablePrefix { get; set; }

        /// <summary>
        /// 序列化方式
        /// </summary>
        public string SerializerType { get; set; }

        public QuartzOptions()
        {
            InstanceName = "QuartzServer";
            TablePrefix = "QRTZ_";
            SerializerType = "JSON";
        }
    }
}

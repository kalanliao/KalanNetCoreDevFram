namespace Kalan.Lib.MQ.RabbitMQ
{
    /// <summary>
    /// 默认交换器
    /// </summary>
    public class DefaultExchange
    {
        public const string Direct = "Kalan.direct";

        public const string Fanout = "Kalan.fanout";

        public const string Topic = "Kalan.topic";

        public const string Headers = "Kalan.headers";
    }
}

namespace MqttUdp
{
    public class SubscribePacket : IPacket
    {
        public SubscribePacket(string topic)
        {
            Topic = topic;
        }
        public string Topic {get;set;}
        public int QoS {get;set;}
    }
}

using System.Text;

namespace MqttUdp
{
    public static class PublishPacketExtensions
    {
        public static string ReadString(this PublishPacket instance)
        {
            return Encoding.UTF8.GetString(instance.Payload);
        }
        public static void Write(this PublishPacket instance, string value)
        {
            instance.Payload = Encoding.UTF8.GetBytes(value);
        }
    }
}

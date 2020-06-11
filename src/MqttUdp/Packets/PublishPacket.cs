using System;
using System.Collections;

namespace MqttUdp
{
    public class PublishPacket : IPacket
    {
        public string Topic { get; set; } = string.Empty;
        public byte[] Payload { get; set; } = Array.Empty<byte>();
        public DateTime MeasuredAt { get; set; }
        public DateTime SentAt { get; set; }
        public int Sequence { get; set; }
        public byte[] Hash { get; internal set; } = Array.Empty<byte>();
        public bool HashMatch { get; set; }
        public int ReplyTo { get; set; }
    }
}

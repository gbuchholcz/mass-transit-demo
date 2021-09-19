using System;

namespace MassTransitDemo.Messages
{
    public interface ITimeRequestAccepted
    {
        public string UserId { get; }
        public DateTime Timestamp { get; }
    }

}

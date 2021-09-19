using MassTransit;
using MassTransitDemo.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassTransitDemo.Consumers
{
    public class RequestTimeConsumer : IConsumer<RequestTime>
    {
        public Task Consume(ConsumeContext<RequestTime> context)
        {
            return context.RespondAsync<ITimeRequestAccepted>(new
            {
               UserId = Guid.NewGuid(),
               InVar.Timestamp
            });
        }
    }
}

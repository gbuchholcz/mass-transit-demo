using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassTransitDemo.Messages
{
    public interface  RequestTime
    {
        public string Timezone { get; }
        public string UserId { get; }
    }

}

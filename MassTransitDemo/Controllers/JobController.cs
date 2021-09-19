using MassTransit;
using MassTransit.Clients;
using MassTransitDemo.Messages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MassTransitDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly RequestClient<RequestTime> _requestTimeClient;
        private readonly ILogger<JobController> _logger;

        public JobController(RequestClient<RequestTime> requestTimeClient, ILogger<JobController> logger)
        {
            this._requestTimeClient = requestTimeClient;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post(string userId, string timeZone, CancellationToken cancelationToken)
        {
            Response<ITimeRequestAccepted> response = await _requestTimeClient.GetResponse<ITimeRequestAccepted>(new { UserId =userId, TimeZone = timeZone }, cancelationToken, RequestTimeout.Default);
            return Ok(response.Message);
        }
    }
}

using Commons.Utils;
using Grpc.Core;
using Grpc.Net.Client;
using IdentityService.Protos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityService.Controllers
{
    [Route("api/identity")]
    [ApiController]
    public class IdentityController : Controller
    {
        private readonly ILogger<IdentityController> _logger;
        private readonly GrpcChannel _channel;
        private readonly Identity.IdentityClient _client;

        public IdentityController(ILogger<IdentityController> logger)
        {
            _logger = logger;
            _channel = GrpcChannel.ForAddress("https://localhost:5001");
            _client = new Identity.IdentityClient(_channel);
        }

        [HttpPost("authenticate")]
        public ActionResult<Profile> Authenticate([FromBody] Credentials credentials)
        {
            return Ok(_client.Autenticate(credentials));
        }
    }
}

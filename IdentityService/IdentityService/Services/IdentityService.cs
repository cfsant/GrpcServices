using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Grpc.Core;
using System;
using IdentityService.Protos;
using IdentityService.Handlers;

namespace IdentityService.Services
{
    public class IdentityService : Identity.IdentityBase
    {
        private readonly ILogger<IdentityService> _logger;

        public IdentityService(ILogger<IdentityService> logger)
        {
            _logger = logger;
        }

        public override Task<Profile> Autenticate(Credentials request, ServerCallContext context)
        {
            return base.Autenticate(request, context);
        }
    }
}

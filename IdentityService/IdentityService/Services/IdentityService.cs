using Grpc.Core;
using IdentityService.Protos;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

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

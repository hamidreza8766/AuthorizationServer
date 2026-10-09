using AuthorizationServer.Application.Modules.Clients.Tools.Generators.AuthorizationCodes.Abstraction;

namespace AuthorizationServer.Application.Modules.Clients.Tools.Generators.AuthorizationCodes.Implementations
{
    public class AuthorizationCodesGenerator : IAuthorizationCodesGenerator
    {
        public string Generate(long? userId = null, long? clientId = null)
        {
            return Guid.NewGuid().ToString();
        }
    }
}
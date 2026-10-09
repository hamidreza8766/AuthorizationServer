using AuthorizationServer.Application.Modules.Clients.Tools.Generators.AuthorizationCodes.Abstraction;
using System.Security.Cryptography;

namespace AuthorizationServer.Application.Modules.Clients.Tools.Generators.AuthorizationCodes.Implementations
{
    public class AuthorizationCodesGenerator : IAuthorizationCodesGenerator
    {
        public string Generate(long? userId = null, long? clientId = null)
        {
            return RandomNumberGenerator.GetHexString(64);
        }
    }
}
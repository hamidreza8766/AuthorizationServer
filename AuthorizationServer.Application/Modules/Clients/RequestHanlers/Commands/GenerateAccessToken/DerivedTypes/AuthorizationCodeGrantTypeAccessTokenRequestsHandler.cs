using AuthorizationServer.Application.Modules.General.RequestHandlers;
using AuthorizationServer.Application.Modules.Clients.Models.Commands.GenerateAccessTokens.DerivedTypes;
using AuthorizationServer.Application.Modules.Clients.Models.Results.Commands.GenerateAccessTokens.DerivedTypes;

namespace AuthorizationServer.Application.Modules.Clients.RequestHanlers.Commands.GenerateAccessToken.DerivedTypes
{
    public class AuthorizationCodeGrantTypeAccessTokenRequestsHandler : IRequestHandler<AuthorizationCodeGrantTypeAccessTokenRequest, AuthorizationCodeGrantTypeAccessTokenRequestsResult>
    {
        public Task<AuthorizationCodeGrantTypeAccessTokenRequestsResult> HandleAsync(AuthorizationCodeGrantTypeAccessTokenRequest requst, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
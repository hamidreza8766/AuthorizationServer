using AuthorizationServer.Application.Modules.General.Requests.BaseType;
using AuthorizationServer.Application.Modules.Clients.Models.Commands.GenerateAccessTokens.BaseType;
using AuthorizationServer.Application.Modules.Clients.Models.Results.Commands.GenerateAccessTokens.DerivedTypes;

namespace AuthorizationServer.Application.Modules.Clients.Models.Commands.GenerateAccessTokens.DerivedTypes
{
    public class AuthorizationCodeGrantTypeAccessTokenRequest : GenerateAccessTokenCommand, IRequest<AuthorizationCodeGrantTypeAccessTokenRequestsResult>
    {
    }
}
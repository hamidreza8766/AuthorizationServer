using AuthorizationServer.Application.Modules.Clients.Models.Results.Commands.GenerateAccessTokens.BaseType;
using AuthorizationServer.Application.Modules.General.Requests.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Models.Commands.GenerateAccessTokens.BaseType
{
    public class GenerateAccessTokenCommand : IRequest<GenerateAccessTokenCommandsResult>
    {
    }
}
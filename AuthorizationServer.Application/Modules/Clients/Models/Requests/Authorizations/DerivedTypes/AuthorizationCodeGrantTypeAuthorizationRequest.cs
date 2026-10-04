using AuthorizationServer.Application.Modules.Clients.Models.Responses;
using AuthorizationServer.Application.Modules.General.Requests.BaseType;
using AuthorizationServer.Application.Modules.Clients.Models.Requests.Authorizations.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Models.Requests.Authorizations.DerivedTypes
{
    public class AuthorizationCodeGrantTypeAuthorizationRequest : BaseAuthorizationRequest, IRequest<AuthorizationCodeGrantTypeAuthorizationRequestsResponse>
    {
    }
}
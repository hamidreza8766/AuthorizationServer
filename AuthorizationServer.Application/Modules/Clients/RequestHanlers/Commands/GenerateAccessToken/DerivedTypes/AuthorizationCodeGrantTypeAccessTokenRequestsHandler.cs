using AuthorizationServer.Application.Modules.General.RequestHandlers;
using AuthorizationServer.Application.Modules.Clients.Models.Responses;
using AuthorizationServer.Application.Modules.General.UnitOfWorks.BaseType;
using AuthorizationServer.Application.Modules.Clients.Models.Requests.Authorizations.DerivedTypes;

namespace AuthorizationServer.Application.Modules.Clients.RequestHanlers.Commands.GenerateAccessToken.DerivedTypes
{
    public class AuthorizationCodeGrantTypeAccessTokenRequestsHandler : IRequestHandler<AuthorizationCodeGrantTypeAuthorizationRequest, AuthorizationCodeGrantTypeAuthorizationRequestsResponse>
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly AuthorizationCodeGrantTypeAuthorizationRequestsResponse _Response;
        public AuthorizationCodeGrantTypeAccessTokenRequestsHandler(
            IUnitOfWork unitOfWork,
            AuthorizationCodeGrantTypeAuthorizationRequestsResponse response)
        {
            if (response == null)
                throw new ArgumentNullException(nameof(response));
            if (unitOfWork == null)
                throw new ArgumentNullException(nameof(unitOfWork));
            _Response = response;
            _UnitOfWork = unitOfWork;
        }
        public async Task<AuthorizationCodeGrantTypeAuthorizationRequestsResponse> HandleAsync(AuthorizationCodeGrantTypeAuthorizationRequest requst, CancellationToken cancellationToken)
        {
            {

            }
        }
    }
}
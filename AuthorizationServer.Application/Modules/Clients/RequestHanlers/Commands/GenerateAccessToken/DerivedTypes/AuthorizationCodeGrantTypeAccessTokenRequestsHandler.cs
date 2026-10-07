using AuthorizationServer.Application.Modules.General.RequestHandlers;
using AuthorizationServer.Application.Modules.Clients.Models.Responses;
using AuthorizationServer.Application.Modules.Clients.Repositories.Queries;
using AuthorizationServer.Application.Modules.General.UnitOfWorks.BaseType;
using AuthorizationServer.Application.Modules.Clients.Models.Requests.Authorizations.DerivedTypes;
using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;
using AuthorizationServer.Application.Modules.General.Catalogs.Errors.ResponseTypes;
using AuthorizationServer.Application.Modules.General.Catalogs.Errors.Clients;

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
            ClientEntity client;
            IEntitiesRetrieverClientsRepository entitiesRetrieverClientsRepository;
            {
                entitiesRetrieverClientsRepository = _UnitOfWork.GetEntitiesRetrieverClientsRepository();
                client = await entitiesRetrieverClientsRepository.GetByClientIdAsync(requst.client_id);
                if (client == null)
                    return ClientErrorsCatalog.ClientDidNotFoundResult.CreateNew<AuthorizationCodeGrantTypeAuthorizationRequestsResponse>();
                if (!string.Equals(requst.response_type, "code", StringComparison.OrdinalIgnoreCase))
                    return ResponseTypeErrorsCatalog.InvalidResponseTypeResult.CreateNew<AuthorizationCodeGrantTypeAuthorizationRequestsResponse>();
                
                return _Response;
            }
        }
    }
}
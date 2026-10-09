using Microsoft.AspNetCore.Http;
using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;
using AuthorizationServer.Application.Modules.General.TypeExtensions;
using AuthorizationServer.Application.Modules.General.RequestHandlers;
using AuthorizationServer.Application.Modules.Clients.Models.Responses;
using AuthorizationServer.Application.Modules.Clients.Repositories.Queries;
using AuthorizationServer.Application.Modules.General.UnitOfWorks.BaseType;
using AuthorizationServer.Application.Modules.General.Catalogs.Errors.Clients;
using AuthorizationServer.Application.Modules.General.Catalogs.Errors.ResponseTypes;
using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.AuthorizationCodes.BaseType;
using AuthorizationServer.Application.Modules.Clients.Models.Requests.Authorizations.DerivedTypes;
using AuthorizationServer.Application.Modules.Clients.Tools.Generators.AuthorizationCodes.Abstraction;

namespace AuthorizationServer.Application.Modules.Clients.RequestHanlers.Commands.GenerateAccessToken.DerivedTypes
{
    public class AuthorizationCodeGrantTypeAccessTokenRequestsHandler : IRequestHandler<AuthorizationCodeGrantTypeAuthorizationRequest, AuthorizationCodeGrantTypeAuthorizationRequestsResponse>
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAuthorizationCodesGenerator _AuthorizationCodesGenerator;
        private readonly AuthorizationCodeGrantTypeAuthorizationRequestsResponse _Response;
        public AuthorizationCodeGrantTypeAccessTokenRequestsHandler(
            IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor,
            IAuthorizationCodesGenerator authorizationCodesGenerator,
            AuthorizationCodeGrantTypeAuthorizationRequestsResponse response)
        {
            if (response == null)
                throw new ArgumentNullException(nameof(response));
            if (unitOfWork == null)
                throw new ArgumentNullException(nameof(unitOfWork));
            if (authorizationCodesGenerator == null)
                throw new ArgumentNullException(nameof(authorizationCodesGenerator));
            _Response = response;
            _UnitOfWork = unitOfWork;
            _AuthorizationCodesGenerator = authorizationCodesGenerator;
        }
        public async Task<AuthorizationCodeGrantTypeAuthorizationRequestsResponse> HandleAsync(AuthorizationCodeGrantTypeAuthorizationRequest request, CancellationToken cancellationToken)
        {
            long? userId;
            string userToken;
            ClientEntity client;
            string authorizationCode;
            AuthorizationCodeEntity entity;
            IEntitiesRetrieverClientsRepository entitiesRetrieverClientsRepository;
            {
                if (!_HttpContextAccessor.HttpContext.Request.Headers.Any(x => x.Key == "Authorization"))
                {
                    _HttpContextAccessor.HttpContext.Response.Redirect("Login");

                }
                entitiesRetrieverClientsRepository = _UnitOfWork.GetEntitiesRetrieverClientsRepository();
                client = await entitiesRetrieverClientsRepository.GetByClientIdAsync(request.client_id);
                if (client == null)
                    return ClientErrorsCatalog.ClientDidNotFoundResult.CreateNew<AuthorizationCodeGrantTypeAuthorizationRequestsResponse>();
                if (!string.Equals(request.response_type, "code", StringComparison.OrdinalIgnoreCase))
                    return ResponseTypeErrorsCatalog.InvalidResponseTypeResult.CreateNew<AuthorizationCodeGrantTypeAuthorizationRequestsResponse>();
                authorizationCode = _AuthorizationCodesGenerator.Generate();
                userId = _HttpContextAccessor.GetUserID();
                entity = new AuthorizationCodeEntity()
                {
                    ClientID = client.ID,
                    UserID = userId.Value,
                    RegistrationDateTime = DateTime.UtcNow
                };
                _UnitOfWork.GetCommandsHandlerAuthorizationCodesRepository().Save(entity);
                return _Response;
            }
        }
    }
}
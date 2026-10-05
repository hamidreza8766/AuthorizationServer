using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.AccessTokens.Dependents;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.AccessTokens.BaseType
{
    public class AccessTokenEntity : Entity
    {
        public List<AccessTokenScopeEntity> AccessTokenScopes { get; set; }
    }
}
using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.AccessTokens.Dependents;
using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.ClientScopes.BaseType;

namespace AuthorizationServer.Domain.Modules.Scopes.Entities.BaseType
{
    public class ScopeEntity : Entity
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public List<ClientScopeEntity> ClientScopes { get; set; }
        public List<AccessTokenScopeEntity> AccessTokenScopes { get; set; }
    }
}
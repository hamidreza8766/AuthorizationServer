using AuthorizationServer.Domain.Modules.Scopes.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.AccessTokens.BaseType;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.AccessTokens.Dependents
{
    public class AccessTokenScopeEntity : Entity
    {
        public long ScopeID { get; set; }
        public ScopeEntity Scope { get; set; }
        public long AccessTokenID { get; set; }
        public AccessTokenEntity AccessToken { get; set; }
    }
}
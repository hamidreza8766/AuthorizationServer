using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.OauthTokens.DerivedTypes.AccessTokens.Dependents;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.OauthTokens.DerivedTypes.AccessTokens.BaseType
{
    public class AccessTokenEntity : Entity
    {
        public List<AccessTokenScopeEntity> AccessTokenScopes { get; set; }
    }
}
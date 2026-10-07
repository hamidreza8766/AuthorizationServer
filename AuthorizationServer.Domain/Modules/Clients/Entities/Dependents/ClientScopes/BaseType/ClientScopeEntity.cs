using AuthorizationServer.Domain.Modules.Scopes.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.ClientScopes.BaseType
{
    public class ClientScopeEntity : Entity
    {
        public long ScopeID { get; set; }
        public long ClientID { get; set; }
        public ScopeEntity Scope { get; set; }
        public ClientEntity Client { get; set; }
    }
}
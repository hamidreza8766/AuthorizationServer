using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Scopes.Entities.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Entities.Dependents
{
    public class ClientScopeEntity : Entity
    {
        public long ScopeID { get; set; }
        public long ClientID { get; set; }
        public ScopeEntity Scope { get; set; }
        public ClientEntity Client { get; set; }
    }
}
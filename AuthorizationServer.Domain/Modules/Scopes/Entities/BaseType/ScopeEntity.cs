using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Application.Modules.Clients.Entities.Dependents;

namespace AuthorizationServer.Domain.Modules.Scopes.Entities.BaseType
{
    public class ScopeEntity : Entity
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public List<ClientScopeEntity> ClientScopes { get; set; }
    }
}
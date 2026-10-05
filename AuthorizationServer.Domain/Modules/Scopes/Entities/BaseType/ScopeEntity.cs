using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Scopes.Entities.BaseType
{
    public class ScopeEntity : Entity
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
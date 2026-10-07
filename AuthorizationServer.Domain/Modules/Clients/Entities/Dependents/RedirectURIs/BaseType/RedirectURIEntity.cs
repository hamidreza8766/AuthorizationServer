using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.RedirectURIs.BaseType
{
    public class RedirectURIEntity : Entity
    {
        public string URI { get; set; }
        public ClientEntity Client { get; set; }
    }
}
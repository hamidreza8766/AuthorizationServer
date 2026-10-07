using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.ClientUsers.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.ClientScopes.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.RedirectURIs.BaseType;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.BaseType
{
    public class ClientEntity : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string LogoURL { get; set; }
        public string HomePageURL { get; set; }
        public bool IsConfidential { get; set; }
        public List<ClientUserEntity> ClientUsers { get; set; }
        public List<RedirectURIEntity> RedirectURIs { get; set; }
        public List<ClientScopeEntity> ClientScopes { get; set; }
    }
}
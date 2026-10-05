using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.BaseType
{
    public class ClientEntity : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string LogoURL { get; set; }
        public string HomePageURL { get; set; }
        public bool IsConfidential { get; set; }
    }
}
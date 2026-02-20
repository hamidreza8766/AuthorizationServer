using AuthorizationServer.Domain.VerticalSlices.Central.Entities.BaseType;

namespace AuthorizationServer.Domain.VerticalSlices.Clients.Entities.BaseType
{
    public class ClientEntity : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string ClientID { get; set; }
        public string GrantTypes { get; set; }
        public string ClientSecret { get; set; }
        public bool IsConfindential { get; set; }
    }
}
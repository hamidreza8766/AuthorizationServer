using AuthorizationServer.Domain.Modules.Users.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.ClientUsers.BaseType
{
    public class ClientUserEntity : Entity
    {
        public long UserID { get; set; }
        public long ClientID { get; set; }
        public UserEntity User { get; set; }
        public ClientEntity Client { get; set; }
    }
}
using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Users.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Users.Entities.Dependents
{
    public class UserClaimEntity : Entity
    {
        public long UserID { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public UserEntity User { get; set; }
    }
}
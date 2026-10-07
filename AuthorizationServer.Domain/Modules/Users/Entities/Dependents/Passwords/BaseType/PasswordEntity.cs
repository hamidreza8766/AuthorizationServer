using AuthorizationServer.Domain.Modules.Users.Enumerations;
using AuthorizationServer.Domain.Modules.Users.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Users.Entities.Dependents.Passwords.BaseType
{
    public class PasswordEntity : Entity
    {
        public long UserID { get; set; }
        public UserEntity User { get; set; }
        public string HashedValue { get; set; }
        public PasswordEntityStateEnum State { get; set; }
    }
}
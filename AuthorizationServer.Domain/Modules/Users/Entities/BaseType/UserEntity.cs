using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Users.Entities.Dependents;

namespace AuthorizationServer.Domain.Modules.Users.Entities.BaseType
{
    public class UserEntity : Entity
    {
        public bool IsActive { get; set; }
        public string Username { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public List<UserClaimEntity> Claims { get; set; }
        public List<PasswordEntity> Passwords { get; set; }
    }
}
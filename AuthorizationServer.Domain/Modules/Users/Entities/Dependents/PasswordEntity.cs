using AuthorizationServer.Domain.Modules.Users.Enumerations;
using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Users.Entities.Dependents
{
    public class PasswordEntity : Entity
    {
        public string HashedValue { get; set; }
        public PasswordEntityStateEnum State { get; set; }
    }
}
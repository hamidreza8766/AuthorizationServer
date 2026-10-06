using AuthorizationServer.Domain.Modules.Users.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;
using AuthorizationServer.Domain.Modules.Clients.Enumerations;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.OauthTokens.BaseType
{
    public class TokenEntity : Entity
    {
        public long UserID { get; set; }
        public long ClientID { get; set; }
        public UserEntity User { get; set; }
        public string HashedValue { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime? RevokedAt { get; set; }
        public ClientEntity Client { get; set; }
        public OauthTokenTypeEnum TokenType { get; set; }
    }
}
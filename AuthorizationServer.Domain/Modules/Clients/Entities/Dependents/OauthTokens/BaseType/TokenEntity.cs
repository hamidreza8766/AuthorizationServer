using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.OauthTokens.BaseType
{
    public class TokenEntity : Entity
    {
        public DateTime RevokedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
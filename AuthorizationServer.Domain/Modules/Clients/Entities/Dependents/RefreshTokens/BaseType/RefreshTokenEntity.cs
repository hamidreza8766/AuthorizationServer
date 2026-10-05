using AuthorizationServer.Domain.Modules.Central.Entities.BaseType;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.RefreshTokens.BaseType
{
    public class RefreshTokenEntity : Entity
    {
        public long UserID { get; set; }
        public long ClientID { get; set; }
        public string HashedValue { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime? RevokedAt { get; set; }
    }
}
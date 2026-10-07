using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.OauthTokens.BaseType;

namespace AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.OauthTokens.DerivedTypes.RefreshTokens.BaseType
{
    public class RefreshTokenEntity : TokenEntity
    {
        public long? ParentTokenID { get; set; }
        public RefreshTokenEntity Parent { get; set; }
        public List<RefreshTokenEntity> Children { get; set; }
    }
}
namespace AuthorizationServer.Domain.Modules.Users.Enumerations
{
    public enum PasswordEntityStateEnum : byte
    {
        Unknown,
        Registered,
        Actived,
        Expired,
        Deactived
    }
}
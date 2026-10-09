namespace AuthorizationServer.Application.Modules.Clients.Tools.Generators.AuthorizationCodes.Abstraction
{
    public interface IAuthorizationCodesGenerator
    {
        string Generate(long? userId = null, long? clientId = null);
    }
}
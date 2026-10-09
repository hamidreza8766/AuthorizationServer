using AuthorizationServer.Domain.Modules.Clients.Entities.Dependents.AuthorizationCodes.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Repositories.Commands
{
    public interface ICommandsHandlerAuthorizationCodesRepository
    {
        void Save(AuthorizationCodeEntity authorizationCode);
        void Update(AuthorizationCodeEntity authorizationCode);
    }
}
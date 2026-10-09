using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Repositories.Commands
{
    public interface ICommandsHandlerClientsRepository
    {
        void Save(ClientEntity client);
        void Update(ClientEntity client);
    }
}
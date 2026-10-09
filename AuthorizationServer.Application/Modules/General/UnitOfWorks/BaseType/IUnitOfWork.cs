using AuthorizationServer.Application.Modules.Clients.Repositories.Queries;
using AuthorizationServer.Application.Modules.Clients.Repositories.Commands;

namespace AuthorizationServer.Application.Modules.General.UnitOfWorks.BaseType
{
    public interface IUnitOfWork
    {
        ICommandsHandlerClientsRepository GetCommandsHandlerClientsRepository();
        IEntitiesRetrieverClientsRepository GetEntitiesRetrieverClientsRepository();
        ICommandsHandlerAuthorizationCodesRepository GetCommandsHandlerAuthorizationCodesRepository();
    }
}
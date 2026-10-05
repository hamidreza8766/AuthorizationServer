using AuthorizationServer.Application.Modules.Clients.Repositories.Queries;

namespace AuthorizationServer.Application.Modules.General.UnitOfWorks.BaseType
{
    public interface IUnitOfWork
    {
        IEntitiesRetrieverClientsRepository GetEntitiesRetrieverClientsRepository();
    }
}
using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Repositories.Queries
{
    public interface IEntitiesRetrieverClientsRepository
    {
        Task<ClientEntity> GetByIdAsync(long id);
        Task<ClientEntity> GetByClientIdAsync(string clientId);
    }
}
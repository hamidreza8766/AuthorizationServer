namespace AuthorizationServer.Application.Modules.Clients.Repositories.Queries
{
    public interface IExistenceCheckerClientsRepository
    {
        Task<bool> ClientExists(string clientId);
    }
}
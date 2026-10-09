using AuthorizationServer.Application.Modules.General.Requests.BaseType;
using AuthorizationServer.Application.Modules.General.Responses.BaseType;

namespace AuthorizationServer.Application.Modules.General.RequestHandlers
{
    public interface IRequestHandler<Requst, Response> where Requst : IRequest<Response> where Response : BaseResult
    {
        Task<Response> HandleAsync(Requst request, CancellationToken cancellationToken);
    }
}
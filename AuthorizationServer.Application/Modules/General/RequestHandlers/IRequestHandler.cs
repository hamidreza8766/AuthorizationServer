using AuthorizationServer.Application.Modules.General.Requests.BaseType;
using AuthorizationServer.Application.Modules.General.Responses.BaseType;

namespace AuthorizationServer.Application.Modules.General.RequestHandlers
{
    public interface IRequestHandler<Requst, Response> where Requst : IRequest<BaseResult> where Response : BaseResult { }
}
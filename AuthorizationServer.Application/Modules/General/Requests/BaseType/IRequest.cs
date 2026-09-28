using AuthorizationServer.Application.Modules.General.Responses.BaseType;

namespace AuthorizationServer.Application.Modules.General.Requests.BaseType
{
    public interface IRequest<T> where T : BaseResult { }
}
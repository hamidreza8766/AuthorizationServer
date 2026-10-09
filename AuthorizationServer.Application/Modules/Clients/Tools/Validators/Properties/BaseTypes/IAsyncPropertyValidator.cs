using AuthorizationServer.Application.Modules.General.Responses.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Tools.Validators.Properties.BaseTypes
{
    public interface IAsyncPropertyValidator<T>
    {
        Task ValidateAsync(T value, BaseResult operationResult, CancellationToken cancellation);
    }
}
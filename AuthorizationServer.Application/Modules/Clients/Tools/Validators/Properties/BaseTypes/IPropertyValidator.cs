using AuthorizationServer.Application.Modules.General.Responses.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Tools.Validators.Properties.BaseTypes
{
    public interface IPropertyValidator
    {
        Task Validate<T>(T value, BaseResult operationResult, CancellationToken cancellation) where T : struct;
    }
}
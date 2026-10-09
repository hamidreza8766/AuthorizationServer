using AuthorizationServer.Domain.Modules.Clients.Entities.BaseType;
using AuthorizationServer.Application.Modules.General.TypeExtensions;
using AuthorizationServer.Application.Modules.General.UnitOfWorks.BaseType;
using AuthorizationServer.Application.Modules.Clients.Tools.Validators.Properties.BaseTypes;
using AuthorizationServer.Application.Modules.General.Responses.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Tools.Validators.Properties.DerivedTypes
{
    public class ClirentIDsValidator : IAsyncPropertyValidator<string>
    {
        private readonly IUnitOfWork _UnitOfWork;
        public ClirentIDsValidator(
            IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException(nameof(unitOfWork));
            _UnitOfWork = unitOfWork;
        }
        public async Task ValidateAsync(string value, BaseResult operationResult, CancellationToken cancellation)
        {
            bool flag;
            ClientEntity client;
            {
                flag = value.HasValidValue();

                flag = await _UnitOfWork.GetExistenceCheckerClientsRepository().ClientExists(value);
            }
        }
    }
}
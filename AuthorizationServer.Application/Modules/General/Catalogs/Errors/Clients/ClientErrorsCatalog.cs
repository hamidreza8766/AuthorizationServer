using AuthorizationServer.Application.Modules.General.Responses.BaseType;

namespace AuthorizationServer.Application.Modules.General.Catalogs.Errors.Clients
{
    public static class ClientErrorsCatalog
    {
        public static class ClientDidNotFoundResult
        {
            public static T CreateNew<T>() where T : BaseResult, new()
            {
                T result = new T();
                result.Initialize("Client یافت نشد", "10", false);
                return result;
            }
        }
    }
}
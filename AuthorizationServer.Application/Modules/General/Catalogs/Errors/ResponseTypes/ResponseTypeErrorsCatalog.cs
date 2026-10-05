using AuthorizationServer.Application.Modules.General.Responses.BaseType;

namespace AuthorizationServer.Application.Modules.General.Catalogs.Errors.ResponseTypes
{
    public class ResponseTypeErrorsCatalog
    {
        public static class InvalidResponseTypeResult
        {
            public static T CreateNew<T>() where T : BaseResult, new()
            {
                T result = new T();
                result.Initialize("responseType نا معتبر است", "30", false);
                return result;
            }
        }
    }
}
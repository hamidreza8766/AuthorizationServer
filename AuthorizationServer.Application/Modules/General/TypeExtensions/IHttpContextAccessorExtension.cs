using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace AuthorizationServer.Application.Modules.General.TypeExtensions
{
    public static class IHttpContextAccessorExtension
    {
        public static long? GetUserID(this IHttpContextAccessor httpContextAccessor)
        {
            long result;
            string claimValue;
            {
                claimValue = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(claimValue) || string.IsNullOrWhiteSpace(claimValue))
                    return null;
                if (!long.TryParse(claimValue, out result))
                    return null;
                return result;
            }
        }
    }
}
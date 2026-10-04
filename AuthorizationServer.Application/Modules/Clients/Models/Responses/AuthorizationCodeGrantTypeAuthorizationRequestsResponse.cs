using AuthorizationServer.Application.Modules.General.Responses.BaseType;

namespace AuthorizationServer.Application.Modules.Clients.Models.Responses
{
    public class AuthorizationCodeGrantTypeAuthorizationRequestsResponse : BaseResult
    {
        public string code { get; set; }
        public string state { get; set; }
    }
}
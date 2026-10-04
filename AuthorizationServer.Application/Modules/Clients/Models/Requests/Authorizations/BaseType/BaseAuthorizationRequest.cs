namespace AuthorizationServer.Application.Modules.Clients.Models.Requests.Authorizations.BaseType
{
    public class BaseAuthorizationRequest
    {
        public string scope { get; set; }
        public string state { get; set; }
        public string client_id { get; set; }
        public string redirect_uri { get; set; }
        public string response_type { get; set; }
    }
}
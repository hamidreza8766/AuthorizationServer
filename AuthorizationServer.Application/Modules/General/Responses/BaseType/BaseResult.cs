namespace AuthorizationServer.Application.Modules.General.Responses.BaseType
{
    public class BaseResult
    {
        protected BaseResult() { }
        public string Description { get; private set; }
        public string ResponseCode { get; private set; }
        public bool OperationSucceeded { get; private set; }
        internal void Initialize(string description, string responseCode, bool operationSucceeded)
        {
            this.Description = description;
            this.ResponseCode = responseCode;
            this.OperationSucceeded = operationSucceeded;
        }
    }
}
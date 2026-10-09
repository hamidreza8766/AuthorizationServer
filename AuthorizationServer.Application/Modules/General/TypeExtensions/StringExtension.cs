namespace AuthorizationServer.Application.Modules.General.TypeExtensions
{
    public static class StringExtension
    {
        public static bool HasValidValue(this string value)
        {
            return !string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value);
        }
    }
}
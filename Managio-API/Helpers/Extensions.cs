using Microsoft.AspNetCore.Http;

namespace Managio_API.Helpers
{
    public static class Extensions
    {
        public static void AddAppError(this HttpResponse response, string msg)
        {
            response.Headers.Add("Application-Error", msg);
            response.Headers.Add("Access-Control-Expose-Headers", "ApplicationError");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}
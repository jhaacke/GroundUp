using GroundUp.Infastructure.Middleware;
using Microsoft.AspNet.Builder;

namespace GroundUp.Infastructure
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMyRequestLogger(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyRequestLoggerMiddleware>();
        }
    }
}

using CQRS.Template.Api.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace CQRS.Template.Api.Extensions
{
    public static class ErrorHandlingMiddlewareExtension
    {
        public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}

using CQRS.Template.Application.Exceptions;
using CQRS.Template.Application.ResponseModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace CQRS.Template.Api.Middlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            response.StatusCode = exception switch
            {
                Application.Exceptions.ApplicationException _ => (int)HttpStatusCode.BadRequest,
                ItemNotFoundException _ => (int)HttpStatusCode.NotFound,
                ValidationException _ => (int)HttpStatusCode.BadRequest,
                _ => (int)HttpStatusCode.InternalServerError
            };

            return response.WriteAsync(JsonSerializer.Serialize(new ErrorResponseModel(exception)));
        }
    }
}

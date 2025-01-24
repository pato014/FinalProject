using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FinalProject.Middlewares
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestResponseLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Request ლოგირება
            Debug.WriteLine($"[Request] HTTP {context.Request.Method} {context.Request.Path}");

            await _next(context); 

            // Response ლოგირება
            Debug.WriteLine($"[Response] HTTP {context.Response.StatusCode}");
        }
    }
}

using System.Diagnostics;

namespace G_ASP_NET_83_MVC01.Middleware
{
    public class RequestTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stop = Stopwatch.StartNew();
            await _next.Invoke(context);
            stop.Stop();

            Console.WriteLine($"{context.Request.Path} --> {stop.ElapsedMilliseconds} ms");
        }
    }
}

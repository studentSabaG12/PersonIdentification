namespace PersonIdentification.MiddleWare
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            if (!context.User.Identity.IsAuthenticated)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Not Authorized");
                return;
            }
            await _next(context);
        }

    }
}




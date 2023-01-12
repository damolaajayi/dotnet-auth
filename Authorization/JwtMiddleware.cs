using Dotnet_Auth.Helpers;
using Microsoft.Extensions.Options;

namespace Dotnet_Auth.Authorization
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;
        public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            _next = next;
            _appSettings = appSettings.Value;
        }


        public async Task Invoke(HttpContext context, DataContext dataContext, IJwtUtils jwtUtils)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var accountId = jwtUtils.ValidateJwtToken(token);
            if(accountId != null)
            {
                context.Items["Account"] = await dataContext.Accounts.FindAsync(accountId.Value);

            }

            await _next(context);
        }

    }
}

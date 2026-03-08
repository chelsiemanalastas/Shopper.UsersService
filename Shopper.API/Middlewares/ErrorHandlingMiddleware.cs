using Shopper.Application.Exceptions;

namespace Shopper.API.Middlewares;

public class ErrorHandlingMiddleware(ILogger<ErrorHandlingMiddleware> logger) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next.Invoke(context);
        }
        catch (NotFoundException ex)
        {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsync(ex.Message);

            logger.LogWarning(ex.Message);
        }
        catch (ForbidException ex)
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsync("You are not authorized to perform this action.");

            logger.LogWarning(ex.Message);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);

            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("Something went wrong. Please check the error message.");
        }
    }
}

using System.Net;
using Scan_Product_TTTQ.Application.Common.Exception;
using FSH.Starter.Infrastructure.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Scan_Product_TTTQ.Infrastructure.Middleware;

public class ExceptionMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandleException(context, ex);
        }
    }

    public static Task HandleException(HttpContext context, Exception exception)
    {
        var errorResult = new ErrorResult
        {
            Source = exception.TargetSite?.DeclaringType?.FullName, Exception = exception.Message.Trim(),
        };

        if (exception is FluentValidation.ValidationException fluentException)
        {
            errorResult.Exception = "One or More Validations failed.";
            foreach (var error in fluentException.Errors)
            {
                errorResult.Messages.Add(error.ErrorMessage);
            }
        }

        if (exception is not CustomException && exception.InnerException != null)
        {
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
            }
        }

        switch (exception)
        {
            case CustomException e:
                errorResult.StatusCode = (int)e.StatusCode;
                if (e.ErrorMessages is not null)
                {
                    errorResult.Messages = e.ErrorMessages;
                }
                break;
            case KeyNotFoundException:
                errorResult.StatusCode = (int)HttpStatusCode.NotFound;
                break;

            case FluentValidation.ValidationException:
                errorResult.StatusCode = (int)HttpStatusCode.BadRequest;
                break;

            default:
                errorResult.StatusCode = (int)HttpStatusCode.InternalServerError;
                break;
        }


        context.Response.ContentType = "application/json";
        context.Response.StatusCode = errorResult.StatusCode;
        return context.Response.WriteAsync(JsonConvert.SerializeObject(errorResult));
    }
}

public static class ExceptionMiddlewareExtensions
{
    public static void UseExceptionMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
    }
}
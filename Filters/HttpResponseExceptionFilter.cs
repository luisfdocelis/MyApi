
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyApi.Exceptions;

namespace MyApi.Filters
{
    public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order => int.MaxValue - 10;

        public void OnActionExecuting(ActionExecutingContext context) { 
            HttpRequest request = context.HttpContext.Request;
            HttpResponse response = context.HttpContext.Response;
            HttpContext httpContext = context.HttpContext;
            
            /* if ( !request.IsHttps)
            {
                
                string redirectUrl =UriHelper.GetEncodedUrl(request).Replace("http:", "https:");
                response.Redirect(redirectUrl, false);
                httpContext.Response.CompleteAsync();
            }*/ 
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is HttpResponseException httpResponseException)
            {
                context.Result = new ObjectResult(httpResponseException.Value)
                {
                    StatusCode = httpResponseException.StatusCode
                };
                context.ExceptionHandled = true;
            }
        }
    }
}
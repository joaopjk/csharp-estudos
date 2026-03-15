using System.Globalization;

namespace MyRecipeBook.Api.Middleware;

public class CultureMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        // var requestedCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();
        //
        // if (requestedCulture != null)
        // {
        //     var culture = new CultureInfo(requestedCulture);
        //
        //     CultureInfo.CurrentCulture = culture;
        //     CultureInfo.CurrentUICulture = culture;
        // }
        
        await next(context);
    }
}
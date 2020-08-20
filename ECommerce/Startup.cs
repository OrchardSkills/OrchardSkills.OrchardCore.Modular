using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace ECommerce
{
    public class Startup
    {
        public void Configure(IEndpointRouteBuilder endpoint)
        {
            endpoint.MapGet("/ecommerce", async context =>
            {
                await context.Response.WriteAsync("ecommerce!");
            });
        }
    }
}

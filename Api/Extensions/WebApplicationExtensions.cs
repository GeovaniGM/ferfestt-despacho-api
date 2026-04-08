using Microsoft.AspNetCore.Builder;

namespace Despacho.API.Api.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication ConfigureApi(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        return app;
    }
}

using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System.Text.Json.Serialization;

namespace PublicTransportAPI.Bootstrapper
{
    public static class NativeBootstrapper
    { 
        internal static void ConfigureService(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<PublicTransportAPIContext>(options =>
            //options.UseInMemoryDatabase("db"));
            options.UseSqlServer(builder.Configuration.GetConnectionString("PublicTransportAPIContext") ?? throw new InvalidOperationException("Connection string 'PublicTransportAPIContext' not found.")));


            // Add builder.Services to the container.
            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            builder.Services.AddControllers()
                .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }
    }
}

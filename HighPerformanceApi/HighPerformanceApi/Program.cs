using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using HealthChecks.UI.Client;


namespace HighPerformanceApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Health Checks Registration
            builder.Services.AddHealthChecks()
                .AddSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection"),
                    name: "SqlServer",
                    tags: new[] { "db", "sql" })
                .AddRedis(
                    builder.Configuration.GetConnectionString("Redis"),
                    name: "redis",
                    tags: new[] { "cache", "redis" });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            //map the healthchecks endpoint with a custom response writer for better UI integration
            app.MapHealthChecks("/health", new HealthCheckOptions
            {
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            app.MapControllers();

            app.Run();
        }
    }
}

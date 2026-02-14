using Microsoft.EntityFrameworkCore;
using WebGame.Server.Data;
using Scalar.AspNetCore;

namespace WebGame.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });
            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
            builder.Services.AddDbContext<GameDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
            );
            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<GameDbContext>();
                dbContext.Database.ExecuteSqlRaw("PRAGMA journal_mode=WAL;");
                dbContext.Database.Migrate();
            }
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseCors("AllowFrontend");
            app.UseAuthorization();
            app.MapControllers();
            app.MapFallbackToFile("/index.html");
            app.Run();
        }
    }
}
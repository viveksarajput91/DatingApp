using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using API.Interfaces;
using API.Services;
using API.Data;
using Microsoft.EntityFrameworkCore;
namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration _config)
        {
            services.AddScoped<ITokenService,TokenService>();
            services.AddDbContext<DataContext>((option) =>
            {
                option.UseSqlite(_config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }        
    }
}
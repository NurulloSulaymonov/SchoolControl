using Application.Services.Students;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace Application.ExtenstionMethods
{
    public static class ServiceExtensions
    {
        public static void RegisterSevices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(config =>
            {
                config.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
      .AddEntityFrameworkStores<DataContext>()
      .AddDefaultTokenProviders();

            services.AddScoped<IStudentService, StudentService>();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SixDegrees.Application.Interfaces.Repositories;
using SixDegrees.Persistence.Repositories;

namespace SixDegrees.Persistence
{
    public static class RegisterLayerExtensions
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration) 
        {

            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")
                )
            );

            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}

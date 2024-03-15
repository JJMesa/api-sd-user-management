using Microsoft.Extensions.DependencyInjection;
using SixDegrees.Application.Services;

namespace SixDegrees.Application
{
    public static class RegisterLayerExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
        }
    }
}

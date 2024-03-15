using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace SixDegress.Api.Extensions
{
    public static class ServiceExtension
    {
        public static void AddCorsPolicy(this IServiceCollection service)
        {
            service.AddCors(options =>
            {
                options.AddPolicy("Security",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }

        public static void AddSwagger(this IServiceCollection service)
        {
            service.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "SixDegrees.Api",
                    Version = "v1",
                    Description = "API para la gestión de personas.",
                    Contact = new OpenApiContact
                    {
                        Name = "Juan Mesa",
                        Url = new Uri("https://www.linkedin.com/in/juanjmesam/")
                    }
                });
            });
        }
    }
}

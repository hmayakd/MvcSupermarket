using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSupermarket.Services
{
    public static class ServiceInjections
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProducService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using PizzariaSul.Application.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSul.Application.Helper
{
    public static class Depencencia
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<UsuarioUseCase>();
            return services;
        }
    }
}

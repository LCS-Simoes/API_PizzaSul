using Microsoft.Extensions.DependencyInjection;
using PizzariaSul.Application.Integracao.Interfaces;
using PizzariaSul.Application.Integracao.Refit;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSul.Application.Integracao
{
    public static class Dependencias
    {
        public static IServiceCollection AddApplicationCep(this IServiceCollection services)
        {
            services.AddRefitClient<IViaCepIntegracaoRefit>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri("https://viacep.com.br/");
                });

            services.AddScoped<IViaCepIntegracao,ViaCepIntegracao>();
            return services;
        }
    }
}

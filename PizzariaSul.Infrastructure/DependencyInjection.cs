using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzariaSul.Domain.Interfaces;
using PizzariaSul.Infrastructure.Data;
using PizzariaSul.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSul.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<PizzariaSulDbContext>(options =>
                options.UseSqlite(connectionString));

            services.AddScoped<IUsuarios, UsuarioRepository>();
            services.AddScoped<IPedidos, PedidosRepository>();

            return services;
        }
    }
}

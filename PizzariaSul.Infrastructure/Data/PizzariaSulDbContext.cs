using Microsoft.EntityFrameworkCore;
using PizzariaSul.Domain.Entidades;
using PizzariaSul.Infrastructure.Data.Map;

namespace PizzariaSul.Infrastructure.Data
{
    public class PizzariaSulDbContext : DbContext
    {
        public PizzariaSulDbContext(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

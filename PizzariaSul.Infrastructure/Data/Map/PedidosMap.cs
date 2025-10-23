using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaSul.Domain.Entidades;


namespace PizzariaSul.Infrastructure.Data.Map
{
    public class PedidosMap : IEntityTypeConfiguration<Pedidos>
    {
        public void Configure(EntityTypeBuilder<Pedidos> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Sabor);
            builder.Property(x => x.Status);
            builder.Property(x => x.Preco);
            builder.Property(x => x.UsuarioID);
            builder.HasOne(x => x.Usuario);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaSul.Domain.Entidades;


namespace PizzariaSul.Infrastructure.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Celular);
            builder.Property(x => x.Bairro);
            builder.Property(x => x.Rua);
            builder.Property(x => x.NumeroCasa);
            builder.Property(x => x.Cidade);
            builder.Property(x => x.Cep);
        }
    }
}

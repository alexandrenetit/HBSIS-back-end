using HBSIS.Data.Extensions;
using HBSIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HBSIS.Data.Mappings
{
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public override void Map(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
            
            builder.Property(c => c.CpfCnpj)
                .IsRequired()
                .HasMaxLength(14);

            builder.HasAlternateKey(c => c.CpfCnpj);

            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasMaxLength(14);

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Clientes");
        }
    }
}
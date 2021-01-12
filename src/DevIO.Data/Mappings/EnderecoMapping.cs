using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Logradouro)
                .IsRequired()
                .HasColumnType("VARCHAR(200)");

            builder.Property(c => c.Numero)
                .IsRequired()
                .HasColumnType("VARCHAR(50)");

            builder.Property(c => c.Cep)
                .IsRequired()
                .HasColumnType("VARCHAR(8)");

            builder.Property(c => c.Complemento)
                .HasColumnType("VARCHAR(250)");

            builder.Property(c => c.Bairro)
                .IsRequired()
                .HasColumnType("VARCHAR(100)");

            builder.Property(c => c.Cidade)
                .IsRequired()
                .HasColumnType("VARCHAR(100)");

            builder.Property(c => c.Estado)
                .IsRequired()
                .HasColumnType("VARCHAR(50)");

            builder.ToTable("Enderecos");
        }
    }
}
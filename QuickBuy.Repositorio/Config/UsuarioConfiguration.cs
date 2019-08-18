using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}

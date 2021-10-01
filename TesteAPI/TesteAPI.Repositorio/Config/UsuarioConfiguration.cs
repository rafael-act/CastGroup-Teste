using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Dominio.Entidades;

namespace TesteAPI.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(u => u.Senha).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(u => u.Role).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        }
    }
}

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
    /// <summary>
    /// Classe para replicação dos dados da aplicação no banco de dados
    /// </summary>
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(u => u.Codigo);
            builder.Property(u => u.Descricao).HasColumnType("varchar").HasMaxLength(100);
            builder.HasMany(u => u.Cursos).WithOne(u=>u.Categoria);
        }
    }
}

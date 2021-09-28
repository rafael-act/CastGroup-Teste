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
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(u => u.CodigoCurso);
            builder.Property(u => u.DescricaoAssunto).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(u => u.DataInicio).HasColumnType("date").IsRequired();
            builder.Property(u => u.DataTernmino).HasColumnType("date").IsRequired();
            builder.Property(u => u.QuantidadeTurma).HasColumnType("int");
            builder.Property(u => u.CodigoCategoria).HasColumnType("int").IsRequired();
            builder.HasOne(u => u.Categoria);
        }
    }
}

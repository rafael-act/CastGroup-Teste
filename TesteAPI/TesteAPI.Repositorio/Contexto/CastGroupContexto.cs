using Microsoft.EntityFrameworkCore;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Repositorio.Config;

/// <summary>
/// Contexto para mapeamento das classes nas tabelas do banco
/// </summary>
namespace TesteAPI.Repositorio.Contexto
{
    public class CastGroupContexto:DbContext
    {
        public CastGroupContexto(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Utilizado para construir modelo para o contexto
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //referencias para classes de mapeamento

            modelBuilder.ApplyConfiguration(new CursoConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}

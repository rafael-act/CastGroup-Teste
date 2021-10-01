using Microsoft.EntityFrameworkCore;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Repositorio.Config;

/// <summary>
/// Contexto para mapeamento das classes nas tabelas do banco
/// </summary>
namespace TesteAPI.Repositorio.Contexto
{
    public class CastGroupContexto : DbContext
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
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            modelBuilder.Entity<Categoria>()
                .HasData(
                new Categoria
                {
                    Codigo = 1,
                    Descricao = "Comportamental"
                },
                new Categoria
                {
                    Codigo = 2,
                    Descricao = "Programação"
                },
                new Categoria
                {
                    Codigo = 3,
                    Descricao = "Qualidade e Processos"
                });

            modelBuilder.Entity<Usuario>()
                .HasData(new Usuario
                {
                    Id = 1,
                    Nome = "cast",
                    Senha = "abc123",
                    Role = "Admin"
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}

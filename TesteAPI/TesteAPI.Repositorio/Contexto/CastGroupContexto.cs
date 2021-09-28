using Microsoft.EntityFrameworkCore;
using TesteAPI.Dominio.Entidades;

/// <summary>
/// Contexto para mapeamento das classes nas tabelas do banco
/// </summary>
namespace TesteAPI.Repositorio.Contexto
{
    public class CastGroupContexto:DbContext
    {
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}

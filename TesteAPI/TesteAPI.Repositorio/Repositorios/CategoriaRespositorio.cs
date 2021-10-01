using System;
using System.Linq;
using TesteAPI.Dominio.Contratos;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Repositorio.Contexto;

namespace TesteAPI.Repositorio.Repositorios
{
    public class CategoriaRespositorio : BaseRepositorio<Categoria>, ICategoriaRepositorio
    {
        public CategoriaRespositorio(CastGroupContexto castGroupContexto) : base(castGroupContexto)
        { }
        public override bool Remover(Categoria entity)
        {
            var cursos = _castGroupContexto.Cursos
                .Where(cur => cur.CodigoCategoria == entity.Codigo).Count();
            if (cursos > 0) return false;
            base.Remover(entity);
            return true;
        }
    }
}

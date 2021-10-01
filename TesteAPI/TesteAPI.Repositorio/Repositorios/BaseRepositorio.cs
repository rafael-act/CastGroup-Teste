
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Dominio.Contratos;
using TesteAPI.Repositorio.Contexto;

namespace TesteAPI.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly CastGroupContexto _castGroupContexto;

        public BaseRepositorio(CastGroupContexto castGroupContexto)
        {
            _castGroupContexto = castGroupContexto;
        }
        
        public void Adicionar(TEntity entity)
        {
            _castGroupContexto.Set<TEntity>().Add(entity);
            _castGroupContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            _castGroupContexto.Set<TEntity>().Update(entity);
            _castGroupContexto.SaveChanges();
        }

        public void Dispose()
        {
            _castGroupContexto.Dispose();
        }

        public TEntity ObterPorCodigo(int codigo)
        {
            return _castGroupContexto.Set<TEntity>().Find(codigo);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _castGroupContexto.Set<TEntity>();
        }

        public virtual bool Remover(TEntity entity)
        {
            _castGroupContexto.Set<TEntity>().Remove(entity);
            _castGroupContexto.SaveChanges();
            return true;
        }
    }
}

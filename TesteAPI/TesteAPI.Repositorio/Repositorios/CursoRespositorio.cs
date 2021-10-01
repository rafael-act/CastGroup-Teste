using System;
using System.Linq;
using TesteAPI.Dominio.Contratos;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Repositorio.Contexto;

namespace TesteAPI.Repositorio.Repositorios
{
    public class CursoRespositorio : BaseRepositorio<Curso>, ICursoRepositorio
    {
        public CursoRespositorio(CastGroupContexto castGroupContexto) : base(castGroupContexto)
        {
        }

        /// <summary>
        /// Não será permitida a inclusão de cursos dentro do mesmo período. O sistema
        /// deve identificar tal situação e retornar um código de erro e a mensagem:
        ///“Existe(m) curso(s) planejados(s) dentro do período informado.”
        /// </summary>
        /// <param name="dataInicio">data inicial do curso</param>
        /// <param name="dataFim">data final do curso</param>
        /// <returns>bool</returns>
        public bool ValidarPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            var result = _castGroupContexto.Cursos
                      .Where(c => dataInicio >= c.DataInicio && dataInicio <= c.DataTernmino
                      || dataFim >= c.DataInicio && dataFim <= c.DataTernmino).Count() > 0
                      ? true
                      : false;
            return result;
        }
    }
}

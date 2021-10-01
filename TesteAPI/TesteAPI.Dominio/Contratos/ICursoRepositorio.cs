using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Dominio.Entidades;

namespace TesteAPI.Dominio.Contratos
{
    public interface ICursoRepositorio:IBaseRepositorio<Curso>
    {
        bool ValidarPeriodo(DateTime dataInicio, DateTime dataFim);
    }
}

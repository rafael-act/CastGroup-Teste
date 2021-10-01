using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Dominio.Contratos;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Repositorio.Contexto;

namespace TesteAPI.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>,IUsuarioRepositorio
    {
        public UsuarioRepositorio(CastGroupContexto castGroupContexto) : base(castGroupContexto)
    {
    }

    public Usuario Login(string Nome, string Senha)
    {
        var result = _castGroupContexto.Usuario
            .Where(x => x.Nome.ToLower() == Nome.ToLower()
            && x.Senha == x.Senha).FirstOrDefault();

        return result;
    }


}
}

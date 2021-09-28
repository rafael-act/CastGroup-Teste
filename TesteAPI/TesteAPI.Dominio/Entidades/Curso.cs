using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAPI.Dominio.Entidades
{
    public class Curso:Entidades
    {
        public int CodigoCurso { get; set; }
        public string DescricaoAssunto { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTernmino { get; set; }
        public int QuantidadeTurma { get; set; }
        public int CodigoCategoria { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(DescricaoAssunto))
            {
                AdicionarCritica("Descrição do assunto não foi informado!");
            }

            if (CodigoCategoria<1)
            {
                AdicionarCritica("Código da categoria informado é inválido!");
            }

        }
    }
}

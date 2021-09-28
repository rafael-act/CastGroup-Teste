using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAPI.Dominio.Entidades
{
    public abstract class Entidades
    {
        private List<string> _mensagemValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get
            {
                return _mensagemValidacao ?? (_mensagemValidacao = new List<string>());
            }
        }

        public abstract void Validate();

        public bool Valido
        {
            get
            {
                return !mensagemValidacao.Any();///se nao tiver mensagem é valido
            }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public string ObterMensagensValidacao()
        {
            return string.Join(". ", mensagemValidacao);//junta as mensagens de validação em uma unica string
        }
    }
}

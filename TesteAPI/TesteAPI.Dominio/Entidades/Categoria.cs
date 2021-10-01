using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TesteAPI.Dominio.Entidades
{
    /// <summary>
    /// Classe de Categorias de cursos
    /// </summary>
    public class Categoria:Entidades
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        [IgnoreDataMember]
        public virtual Curso Cursos { get; set; }

        public override void Validar()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Descrição da Categoria não foi informada!");
            }
        }
    }
}

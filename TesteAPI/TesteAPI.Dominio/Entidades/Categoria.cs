﻿using System;
using System.Collections.Generic;

namespace TesteAPI.Dominio.Entidades
{
    /// <summary>
    /// Classe de Categorias de cursos
    /// </summary>
    public class Categoria:Entidades
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Descrição da Categoria não foi informada!");
            }
        }
    }
}

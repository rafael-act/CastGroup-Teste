﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAPI.Dominio.Entidades
{
    public class Curso : Entidades
    {
        public int CodigoCurso { get; set; }
        public string DescricaoAssunto { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTernmino { get; set; }
        public int QuantidadeTurma { get; set; }
        public int CodigoCategoria { get; set; }
        public Categoria Categoria { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(DescricaoAssunto))
            {
                AdicionarCritica("Descrição do assunto não foi informado!");
            }

            if (CodigoCategoria < 1)
            {
                AdicionarCritica("Código da categoria informado é inválido!");
            }
            if (DataInicio <= DateTime.Now)
            {
                AdicionarCritica("Não será permitida a inclusão de cursos com a data de início menor que a data atual!");
            }
        }
    }
}

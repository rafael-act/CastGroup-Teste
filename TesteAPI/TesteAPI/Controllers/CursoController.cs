using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Dominio.Contratos;
using TesteAPI.Dominio.Entidades;
using TesteAPI.Repositorio.Repositorios;

namespace TesteAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CursoController : ControllerBase
    {
        private readonly ICursoRepositorio _cursoRespositorio;

        public CursoController(ICursoRepositorio cursoRepositorio)
        {
            _cursoRespositorio = cursoRepositorio;
        }

        /// <summary>
        /// Consulta lista de cursos
        /// </summary>
        /// <returns>{curso:[]}</curso></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_cursoRespositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        /// <summary>
        /// Consulta o curso pelo código
        /// // GET: CursoController/GetPorCodigo/5
        /// </summary>
        /// <param name="codigo">Código do curso</param>
        /// <returns>{curso}</returns>
        [HttpGet("GetPorCodigo")]
        public IActionResult GetPorCodigo(int codigo)
        {
            try
            {
                return Ok(_cursoRespositorio.ObterPorCodigo(codigo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        /// <summary>
        /// Cria ou altera um novo curso dentro da plataforma
        /// // POST: CursoController
        /// </summary>
        /// <param name="curso">Objeto do tipo curso</param>
        /// <returns>{curso}</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Curso curso)
        {
            try
            {
                curso.Validar();
                if (!curso.Valido)
                {
                    return BadRequest(curso.ObterMensagensValidacao());
                }

                if (curso.CodigoCurso > 0)
                {
                    _cursoRespositorio.Atualizar(curso);
                }
                else
                {
                    if (_cursoRespositorio.ValidarPeriodo(curso.DataInicio, curso.DataTernmino))
                    {
                        return BadRequest("Existe(m) curso(s) planejados(s) dentro do período informado.");
                    }
                    _cursoRespositorio.Adicionar(curso);
                }
                return Created("api/curso", curso);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui um curso da plataforma
        /// // POST: CursoController/Excluir/5
        /// </summary>
        /// <param name="codigo">codigo do curso</param>
        /// <returns>string</returns>
        [HttpDelete("Excluir")]
        public IActionResult Excluir(int codigo)
        {
            try
            {
                var curso = _cursoRespositorio.ObterPorCodigo(codigo);
                if (curso != null)
                {
                    _cursoRespositorio.Remover(curso);
                    return Ok("Curso excluído com sucesso!");
                }
                return BadRequest("Nenhum curso com este código foi encontrado!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

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
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaController(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        /// <summary>
        /// Consulta lista de categorias
        /// </summary>
        /// <returns>{categorias:[]}</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_categoriaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Consulta categoria pelo codigo
        /// </summary>
        /// <param name="codigo">codigo da categoria</param>
        /// <returns>{categoria}</returns>
        [HttpGet("GetPorCodigo")]
        public IActionResult GetPorCodigo(int codigo)
        {
            try
            {
                return Ok(_categoriaRepositorio.ObterPorCodigo(codigo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Categoria categoria)
        {
            try
            {
                categoria.Validar();
                if (!categoria.Valido)
                {
                    return BadRequest(categoria.ObterMensagensValidacao());
                }

                if (categoria.Codigo > 0)
                {
                    _categoriaRepositorio.Atualizar(categoria);
                }
                else
                {
                    _categoriaRepositorio.Adicionar(categoria);
                }
                return Created("api/categoria", categoria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui uma categooria da plataforma
        /// </summary>
        /// <param name="codigo">codigo da categoria</param>
        /// <returns>string</returns>
        [HttpDelete("Excluir")]
        public IActionResult Excluir(int codigo)
        {
            try
            {
                var categoria = _categoriaRepositorio.ObterPorCodigo(codigo);
                if (categoria != null)
                {
                    if (_categoriaRepositorio.Remover(categoria))
                    {
                        return Ok("Categoria excluida com sucesso!");
                    }
                    else
                    {
                        return BadRequest("Não foi possível remover a categoria!");
                    }
                }
                return BadRequest("Nenhuma categoria com este código foi encontrada!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

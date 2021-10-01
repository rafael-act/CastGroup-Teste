using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Dominio.Entidades;

namespace TesteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursoController : ControllerBase
    {
        // GET: CursoController/Consultar/5
        [HttpGet]
        public IActionResult Get(int codigo)
        {
            return Ok();
        }

        // POST: CursoController/Criar
        [HttpPost]
        public IActionResult Post([FromBody] Curso curso)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        // POST: CursoController/Excluir/5
        [HttpPost("Excluir")]
        public IActionResult Excluir(int codigo)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}

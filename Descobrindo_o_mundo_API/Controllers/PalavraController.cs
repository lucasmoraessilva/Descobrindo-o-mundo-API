using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Descobrindo_o_mundo_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Descobrindo_o_mundo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalavraController : ControllerBase
    {
        // GET: api/[controller]/nivel
        [HttpGet("{nivel}")]
        public ActionResult<Palavra> Get(int nivel)
        {
            try
            {
                Palavra palavra = new Palavra();
                return Ok(palavra.buscar(nivel));
            }
            catch(Exception e)
            {
                return StatusCode(
                        500,
                        new ErrorResponse("Não foi possível responder a requisição.")
                    );
            }
        }
    }
}

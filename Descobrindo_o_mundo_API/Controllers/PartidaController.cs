using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Descobrindo_o_mundo_API;
using Descobrindo_o_mundo_API.Models;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Descobrindo_o_mundo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidaController : ControllerBase
    {
        //api/[controller]/{nickname}
        [HttpGet("{nickname}")]
        public ActionResult<List<TblPartida>> Pesquisar(string nickname)
        {
            try
            {
                Partida partida = new Partida();
                return Ok(partida.Pesquisar(nickname));
            }
            catch (Exception e)
            {
                return StatusCode(
                        500,
                        new ErrorResponse("Não foi possível responder a requisição.")
                    );
            }
        }

        //api/[controller]
        [HttpPost]
        public ActionResult Cadastrar([FromBody] Partida partida)
        {
            try
            {
                partida.Cadastrar(partida);
                return Ok(new Partida());
            }
            catch (Exception e)
            {
                return StatusCode(
                        500,
                        new ErrorResponse("Não foi possível responder a requisição.")
                    );
            }
        }
    }
}

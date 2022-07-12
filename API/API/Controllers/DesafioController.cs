using API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesafioController : ControllerBase
    {
        public IDesafio desafio;

        public DesafioController(IDesafio ds)
        {
            desafio = ds;
        }

        [HttpGet("calculaIMC")]
        public ActionResult<double> calcularIMC(double altura, double peso) {
            try
            {
                if (altura > 0 && peso > 0)
                {
                    return desafio.calcularIMC(altura, peso);
                }
                return NotFound("Não foi possível calcular o IMC.");
            }
            catch (Exception msg)
            {
                return BadRequest(msg.Message);
            } 
        }

        [HttpPost("ordenaLista")]
        public ActionResult<List<int>> ordenaLista([FromBody]List<int> lista) {
            try
            {
                if (lista != null) {
                    return desafio.ordenarLista(lista);
                }
                return NotFound("Não foi possível ordenar lista.");
            }
            catch (Exception msg)
            {
                return BadRequest(msg.Message);
            }
        }

        [HttpGet("obtemUltimoCaractere")]
        public ActionResult<char> ultimoCaractere(String nome) {
            try
            {
                if (nome.Length > 0)
                {
                    return desafio.retornaUltimoCaractere(nome);
                }
                return NotFound("Palavra Inválida.");

            }
            catch (Exception msg)
            {
                return BadRequest(msg.Message);
            }
        }
    }
}

using API.Interfaces;
using API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public ITimeService timeservice;

        public HomeController(ITimeService ts)
        {
            timeservice = ts;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Time>> GetAll()
        {
            return Ok(timeservice.RetornaTimes());
        }

        
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Time> Get(int id)
        {
            try
            {
                var time = timeservice.BuscaTime(id);
                if (time == null) return NotFound("Não foi possível encontrar o time de ID: " + id);
                return Ok(time);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult<IEnumerable<Time>> Post([FromBody] Time time)
        {
            try
            {
                timeservice.InsereTime(time);
                return NotFound("Não foi possível adicionar a Lista.");
            }
            catch (Exception msg)
            {
                return BadRequest(msg.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Time>> Delete(int id)
        {
            try
            {
                bool resultado = timeservice.DeletaTime(id);

                if (!resultado) {
                    return NotFound("Não foi possível encontrar o time de ID: " + id);
                }
                return Ok(resultado);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // Update api/values
        [HttpPut]
        public ActionResult<IEnumerable<Time>> Put([FromBody] Time time)
        {
            var times = timeservice.RetornaTimes();
            
            try
            {
                if (timeservice.BuscaTime(time.Id) != null) {
                    var novoTime = timeservice.AtualizaTime(time);
                    return Ok(timeservice.RetornaTimes());
                }
                return NotFound("não foi possível encontar o time de id: " + time.Id);
            }
            catch (Exception msg)
            {
                return BadRequest(msg.Message);
            }
        }
    }
}

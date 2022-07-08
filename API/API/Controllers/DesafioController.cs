using API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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


    }
}

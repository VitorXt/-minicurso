using Microsoft.AspNetCore.Mvc;
using Vendas.API.Models;

namespace Vendas.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {

        [HttpPost("Incluir")]
        public IActionResult Incluir(Venda venda)
        {
            return Ok();
        }

        [HttpPatch("Cancelar")]

        public IActionResult Cancelar(Venda venda)
        {
            return Ok();
        }

        [HttpGet("BuscarVendas")]

        public IActionResult BuscarVendas()
        {
            return Ok();
        }
    }
}

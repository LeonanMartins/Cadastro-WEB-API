using Cadastro.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroController : ControllerBase
    {
        private static List<Cliente> Clientes()
        {
            return new List<Cliente>
            {
                new Cliente{ Nome = "Lucas", Id = 1, DataContacto = new DateTime(1998, 10,5)}
            };
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Clientes());
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            var clientes = Clientes();
            clientes.Add(cliente);
            return Ok(clientes);
        }

    }
}
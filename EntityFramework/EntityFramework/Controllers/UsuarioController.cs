using EntityFramework.Servico.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioServico _servico;

        public UsuarioController()
        {
            _servico = new UsuarioServico();
        }

        [HttpPost]
        public JsonResult Cadastrar()
        {
            return new JsonResult("");
        }
    }
}

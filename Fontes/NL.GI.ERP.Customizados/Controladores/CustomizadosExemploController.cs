using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NL.GI.ERP.Extensoes.API;

namespace NL.GI.ERP.Customizados.Controladores
{
    [Route("api/v1/customizados/[controller]")]
    public class CustomizadosExemploController : NLGIERPAPIControllerPing_1_0
    {
        public CustomizadosExemploController(ILogger<CustomizadosExemploController> logger) 
            : base(logger)
        {
        }

        [HttpGet("get-teste")]
        public IActionResult Get()
            => Ok("Testado...");
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NL.GI.ERP.Extensoes.API;

namespace NL.GI.ERP.Customizados.Controladores
{
    [Route("api/v1/customizados/AFI/[controller]")]
    public class OlucroVendasController : ControllerBase
    {
        

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var vendas = new List<OlucroVendas>
        {
            new OlucroVendas
            {
                Cod = 1 ,
                Qtda = 100,
                Preco = 200,
                ICMS = 300,
                ICMS_ST = 500,
                IPI = 600,
            }
        };


            return Ok(vendas);

        }
    }
}

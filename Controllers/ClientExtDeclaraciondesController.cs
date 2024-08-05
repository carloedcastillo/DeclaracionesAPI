using API_Declaraciones.Aplicacion;
using Declaraciones.Services;
using Microsoft.AspNetCore.Mvc;

namespace Declaraciones.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientExtDeclaraciondesController : ControllerBase
    {
        private readonly XMLServiceClient _xmlServiceClient;
        private readonly DeclaracionService _declaracionService;

        private readonly string _documentServiceUrl;
        private readonly string _apiKey;

        public ClientExtDeclaraciondesController(XMLServiceClient xmlServiceClient, IConfiguration configuration , DeclaracionService declaracionService)
        {
            _xmlServiceClient = xmlServiceClient;
            _declaracionService = declaracionService;
            _documentServiceUrl = configuration["ServiceUrls:Declaraciones"];
            _apiKey = configuration["ApiKeys:DeclaracionesServiceApiKey"];
        }
        /// <summary>
        /// Las fechas que han sido habilitadas para la prueba son:  2021-06-20  • 2021-06-21  • 2021-06-22  • 2021-06-23  • 2021-06-24 
        /// </summary>
        /// <param name="Fecha"></param>
        /// <returns></returns>
        [HttpGet("{Fecha}")]
        public async Task<IActionResult> ExtraerDeclaracionesExtporFecha(string Fecha)
        {
            //TODO: Pasar a capa de aplicacion
            ///Consulta Declaraciones
            var document = await _xmlServiceClient.GetDeclaracionAsync(_documentServiceUrl, _apiKey, Fecha);
            //Descomprime Declaraciones
            var datosdescomprimidos = await _declaracionService.ReadDeclaracion(document.DatosComprimidos);
            //Guarda Declaraciones
            await _declaracionService.GuardaDeclaraciones(datosdescomprimidos);

            return Ok("Datos guardados!");
        }


        

    }
}

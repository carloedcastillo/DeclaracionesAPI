using API_Declaraciones.Aplicacion;
using Declaraciones.Data.Models.Declaraciones;
using Declaraciones.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_Declaraciones.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeclaracionesController : Controller
    {

        private readonly DeclaracionService _declaracionService;


        public DeclaracionesController( DeclaracionService declaracionService)
        {
            _declaracionService = declaracionService;
        }
        /// <summary>
        /// GetDeclaracionesExtporFecha
        /// </summary>
        /// <param name="Nddtimmioe"></param>
        /// <returns></returns>
        [HttpGet("{Nddtimmioe}")]
        public ActionResult<Declaracion> GetDeclaracionesExtporFecha(string Nddtimmioe)
        {
            //TODO: Pasar a capa de aplicacion

            //Guarda Declaraciones
            var declaracion = _declaracionService.GetDeclaracionAsync(Nddtimmioe);

            return Ok(declaracion); 
        }
    }
}

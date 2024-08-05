using Declaraciones.Data.Models.Declaraciones;
using Newtonsoft.Json;

namespace API_Declaraciones.Data.DTO
{
    public class DeclaracionesResponse
    {

        public List<Articulo> ART { get; set; }
        
        public Declaracion DDT { get; set; }

        public Liquidacion LIQ { get; set; }

        public List<LiquidacionArticulo> LQA { get; set; }


    }
}

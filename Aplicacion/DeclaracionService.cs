using API_Declaraciones.Data.Context;
using API_Declaraciones.Data.DTO;
using Declaraciones.Data.Models.Declaraciones;
using Declaraciones.Utils;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace API_Declaraciones.Aplicacion
{
    public class DeclaracionService
    {
        private readonly ApplicationDBContext _context;

        public DeclaracionService(ApplicationDBContext context)
        {
                _context = context;
        }

        public async Task<string> ReadDeclaracion(string encoded) {
            Declaracion declaracion = null;
            string datos =  CompressXML.DecompressAsync(encoded).Result.ToString();

            return datos;
        
        }

        public Declaracion GetDeclaracionAsync(string Nddtimmioe) {
            Declaracion declaracion =  _context.Declaraciones
                .Where(q => q.Nddtimmioe == Nddtimmioe).FirstOrDefault();
            declaracion.Liquidacion = _context.Liquidaciones.Where(q => q.Iddt == declaracion.Iddt).FirstOrDefault();
            declaracion.Articulos = _context.Articulos.Where(q => q.Iddt == declaracion.Iddt).ToList();
            foreach (var item in declaracion.Articulos)
            {
                item.LiquidacionArticulos = _context.LiquidacionesArticulo.Where(q => q.Nart == item.Nart && q.Iliq == declaracion.Liquidacion.Iliq).ToList();
            }
            
            return declaracion;
        
        }

        public async Task GuardaDeclaraciones(string declaracionestoDeserialize) {
             List<DeclaracionesResponse> declaracionesres = null;
            declaracionesres = JsonConvert.DeserializeObject<List<DeclaracionesResponse>>(declaracionestoDeserialize);

            List<Declaracion> declaracions = new List<Declaracion>();
            /*
            declaracions = declaracionesres.Select( x =>  new Declaracion {
                Articulos = x.ART,
                Liquidacion = x.LIQ,

            }).ToList();
            
             */

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach (var item in declaracionesres)
                    {
                        _context.Declaraciones.Add(item.DDT);
                        _context.Articulos.AddRange(item.ART);
                        _context.LiquidacionesArticulo.AddRange(item.LQA);
                       // _context.Liquidaciones.Add(item.LIQ.Declaracion);
                        Liquidacion liquidacion = item.LIQ;
                        liquidacion.Declaracion = item.DDT;
                        _context.Liquidaciones.Add(liquidacion);

                    }
                    //List<LiquidacionArticulo> liquidacionArticulos = declaraciones.Select(x => x.LQA).ToList();

                    //_context.AddRange(declaraciones);
                    _context.SaveChanges();
                    transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }

                
        
        }

        


    }
}

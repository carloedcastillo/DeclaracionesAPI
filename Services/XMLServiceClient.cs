using Declaraciones.ModelsXML;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Declaraciones.Services
{
    public class XMLServiceClient
    {
        private readonly HttpClient _httpClient;

        public XMLServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        ///TODO: Pasar a capa de adaptadores
        public async Task<DeclaracionDTO> GetDeclaracionAsync(string url, string apiKey, string Fecha)
        {
            _httpClient.DefaultRequestHeaders.Add("ApiKey", apiKey);
            var response = await _httpClient.GetAsync(url+"?Fecha="+Fecha);
            /// valida el codigo de respuesta devuelve ex si no es 200
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            var serializer = new XmlSerializer(typeof(DeclaracionDTO));
            return (DeclaracionDTO)serializer.Deserialize(stream);

        }
    }
}

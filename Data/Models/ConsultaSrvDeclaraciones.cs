using System.Xml.Serialization;

namespace Declaraciones.Data.Models
{
    public class ConsultaSrvDeclaraciones
    {
        public string FechaConsulta { get; set; }
        [XmlElement("cuentaDeclaraciones")]
        public string CuentaDeclaraciones { get; set; }
        [XmlElement("datosComprimidos")]
        public string DatosComprimidos { get; set; }
    }
}

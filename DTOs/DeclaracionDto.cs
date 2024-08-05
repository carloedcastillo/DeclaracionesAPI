using System.Xml.Serialization;

namespace Declaraciones.ModelsXML
{
    [XmlRoot("CNBS-INFO-R")]
    public class DeclaracionDTO
    {
        [XmlAttribute("nroTransaccion")]
        public string NoTransaccion { get; set; }
        [XmlAttribute("fechaHoraTrn")]
        public string FechaHoraTransacciom { get; set; }
        [XmlElement("fechaAConsultar")]
        public string FechaaConsultar { get; set; }
        [XmlElement("cuentaDeclaraciones")]
        public string CuentaDeclaraciones { get; set; }
        [XmlElement("datosComprimidos")]
        public string DatosComprimidos { get; set; }


    }
}

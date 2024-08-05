using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Declaraciones.Data.Models.Declaraciones
{
    public class Declaracion //DDT
    {
        [MaxLength(17)]
        public string Iddtextr { get; set; } // Texto (17) Si

        [Range(0, 999)]
        public int Cddtver { get; set; } // Entero (3) Si

        [MaxLength(17)]
        public string Iddtext { get; set; } // Texto (17) Si

        [MaxLength(17)]
        [Key]
        public string Iddt { get; set; } // Texto (17) Si

        [MaxLength(40)]
        public string? Iext { get; set; } // Texto (40) No

        [MaxLength(4)]
        public string Cddteta { get; set; } // Texto (4) Si

        public DateTime Dddtoficia { get; set; } // Fecha Hora Si

        public DateTime? Dddtrectifa { get; set; } // Fecha Hora No

        [MaxLength(1)]
        public string? Cddtcirvis { get; set; } // Texto (1) No

        [Range(0, 999999999999.999999)]
        public decimal Qddttaxchg { get; set; } // Número (12,6) Si

        [MaxLength(4)]
        public string Ista { get; set; } // Texto (4) Si

        [MaxLength(4)]
        public string Cddtbur { get; set; } // Texto (4) Si

        [MaxLength(4)]
        public string? Cddtburdst { get; set; } // Texto (4) No

        [MaxLength(4)]
        public string? Cddtdep { get; set; } // Texto (4) No

        [MaxLength(4)]
        public string? Cddtentrep { get; set; } // Texto (4) No

        [MaxLength(5)]
        public string Cddtage { get; set; } // Texto (5) Si

        [MaxLength(14)]
        public string? Cddtagr { get; set; } // Texto (14) No

        [MaxLength(100)]
        public string? Lddtagr { get; set; } // Texto (100) No

        [MaxLength(14)]
        public string Nddtimmioe { get; set; } // Texto (14) Si

        [MaxLength(100)]
        public string Lddtnomioe { get; set; } // Texto (100) Si

        [MaxLength(2)]
        public string? Cddtpayori { get; set; } // Texto (2) No

        [MaxLength(2)]
        public string? Cddtpaidst { get; set; } // Texto (2) No

        [MaxLength(150)]
        public string? Lddtnomfod { get; set; } // Texto (150) No

        [MaxLength(3)]
        public string? Cddtincote { get; set; } // Texto (3) No

        [MaxLength(3)]
        public string Cddtdevfob { get; set; } // Texto (3) Si

        [MaxLength(3)]
        public string? Cddtdevfle { get; set; } // Texto (3) No

        [MaxLength(3)]
        public string? Cddtdevass { get; set; } // Texto (3) No

        [MaxLength(5)]
        public string? Cddttransp { get; set; } // Texto (5) No

        [MaxLength(1)]
        public string? Cddtmdetrn { get; set; } // Texto (1) No

        [MaxLength(2)]
        public string? Cddtpaytrn { get; set; } // Texto (2) No

        [Range(0, 9999)]
        public int Nddtart { get; set; } // Entero (4) Si

        [Range(0, 999)]
        public int? Nddtdelai { get; set; } // Entero (3) No

        public DateTime? Dddtbae { get; set; } // Fecha Hora No

        public DateTime? Dddtsalida { get; set; } // Fecha Hora No

        public DateTime? Dddtcancel { get; set; } // Fecha Hora No

        public DateTime? Dddtechean { get; set; } // Fecha No



        [MaxLength(500)]
        public string? Cddtobs { get; set; } // Texto (500) No
        [NotMapped]
        public Liquidacion? Liquidacion { get; set; }
        [NotMapped]
        public List<Articulo>? Articulos { get; set; }

    }
}

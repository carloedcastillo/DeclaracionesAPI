using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Declaraciones.Data.Models.Declaraciones
{
    public class Liquidacion//LIQ
    {
        [MaxLength(17)]
        [Key]
        public string Iliq { get; set; } // Texto (17), Si
        
        [MaxLength(17)]
        public string Cliqdop { get; set; } // Texto (17), Si

        [MaxLength(3)]
        public string Cliqeta { get; set; } // Texto (3), Si

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Mliq { get; set; } // Número (18,2), Si

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Mliqgar { get; set; } // Número (18,2), Si

        public DateTime? Dlippay { get; set; } // Fecha Hora, No

        [MaxLength(20)]
        public string? Clipnomope { get; set; } // Texto (20), No
        
        public string? Iddt { get; set; } // Texto (17) Si
        [ForeignKey("Iddt")]
        public Declaracion? Declaracion { get; set; }
        

    }
}

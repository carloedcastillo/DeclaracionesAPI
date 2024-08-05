using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Declaraciones.Data.Models.Declaraciones
{
    public class Articulo
    {
        [MaxLength(17)]
        public string Iddt { get; set; } // Texto (17), Si\
        
        [Range(0, 9999)]
        public int Nart { get; set; } // Entero (4), Si

        [MaxLength(1)]
        public string Carttyp { get; set; } // Texto (1), Si

        [MaxLength(15)]
        public string Codbenef { get; set; } // Texto (15), Si

        [MaxLength(2)]
        public string? Cartetamrc { get; set; } // Texto (2), No

        [MaxLength(17)]
        public string Iespnce { get; set; } // Texto (17), Si

        [MaxLength(500)]
        public string Cartdesc { get; set; } // Texto (500), Si

        [MaxLength(2)]
        public string? Cartpayori { get; set; } // Texto (2), No

        [MaxLength(2)]
        public string? Cartpayacq { get; set; } // Texto (2), No

        [MaxLength(2)]
        public string? Cartpayprc { get; set; } // Texto (2), No

        [MaxLength(17)]
        public string? Iddtapu { get; set; } // Texto (17), No

        [Range(0, 9999)]
        public int? Nartapu { get; set; } // Entero (4), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qartbul { get; set; } // Número (18,2), No

        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Martunitar { get; set; } // Número (18,4), No

        [MaxLength(2)]
        public string? Cartuntdcl { get; set; } // Texto (2), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qartuntdcl { get; set; } // Número (18,2), No

        [MaxLength(2)]
        public string? Cartuntest { get; set; } // Texto (2)

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qartuntest { get; set; } // Número (18,2), No

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Qartkgrbrt { get; set; } // Número (18,3), No

        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Qartkgrnet { get; set; } // Número (18,3), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Martfob { get; set; } // Número (18,2), Si

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Martfobdol { get; set; } // Número (18,2), Si

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Martfle { get; set; } // Número (18,2), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Martass { get; set; } // Número (18,2), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Martemma { get; set; } // Número (18,2), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Martfrai { get; set; } // Número (18,2), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Martajuinc { get; set; } // Número (18,2), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Martajuded { get; set; } // Número (18,2), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Martbasimp { get; set; } // Número (18,2), No

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Martbasimp2 { get; set; } // Número (18,2), Si
        [NotMapped]
        public List<LiquidacionArticulo>? LiquidacionArticulos { get; set; }
    }
}

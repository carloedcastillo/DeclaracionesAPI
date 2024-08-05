using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Declaraciones.Data.Models.Declaraciones
{
    public class LiquidacionArticulo// LIQART
    {
        [MaxLength(17)]
        public string Iliq { get; set; } // Texto (17), No


        [Range(0, 9999)]
        public int Nart { get; set; } // Entero (4), No


        [MaxLength(3)]
        public string Clqatax { get; set; } // Texto (3), No

        [MaxLength(1)]
        public string Clqatyp { get; set; } // Texto (1), No

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Mlqabas { get; set; } // Número (18,4), No

        [Column(TypeName = "decimal(18, 6)")]
        public decimal Qlqacoefic { get; set; } // Número (18,6), No

        [Column(TypeName = "decimal(18, 4)")]
        public decimal Mlqa { get; set; } // Número (18,4), No
    }
}

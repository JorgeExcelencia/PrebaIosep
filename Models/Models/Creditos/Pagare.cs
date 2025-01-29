using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public class Pagare
    {
        [Key]
        public int IdPagare { get; set; }

        public int? IdAfiliado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_mov { get; set; }

        public int? Id_operacion { get; set; }

        public int? Cuotas { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Valor { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Pcto_inter { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Total_pagare { get; set; }

        [StringLength(50)]
        public string Nro_pagare { get; set; } = string.Empty;

        [StringLength(50)]
        public string Plazo { get; set; } = string.Empty;

        [StringLength(200)]
        public string Domicilio { get; set; } = string.Empty;

        [StringLength(100)]
        public string Localidad { get; set; } = string.Empty;

        [StringLength(50)]
        public string Id_gar { get; set; } = string.Empty;
    }
}

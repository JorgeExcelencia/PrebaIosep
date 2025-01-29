using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwEntregaTurnos2
    {
        public int IdAfiliado { get; set; }
        public string cuil { get; set; } = null!;
        public int Recno { get; set; }
        public int RecnoGrupo { get; set; }
        public string familiar { get; set; } = null!;
        public string a_numero { get; set; } = null!;
        public string nombre { get; set; } = null!;
        public DateTime? fecha_nacimiento { get; set; }
        public string sexo { get; set; } = null!;
        public string? d_tipo { get; set; }
        public string d_nro { get; set; } = null!;
        public string? e_civil { get; set; }
        public string? domicilio { get; set; }
        public decimal? puerta { get; set; }
        public decimal? piso { get; set; }
        public string? dto { get; set; }
        public string? telefono { get; set; }
        public string? delegacion { get; set; }
        public string? tipo_dom { get; set; }
        public string? provincia { get; set; }
        public string? zona { get; set; }
        public string? localidad { get; set; }
        public byte? estado { get; set; }
        public bool? convenio { get; set; }
        public DateTime? fecha { get; set; }
        public DateTime? v_fecha { get; set; }
        public DateTime? ven_fecha { get; set; }
        public DateTime? i_fecha { get; set; }
        public string? letarc { get; set; }
        public string? codarc { get; set; }
        public string EstadoTarjeta { get; set; } = null!;
        public string CuilABuscar { get; set; } = null!;
    }
}

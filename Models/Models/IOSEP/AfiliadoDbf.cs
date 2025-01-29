using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadoDbf
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
        public bool? materno { get; set; }
        public DateTime? mat_fdes { get; set; }
        public DateTime? mat_fhas { get; set; }
        public string? empresa { get; set; }
        public string? categoria { get; set; }
        public bool? transito { get; set; }
        public bool? incapacida { get; set; }
        public string? tipo_disc { get; set; }
        public DateTime? dis_fdes { get; set; }
        public DateTime? dis_fhas { get; set; }
        public bool? estudian { get; set; }
        public DateTime? est_fdes { get; set; }
        public DateTime? est_fhas { get; set; }
        public string? plan_esp { get; set; }
        public decimal? imp_aporte { get; set; }
        public string? periodo_aporte { get; set; }
        public string? cta_apo { get; set; }
        public string? jub_benef { get; set; }
        public DateTime? chequeado { get; set; }
        public DateTime? f_ult_cens { get; set; }
        public DateTime? e_fecha { get; set; }
        public string? motivo1 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwInternados_Alta
    {
        public int idinternado { get; set; }
        public int idafiliado { get; set; }
        public string Nombre_Afiliado { get; set; } = null!;
        public int idtitular { get; set; }
        public string Nombre_Titular { get; set; } = null!;
        public int idclinica { get; set; }
        public string? Diagnostico { get; set; }
        public short? idtipointernacion { get; set; }
        public string? habitacion { get; set; }
        public string? cama { get; set; }
        public byte edad { get; set; }
        public bool hijo { get; set; }
        public short idestado { get; set; }
        public string? Estado { get; set; }
        public string Cuil_Afiliado { get; set; } = null!;
        public string Cuil_Titular { get; set; } = null!;
        public bool anulada { get; set; }
        public decimal? coseguro { get; set; }
        public short? idestado_anterior { get; set; }
        public string? Estado_anterior { get; set; }
        public string? Nombre_prestador { get; set; }
        public string? Codigo_prestador { get; set; }
        public DateTime? fecha_alta { get; set; }
        public int? iddiagnosticoalta { get; set; }
        public string? Motivo_Alta { get; set; }
        public string? Obs_auditor { get; set; }
        public string? respauditor { get; set; }
        public int? idprestadoralta { get; set; }
        public short? idmotivoalta { get; set; }
        public string Tipo_internacion { get; set; } = null!;
    }
}

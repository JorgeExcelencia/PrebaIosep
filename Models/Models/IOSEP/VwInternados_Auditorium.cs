using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwInternados_Auditorium
    {
        public int idinternado { get; set; }
        public int idafiliado { get; set; }
        public string Nombre_Afiliado { get; set; } = null!;
        public int idtitular { get; set; }
        public string Nombre_Titular { get; set; } = null!;
        public int idclinica { get; set; }
        public int iddiagnostico { get; set; }
        public string? Codigo { get; set; }
        public string? Diagnostico { get; set; }
        public short? idtipointernacion { get; set; }
        public string? Tipo_Internacion { get; set; }
        public int? idprestador { get; set; }
        public string? codigo_prestador { get; set; }
        public string? Nombre_prestador { get; set; }
        public DateTime fecha_internacion { get; set; }
        public string? habitacion { get; set; }
        public string? cama { get; set; }
        public byte edad { get; set; }
        public bool hijo { get; set; }
        public string? tratamiento { get; set; }
        public string? obs_auditor { get; set; }
        public string? respAuditor { get; set; }
        public short idestado { get; set; }
        public string? Estado { get; set; }
        public string Cuil_Afiliado { get; set; } = null!;
        public string Cuil_Titular { get; set; } = null!;
        public bool anulada { get; set; }
        public decimal? coseguro { get; set; }
        public short? idestado_anterior { get; set; }
        public string? Estado_anterior { get; set; }
    }
}

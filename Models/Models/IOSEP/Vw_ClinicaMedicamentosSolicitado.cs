using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_ClinicaMedicamentosSolicitado
    {
        public DateTime? Fecha { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte? Cantidad { get; set; }
        public byte TipoAutorizacion { get; set; }
        public byte? TipoId { get; set; }
        public int IdAutoriza { get; set; }
        public string Numero { get; set; } = null!;
        public string? Motivo { get; set; }
        public string? Autorizacion { get; set; }
        public short SeImprimio { get; set; }
        public bool Anulada { get; set; }
        public int? iddetipo { get; set; }
        public int IdHistoria { get; set; }
        public int NroRegistro { get; set; }
        public string Troquel { get; set; } = null!;
        public string CodBarras { get; set; } = null!;
        public string NombreMedicamento { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string Tamano { get; set; } = null!;
        public string Monodroga { get; set; } = null!;
        public string titular { get; set; } = null!;
        public string nombretitular { get; set; } = null!;
        public string Institucion { get; set; } = null!;
        public byte EstadoAnulada { get; set; }
    }
}

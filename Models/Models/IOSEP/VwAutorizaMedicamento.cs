using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwAutorizaMedicamento
    {
        public int IdAutoriza { get; set; }
        public string Autorizada { get; set; } = null!;
        public byte? Cantidad { get; set; }
        public int Cobertura { get; set; }
        public string Numero { get; set; } = null!;
        public string? Motivo { get; set; }
        public string Tipo { get; set; } = null!;
        public DateTime? Fecha_Prescripcion { get; set; }
        public int? IdAfiliado { get; set; }
        public string NomAut { get; set; } = null!;
        public int NroRegistro { get; set; }
        public string Troquel { get; set; } = null!;
        public string CodBarras { get; set; } = null!;
        public string NombreMedicamento { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string Tamano { get; set; } = null!;
        public string Monodroga { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte? TipoId { get; set; }
        public bool Anulada { get; set; }
        public byte TipoAutorizacion { get; set; }
        public byte EstadoAnulada { get; set; }
        public int? IddeTipo { get; set; }
    }
}

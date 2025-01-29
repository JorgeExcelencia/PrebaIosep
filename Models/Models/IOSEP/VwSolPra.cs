using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwSolPra
    {
        public int IdInternado { get; set; }
        public int IdAfiliado { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdTitular { get; set; }
        public string Titular { get; set; } = null!;
        public int IdDiagnostico { get; set; }
        public string Codigo { get; set; } = null!;
        public string Diagnostico { get; set; } = null!;
        public short? IdTipoInternacion { get; set; }
        public DateTime Fecha_Internacion { get; set; }
        public bool Hijo { get; set; }
        public short IdEstado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public bool Anulada { get; set; }
        public DateTime DiaHora { get; set; }
        public short AnuladoDia { get; set; }
        public int IdClinica { get; set; }
    }
}

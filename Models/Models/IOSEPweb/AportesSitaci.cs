using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AportesSitaci
    {
        public int IdAporteSitaci { get; set; }
        public string CodArchivo { get; set; } = null!;
        public string NumeroBeneficio { get; set; } = null!;
        public string ApellidoNombre { get; set; } = null!;
        public string CodAnses { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string CodigoLiquidacion { get; set; } = null!;
        public decimal Haber { get; set; }
        public decimal Aportes { get; set; }
        public string MesAporte { get; set; } = null!;
        public string AnioAporte { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; } = null!;
        public string CodigoAnses { get; set; } = null!;
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}

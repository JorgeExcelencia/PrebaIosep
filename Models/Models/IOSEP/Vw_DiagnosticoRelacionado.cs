using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_DiagnosticoRelacionado
    {
        public int IdDiagnosticoRelacionado { get; set; }
        public int IdCapitulo { get; set; }
        public int? IdDiagnosticoDetalle { get; set; }
        public int? NroRegistro { get; set; }
        public int? IdNomen_General { get; set; }
        public string? NombreMedicamento { get; set; }
        public string? Monodroga { get; set; }
        public string? Presentacion { get; set; }
        public string? Tamano { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? NombreCapitulo { get; set; }
        public string? NombreNomenclador { get; set; }
        public string? CodigoNomenclador { get; set; }
        public string IdDiagnostico { get; set; } = null!;
    }
}

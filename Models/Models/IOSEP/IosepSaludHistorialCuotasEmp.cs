using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class IosepSaludHistorialCuotasEmp
    {
        public int IosepSaludHistorialCuotasEmpID { get; set; }
        public int IdEmpresa { get; set; }
        public decimal Importe { get; set; }
        public string? Resolucion { get; set; }
        public string? ReferenciaResolucion { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime VigenciaHasta { get; set; }
        public DateTime FechaCarga { get; set; }
        public string OperadorCarga { get; set; } = null!;
        public string? OperModif { get; set; }
        public DateTime? FechaModif { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
        public bool Anulada { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Encabezado_AutorizacionesAuditorium
    {
        public int Encabezado_AutorizacionesAuditoriaId { get; set; }
        public int IdAfiliado { get; set; }
        public int IdPlan { get; set; }
        public int? IdInternado { get; set; }
        public string? Numero { get; set; }
        public string? Numero_Internacion { get; set; }
        public short IdDelegacion { get; set; }
        public int IdMedico_Prescriptor { get; set; }
        public int? IdEfector { get; set; }
        public int? IdInstitucion { get; set; }
        public int IdDiagnostico { get; set; }
        public DateTime Fecha_Prescripcion { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public DateTime? Fecha_Vencimiento { get; set; }
        public string Operador { get; set; } = null!;
        public string? Observaciones { get; set; }
        public string? Motivo_Rechazo { get; set; }
        public string EstadoAutorizacion { get; set; } = null!;
        public bool Anulada { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? Modifica { get; set; }
        public bool IosepSalud { get; set; }
        public byte IdLugar { get; set; }
    }
}

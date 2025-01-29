using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProtesisEncabezadoSolicitud
    {
        public int ProtesisEncabezadoSolicitudID { get; set; }
        public int DelegacionSolicitaID { get; set; }
        public string? CodigoSolicitud { get; set; }
        public string? NroExpediente { get; set; }
        public string? RefExpediente { get; set; }
        public DateTime? FechaExpediente { get; set; }
        public DateTime? FechaVinculacion { get; set; }
        public int IdTitular { get; set; }
        public int IdBeneficiario { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime? FechaCirugia { get; set; }
        public int IdPrescriptor { get; set; }
        public int EspecialidadID { get; set; }
        public string? MatriculaNacional { get; set; }
        public int IdCentroAsistencial { get; set; }
        public string? LugarEntrega { get; set; }
        public string EstadoAutorizacion { get; set; } = null!;
        public bool Internado { get; set; }
        public bool Urgente { get; set; }
        public string ResumenHistoriaClinica { get; set; } = null!;
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public bool Anulado { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? MotivoAnulaID { get; set; }
        public string? ObservacionesAnula { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TurnosServicio
    {
        public int TurnoId { get; set; }
        public int PacienteId { get; set; }
        public string? Apellido { get; set; }
        public string? Nombre { get; set; }
        public string? Documento { get; set; }
        public string? Sexo { get; set; }
        public int ServicioId { get; set; }
        public int ConsultorioId { get; set; }
        public int PrestadorId { get; set; }
        public DateTime FechaHora { get; set; }
        public string HoraHasta { get; set; } = null!;
        public string? Orden { get; set; }
        public DateTime? Llegada { get; set; }
        public DateTime? Llamado { get; set; }
        public DateTime? Atendido { get; set; }
        public DateTime? NoAtendido { get; set; }
        public bool? Primeravez { get; set; }
        public int? AnterirorId { get; set; }
        public int? ObraSocialId { get; set; }
        public bool? Emergencia { get; set; }
        public short? EmergenciaId { get; set; }
        public bool? Admisionado { get; set; }
        public short? Edad { get; set; }
        public string? OpCrea { get; set; }
        public string? OpModifica { get; set; }
        public DateTime? FecModifica { get; set; }
        public bool Anulado { get; set; }

        public virtual Servicio Servicio { get; set; } = null!;
    }
}

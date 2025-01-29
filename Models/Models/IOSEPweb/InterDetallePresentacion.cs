using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InterDetallePresentacion
    {
        public InterDetallePresentacion()
        {
            InterDetalleProtocolos = new HashSet<InterDetalleProtocolo>();
            InterEncabezadoMedicamentos = new HashSet<InterEncabezadoMedicamento>();
        }

        public int IdDetallePresentacion { get; set; }
        public int EncabezadoId { get; set; }
        public int IdClinica { get; set; }
        public string? NumeroInternado { get; set; }
        public int? IdInternado { get; set; }
        public int IdAfiliado { get; set; }
        public int TipoInternacionId { get; set; }
        public DateTime FechaInternacion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public short DiasInternacion { get; set; }
        public bool Chequeado { get; set; }
        public bool Devuelto { get; set; }
        public int IdMotivoDevolucion { get; set; }
        public string? Observacion { get; set; }
        public bool ACompartida { get; set; }
        public string OperadorCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual InterEncabezadoPresentacion Encabezado { get; set; } = null!;
        public virtual ICollection<InterDetalleProtocolo> InterDetalleProtocolos { get; set; }
        public virtual ICollection<InterEncabezadoMedicamento> InterEncabezadoMedicamentos { get; set; }
    }
}

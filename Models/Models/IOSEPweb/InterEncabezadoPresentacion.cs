using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class InterEncabezadoPresentacion
    {
        public InterEncabezadoPresentacion()
        {
            InterClinicaFacturas = new HashSet<InterClinicaFactura>();
            InterDetallePresentacions = new HashSet<InterDetallePresentacion>();
        }

        public int EncabezadoId { get; set; }
        public int IdObraSocial { get; set; }
        public int IdInstitucion { get; set; }
        public DateTime Fecha { get; set; }
        public string Periodo { get; set; } = null!;
        public string OperadorCrea { get; set; } = null!;
        public DateTime? FechaCierrePresentacion { get; set; }
        public string? OperadorCierrePresentacion { get; set; }
        public DateTime? FechaCierreAuditoria { get; set; }
        public string? OperadorCierreAuditoria { get; set; }
        public DateTime? FechaCierreCompartida { get; set; }
        public string? OperadorCierreCompartida { get; set; }
        public byte Complementaria { get; set; }
        public string? NumeroFactura { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<InterClinicaFactura> InterClinicaFacturas { get; set; }
        public virtual ICollection<InterDetallePresentacion> InterDetallePresentacions { get; set; }
    }
}

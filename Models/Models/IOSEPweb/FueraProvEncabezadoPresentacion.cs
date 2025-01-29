using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class FueraProvEncabezadoPresentacion
    {
        public FueraProvEncabezadoPresentacion()
        {
            FueraProvDetallePresentacions = new HashSet<FueraProvDetallePresentacion>();
            FueraProvFacturas = new HashSet<FueraProvFactura>();
        }

        public int IdEncabezado { get; set; }
        public int IdInstitucion { get; set; }
        public int IdObraSocial { get; set; }
        public string Periodo { get; set; } = null!;
        public byte Complementaria { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaCierrePresentacion { get; set; }
        public string? OpCierrePresentacion { get; set; }
        public DateTime? FechaCierreAuditoria { get; set; }
        public string? OpCierreAuditoria { get; set; }
        public DateTime? FechaCierreCompartida { get; set; }
        public string? OpCierreCompartida { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<FueraProvDetallePresentacion> FueraProvDetallePresentacions { get; set; }
        public virtual ICollection<FueraProvFactura> FueraProvFacturas { get; set; }
    }
}

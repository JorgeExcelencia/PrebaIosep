using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PracEncabezadoPresentacion
    {
        public PracEncabezadoPresentacion()
        {
            PracDetallePresentacionAutos = new HashSet<PracDetallePresentacionAuto>();
            PracDetallePresentacions = new HashSet<PracDetallePresentacion>();
        }

        public int EncabezadoId { get; set; }
        public DateTime Fecha { get; set; }
        public string PeriodoPresentacion { get; set; } = null!;
        public int IdObraSocial { get; set; }
        public int IdInstitucion { get; set; }
        public DateTime? FechaCierrePresentacion { get; set; }
        public string? OperadorCierrePresentacion { get; set; }
        public DateTime? FechaCierreAuditoria { get; set; }
        public string? OperadorCierreAuditoria { get; set; }
        public DateTime? FechaCierreCompartida { get; set; }
        public string? OperadorCierreCompartida { get; set; }
        public byte Complementaria { get; set; }
        public string? NumeroFactura { get; set; }
        public bool? Capitado { get; set; }
        public int IdCentroImagen { get; set; }
        public decimal Cartera { get; set; }
        public bool Anuladas { get; set; }
        public string? Cuit { get; set; }
        public string? Cae { get; set; }
        public bool Anulado { get; set; }
        public string Tipo { get; set; } = null!;
        public decimal TotalPresentado { get; set; }
        public decimal TotalDebitos { get; set; }
        public decimal TotalCreditos { get; set; }
        public decimal ImagenDebitos { get; set; }
        public decimal ImagenCreditos { get; set; }

        public virtual ICollection<PracDetallePresentacionAuto> PracDetallePresentacionAutos { get; set; }
        public virtual ICollection<PracDetallePresentacion> PracDetallePresentacions { get; set; }
    }
}

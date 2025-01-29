using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Detalle_Autorizacione
    {
        public int DetalleID { get; set; }
        public int AutorizacionesId { get; set; }
        public int IdNomenclador { get; set; }
        public byte Cantidad_Solicitada { get; set; }
        public byte Cantidad_Autorizada { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal Coseguro_Honorarios { get; set; }
        public decimal Coseguro_Gastos { get; set; }
        public decimal Reconoce_Honorarios { get; set; }
        public decimal Reconoce_Gastos { get; set; }
        public decimal? Factura_Honorarios { get; set; }
        public decimal? Factura_Gastos { get; set; }
        public DateTime? FechaPrestacion { get; set; }
        public int? IdEfector { get; set; }
        /// <summary>
        /// P - &apos; &apos; Pendiente De Autorizar/E-Enviada a IOSEP/R-Con Respuesta a Institucion/X-Rechazada/A-Autorizada/H-Pide Historia Clinica/S-Solicita Aclaracion a la Institucion/O-Aclaracion Enviada
        /// </summary>
        public string EstadoAutorizacion { get; set; } = null!;
        public string? Observaciones { get; set; }
        public string? Motivo_Rechazo { get; set; }
        public bool Anulada { get; set; }
        public string? MotivoAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OperAnula { get; set; }

        public virtual Encabezado_Autorizacione Autorizaciones { get; set; } = null!;
    }
}

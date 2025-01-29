using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwAutorizaPractica
    {
        public int AutorizacionesId { get; set; }
        public int IdAfiliado { get; set; }
        public int? IdInternado { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime Fecha_Prescripcion { get; set; }
        public DateTime? Fecha_Vencimiento { get; set; }
        public string EstadoAutorizacion { get; set; } = null!;
        public string matricula { get; set; } = null!;
        public string? Prescriptor { get; set; }
        public int DetAutoId { get; set; }
        public int IdNomenclador { get; set; }
        public byte Cantidad_Autorizada { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal Coseguro_Honorarios { get; set; }
        public decimal Coseguro_Gastos { get; set; }
        public decimal? Reconoce_Honorarios { get; set; }
        public decimal? Reconoce_Gastos { get; set; }
        public string EstadoDetalle { get; set; } = null!;
        public string? Motivo_Rechazo { get; set; }
        public string? Practica { get; set; }
        public string? DetallePractica { get; set; }
        public string? Motivo_Rechazo_Encabezado { get; set; }
        public int DetalleID { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? Expr1 { get; set; }
        public int IdPlan { get; set; }
        public string NombrePlan { get; set; } = null!;
        public int? IdInstitucion { get; set; }
    }
}

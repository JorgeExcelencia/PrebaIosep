using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Detalle_PresupuestoAutorizacione
    {
        public int Detalle_PresupuestoAutorizacionesID { get; set; }
        public int Encabezado_PresupuestoAutorizacionesId { get; set; }
        public string? NumeroBono { get; set; }
        public string? BonoAmbulatorio { get; set; }
        public int? IdNomenclador { get; set; }
        public byte Cantidad_Solicitada { get; set; }
        public byte Cantidad_Autorizada { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal Coseguro_Honorarios { get; set; }
        public decimal Coseguro_Gastos { get; set; }
        public decimal Reconoce_Honorarios { get; set; }
        public decimal Reconoce_Gastos { get; set; }
        public string? EstadoAutorizacion { get; set; }
        public string? Observaciones { get; set; }
        public string? Motivo_Rechazo { get; set; }
        public bool Anulada { get; set; }
        public bool Impresa { get; set; }
        public bool IncluidoPresup { get; set; }
        public int? IdGrupoPractica { get; set; }
        public int? IdCentroAfiliado { get; set; }
        public bool? CambioCentro { get; set; }
        public int? IdMotivoAnulacion { get; set; }
        public string? MotivoAnulacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string? UsuarioAnula { get; set; }
    }
}

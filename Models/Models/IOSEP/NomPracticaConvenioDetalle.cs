using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomPracticaConvenioDetalle
    {
        public int NomPracticaConvenioDetalleID { get; set; }
        public int NomPracticaConvenioID { get; set; }
        public int IdPractica { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal Ayudante1 { get; set; }
        public decimal Ayudante2 { get; set; }
        public decimal Ayudante3 { get; set; }
        public decimal Ayudante4 { get; set; }
        public decimal Anestesista { get; set; }
        public decimal Instrumentador { get; set; }
        public decimal CoseguroAmbulatorio { get; set; }
        public decimal CoseguroInternado { get; set; }
        public DateTime FechaVigenciaDesde { get; set; }
        public DateTime? FechaVigenciaHasta { get; set; }
        public bool? Vigente { get; set; }
        public bool Ambulatorio { get; set; }
        public string CreaOp { get; set; } = null!;
        public DateTime CreaFecha { get; set; }
        public string? ModiOp { get; set; }
        public DateTime? ModiFecha { get; set; }
        public string? Resolucion { get; set; }
        public bool Anulado { get; set; }

        public virtual NomPracticaConvenio NomPracticaConvenio { get; set; } = null!;
    }
}

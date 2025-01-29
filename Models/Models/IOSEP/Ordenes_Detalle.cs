using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Ordenes_Detalle
    {
        public int OrdenDetalleID { get; set; }
        public int IdOrden { get; set; }
        public int IdTipo_Nomenclador { get; set; }
        public int IdNomenclador { get; set; }
        public int Cantidad { get; set; }
        public decimal? Honorarios { get; set; }
        public decimal? Gastos { get; set; }
        public decimal? Coseguro_Honorarios { get; set; }
        public decimal? Coseguro_Gastos { get; set; }
        public decimal? Reconoce_Honorarios { get; set; }
        public decimal? Reconoce_Gastos { get; set; }
        public bool Anulado { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RedLink_ArchivoControlDetalle
    {
        public int ControlDetalleID { get; set; }
        public int ControlID { get; set; }
        public string IdentificacionDatos { get; set; } = null!;
        public int Lote { get; set; }
        public int CantRegistroLote { get; set; }
        public decimal SumaPrimerVencimientoLote { get; set; }
        public decimal? SumaSegundoVencimientoLote { get; set; }
    }
}

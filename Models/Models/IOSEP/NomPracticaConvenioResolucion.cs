using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NomPracticaConvenioResolucion
    {
        public int NomPracticaConvenioResolucionID { get; set; }
        public int? NomPracticaConvenioID { get; set; }
        public string NroResolucion { get; set; } = null!;
        public DateTime FechaCargaResolucion { get; set; }
        public DateTime FechaVigenciaDesde { get; set; }
        public string Accion { get; set; } = null!;
        public int CantidadPracticas { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
    }
}

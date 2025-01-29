using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MovimientoPracticasInternado
    {
        public int MovimientoPracticasInternadoID { get; set; }
        public int MovimientoInternadoID { get; set; }
        public int EncabezadoID { get; set; }
        public int PlanID { get; set; }
        public int DiagnosticoID { get; set; }
        public int InternadoID { get; set; }
        public DateTime Fecha { get; set; }
    }
}

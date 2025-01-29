using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vias_Cirugia
    {
        public long Id { get; set; }
        public long Id_Internacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Via { get; set; } = null!;
        public decimal Importe { get; set; }
        public decimal xOSP { get; set; }
        public decimal xAfi { get; set; }
        public decimal totalosp { get; set; }
        public decimal totalafi { get; set; }
    }
}

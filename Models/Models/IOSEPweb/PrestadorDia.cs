using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PrestadorDia
    {
        public int PrestadorDiasId { get; set; }
        public int PrestadorId { get; set; }
        public int ServicioId { get; set; }
        public int ConsultorioId { get; set; }
        public int DiaId { get; set; }
        public string? MDesde { get; set; }
        public string? MHasta { get; set; }
        public string? TDesde { get; set; }
        public string? THasta { get; set; }
        public string? NDesde { get; set; }
        public string? NHasta { get; set; }
        public string? Frecuencia { get; set; }
        public bool Anulado { get; set; }

        public virtual Dia Dia { get; set; } = null!;
    }
}

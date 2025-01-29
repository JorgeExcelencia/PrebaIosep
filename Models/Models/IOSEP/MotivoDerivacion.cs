using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MotivoDerivacion
    {
        public int MotivoDerivacionID { get; set; }
        public string Descripcion { get; set; } = null!;
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string? MotivoAnula { get; set; }
        public bool Anulado { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OperModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string? OperActiva { get; set; }
        public DateTime? FechaActiva { get; set; }
        public string? MotivoActiva { get; set; }
    }
}

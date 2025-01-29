using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EntidadBancarium
    {
        public int EntidadBancariaID { get; set; }
        public string? Codigo { get; set; }
        public string Denominacion { get; set; } = null!;
        public string? Domicilio { get; set; }
        public string? Telefono { get; set; }
        public string? MotivoAnulacion { get; set; }
        public string OperCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? OperModif { get; set; }
        public DateTime? FechaModif { get; set; }
        public bool Anulado { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OperAnula { get; set; }
    }
}

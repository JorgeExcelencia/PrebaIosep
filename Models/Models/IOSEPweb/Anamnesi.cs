using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Anamnesi
    {
        public int AnamnesisId { get; set; }
        public int IdAfiliado { get; set; }
        public int TurnoId { get; set; }
        public int PrestadorId { get; set; }
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public int TipoAnamnesisId { get; set; }
        public DateTime? Ingreso { get; set; }
        public DateTime? Egreso { get; set; }
        public DateTime? Creado { get; set; }
        public bool Anulado { get; set; }

        public virtual TipoAnamnesi TipoAnamnesis { get; set; } = null!;
    }
}

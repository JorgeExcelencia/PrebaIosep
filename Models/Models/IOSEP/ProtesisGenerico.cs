﻿using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ProtesisGenerico
    {
        public int ProtesisGenericoID { get; set; }
        public string? Codigo { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Presentacion { get; set; }
        public string? Observaciones { get; set; }
        public bool Anulado { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public DateTime FechaCarga { get; set; }
        public string? UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public int? MotivoAnulaID { get; set; }
        public string? ObservacionesAnula { get; set; }
    }
}

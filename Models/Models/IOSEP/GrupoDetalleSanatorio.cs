﻿using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class GrupoDetalleSanatorio
    {
        public int IdGrupoDetalleSanatorios { get; set; }
        public int IdGrupoSanatorios { get; set; }
        public int IdSanatorio { get; set; }
        public DateTime FechaCrea { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual GrupoSanatorio IdGrupoSanatoriosNavigation { get; set; } = null!;
    }
}

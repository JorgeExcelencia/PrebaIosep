﻿using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class TipoResolucione
    {
        public short TipoResolucionId { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

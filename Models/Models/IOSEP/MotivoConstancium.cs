﻿using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class MotivoConstancium
    {
        public int MotivoConstanciaID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

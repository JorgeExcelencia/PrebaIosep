using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Ordenes_Key
    {
        public int IdOrdenes { get; set; }
        public string Codigo_Delegacion { get; set; } = null!;
        public string Ultimo_Nro { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TipoFrecuencium
    {
        public string FrecuenciaTipo { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        /// <summary>
        /// 1 - Esquemas y Planes 2 - Medicamentos
        /// </summary>
        public string Esquemas { get; set; } = null!;
        public string Medicamentos { get; set; } = null!;
        public int Dias { get; set; }
        public bool Anulado { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CentrosVacunacion
    {
        public int CentrosVacunacionID { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

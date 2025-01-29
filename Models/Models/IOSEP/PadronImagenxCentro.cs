using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PadronImagenxCentro
    {
        public int PadronImagenxCentroID { get; set; }
        public int GrupoPracticaIDGrupoPrestadorID { get; set; }
        public int AfiliadoID { get; set; }
        public int AfiliadoTitularID { get; set; }
        public bool Anulado { get; set; }
    }
}

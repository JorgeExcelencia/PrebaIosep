using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ConfirmaCambioCentro
    {
        public int CambioCentroID { get; set; }
        public int EncabezadoID { get; set; }
        public int CentroAnteriorID { get; set; }
        public int CentroNuevoID { get; set; }
        public int MotivoID { get; set; }
        public string Observaciones { get; set; } = null!;
        public string UsuarioCambia { get; set; } = null!;
        public DateTime FechaCambio { get; set; }
    }
}

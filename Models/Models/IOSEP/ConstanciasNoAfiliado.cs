using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class ConstanciasNoAfiliado
    {
        public int ConstanciaNoAfiliadoId { get; set; }
        public int? IdAfiliado { get; set; }
        public string DniSolicitante { get; set; } = null!;
        public string NombreApellidoSolicitante { get; set; } = null!;
        public string DniNoAfiliado { get; set; } = null!;
        public string NombreNoAfiliado { get; set; } = null!;
        public int Clase { get; set; }
        public DateTime FechaConstancia { get; set; }
        public DateTime FechaVenceConstancia { get; set; }
        public string OperCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulada { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class UsoSupervisor
    {
        public int IdUsoSupervisor { get; set; }
        public string Supervisor { get; set; } = null!;
        public string UsuarioSolicita { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public int Motivo { get; set; }
        public string Origen { get; set; } = null!;
        public bool Exito { get; set; }
        public bool Anulado { get; set; }
    }
}

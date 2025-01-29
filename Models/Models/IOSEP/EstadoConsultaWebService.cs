using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EstadoConsultaWebService
    {
        public int IdEstadoConsulta { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

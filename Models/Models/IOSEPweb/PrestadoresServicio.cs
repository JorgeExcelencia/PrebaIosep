using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class PrestadoresServicio
    {
        public int PrestadoresServiciosId { get; set; }
        public int PrestadorId { get; set; }
        public int ServicioId { get; set; }
        public bool Anulado { get; set; }

        public virtual Servicio Servicio { get; set; } = null!;
    }
}

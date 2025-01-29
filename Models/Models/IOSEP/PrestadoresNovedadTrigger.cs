using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadoresNovedadTrigger
    {
        public int IdPrestadorNovedad { get; set; }
        public int IdPrestador { get; set; }
        public int? IdPrestadorDDJJ { get; set; }
        public string Matricula { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CUIL { get; set; } = null!;
        public string? Domicilio { get; set; }
        public string? TelefonoFijo { get; set; }
        public DateTime FechaCrea { get; set; }
    }
}

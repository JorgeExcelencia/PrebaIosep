using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorEspecialidadDDJJ
    {
        public int PrestadorEspecialidadDDJJID { get; set; }
        public int PrestadorDDJJID { get; set; }
        public int EspecialidadDDJJID { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string MatriculaEspecialidad { get; set; } = null!;
        public string? NroExpediente { get; set; }

        public virtual EspecialidadDDJJ EspecialidadDDJJ { get; set; } = null!;
        public virtual PrestadorDDJJ PrestadorDDJJ { get; set; } = null!;
    }
}

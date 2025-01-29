using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vacunas_Paciente
    {
        public int VacunasID { get; set; }
        public int? VacunaID { get; set; }
        public int PacienteID { get; set; }
        public DateTime? FechaAplica { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime Creado { get; set; }
        public string? UsuarioModifica { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Anulado { get; set; }
        public int? CentrosVacunacionID { get; set; }
        public string? NLote { get; set; }

        public virtual Vacuna? Vacuna { get; set; }
    }
}

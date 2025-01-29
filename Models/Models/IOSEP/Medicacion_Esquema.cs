using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Medicacion_Esquema
    {
        public int IdMedicacionEsquema { get; set; }
        public int IdEsquema { get; set; }
        public int NuevaDro { get; set; }
        public string? Observaciones { get; set; }
        public string? Resolucion { get; set; }
        public string? Ref_Resolucion { get; set; }
        public string? NroExpediente { get; set; }
        public string? Ref_Expediente { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Vencimiento { get; set; }
        public string? CreaOperador { get; set; }
        public DateTime? CreaFecha { get; set; }
        public string? Modifica { get; set; }
        public DateTime? ModificaFecha { get; set; }
        public bool Anulado { get; set; }

        public virtual Esquemas_Afiliado IdEsquemaNavigation { get; set; } = null!;
    }
}

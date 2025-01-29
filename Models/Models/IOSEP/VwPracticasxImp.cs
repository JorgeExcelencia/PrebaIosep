using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwPracticasxImp
    {
        public DateTime? Fecha { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte? Cantidad { get; set; }
        public byte TipoAutorizacion { get; set; }
        public byte? TipoId { get; set; }
        public int IdAutoriza { get; set; }
        public string Numero { get; set; } = null!;
        public string? Motivo { get; set; }
        public string? Autorizacion { get; set; }
        public short SeImprimio { get; set; }
        public bool Anulada { get; set; }
        public int? iddetipo { get; set; }
        public int IdHistoria { get; set; }
        public byte EstadoAnulada { get; set; }
        public int IdClinica { get; set; }
        public int idnomenclador { get; set; }
        public string codigo { get; set; } = null!;
        public string Practica { get; set; } = null!;
    }
}

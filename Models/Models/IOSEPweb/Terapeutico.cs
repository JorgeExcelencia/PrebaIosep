using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Terapeutico
    {
        public Terapeutico()
        {
            TerapeuticoMedicacions = new HashSet<TerapeuticoMedicacion>();
        }

        public int TerapeuticoId { get; set; }
        public int IdAfiliado { get; set; }
        public DateTime FechaVigencia { get; set; }
        public decimal Peso { get; set; }
        public string Telefono { get; set; } = null!;
        public int MedicoId { get; set; }
        public string? Patologia { get; set; }
        public string? Antecedentes { get; set; }
        public string? Examenes { get; set; }
        public int DiagnosticoId1 { get; set; }
        public int? DiagnosticoId2 { get; set; }
        public DateTime? Creada { get; set; }
        public string? OpCrea { get; set; }
        public DateTime? Modifica { get; set; }
        public string? OpModifica { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<TerapeuticoMedicacion> TerapeuticoMedicacions { get; set; }
    }
}

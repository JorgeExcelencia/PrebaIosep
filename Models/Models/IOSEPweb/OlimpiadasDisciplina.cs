using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class OlimpiadasDisciplina
    {
        public OlimpiadasDisciplina()
        {
            OlimpiadasDetalleMovimientos = new HashSet<OlimpiadasDetalleMovimiento>();
        }

        public int DisciplinaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Avatar { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<OlimpiadasDetalleMovimiento> OlimpiadasDetalleMovimientos { get; set; }
    }
}

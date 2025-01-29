using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncMovLog
    {
        public int MovLogId { get; set; }
        public int TipoMovLogId { get; set; }
        public int TipoMovLogAccionId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Tabla { get; set; } = null!;
        public int Id { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string? FieldType { get; set; }
        public string? Comentario { get; set; }
        public bool Anulado { get; set; }
        public string? FieldName { get; set; }

        public virtual IncTipoMovLog TipoMovLog { get; set; } = null!;
        public virtual IncTipoMovLogAccion TipoMovLogAccion { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Carrera_Inscripcion
    {
        public int Id { get; set; }
        public short IdCategoria { get; set; }
        public int IdAfiliado { get; set; }
        public string? Cuil { get; set; }
        public string? Nombre { get; set; }
        public DateTime? FecNac { get; set; }
        public int IdFamilia { get; set; }
        public string Email { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public int Numero { get; set; }
        public DateTime FechaPreInscripcion { get; set; }
        public DateTime? FechaEntregaKits { get; set; }
        public bool Anulado { get; set; }

        public virtual Categoria_Aerobica IdCategoriaNavigation { get; set; } = null!;
    }
}

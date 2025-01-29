using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CartaPresentacionGrupoFliar
    {
        public int CartaPresGrupoFliarID { get; set; }
        public int CartaPresentacionID { get; set; }
        public int IdAfiliado { get; set; }
        public DateTime FechaCarga { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public bool Anulado { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
    }
}

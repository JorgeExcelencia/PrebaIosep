using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CartaPresentacion
    {
        public int CartaPresentacionID { get; set; }
        public int IdAfiliado { get; set; }
        public int IdPlan { get; set; }
        public DateTime FechaCarga { get; set; }
        public string UsuarioCarga { get; set; } = null!;
        public bool Anulado { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? UsuarioAnula { get; set; }
        public int? MotivoId { get; set; }
        public string? MotivoAnula { get; set; }
    }
}

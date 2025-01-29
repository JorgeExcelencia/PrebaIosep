using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EncabezadoNotaDeCredito
    {
        public EncabezadoNotaDeCredito()
        {
            DetalleNotaDeCreditos = new HashSet<DetalleNotaDeCredito>();
            ReajusteCreditos = new HashSet<ReajusteCredito>();
        }

        public int EncabezadoNotaDeCreditoID { get; set; }
        public int IdAfiliado { get; set; }
        public int NumeroCredito { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; } = null!;
        public string? OperadorAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<DetalleNotaDeCredito> DetalleNotaDeCreditos { get; set; }
        public virtual ICollection<ReajusteCredito> ReajusteCreditos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte
{
    [Keyless]
    public class DetalleMovimiento
    {
        public int? IdComprobante { get; set; }
        public string? Numero { get; set; }
        public string? Detalle { get; set; }
        public Decimal Saldo { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Periodo { get; set; }
    }
}

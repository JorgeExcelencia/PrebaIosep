using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte
{
    [Table("ComprobanteLog", Schema = "iosepsalud")]
    public class ComprobanteLog
    {
        [Key]
        public int IdLog { get; set; }
        public int IdComprobante { get; set; }
        public string Operador { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string? Operacion { get; set; } = string.Empty;
        public virtual Comprobante Comprobante { get; set; } = new();
    }
}

using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Models.StoreProcedures
{
    [Keyless]
    public class NotaCreditoEmpresa
    {
        public int IdComprobante { get; set; }
        public decimal Importe { get; set; }
        public string Periodo { get; set; } = null!;
        public string Comprobante { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string TipoComprobante { get; set; } = null!;
        public int IdAfiliado { get; set; }
        public string CodBarra { get; set; } = null!;
        public bool ProntoPago { get; set; }
        public decimal Descuento { get; set; }
        public int Pagado { get; set; }
    }
}

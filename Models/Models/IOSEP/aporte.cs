using System.ComponentModel.DataAnnotations;

namespace ApiIosep.Models.IOSEP
{
    public partial class aporte
    { 
        public int AportesID { get; set; }
        public int LugarPagoID { get; set; }
        public int IdAfiliado { get; set; }
        public string Periodo { get; set; } = null!;
        public string? CodigoDescuento { get; set; }
        public decimal? Haberes { get; set; }
        public decimal? Importe_Descontado { get; set; }
        public bool? Contratado { get; set; }
        public byte? Cantidad_Adicionales { get; set; }
        public string? Planta { get; set; }
        public bool Anulado { get; set; }

        public virtual Tipo_DescuentoAporte? CodigoDescuentoNavigation { get; set; }
        public virtual Afiliado IdAfiliadoNavigation { get; set; } = null!;
        public virtual Tipo_LugarPago LugarPago { get; set; } = null!;
    }
}

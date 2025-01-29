using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public partial class CreditosPagosCredito
    {
        [Key]
        public int IdPago { get; set; }  // Llave primaria

        public int? IdCreditoDetalle { get; set; }   

        public DateTime? FechaPago { get; set; }   

        public int? IdDetalleFactura { get; set; }  

        public bool Anulado { get; set; }   
    }
}

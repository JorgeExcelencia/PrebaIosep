using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public class CreditosFichacta
    {
        [Key]
        public int IdFichacta { get; set; }
        [StringLength(6)]
        public string Periodo { get; set; } 
        [StringLength(7)]
        public string IdAfiliado { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        [StringLength(1)]
        public string TipoDNI { get; set; }
        [StringLength(8)]
        public string DNI { get; set; }
        [StringLength(11)]
        public string NumBeneficiario { get; set; }
        [StringLength(5)]
        public string LugarPago { get; set; }
        [StringLength(2)]
        public string Estado { get; set; }
        [StringLength(3)]
        public string CodigoCredito { get; set; }
        [StringLength(1)]
        public string SubCodigo { get; set; }
        [StringLength(6)]
        public string NroCredito { get; set; }
        [StringLength(3)]
        public string Cuotas { get; set; }
        [StringLength(3)]
        public string CuotasPendientes { get; set; }
        [StringLength(8)]
        public string Fecha { get; set; }
        [StringLength(9)]
        public decimal ImporteCuota { get; set; } 
        public decimal PagoAcumulado { get; set; } 
        public string MontoCredito { get; set; }
        public bool Anulado { get; set; }
        public bool LoteCargado { get; set; }
    }
}

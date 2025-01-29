namespace Models.Models.DTOs.CreditosDTO
{
    public class CreditosFichactaDTO
    { 
        public int IdFichacta { get; set; } 
        public string Periodo { get; set; } 
        public string IdAfiliado { get; set; } 
        public string Nombre { get; set; } 
        public string TipoDNI { get; set; } 
        public string DNI { get; set; } 
        public string NumBeneficiario { get; set; } 
        public string LugarPago { get; set; } 
        public string Estado { get; set; } 
        public string CodigoCredito { get; set; } 
        public string SubCodigo { get; set; } 
        public string NroCredito { get; set; } 
        public string Cuotas { get; set; } 
        public string CuotasPendientes { get; set; } 
        public string Fecha { get; set; } 
        public decimal ImporteCuota { get; set; }
        public decimal PagoAcumulado { get; set; }
        public string MontoCredito { get; set; }
        public bool Anulado { get; set; }
        public bool LoteCargado { get; set; }
    }
}

namespace Models.Models.Creditos.Respuesta
{
    public class CreditosDetalleParameter
    {
        public int IdCredito { get; set; } = 0;

        public int IdLote { get; set; } = 0;

        public int IdAfiliado { get; set; } = 0;

        public string Subcodigo { get; set; } = string.Empty;

        public string NroCredito { get; set; } = string.Empty;

        public string CodMovimiento { get; set; } = string.Empty;

        public int CantidadCuotas { get; set; } = 0;

        public decimal ImporteCuota { get; set; } = 0;

        public decimal Saldo { get; set; } = 0;

        public virtual CreditosLotes? CreditosLote { get; set; }

        public int IdDetalleCredito { get; internal set; } = 0;

        public int IdTipoDetalle { get; set; } = 0;

        public int IdDetalle { get; set; } = 0;
    }
}

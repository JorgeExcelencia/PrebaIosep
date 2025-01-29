namespace Models.Models.Creditos
{
    public class CreditosReporteCoseguroOrden
    {
        public int IdAfiliadoTitular { get; set; }
        public string? Numero { get; set; }
        public string? Nombre { get; set; }
        public string? Cuil { get; set; }
        public string? NumeroAfiliado { get; set; }
        public string? TipoFamiliar { get; set; }
        public string? Titular { get; set; }
        public string? CuilTitular { get; set; }
        public string? Plan { get; set; }
        public string? TipoOrden { get; set; }
        public decimal Importe { get; set; }
        public decimal Coseguro { get; set; }
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
        public string? CodigoPago { get; set; }
        public string? LugarPago { get; set; }
        public string? NumeroBeneficio { get; set; }
    }
}

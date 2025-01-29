namespace Models.Models.Creditos
{
    public class CreditoExtraJudicial
    {
        public int IdExtraJudicial { get; set; }
        public int IdCredito { get; set; } = 0;
        public int IdAfiliado { get; set; } = 0;
        public DateTime? FechaCrea { get; set; } // Fecha de creación (nullable)
        public bool Anulado { get; set; } = false;
    }
}

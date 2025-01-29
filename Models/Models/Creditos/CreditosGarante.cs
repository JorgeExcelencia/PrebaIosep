namespace Models.Models.Creditos
{
    public class CreditosGarante
    {
        public int IdGarante { get; set; }

        public int IdAfiliadoGarante { get; set; } = 0;

        public int IdAfiliadoDeudor { get; set; } = 0;

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaAnula { get; set; }

        public bool Anulado { get; set; } = false;

        public string OperadorCrea { get; set; } = string.Empty;
    }
} 
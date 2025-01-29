namespace Models.Models.Creditos
{
    public class CreditosMotivoCancelado
    {
        public int idMotivoCancelado { get; set; }
        public string descripcionMotivo { get; set; } = string.Empty;
        public int idCredito { get; set; } = 0;
        public int idMotivo { get; set; } = 0;
        public bool Anulado { get; set; } = false;
    }
}

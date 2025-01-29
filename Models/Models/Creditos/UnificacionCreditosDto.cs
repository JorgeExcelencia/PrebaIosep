namespace Models.Models.Creditos
{
    public class UnificacionCreditosDto
    {
        public List<CreditosCreditoDTO> Creditos { get; set; }

        public UnificacionCreditosDto()
        {
            Creditos = new List<CreditosCreditoDTO>();
        }
    }
}

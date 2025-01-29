namespace ApiIosep.Models.DTOs.NotaCredito
{
    public class NtcreditoDTO
    {
        public string Cuit { get; set; }
        public string Observacion { get; set; }
        public List<ComprobanteNotaCredito> comprobantesNotaCredito { get; set; }

    }
}

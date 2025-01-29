namespace ApiIosep.Models.DTOs.Autogestion
{
    public class BoletaDTO
    {
        public int idComprobante { get; set; }
        public string periodo {  get; set; }
        public string numero { get; set; }

        public string? detalle { get; set; }

        public decimal importe { get; set; }
        public int IdAfiliado { get; set; }
        public string? Email { get; set; }
        public string CodigoBarra { get; set; }
    }
}

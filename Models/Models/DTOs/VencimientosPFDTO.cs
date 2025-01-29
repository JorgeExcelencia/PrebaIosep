namespace ApiIosep.Models.DTOs
{
    public class VencimientosPFDTO
    {
    }

    public class VencimientosDTO
    {
        public DateTime? Vencimiento_1_Original { get; set; }
        public DateTime? Vencimiento_2_Original { get; set; }
    }
    public class VencimientoDTO
    {
        public DateTime Vencimiento_1 { get; set; }
        public DateTime? Vencimiento_2{ get; set; }
    }

    public class VencimientoPeriodoDTO
    {
        public DateTime Vencimiento_1 { get; set; }
        public DateTime? Vencimiento_2 { get; set; }
        public string? Renglon_1 { get; set; }
        public string? Renglon_2 { get; set; }
        public string? Renglon_3 { get; set; }
        public string? Lugar_de_pago1 { get; set; }
        public string? Lugar_de_pago2 { get; set; }
    }

}

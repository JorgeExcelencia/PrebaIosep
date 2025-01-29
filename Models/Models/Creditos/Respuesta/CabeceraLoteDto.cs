namespace Models.Models.Creditos.Respuesta
{
    public class CabeceraLoteDto
    {
        public string Identif { get; set; } = string.Empty;
        public string Nropaq { get; set; } = string.Empty;
        public string Credito { get; set; } = string.Empty;
        public string Mes { get; set; } = string.Empty;
        public string Anio { get; set; } = string.Empty;
        public string Cantdoc { get; set; } = string.Empty;
        public string Totimpcu { get; set; } = string.Empty;
        public string Cantotcu { get; set; } = string.Empty;
        public string Imptotcr { get; set; } = string.Empty;
        public List<DetalleLoteDto> detalleLote { get; set; }
    }
    public class DetalleLoteDto
    {
        public string Identif { get; set; } = string.Empty;
        public string Nropaq { get; set; } = string.Empty;
        public string Credito { get; set; } = string.Empty;
        public string Mes { get; set; } = string.Empty;
        public string Anio { get; set; } = string.Empty;
        public string Nroafil { get; set; } = string.Empty;
        public string Nrocred { get; set; } = string.Empty;
        public string Codmov { get; set; } = string.Empty;
        public string Dias { get; set; } = string.Empty;
        public string Cantcuot { get; set; } = string.Empty;
        public string Impcuota { get; set; } = string.Empty;
        public string Nroafil2 { get; set; } = string.Empty;
        public string Nrocred2 { get; set; } = string.Empty;
        public string Codmov2 { get; set; } = string.Empty;
        public string Dias2 { get; set; } = string.Empty;
        public string Cantcuot2 { get; set; } = string.Empty;
        public string Impcuota2 { get; set; } = string.Empty;
    }
}

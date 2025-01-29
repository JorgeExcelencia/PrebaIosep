
namespace Models.Models.Creditos
{
    public class CreditosAnexo
    {
        public int IdAnexo { get; set; }
        public string Control { get; set; } = string.Empty;
        public string LugarPago { get; set; } = string.Empty;
        public string Planta { get; set; } = string.Empty;
        public string Cuil { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public string Periodo { get; set; } = string.Empty;
        public decimal TotalHaber { get; set; }  
        public string CodigoCred { get; set; } = string.Empty;
        public decimal Importe { get; set; }  
        public bool Anulado { get; set; } = false;
        public bool EstadoImporte {  get; set; } = false;
    }
}

using System.ComponentModel.DataAnnotations;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Aporte
    {
        [Key]
        public int IdAporte { get; set; }
        public string? Control { get; set; }
        public string? LugarPago { get; set; }
        public string? Planta { get; set; }
        public string? ANumero { get; set; }
        public string? Cuil { get; set; }
        public string? Afiliado { get; set; }
        public string? Otro { get; set; }
        public string? NumeroBeneficio { get; set; }
        public string? Periodo { get; set; }
        public string? Codigo { get; set; }
        public decimal? Aporte1 { get; set; }
        public string? CodigoJubilado { get; set; }
        public decimal? HaberJubilado { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
    }
}

namespace ApiIosep.Models.DTOs.Afiliados
{
    public class AfiliadoLugarPago
    {
        public int IdAfiliadosLugarPago { get; set; }
        public int IdLugarPago { get; set; }
        public int IdAfiliado { get; set; }
        public string NumBeneficioAnses { get; set; } // nchar(13)
        public DateTime? FechaDesde { get; set; } // Nullable
        public DateTime? FechaHasta { get; set; } // Nullable
        public decimal? Sueldo { get; set; } // Nullable
        public decimal? Aporte { get; set; } // Nullable
        public decimal? Adicional { get; set; } // Nullable
        public int? IdSituacionLaboral { get; set; } // Nullable
        public string Observaciones { get; set; } // nchar(3000), Nullable
        public bool Anulado { get; set; }
    }
}

using ApiIosep.Models.IOSEP;
using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public partial class LugarPagoDdjj
    {
        [Key]
        public int IdLugarPagoDdjj { get; set; }
        public int IdLugarPago { get; set; }
        public int IdDdjj { get; set; }
        public string? NumBeneficioAnses { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int IdSituacionLaboral { get; set; }
        public decimal? Sueldo { get; set; }
        public decimal? Aporte { get; set; }
        public string? Observaciones { get; set; }
        public string OpCrea { get; set; } = null!;
        public DateTime? FechaCrea { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OpAnula { get; set; }
        public bool Anulado { get; set; }

        //public virtual AfiliadosDdjjbk IdDdjjNavigation { get; set; } = null!;
        public virtual Tipo_LugarPago IdLugarPagoNavigation { get; set; } = null!;
        public virtual TipoSituacionLaboral IdSituacionLaboralNavigation { get; set; } = null!;
    }
}

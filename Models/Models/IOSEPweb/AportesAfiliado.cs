using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AportesAfiliado
    {
        public int AportesAfiliadosId { get; set; }
        /// <summary>
        /// (Control/Jubilado)
        /// </summary>
        public string? NumeroBeneficio { get; set; }
        public string? ANumero { get; set; }
        public string? Codigo { get; set; }
        public string? Codigo2 { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Categoria { get; set; }
        public string Periodo { get; set; } = null!;
        public decimal? Aporte { get; set; }
        public string? CuentaAporte { get; set; }
        public int? LugarPagoId { get; set; }
        public string? CodigoJubilado { get; set; }
        public decimal? HaberJubilado { get; set; }
        public DateTime? FechaSubida { get; set; }
    }
}

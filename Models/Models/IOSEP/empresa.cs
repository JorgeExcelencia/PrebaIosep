using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class empresa
    {
        public empresa()
        {
            empresaLogs = new HashSet<empresaLog>();
            empresa_afiliados = new HashSet<empresa_afiliado>();
        }

        public int IdEmpresa { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Domicilio { get; set; }
        public string? Contacto { get; set; }
        public string? Telefono { get; set; }
        public string? Resolucion { get; set; }
        public decimal? CuotaFija { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public DateTime? Renovar { get; set; }
        public string? Cuit { get; set; }
        public int? IdLocalidad { get; set; }
        public bool? Contratados { get; set; }
        public decimal? ProntoPagoDescuento { get; set; }
        public decimal? ProntoPagoImporte { get; set; }
        public bool ValorFijo { get; set; }
        public bool ContratoIndividual { get; set; }
        public string? Tipo { get; set; }
        public string PeriodoFacturado { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<empresaLog> empresaLogs { get; set; }
        public virtual ICollection<empresa_afiliado> empresa_afiliados { get; set; }
    }
}

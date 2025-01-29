using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Empresas_IosepSalud
    {
        public Empresas_IosepSalud()
        {
            EmpresasAfiliadosDDJJs = new HashSet<EmpresasAfiliadosDDJJ>();
        }

        public int IdEmpresa { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Domicilio { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Resolucion { get; set; } = null!;
        public decimal cuota_afiliado { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public DateTime renovar_el { get; set; }
        public bool Anulado { get; set; }
        public string CUIT { get; set; } = null!;
        public byte idprovincia { get; set; }
        public int idlocalidad { get; set; }
        public bool? Contratados { get; set; }
        public string? codigopostal { get; set; }
        public string? localidad { get; set; }
        public decimal? descuento_prontopago { get; set; }
        public decimal? importe_prontopago { get; set; }
        public string? OperCarga { get; set; }
        public DateTime? FechaCarga { get; set; }
        public string? OperModif { get; set; }
        public DateTime? FechaModif { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public bool ValorFijo { get; set; }
        public bool ContratoIndividual { get; set; }
        public string? Tipo { get; set; }

        public virtual ICollection<EmpresasAfiliadosDDJJ> EmpresasAfiliadosDDJJs { get; set; }
    }
}

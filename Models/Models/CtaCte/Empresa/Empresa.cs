using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiIosep.Models.CtaCte.Empresa
{
    [Table("Empresa", Schema = "iosepsalud")]
    public class Empresa
    {
        public Empresa()
        {
            Empresa_Afiliado = new HashSet<Empresa_Afiliado>();
            EmpresaLog = new HashSet<EmpresaLog>();
        }

        [Key]
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Domicilio { get; set; }
        public string? Contacto { get; set; }
        public string? Telefono { get; set; }
        public string? Resolucion { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? CuotaFija { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public DateTime? Renovar { get; set; }
        public string? Cuit { get; set; } = string.Empty;
        public int? IdLocalidad { get; set; }
        public bool? Contratados { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ProntoPagoDescuento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ProntoPagoImporte { get; set; }
        public bool ValorFijo { get; set; }
        public bool ContratoIndividual { get; set; }
        public string? Tipo { get; set; }
        public string PeriodoFacturado { get; set; } = string.Empty;
        public bool Anulado { get; set; }

        [JsonIgnore]
        public virtual ICollection<Empresa_Afiliado> Empresa_Afiliado { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<EmpresaLog> EmpresaLog { get; set; }
    }
}

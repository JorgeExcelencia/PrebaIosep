using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte.Empresa
{
    [Table("Empresa_Afiliado", Schema = "iosepsalud")]
    public class Empresa_Afiliado
    {

        [Key]
        public int ID { get; set; }
        public int IdEmpresa { get; set; }
        public int IdAfiliado { get; set; }
        public bool EsTitular { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CuotaAfiliado { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string? Motivo { get; set; } = string.Empty;
        public bool Anulado { get; set; }

        public virtual Empresa Empresa { get; set; } = new();
    }
}

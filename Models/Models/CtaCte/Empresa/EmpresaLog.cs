using System.ComponentModel.DataAnnotations;

namespace ApiIosep.Models.CtaCte.Empresa
{
    public class EmpresaLog
    {
        [Key]
        public int IdEmpresaLog { get; set; }
        public int IdEmpresa { get; set; }
        public int? IdEmpAfi { get; set; }
        public string Operador { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string? Operacion { get; set; } = string.Empty;
        public virtual Empresa Empresa { get; set; } = new();
    }
}

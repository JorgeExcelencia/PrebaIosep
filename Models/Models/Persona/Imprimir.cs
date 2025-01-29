using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.Persona
{
    [Table("Imprimir", Schema = "usuario")]
    public class Imprimir
    {
        [Key]
        public long IdImprimir { get; set; }
        public DateTime Fecha { get; set; }
        public string JSON { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public DateTime? Impreso { get; set; }
        public string? Estado { get; set; }
    }
}

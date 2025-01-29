using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.Persona.Geo
{
    [Table("Localidades", Schema = "dbo")]
    public class LocalidadDB
    {
        [Key]
        public int IdLocalidad { get; set; }
        public int IdProvincia { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public bool Anulado { get; set; }

        public virtual Provincias Provincia { get; set; } = new();
    }
}

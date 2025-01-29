using ApiIosep.Models.CtaCte;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiIosep.Models.Persona.Geo
{
    [Table("Provincias", Schema = "dbo")]
    public class Provincias
    {
        public Provincias()
        {
            Localidades = new HashSet<LocalidadDB>();
        }

        [Key]
        public int IdProvincia { get; set; }
        public int IdPais { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Anulado { get; set; }

        [JsonIgnore]
        public virtual ICollection<LocalidadDB> Localidades { get; set; }
        public virtual Paises Pais { get; set; } = new();
    }
}

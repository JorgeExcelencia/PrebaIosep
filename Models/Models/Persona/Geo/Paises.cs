using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiIosep.Models.Persona.Geo
{
    [Table("Paises", Schema = "dbo")]
    public class Paises
    {
        public Paises()
        {
            Provincia = new HashSet<Provincias>();
        }

        [Key]
        public int IdPais { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? Nacionalidad { get; set; }
        public bool Anulado { get; set; }

        public string? Code { get; set; }

        [JsonIgnore]
        public virtual ICollection<Provincias> Provincia { get; set; }
    }
}

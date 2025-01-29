using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiIosep.Models.Persona
{
    public class TipoFamiliar
    {
        public TipoFamiliar ()
        {
            Afiliados = new HashSet<Afiliados>();
        }

        [Key]
        public byte IdTipoFamiliar { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Codigo_Anses { get; set; }
        public bool ConVencimiento { get; set; }
        public string? Compatible { get; set; }
        public bool? Iosep { get; set; }
        public bool? IosepSalud { get; set; }
        public bool Anulado { get; set; }

        [JsonIgnore]
        public virtual ICollection<Afiliados> Afiliados { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiIosep.Models.Persona
{
    public partial class Sexo
    {
        public Sexo()
        {
            Afiliados = new HashSet<Afiliados>();
        }

        [Key]
        public byte IdSexo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        public bool Anulado { get; set; }

        [JsonIgnore]
        public virtual ICollection<Afiliados> Afiliados { get; set; }
    }
}

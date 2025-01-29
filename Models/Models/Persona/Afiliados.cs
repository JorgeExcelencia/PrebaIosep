using System.ComponentModel.DataAnnotations;

namespace ApiIosep.Models.Persona
{
    public class Afiliados
    {
        public Afiliados()
        {

        }

        [Key]
        public int IdAfiliado { get; set; }

        [Required]
        [StringLength(11)]
        public string Cuil { get; set; } = String.Empty;

        [Required]
        [StringLength(11)]
        public string CuilTitular { get; set; } = String.Empty;

        public byte IdTipoDocumento { get; set; }

        [Required]
        [StringLength(8)]
        public string Documento { get; set; } = String.Empty;

        [StringLength(30)]
        public string? ApellidoMaterno { get; set; }

        [StringLength(30)]
        public string? ApellidoPaterno { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = String.Empty;

        [StringLength(15)]
        public string? A_Numero { get; set; } = String.Empty;

        public Int16 IdMotivoBaja { get; set; }

        public bool IosepSalud { get; set; }

        public byte IdSexo { get; set; }

        public byte IdTipoFamiliar { get; set; }

        public virtual Sexo Sexo { get; set; } = new ();
        public virtual TipoFamiliar TipoFamiliar { get; set; } = new();
    }
}

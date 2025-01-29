using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.IOSEPweb
{
    public class RefreshToken
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Token { get; set; } = string.Empty;

        public DateTime Expiracion { get; set; }
        public bool IsExpired => DateTime.UtcNow >= Expiracion;

        public DateTime Creado { get; set; }
        public string CreadoPor { get; set; } = string.Empty;

        public DateTime? Utilizado { get; set; }
        public string? UtilizadoPor { get; set; }
        public string RemplazadoPorToken { get; set; } = string.Empty;
        public bool IsActive => Utilizado == null && !IsExpired;

    }
}

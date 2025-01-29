using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models.Creditos
{
    public class CreditosSalarioAfiliado
    {
        [Key]
        public int IdSalario { get; set; }
        public int IdAfiliado { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; } = new DateTime(1900, 01, 01);
        public decimal Monto { get; set; }
        public DateTime FechaCrea { get; set; } = new DateTime(1900, 01, 01);
        
        [MaxLength(8)]
        public string NroControl { get; set; } = string.Empty;
        
        [MaxLength(10)]
        public string IDLugarDePago { get; set; } = string.Empty;
         
        [MaxLength(2)]
        public string Antiguedad { get; set; } = string.Empty;
         
        [Column(TypeName = "decimal(18, 2)")]
        public decimal HaberConAportes { get; set; } = 0.00M;
         
        [Column(TypeName = "decimal(18, 2)")]
        public decimal HaberSinAportes { get; set; } = 0.00M;
         
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalDescuentos { get; set; } = 0.00M;
         
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Liquido { get; set; } = 0.00M;
         
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MaximoDescuento { get; set; } = 0.00M;
        [MaxLength(11)]
        public string UsuarioCrea { get; set; } = string.Empty;
        public bool Anulado { get; set; } = false;
        public DateTime FechaAnula { get; set; } = new DateTime(1900, 01, 01);
        [MaxLength(11)]
        public string UsuarioAnula { get; set; } = string.Empty;
    }
}

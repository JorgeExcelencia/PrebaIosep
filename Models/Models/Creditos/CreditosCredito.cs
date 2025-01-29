using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public class CreditosCredito
    {
        [Key]
        public int IdCredito { get; set; }
        public int Cuotas { get; set; } = 0;
        public decimal ImporteTotal { get; set; } = 0;

        [Required]
        [StringLength(50)]
        public string Denomina { get; set; } = string.Empty;
        public string CodigoCredito { get; set; } = string.Empty;
        public int IdAfiliado { get; set; } = 0;
        public int IdLote { get; set; } = 0;
        public int? FormaPago { get; set; } = 0;
        public DateTime FechaCrea { get; set; } = new DateTime(1900, 1, 1);
        public bool Anulado { get; set; } = false;
        public bool Cancelado { get; set; } = false;
        public string NroCreditoMigracion { get; set; } = string.Empty;

    }
}

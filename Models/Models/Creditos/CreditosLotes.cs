using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos
{
    public partial class CreditosLotes
    {
        [Key]
        public int IdLote { get; set; }

        [MaxLength(50)]
        public string Descripcion { get; set; } = string.Empty.ToString();

        public string? PeriodoProcesamiento { get; set; }

        [MaxLength(11)]
        public string OperadorCrea { get; set; } = string.Empty.ToString();

        public bool Anulado { get; set; } = false;
    }
}

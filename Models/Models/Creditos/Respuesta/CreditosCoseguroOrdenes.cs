using System.ComponentModel.DataAnnotations;

namespace Models.Models.Creditos.Respuesta
{
    public class CreditosCoseguroOrdenes
    {
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaDesde { get; set; } = default(DateTime);

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaHasta { get; set; } = default(DateTime);
        public int TipoOrden { get; set; } = 0;
        public List<int> IdPrestadores { get; set; } = new List<int>();
        public bool Detalle { get; set; } = false;
        public int IdAfiliado { get; set; } = 0;
    }
}

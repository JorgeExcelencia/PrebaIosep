using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte.MovDet
{
    [Keyless]
    public class imprimir_ctacteVW
    {
        public int IdCtaCteIosep { get; set; }
        public string Fecha_Emision { get; set; } = String.Empty;
        public string Numero_Comprobante { get; set; } = String.Empty;
        public string CodigoBarra { get; set; } = String.Empty;
        public string Periodo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Importe_Total { get; set; }
        public string Cantidad_Cuotas { get; set; } = String.Empty;
        public string Cuil_Titular { get; set; } = String.Empty;
        public string A_Numero { get; set; } = String.Empty;
        public string Nombre { get; set; } = String.Empty;
        public string Tipo_Detalle { get; set; } = String.Empty;

        public string? DetalleFactura { get; set; } = String.Empty;
        public string DomicilioCompleto { get; set; } = String.Empty;
        public string Localidad { get; set; } = String.Empty;
        public string Obs1 { get; set; } = String.Empty;
        public string Obs2 { get; set; } = String.Empty;
        public string Obs3 { get; set; } = String.Empty;
        public string Lugar1 { get; set; } = String.Empty;
        public string Lugar2 { get; set; } = String.Empty;
        public string FecVen1 { get; set; } = String.Empty;
        public string FecVen2 { get; set; } = String.Empty;
        public string CodPostal { get; set; } = String.Empty;
        public string BarCode { get; set; } = String.Empty;
        public string TipoHoja { get; set; } = String.Empty;
        public string Cantidad { get; set; } = String.Empty;
    }
}

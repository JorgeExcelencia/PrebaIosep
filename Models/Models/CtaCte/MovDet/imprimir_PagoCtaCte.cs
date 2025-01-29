using ApiIosep.Models.IOSEPweb;
using ApiIosep.Models.Persona.Geo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte.MovDet
{
    [Keyless]
    public class imprimir_PagoCtaCte
    {
        public int IdCtaCteIosep { get; set; }
        public  DateTime Fecha_Emision { get; set; }
        public string Numero_Comprobante { get; set; } = string.Empty;
        public string CodigoBarra{ get; set; } = string.Empty;
        public string Periodo { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Importe_Total { get; set; } 
        public string Cantidad_Afiliados { get; set; } = string.Empty;
        public string CuilTitular { get; set; } = string.Empty;
        public string A_Numero { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Tipo_Detalle { get; set; } = string.Empty;
        public string DomicilioCompleto { get; set; } = string.Empty;
        public string Localidad { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public string DetalleFactura { get; set; } = string.Empty;
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte.Empresa
{

    public class EmpresaDetalleVW
    {
        public int idCtaCteIosep { get; set; }
        public string Periodo { get; set; }
        public string? Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public string Imputado { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Debe { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Haber { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Saldo { get; set; }
        public string idPagoClinica { get; set; }
        public string Numero { get; set; }

        public byte Iddetalle { get; set; }


    }
}

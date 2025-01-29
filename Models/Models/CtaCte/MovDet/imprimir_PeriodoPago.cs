using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte.MovDet
{
    [Keyless]
    public class imprimir_PeriodoPago
    {
        public string CodEmpresa { get; set; } = String.Empty;
        public string Empresa { get; set; } = String.Empty;
        public string Cuil { get; set; } = String.Empty;
        public string CuilTitular { get; set; } = String.Empty;
        public string A_Numero { get; set; } = String.Empty;
        public string Nombre { get; set; } = String.Empty;
        public decimal ValorCuota { get; set; }
        public int Edad { get; set; } 
        public int idEstado { get; set; }
        public string Estado { get; set; } = String.Empty;
        public string Sexo { get; set; } = String.Empty;
        public int IdFliar { get; set; }
        public string Fliar { get; set; } = String.Empty;
        public decimal Deuda { get; set; } 
       
    }
}

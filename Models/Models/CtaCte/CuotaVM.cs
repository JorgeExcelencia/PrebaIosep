using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiIosep.Models.CtaCte
{
    [Keyless]
    public class CuotaVM
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorCuota { get; set; }
        public Byte CantidadFamiliares { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class RedLink_ArchivoExtractDetalle
    {
        public int ExtractDetalleID { get; set; }
        public int ExtractID { get; set; }
        public string TipoRegistro { get; set; } = null!;
        public string IdentificadorDeuda { get; set; } = null!;
        public string IdentificadorConcepto { get; set; } = null!;
        public string IdentificadorUsuario { get; set; } = null!;
        public decimal ImportePagado { get; set; }
        public string FechaPago { get; set; } = null!;
        public string Discrecional { get; set; } = null!;
    }
}

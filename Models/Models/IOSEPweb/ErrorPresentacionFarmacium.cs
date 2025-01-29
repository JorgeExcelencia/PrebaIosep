using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class ErrorPresentacionFarmacium
    {
        public int ErrorId { get; set; }
        public int EncabezadoId { get; set; }
        public int? Nroreg { get; set; }
        public string? Periodo { get; set; }
        public string? Ciuinstritucion { get; set; }
        public string? CiuFarmacia { get; set; }
        public string? Mensaje { get; set; }
        public decimal? Debitado { get; set; }
        public decimal? Presentado { get; set; }
        public string? NumeroOrden { get; set; }
        public int? IdTipoDebito { get; set; }
    }
}

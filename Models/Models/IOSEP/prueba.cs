using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class prueba
    {
        public int id { get; set; }
        /// <summary>
        /// Descripción por Leonardo Illanez
        /// </summary>
        public string? nombre { get; set; }
        public bool? anulado { get; set; }
        public decimal? importe { get; set; }
        public DateTime? fecha { get; set; }
        public DateTime? fechahora { get; set; }
        public string? memo { get; set; }
        public int _int { get; set; }
        public byte? tyniint { get; set; }
        public short? smallint { get; set; }
        public decimal? money { get; set; }
        public byte[]? general { get; set; }
    }
}

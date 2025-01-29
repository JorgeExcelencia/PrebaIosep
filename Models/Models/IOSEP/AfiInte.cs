using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiInte
    {
        public int AfiInteID { get; set; }
        public string? O_SOCIAL { get; set; }
        public string? A_NUMERO { get; set; }
        public string? FAMILIAR { get; set; }
        public byte? CONTROL { get; set; }
        public string? NOMBRE { get; set; }
        public string? PROT_SUC { get; set; }
        public string? PROT_NRO { get; set; }
        public DateTime? I_FECHA { get; set; }
        public DateTime? E_FECHA { get; set; }
        public int? CANTIDAD { get; set; }
        public DateTime? OP_FECHA { get; set; }
        public string? OPERADOR { get; set; }
        public string? HORA_CARGA { get; set; }
        public byte? I_TIPO { get; set; }
        public string? I_CAUSA { get; set; }
        public string? E_CAUSA { get; set; }
        public string? DIAGNOSTIC { get; set; }
        public string? PLAN { get; set; }
        public string? EMPRESA { get; set; }
        public string? PRESCRIBE { get; set; }
        public string? INSTITUCIO { get; set; }
        public string? EFECTOR { get; set; }
        public string? OBS { get; set; }
        public bool? ESTADO { get; set; }
        public byte? DIAS { get; set; }
        public bool? REMISOS { get; set; }
        public bool? INF_FINAL { get; set; }
        public DateTime? FECHA_FIN { get; set; }
        public string? HORA_FIN { get; set; }
        public string? OPERA_FIN { get; set; }
    }
}

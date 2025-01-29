using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class I_AutoriDbf
    {
        public long IdI_AutoriDbf { get; set; }
        public string? O_SOCIAL { get; set; }
        public string? A_NUMERO { get; set; }
        public string? FAMILIAR { get; set; }
        public string? PRESCRIBE { get; set; }
        public string? DIAGNOSTIC { get; set; }
        public string? NOMENCLADO { get; set; }
        public string? T_PRESTAC { get; set; }
        public string? P_CODIGO { get; set; }
        public string? OBS { get; set; }
        public DateTime? FECHA { get; set; }
        public string? I_CAUSA { get; set; }
        public string? NUMERO { get; set; }
        public DateTime? E_FECHA { get; set; }
        public string? E_CAUSA { get; set; }
        public int? I_TIPO { get; set; }
        public string? OPERADOR { get; set; }
        public string? HORA_CARGA { get; set; }
        public string? TIP_AUT { get; set; }
        public string? SUC_AUT { get; set; }
        public string? NRO_AUT { get; set; }
        public int? ITEM_AUT { get; set; }
        public int? CANTIDAD { get; set; }
        public decimal? TOTAL { get; set; }
        public decimal? AFICAR { get; set; }
        public decimal? HONORARIO { get; set; }
        public decimal? GASTOS { get; set; }
        public decimal? COSEG_H { get; set; }
        public decimal? COSEG_G { get; set; }
        public int? PORCEN { get; set; }
        public int? PORCENG { get; set; }
        public int? Recno { get; set; }
    }
}

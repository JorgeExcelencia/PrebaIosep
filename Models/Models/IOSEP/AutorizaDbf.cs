using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AutorizaDbf
    {
        public long IdAutorizaDbf { get; set; }
        public string? Tip_Aut { get; set; }
        public string? Suc_Aut { get; set; }
        public string? Nro_Aut { get; set; }
        public byte? Item_Aut { get; set; }
        public string? O_social { get; set; }
        public string? A_Numero { get; set; }
        public string? Familiar { get; set; }
        public string? Prescribe { get; set; }
        public string? Efector { get; set; }
        public string? Diagnostico { get; set; }
        public string? Nomenclado { get; set; }
        public bool? T_Arancel { get; set; }
        public string? Lp_su { get; set; }
        public string? t_Prestac { get; set; }
        public string? p_codigo { get; set; }
        public byte? Cantidad { get; set; }
        public DateTime? Fecha_e { get; set; }
        public DateTime? Fecha_v { get; set; }
        public string? Operador { get; set; }
        public string? Hora_Carga { get; set; }
        public decimal? Imp_Tot_H { get; set; }
        public decimal? Imp_Tot_G { get; set; }
        public decimal? Imp_Afi_H { get; set; }
        public decimal? Imp_Afi_G { get; set; }
        public string? c_Plan { get; set; }
        public bool? Exe_Tope { get; set; }
        public bool? Estado { get; set; }
        public string? Empresa { get; set; }
        public byte? Emision_a { get; set; }
        public bool? T_Cobertu { get; set; }
        public decimal? Cobertu { get; set; }
        public bool? Excepcion { get; set; }
        public bool? Consumido { get; set; }
        public decimal? Caja { get; set; }
        public string? T_Emite { get; set; }
        public DateTime? Fecha_i { get; set; }
        public bool? Cobrada { get; set; }
        public DateTime? f_Cobro { get; set; }
        public string? Ope_Cza { get; set; }
        public string? Hora_Cza { get; set; }
        public string? Int_Suc { get; set; }
        public string? Int_Nro { get; set; }
        public int? Dias { get; set; }
        public bool? Rx { get; set; }
        public bool? Ecg { get; set; }
        public long? Transac { get; set; }
        public string? Obs { get; set; }
        public byte? Digi { get; set; }
        public bool? Art { get; set; }
        public bool? Remisos { get; set; }
        public int? Recno { get; set; }
    }
}

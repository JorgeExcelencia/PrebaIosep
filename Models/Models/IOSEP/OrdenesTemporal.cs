using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenesTemporal
    {
        public string? tip_aut { get; set; }
        public string? suc_aut { get; set; }
        public string? nro_aut { get; set; }
        public byte? item_aut { get; set; }
        public string? o_social { get; set; }
        public string? a_numero { get; set; }
        public string? familiar { get; set; }
        public string? prescribe { get; set; }
        public string? efector { get; set; }
        public string? diagnostic { get; set; }
        public string? nomenclado { get; set; }
        public byte? t_arancel { get; set; }
        public string? lp_su { get; set; }
        public string? t_prestac { get; set; }
        public string? p_codigo { get; set; }
        public byte? cantidad { get; set; }
        public DateTime? fecha_e { get; set; }
        public DateTime? fecha_v { get; set; }
        public string? operador { get; set; }
        public string? hora_carga { get; set; }
        public decimal? imp_tot_h { get; set; }
        public decimal? imp_tot_g { get; set; }
        public decimal? imp_afi_h { get; set; }
        public decimal? imp_afi_g { get; set; }
        public string? plan { get; set; }
        public byte? exe_tope { get; set; }
        public byte? estado { get; set; }
        public string? empresa { get; set; }
        public byte? emision_a { get; set; }
        public byte? t_cobertu { get; set; }
        public decimal? cobertu { get; set; }
        public byte? excepcion { get; set; }
        public byte? consumido { get; set; }
        public decimal? caja { get; set; }
        public string? t_emite { get; set; }
        public DateTime? fecha_i { get; set; }
        public byte? cobrada { get; set; }
        public DateTime? f_cobro { get; set; }
        public string? ope_cza { get; set; }
        public string? hora_cza { get; set; }
        public string? int_suc { get; set; }
        public string? int_nro { get; set; }
        public int? dias { get; set; }
        public byte? rx { get; set; }
        public byte? ecg { get; set; }
        public int? transac { get; set; }
        public string? obs { get; set; }
        public byte? digi { get; set; }
        public byte? art { get; set; }
        public byte? remisos { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Institucione
    {
        public int idprestador { get; set; }
        public string matricula { get; set; } = null!;
        public string? nombre { get; set; }
        public long? iddomicilio { get; set; }
        public string cuil { get; set; } = null!;
        public int? recnomedsoft { get; set; }
        public bool? turnos { get; set; }
        public bool suspendida { get; set; }
        public bool? lis_x_id_tip_int { get; set; }
        public bool? hab_liso_x_tip_int { get; set; }
        public bool? control_x_dia { get; set; }
        public bool anulado { get; set; }
        public bool Clinica { get; set; }
        public string? CODIGO { get; set; }
        public string? DOMICILIO { get; set; }
        public string? TELEFONO { get; set; }
        public string? PROVINCIA { get; set; }
        public string? ZONA { get; set; }
        public string? LOCALIDAD { get; set; }
        public string? CONTACTO { get; set; }
        public DateTime? I_FECHA { get; set; }
        public DateTime? E_FECHA { get; set; }
        public byte? TIPO_IVA { get; set; }
        public string? NRO_IVA { get; set; }
        public string? NRO_GAN { get; set; }
        public string? NRO_BRU { get; set; }
        public string? NRO_MUN { get; set; }
        public byte? ESTADO { get; set; }
        public byte? P_TIPO { get; set; }
        public string? ESPECIAL { get; set; }
        public byte? M_TIPO { get; set; }
        public string? M_NRO { get; set; }
        public string? OBS { get; set; }
        public int? CATEGORIA { get; set; }
        public string? I_BRUTOS { get; set; }
        public string? GANANCIAS { get; set; }
        public string? NRO_INSTI { get; set; }
        public bool? HS_COLE { get; set; }
        public DateTime? HS_FECHA { get; set; }
        public bool? GS_COLE { get; set; }
        public DateTime? GS_FECHA { get; set; }
        public bool? COL_FECLI { get; set; }
        public string? INTERMEDIA { get; set; }
        public int? NRO { get; set; }
        public int? CODCOL { get; set; }
        public byte? ESTADOC { get; set; }
        public DateTime? FECHACOL { get; set; }
        public bool? DEBECIU { get; set; }
        public string? DESCESP { get; set; }
        public bool? RES112004 { get; set; }
        public DateTime? F_INACT { get; set; }
        public bool? DIABES_NOA { get; set; }
        public bool? MATER_NOA { get; set; }
        public bool? OTROS_NOA { get; set; }
        public bool? PLUSB { get; set; }
        public DateTime? PLUS_FECHA { get; set; }
        public string? PLUS_NRO { get; set; }
    }
}

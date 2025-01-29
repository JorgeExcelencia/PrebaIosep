using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class OrdenesCobra
    {
        public int Id { get; set; }
        public string? TIP_AUT { get; set; }
        public string? SUC_AUT { get; set; }
        public string? NRO_AUT { get; set; }
        public DateTime? FECHA_ORD { get; set; }
        public string? A_NUMERO { get; set; }
        public string? FAMILIAR { get; set; }
        public decimal? IMPORTE { get; set; }
        public decimal? COSEGURO { get; set; }
        public string? CAJA { get; set; }
        public string? TURNO { get; set; }
        public string? CAJERO { get; set; }
        public DateTime? FECHA_CAJ { get; set; }
        public string? HORA_MOV { get; set; }
        public bool? ANULADO { get; set; }
        public decimal? TRANSAC { get; set; }
        public decimal? DIGITO { get; set; }
        public decimal? IVA { get; set; }
        public string? O_SOCIAL { get; set; }
        public string? P_CODIGO { get; set; }
        public decimal? TRANS_CAJ { get; set; }
        public decimal? DIGITO_CAJ { get; set; }
        public string? T_EMITE { get; set; }
        public bool? EFECTIVO { get; set; }
        public decimal? IMP_EFE { get; set; }
        public bool? CHEQUE { get; set; }
        public string? BANCO { get; set; }
        public string? NRO_CHE { get; set; }
        public DateTime? FECHA_CHE { get; set; }
        public decimal? IMP_CHE { get; set; }
        public bool? TARJETA { get; set; }
        public string? NRO_TARJ { get; set; }
        public string? TIPO_TARJ { get; set; }
        public decimal? IMP_TARJ { get; set; }
        public bool? DOCUMENTO { get; set; }
        public string? SUC_DOCU { get; set; }
        public string? NRO_DOCU { get; set; }
        public decimal? IMP_DOC { get; set; }
        public bool? DOLAR { get; set; }
        public decimal? IMP_DOL { get; set; }
        public bool? DEBITO { get; set; }
        public string? NRO_DEBI { get; set; }
        public decimal? IMP_DEBI { get; set; }
        public bool? BONOS { get; set; }
        public string? TIPO_BONO { get; set; }
        public decimal? IMP_BON { get; set; }
        public bool? CERRADO { get; set; }
        public bool? IMPUTADO { get; set; }
        public bool? TILDEB { get; set; }
        public string? DEB_CAJA { get; set; }
        public string? DEB_TURNO { get; set; }
        public string? DEB_CAJERO { get; set; }
        public DateTime? DEB_FECHA { get; set; }
        public string? DEB_HORA { get; set; }
        public decimal? DEB_TRANS { get; set; }
        public decimal? DEB_DIGI { get; set; }
        public decimal? TIPO_ANUL { get; set; }
        public string? REI_CAJA { get; set; }
        public string? REI_TURNO { get; set; }
        public string? REI_CAJERO { get; set; }
        public DateTime? REI_FECHA { get; set; }
        public string? REI_HORA { get; set; }
        public decimal? REI_TRANS { get; set; }
        public decimal? REI_DIGI { get; set; }
        public bool? MARCA_REIN { get; set; }
        public decimal? HISTORIC { get; set; }
    }
}

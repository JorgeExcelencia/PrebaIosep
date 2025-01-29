using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class EscuelasDBF
    {
        public int Id { get; set; }
        public string? CODESC { get; set; }
        public string? NOMBRE { get; set; }
        public int? NIVEL { get; set; }
        public string? DIRECCION { get; set; }
        public int? LOCA { get; set; }
        public int? DPTO { get; set; }
        public string? COD_POSTAL { get; set; }
        public string? TELEFONO { get; set; }
        public string? CATEGORIA { get; set; }
        public string? GRUPO { get; set; }
        public int? NROESC { get; set; }
        public string? DIRECTOR { get; set; }
        public string? CUENTA { get; set; }
        public string? TIPDEP { get; set; }
        public int? CODSUC { get; set; }
        public int? GRUPOTES { get; set; }
        public string? VIGENCIA { get; set; }
        public string? ESTABLE { get; set; }
        public string? FUNCIONA { get; set; }
        public int? CANALU { get; set; }
        public int? CANTDIVI { get; set; }
        public int? CARGOS { get; set; }
        public int? ARANCEL { get; set; }
        public int? MATRICULA { get; set; }
        public bool? PERSUNIC { get; set; }
        public bool? CAJEROS { get; set; }
        public DateTime? FECING { get; set; }
        public DateTime? FECCARGA { get; set; }
    }
}

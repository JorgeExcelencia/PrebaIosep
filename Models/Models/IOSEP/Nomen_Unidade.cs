using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Nomen_Unidade
    {
        public int IdNomen_Unidades { get; set; }
        public int IdNomenclador { get; set; }
        public short? IdTipoNom { get; set; }
        public decimal Especialista { get; set; }
        public decimal Ayudante_1 { get; set; }
        public decimal Ayudante_2 { get; set; }
        public decimal Ayudante_3 { get; set; }
        public decimal Ayudante_4 { get; set; }
        public decimal Anestesista { get; set; }
        public decimal Instrumentadora { get; set; }
        public int IdTipoUnidadH { get; set; }
        public int IdTipoUnidadG { get; set; }
        public int CantidadHonorarios { get; set; }
        public int CantidadGastos { get; set; }
        public decimal HonorarioUnidades { get; set; }
        public decimal TotalHonorarios { get; set; }
        public decimal GastoUnidades { get; set; }
        public decimal TotalGastos { get; set; }
        public decimal Total { get; set; }
        public bool Anulado { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TxtNovedad
    {
        public int IdTxtNovedad { get; set; }
        public string StoredProcedure { get; set; } = null!;
        public string Periodo { get; set; } = null!;
        public string Beneficio { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string GrupoNovedad { get; set; } = null!;
        public string FechaCarga { get; set; } = null!;
        public string HoraCarga { get; set; } = null!;
        public string TipoConcepto { get; set; } = null!;
        public string CodigoConcepto { get; set; } = null!;
        public string CodigoEmpresa { get; set; } = null!;
        public string Filler { get; set; } = null!;
        public string Importe { get; set; } = null!;
        public string ImporteTotal { get; set; } = null!;
        public string Cero { get; set; } = null!;
        public string Cuotas { get; set; } = null!;
        public string Porcentaje { get; set; } = null!;
        public string Reserva { get; set; } = null!;
        public string CodigoOficina { get; set; } = null!;
        public string Sistema { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
    }
}

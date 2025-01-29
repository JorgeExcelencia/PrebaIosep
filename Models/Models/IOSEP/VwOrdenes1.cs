﻿using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwOrdenes1
    {
        public string NombrePlan { get; set; } = null!;
        public int IdOrden { get; set; }
        public int? IdAfiliado { get; set; }
        public int IdPlan { get; set; }
        public string TipoOrden { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public int IdDelegacion { get; set; }
        public int? IdPrescriptor { get; set; }
        public int? IdEfector { get; set; }
        public int? IdDiagnostico { get; set; }
        public byte? IosepSalud { get; set; }
        public DateTime? Modifica { get; set; }
        public string? OperAnula { get; set; }
        public bool Anulada { get; set; }
        public byte TipoAutorizacion { get; set; }
        public string? Motivo { get; set; }
        public string? Observacion { get; set; }
        public string? TipoReconoce { get; set; }
        public bool SobreTope { get; set; }
        public decimal Total { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha_Vence { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public DateTime Fecha_Prescripcion { get; set; }
        public byte Cantidad { get; set; }
        public int? IdNomenclador { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string OperTroquel { get; set; } = null!;
        public string? OperCuerpo { get; set; }
    }
}

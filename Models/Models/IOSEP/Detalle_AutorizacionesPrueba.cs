﻿using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Detalle_AutorizacionesPrueba
    {
        public int DetalleID { get; set; }
        public int AutorizacionesId { get; set; }
        public int IdNomenclador { get; set; }
        public byte Cantidad_Solicitada { get; set; }
        public byte Cantidad_Autorizada { get; set; }
        public decimal Honorarios { get; set; }
        public decimal Gastos { get; set; }
        public decimal Coseguro_Honorarios { get; set; }
        public decimal Coseguro_Gastos { get; set; }
        public decimal Reconoce_Honorarios { get; set; }
        public decimal Reconoce_Gastos { get; set; }
        public string EstadoAutorizacion { get; set; } = null!;
        public string? Observaciones { get; set; }
        public string? Motivo_Rechazo { get; set; }
        public bool Anulada { get; set; }
    }
}

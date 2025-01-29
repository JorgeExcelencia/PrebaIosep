using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CajaCierreDeposito
    {
        public int IdCajaCierreDeposito { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public string Terminal { get; set; } = null!;
        public string NumeroTransaccion { get; set; } = null!;
        public int IdBanco { get; set; }
        public string Sucursal { get; set; } = null!;
        public string TipoDeposito { get; set; } = null!;
        public decimal Importe { get; set; }
        public string Operador { get; set; } = null!;
        public int IdDelegacion { get; set; }
        public bool Confirmado { get; set; }
        public string OperadorConfirma { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public DateTime Cargado { get; set; }
        public bool Anulado { get; set; }
    }
}

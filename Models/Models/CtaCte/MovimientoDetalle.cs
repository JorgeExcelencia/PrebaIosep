using Microsoft.EntityFrameworkCore;

namespace ApiIosep.Models.CtaCte
{
    [Keyless]
    public class MovimientoDetalle
    {
        public int IdTipoMovimiento { get; set; }
        public string Movimiento { get; set; } = string.Empty;
        public int IdDetalle { get; set; }
        public string Detalle { get; set; } = string.Empty;
        public string DebeHaber { get; set; } = string.Empty;
        public int Relacion { get; set; }
        public int RelacionMov { get; set; } = 0;
        public bool Cuotas { get; set; } = false;
        public Byte RelacionCaja { get; set; } = 0;
        public bool ConsultaValorCuota { get; set; } = false;
        public bool OrdenesOnline { get; set; } = false;

        //public bool Afiliados { get; set; }
        //public bool Empresas { get; set; }
    }
}

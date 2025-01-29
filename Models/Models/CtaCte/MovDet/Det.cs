namespace ApiIosep.Models.CtaCte.MovDet
{
    public class Det
    {
        public int IdDetalle { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string DebeHaber { get; set; } = string.Empty;
        public int Relacion { get; set; }
        public int RelacionMov { get; set; } = 0;
        public bool Cuotas { get; set; } = false;
        public Byte RelacionCaja { get; set; } = 0;
        public bool ConsultaValorCuota { get; set; } = false;
        public bool OrdenesOnline { get; set; } = false;
    }
}

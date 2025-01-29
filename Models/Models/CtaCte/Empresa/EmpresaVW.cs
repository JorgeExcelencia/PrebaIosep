namespace ApiIosep.Models.CtaCte.Empresa
{
    public class EmpresaVW
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Familia { get; set; }
        public int Titulares { get; set; }
        public int Beneficiarios { get; set; }
        public string? Domicilio { get; set; }
        public string? Contacto { get; set; }
        public string? Telefono { get; set; }
        public string? Resolucion { get; set; }
        public decimal? CuotaFija { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public DateTime? Renovar { get; set; }
        public string? Cuit { get; set; } = string.Empty;
        public int? IdLocalidad { get; set; }
        public bool? Contratados { get; set; }
        public decimal? ProntoPagoDescuento { get; set; }
        public decimal? ProntoPagoImporte { get; set; }
        public bool ValorFijo { get; set; }
        public bool ContratoIndividual { get; set; }
        public string? Tipo { get; set; }
        public string PeriodoFacturado { get; set; } = string.Empty;
        public bool Anulado { get; set; }
    }
}

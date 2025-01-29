using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models.Creditos
{
    public class CreditosDTO
    {
    }
    public class SolicitudCreditoDto
    {
        public int IdAfiliado { get; set; }
        public string Denomina { get; set; } = string.Empty;
        public int ConceptoCodigo { get; set; } = 0;
        public int? IdLote { get; set; }
        public CreditoDetalleDto[] creditoDetalle { get; set; } = new CreditoDetalleDto[0];
    }

    public class CreditoDetalleDto
    { 
        public string Subcodigo { get; set; } = string.Empty;

        public string NroCredito { get; set; } = string.Empty;

        public string CodMovimiento { get; set; } = string.Empty;

        public decimal ImporteCuota { get; set; } = 0; 
    }
    public class FichactaDto
    {
        public string NroCredito { get; set; }
        public string CodigoCredito { get; set; }
        public string IdAfiliado { get; set; }
        public string Nombre { get; set; }
        public string Cuotas { get; set; }
        public decimal ImporteCuota { get; set; }
        public string CuotasPendientes { get; set; }
        public string MontoCredito { get; set; }
        public decimal PagoAcumulado { get; set; }
        public bool loteCargado { get; set; } = false;
    }
    public class CreditosHcablTcr
    {

        [Key]
        public int Id { get; set; }
        public string Identif { get; set; }
        public string Nropaq { get; set; }
        public string Credito { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Cantdoc { get; set; }
        public string Totimpcu { get; set; }
        public string Cantocu { get; set; }
        public string Impotctr { get; set; }
        public string Identific { get; set; }
        public string Iden_fecha { get; set; }
        public string Iden_hora { get; set; }
        public string Error1 { get; set; }
        public string Error2 { get; set; }
        public string Error3 { get; set; }
        public string Error4 { get; set; }
        public string Error9 { get; set; }
        public string Fecproc { get; set; }
    }
    public class CreditosHlotEcrd
    {
        public string Identif { get; set; }
        public string Nropaq { get; set; }
        public string Credito { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Nroafil { get; set; }
        public string Subcod { get; set; }
        public string Nrocred { get; set; }
        public string Codmov { get; set; }
        public string Dias { get; set; }
        public string Cantcuot { get; set; }
        public string Signo { get; set; }
        public string Impcuota { get; set; }
        public string Identific { get; set; }
        public string Iden_fecha { get; set; }
        public string Iden_hora { get; set; }
        public string Error1 { get; set; }
        public string Fecproc { get; set; }
        [Key]
        public int Id { get; set; }
    }

    public class CuotasDisponibles
    {
        public int cantidadCuota { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal importePorCuota { get; set; } = 0;
        public decimal ImporteTotalSinInteres { get; set; } = 0;
        public decimal ImporteTotalConInteres { get; set; } = 0;
    }

    public partial class CreditosLotesDTO
    {
        public int IdLote { get; set; }
        public string Descripcion { get; set; } = string.Empty.ToString();

        public string? PeriodoProcesamiento { get; set; }
        public string OperadorCrea { get; set; } = string.Empty.ToString();

        public bool Anulado { get; set; } = false;
    }
    public class CreditosLoteDetallesDTO
    {
        public int IdLoteDetalle { get; set; } = 0;
        public decimal? ImporteTotal { get; set; } = 0;

        public int? CantDocumentos { get; set; } = 0;

        public int IdLote { get; set; } = 0;

        public bool Anulado { get; set; } = false;
    }
    public class CreditosCreditoDTO
    {
        public int IdCredito { get; set; }
        public int Cuotas { get; set; } = 0;
        public decimal ImporteTotal { get; set; } = 0;
        public string Denomina { get; set; } = string.Empty;
        public string CodigoCredito { get; set; } = string.Empty;
        public int IdAfiliado { get; set; } = 0;
        public int IdLote { get; set; } = 0;
        public int? FormaPago { get; set; } = 0;
        public DateTime FechaCrea { get; set; } = new DateTime(1900, 1, 1);
        public bool Anulado { get; set; } = false;
        public bool Cancelado { get; set; } = false;
        public string NroCreditoMigracion { get; set; } = string.Empty;

    }
    public partial class CreditosDetalleDTO
    {
        public int IdDetalleCredito { get; set; }
        public string Subcodigo { get; set; } = string.Empty;
        public string NroCredito { get; set; } = string.Empty;
        public string CodMovimiento { get; set; } = string.Empty;
        public decimal ImporteCuota { get; set; } = 0;
        public decimal Saldo { get; set; } = 0;

        public bool Anulado { get; set; } = false;

        public int IdCredito { get; set; } = 0;
        public int IdDetalle { get; set; } = 0;
        public string Periodo { get; set; } = string.Empty;
    }
    public partial class CreditosSalarioAfiliadoDTO
    {
        public int IdSalario { get; set; }
        public int IdAfiliado { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; } = new DateTime(1900, 01, 01);
        public decimal Monto { get; set; }
        public string NroControl { get; set; } = string.Empty;
        public string IDLugarDePago { get; set; } = string.Empty;
        public string Antiguedad { get; set; } = string.Empty;
        public decimal HaberConAportes { get; set; } = 0.00M;
        public decimal HaberSinAportes { get; set; } = 0.00M;
        public decimal TotalDescuentos { get; set; } = 0.00M;
        public decimal Liquido { get; set; } = 0.00M;
        public decimal MaximoDescuento { get; set; } = 0.00M;
        public DateTime FechaCrea { get; set; } = new DateTime(1900, 01, 01);
        public string UsuarioCrea { get; set; } = string.Empty;
        public bool Anulado { get; set; } = false;
        public DateTime FechaAnula { get; set; } = new DateTime(1900, 01, 01);
        public string UsuarioAnula { get; set; } = string.Empty;
    }

    public class CreditoImprimirDto
    {
        public int IdCredito { get; set; }
        public int Cuotas { get; set; }
        public decimal ImporteTotal { get; set; }
        public string Denomina { get; set; } = string.Empty;
        public string CodigoCredito { get; set; } = string.Empty;
        public int IdAfiliado { get; set; }
        public int IdLote { get; set; }
        public int? FormaPago { get; set; }
        public bool Anulado { get; set; }
        public string FechaCrea { get; set; }
        public bool Cancelado { get; set; }
        public string NroCreditoMigracion { get; set; } = string.Empty;
        public string NombreAfiliado { get; set; } = string.Empty;
        public string CuilTitular { get; set; } = string.Empty;
        public string A_Numero { get; set; } = string.Empty;
        public string Domicilio { get; set; } = string.Empty;
        public int IdLocalidad { get; set; }
        public string CodigoPostal { get; set; } = string.Empty;
        public string NombreLocalidad { get; set; } = string.Empty;
    }

    public class AfiliadoDetalleImprimirDto
    {
        public int IdAfiliado { get; set; }
        public string NombreAfiliado { get; set; } = string.Empty;
        public string CuilTitular { get; set; } = string.Empty;
        public string A_Numero { get; set; } = string.Empty;
        public string Domicilio { get; set; } = string.Empty;
        public int IdLocalidad { get; set; }
        public string CodigoPostal { get; set; } = string.Empty;
        public string NombreLocalidad { get; set; } = string.Empty;
    }
    public partial class CreditoOrden
    {
        public DateTime FechaCrea { get; set; }
        public int IdCredito { get; set; }
        public string Denomina { get; set; }
        public string NumCuota { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal Pagado { get; set; }
    }
    public class LugarPagoDTO
    {
        public int Id { get; set; }
        public string Control { get; set; } 
        public string LugarPago { get; set; }
        public string NombreLugar { get; set; }
        public string Planta { get; set; }
        public string ANumero { get; set; }
        public string Cuil { get; set; }
        public string Afiliado { get; set; }
        public string Otro { get; set; }
        public string NumeroBeneficio { get; set; }
        public string Codigo { get; set; }
        public string CodigoJubilado { get; set; }
        public decimal? HaberJubilado { get; set; }
        public decimal? Aporte { get; set; }
        public decimal? ConAporteDescontado {  get; set; }
        public decimal? CreditoTomado { get; set; }
        public decimal? Disponible {  get; set; }
    }

}

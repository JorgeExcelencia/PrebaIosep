using ApiIosep.Models.CtaCte;
using ApiIosep.Models.CtaCte.Afiliado;
using ApiIosep.Models.CtaCte.Empresa;
using ApiIosep.Models.CtaCte.MovDet;
using ApiIosep.Models.StoreProcedures;
using Models.Models.DTOs;
using System.Xml;


namespace ApiIosep.Repositorio.Interfaces
{
    public interface IStoredProceduresIOSEPRepository
    {
        Task<List<ComprobanteVM>> ctacte_resumen(int id, bool esEmpresa = false, string? desde = "", string? hasta = "");
        Task<List<ComprobanteVM>> ctacte_resumenAfiliadosEmpresa(string param, int id);
        Task<List<ComprobanteVM>> ctacte_sistemaviejo(int id);
        Task<List<DetalleMovimiento>> ctacte_resumenDetalleComp(int id);
        Task<List<MovimientoDetalle>> getMovimientos();
        Task<List<MovimientoDetalle>> getMovimientos(int? id);
        Task<List<MovimientoDetalle>> getMovimientos(string param);
        Task<List<CuotaVM>> CuotaAfiliado(int id, string periodo);
        Task<List<CuotaVM>> ImporteCuotaEmpresa(int id, string periodo);
        Task<List<imprimir_ctacteVW>> ctacte_imprimir(int id);
        Task<List<imprimir_PagoCtaCte>> pa_CtaCte_Imprimir_Recibos_Empresas(int id);
        Task<List<NotaCredito>> pa_CtaCte_CobranzaGetInfo(string codBarra);
        Task<List<NotaCreditoEmpresa>> pa_CtaCte_CobranzaGetInfoEmpresas(string codBarra);
        Task<List<Comprobante>> pa_CtaCte_NotaDeCredito1(string CodigoBarra, XmlDocument doc, string cuil, string? observaciones);
        Task<List<Comprobante>> pa_CtaCte_NotaDeCreditoEmpresas(string CodigoBarra, double importe, string cuil, string? observaciones);
        Task pa_CtaCte_Facturacion(ComprobanteP comprobante, string fecha1, string fecha2);
        Task FacturacionEmpresasNuevo(ComprobanteP comprobante);
        Task<List<imprimir_PeriodoPago>> GenerarImpresionEmpresaPanel(int id, string periodo);
        Task<List<ClaseIosepSalud>> SP_IosepSALUDAfiliadosPeriodoNuevo(InformeAfiliadosRequest request);
        Task<List<IosepSALUDAfiliadosEmp>> SP_GenerarImpresionEmpresaPanel(ImprimirPanelDTO payload, string UsuarioImprime);
        Task<int> pa_CtaCteProcesofacturacionEmpresasPanel(ImprimirPanelDTO payload, string operador, string sucursal);
        Task<List<AfiliadoCuil>> SP_BuscarAfiliado(buscarCuilRequest datos);
        Task<List<EmpresaDetalleVW>> pa_CtaCteEmpresas_Vista(int IdAfiliado, DateTime d, DateTime h);
        Task<List<AfiliadoDetalleVW>> pa_CtaCteAfiliados_Vista(int IdAfiliado, DateTime d, DateTime h);
        Task VerificarYActualizarVencimientos(string periodo);
    }
}

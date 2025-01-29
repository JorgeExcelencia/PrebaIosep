using ApiIosep.Models;
using ApiIosep.Models.CtaCte;
using ApiIosep.Models.CtaCte.MovDet;
using ApiIosep.Models.DTOs;
using ApiIosep.Models.StoreProcedures;
using Models.Models.DTOs;

namespace ApiIosep.Services.Interfaces
{
    public interface IComprobantesService
    {
        Task<List<ComprobanteVM>> GetComprobantexAfiliado(int id, bool esEmpresa = false, string? desde = "", string? hasta = "");
        Task<List<ComprobanteVM>> GetComprobanteViejoxAfiliado(int id);
        Task<List<DetalleMovimiento>> GetDetallesMovimientos(int id);
        Task<List<Mov>> GetMovimientos();
        Task<List<Mov>> GetMovxOpc(string param);
        Task<List<CuotaVM>> GetCuotaxAfiliado(int id, string periodo);
        Task<List<CuotaVM>> GetCuotaxEmpresa(int id, string periodo);
        Task<string> GetImprimirxComprobante(int id);
        Task<List<NotaCredito>> GetDataInfoReciboAfiliado(string codBarra);
        Task<List<NotaCreditoEmpresa>> GetDataInfoReciboEmpresa(string codBarra);
        Task<string> SetNotadeCredito(string CodigoBarra, string Json, Int16 Tipo, string? Observaciones, string cuil);
        Task<List<ComprobanteVM>> PostComprobante(ComprobanteP comprobante);
        Task<List<ComprobanteVM>> PostComprobanteEmpresa(ComprobanteP comprobante);
        Task<VencimientosDTO> FechasVencimiento(string periodo);
        Task<int> PostGlobal(string periodo, string tipo,string sucursal);
        Task<Respuesta> PutComprobantes(int id, Models.IOSEP.comprobante comprobante);
        Task<List<ComprobanteVM>> DeleteComprobante(int id);
        Task<Response<List<ComprobanteVM>>> AnularComprobanteReporte( anularComprobanteRequest request, string? user);
        Task<string> GetImprimirPeriodoAfiliado(int id, string periodo);
    }
}

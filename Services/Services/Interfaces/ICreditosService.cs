using Models.Models.Creditos;
using Models.Models.Creditos.Respuesta;
using Models.Models.DTOs;
using RestSharp;
using Models.Models.DTOs.CreditosDTO;
using System.ComponentModel.Design.Serialization;

namespace Services.Services.Interfaces
{
    public interface ICreditosService
    {
        Task<RespuestaIOSEP> CrearLote(CreditosLotesParameter request);
        Task<RespuestaDTO> BuscarCreditoLotePorId(int idCreditoLote);
        Task<RespuestaDTO> BuscarCreditoLotePorPeriodo(string periodo);
        Task<RespuestaDTO> BuscarLotePorPeriodoDetalleCredito(string periodo, int IdConcepto); 
        Task<RespuestaDTO> BuscarAfiliado(string cuil);
        Task<RespuestaDTO> BuscarLugarDePago(string cuil);
        Task<RespuestaIOSEP> CrearCredito(SolicitudCreditoDto request);
        Task<RespuestaDTO> BuscarConceptoCredito();
        Task<bool> ValidarInformeSocioEconomico(int IdAfiliado);
        Task<RespuestaIOSEP> ProcesoPago(List<CreditosDetalleParameter> payments);
        Task<RespuestaDTO> BuscarDetalleCuotas(int IdCredito);
        Task<RespuestaDTO> BuscarCreditos(int IdAfiliado);
        Task<RespuestaDTO> BuscarCredito(string CodigoCredito);
        Task<List<CreditosReporteCoseguroOrden>> GetReportesCoseguroOrdenesAsync(CreditosCoseguroOrdenes request);
        Task<RespuestaIOSEP> GrabarCreditosCoseguroOrdenesAsync(List<CreditosReporteCoseguroOrden> request);
        Task<RespuestaDTO> BuscarSalario(string cuil);
        Task<RespuestaDTO> BuscarSalario(int idafiliado);
        Task<RespuestaIOSEP> NuevoSalario(int IdAfiliado, decimal Monto, DateTime Desde);
        Task<RespuestaIOSEP> EditarSalario(int IdSalario, decimal Monto, DateTime Hasta);
        Task<RespuestaIOSEP> AnularSalario(int IdSalario);
        Task<RespuestaIOSEP> GrabarFichacta(List<string> archivo);
        Task<RespuestaIOSEP> GrabarAnexo(List<string> archivo);
        Task<RespuestaIOSEP> GrabarNoefect(List<string> archivo);
        Task<List<string>> GenerarCabeceraLote(string fechaCrea);
        Task<List<ResultadoOrdenCoseguro>> DetalleLote(int pageNumber, int pageSize);
        Task<List<CabeceraLoteArchivoNuevoDTO>> CabeceraLoteArchivoNuevo();
        Task<RespuestaDTO> BuscarDatosFichaCuenta(string periodo, int pageNumber, int pageSize);
        Task<RespuestaIOSEP> pagoFichacta(List<FichactaDto> payments);
        Task<RespuestaDTO> BuscarDatosNoEfectuados(string periodo, int pageNumber, int pageSize);
        Task<RespuestaDTO> BuscarDatosAnexo(string periodo, int pageNumber, int pageSize);
        Task<RespuestaIOSEP> GrabarMigracion(List<string> archivo, bool Cabecera = false);
        Task<RespuestaDTO> GenerarCuotaPorCredito(decimal ImporteCredito, decimal ingresoFamiliar);
        Task<RespuestaDTO> GenerarCuotasPorImporte(decimal ImporteCredito, decimal ingresoFamiliar, int cantCuotas);
        Task<RespuestaDTO> GetLoteOtorgamiento(string conceptoCredito, string periodo);
        Task<Root?> GetConsumoApi(string cuil);
        Task<RespuestaDTO> CancelarCreditoFallecido(List<CreditosNoEfectuadosDTO> creditosNoEfect);
        Task<List<CreditosNoEfectuadosDTO>> GetFallecidosNoEfectuados();
        Task<RespuestaDTO> CalcularCreditosUnificados(UnificacionCreditosDto request, int cantCuotas);
        Task<RespuestaDTO> GetCreditoUnificar(int idAfiliado);
        Task<RespuestaDTO> UnificarCreditosService(UnificacionCreditosDto ListaCredito, decimal importeCredito, int cantCuota, decimal importePorCuota);
        Task<RestResponse> GetImprimirxCredito(int id);
        Task<RespuestaDTO> VincularGaranteService(int idAfiliadoGarante, int idAfiliadoDeudor);
        Task<RespuestaDTO> VincularCreditoDeudorGaranteService(int idAfiliadoGarante, int idAfiliadoDeudor, int idCredito);
        Task<RespuestaDTO> GetAfiliadoService(int idAfiliado);
        Task<RespuestaDTO> TransferirCreditoACobranzasService(int idCredito, int idAfiliado);
        Task<RespuestaDTO> ActualizarMargenSalarialPorCreditoService(int idCredito, int idAfiliado);

    }
}

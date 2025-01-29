using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using Models.Models.Creditos;
using Models.Models.DTOs;
using Models.Models.DTOs.CreditosDTO;
using static Repository.Repositorio.Concrete.CreditosRepository;

namespace Repository.Repositorio.Interfaces
{
    public interface ICreditosRepository
    {
        //Task<CreditosLotes> GetCreditoLote(int IdLote);
        //Task<bool> existeCreditos(int IdLote);
        Task<CreditosLotes?> GetCreditosLotesByID(int id);
        Task<List<CreditosConcCred>> GetConceptoCredito();
        Task<CreditosSalarioAfiliado?> GetIngresoFamiliarById(int idAfiliado);
        Task<CreditosSalarioAfiliado?> GetIngresoFamiliarByIdSalario(int idSalario);
        Task<CreditosSalarioAfiliado> CompararIngresoFamiliar(int IdAfiliado, Datum data);
        void ActualizarSalarioAfiliadoDGI(CreditosSalarioAfiliado salario, Datum data);
        Task AgregarNuevoIngresoFamiliarDGI(CreditosSalarioAfiliadoDTO creditoIngresoFamiliarDTO);
        Task<CreditosSalarioAfiliado?> GetIngresoFamiliarByIdAfiliado(int idafiliado);
        Task<CreditosCredito> CrearCredito(CreditosCreditoDTO creditoDTO);
        void CrearCreditoDetalle(CreditosDetalleDTO creditoDTO);
        Task<List<CreditosDetalle>> GetDetalleCreditoById(int idCredito);
        Task<List<CreditosDetalle>> GetDetalleCreditoByIdDetalle(int idDetalleCredito);
        Task<CreditosCredito> GetCreditoByIdCredito(int idCredito);
        Task<List<CreditosCredito>> GetCreditosPorPeriodo(DateTime fecha, int idConcepto);
        Task CancelarCreditoPago(int idCredito);
        Task<decimal> CalcularSaldoCuota(int idDetalleCredito);
        Task<bool> ExisteCreditoByIdAfiliado(int idafiliado);
        Task<List<CreditoOrden>> GetCreditosYDetalleCreditos(int idAfiliado);
        Task<List<CreditosCredito>> GetCreditoByConceptoCodigo(string codigo);
        Task AgregarNuevoIngresoFamiliar(CreditosSalarioAfiliadoDTO creditoIngresoFamiliarDTO);
        void ActualizarSalarioAfiliado(CreditosSalarioAfiliado salario, decimal monto, DateTime Hasta);
        void AnularSalarioAfiliado(CreditosSalarioAfiliado salario);
        void GrabarFichacta(List<CreditosFichactaDTO> registros);
        void GrabarAnexo(List<CreditosAnexoDTO> registros);
        void GrabarNoEfectuados(List<CreditosNoEfectuadosDTO> registros);
        Task<List<CreditosCredito>> GetAllCreditos();
        Task<List<ResultadoOrdenCoseguro>> GetDetalleLote(int pageNumber, int pageSize);
        Task<List<CreditosFichacta>> BuscarDatosFichaCuenta(string periodo, int pageNumber, int pageSize);
        Task<CreditosCredito> GetCreditoByNroCreditoMigracion(string NroCredito, int idafiliado);
        Task<CreditosFichacta?> GetDatoFichaCta(FichactaDto fichacta);
        Task<CreditosDetalle?> GetDetalleCreditoByIdYNumCuota(int idCredito, string numCuota);
        void ImpactarPagoFichacta(CreditosDetalle pagoFichacta, CreditosFichacta impactarCredito, decimal importeCuota);
        void GrabarMigracion(List<CreditosHcablTcrDTO> registros);
        Task<List<object>> BuscarDatosAnexo(string periodo, int pageNumber, int pageSize);
        Task<List<object>> BuscarDatosNoEfectuados(string periodo, int pageNumber, int pageSize);
        Task<List<CreditoImprimirDto>> GetCreditosAsync(int idAfiliado);
        Task<List<CreditosNoEfectuados>> BuscarDatosNoEfectuadosXFallecidos();
        Task<string> CancelarCreditosAfiliado(List<CreditosNoEfectuadosDTO> creditosNoEfect);
        Task<decimal> CalcularImporteCuotasPendientes(CreditosCreditoDTO credito);
        Task<List<CreditosCredito>> GetListCreditosByIdAfiliado(int idAfiliado);
        Task<string> CancelarCreditoPorUnificar(UnificacionCreditosDto credito);
        Task AgregarNuevoGarante(int idAfiliadoGarante, int idAfiliadoDeudor, string cuilOperador);
        Task<bool> ExisteGarante(int idAfiliadoGarante, int idAfiliadoDeudor);
        Task CancelarCreditoPorVincularDeudor(int idCredito, string descMotivo);
        Task<Afiliado> GetAfiliadoByID(int idAfiliado);
        void ActualizarMargenSalarialJubilado(CreditosSalarioAfiliado salario);

    }
}

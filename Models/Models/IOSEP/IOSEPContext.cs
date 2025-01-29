using System;
using System.Collections.Generic;
using ApiIosep.Models.CtaCte; 
using ApiIosep.Models.CtaCte.MovDet;
using ApiIosep.Models.StoreProcedures; 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models.Creditos;
using ApiIosep.Models.DTOs.Afiliados;

namespace ApiIosep.Models.IOSEP
{
    public partial class IOSEPContext : DbContext
    {
        public IOSEPContext()
        {
        }

        public IOSEPContext(DbContextOptions<IOSEPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.StoreProcedures.ClaseIosepSalud> ClaseIosepSalud { get; set; } = null!;
        public virtual DbSet<Models.StoreProcedures.IosepSALUDAfiliadosEmp> IosepSALUDAfiliadosEmp { get; set; } = null!;
        public virtual DbSet<Models.StoreProcedures.AfiliadoCuil> AfiliadoCuil { get; set; } = null!;
        public virtual DbSet<Models.StoreProcedures.ResultadoFactura> ResultadoFactura { get; set; } = null!;

        public virtual DbSet<ANCapitulo> ANCapitulos { get; set; } = null!;
        public virtual DbSet<ANCapituloSubcapitulo> ANCapituloSubcapitulos { get; set; } = null!;
        public virtual DbSet<ANConvenio> ANConvenios { get; set; } = null!;
        public virtual DbSet<ANConvenioPractica> ANConvenioPracticas { get; set; } = null!;
        public virtual DbSet<ANConvenioRestriccion> ANConvenioRestriccions { get; set; } = null!;
        public virtual DbSet<ANConvenioValor> ANConvenioValors { get; set; } = null!;
        public virtual DbSet<ANPracticasBase> ANPracticasBases { get; set; } = null!;
        public virtual DbSet<ANPracticasModulo> ANPracticasModulos { get; set; } = null!;
        public virtual DbSet<ANSolicitudCambio> ANSolicitudCambios { get; set; } = null!;
        public virtual DbSet<ANSolicitudCambioDetalleAN> ANSolicitudCambioDetalleANs { get; set; } = null!;
        public virtual DbSet<ANSolicitudCambioDetalleAV> ANSolicitudCambioDetalleAVs { get; set; } = null!;
        public virtual DbSet<ANSolicitudCambioDetalleNP> ANSolicitudCambioDetalleNPs { get; set; } = null!;
        public virtual DbSet<ANSolicitudCambioDetalleRestricAN> ANSolicitudCambioDetalleRestricANs { get; set; } = null!;
        public virtual DbSet<ANSolicitudCambioDetalleRestricNP> ANSolicitudCambioDetalleRestricNPs { get; set; } = null!;
        public virtual DbSet<ANSolicitudCambioDetalleValNP> ANSolicitudCambioDetalleValNPs { get; set; } = null!;
        public virtual DbSet<ANSolicitudCambioMovimiento> ANSolicitudCambioMovimientos { get; set; } = null!;
        public virtual DbSet<ANTipoCalculo> ANTipoCalculos { get; set; } = null!;
        public virtual DbSet<ANTipoPractica> ANTipoPracticas { get; set; } = null!;
        public virtual DbSet<ANTipoRestriccion> ANTipoRestriccions { get; set; } = null!;
        public virtual DbSet<ANTipoRestriccionValor> ANTipoRestriccionValors { get; set; } = null!;
        public virtual DbSet<ANTipoSolicitud> ANTipoSolicituds { get; set; } = null!;
        public virtual DbSet<ANTipoUnidad> ANTipoUnidads { get; set; } = null!;
        public virtual DbSet<AccionFarmacologica> AccionFarmacologicas { get; set; } = null!;
        public virtual DbSet<AcliseMayo> AcliseMayos { get; set; } = null!;
        public virtual DbSet<AcliseRX> AcliseRXes { get; set; } = null!;
        public virtual DbSet<AcreditacionesMedica> AcreditacionesMedicas { get; set; } = null!;
        public virtual DbSet<Afeccion> Afeccions { get; set; } = null!;
        public virtual DbSet<AfiAtsa> AfiAtsas { get; set; } = null!;
        public virtual DbSet<AfiInte> AfiIntes { get; set; } = null!;
        public virtual DbSet<AfiLuga> AfiLugas { get; set; } = null!;
        public virtual DbSet<AfiUPCN2> AfiUPCN2s { get; set; } = null!;
        public virtual DbSet<AfiUPCN3> AfiUPCN3s { get; set; } = null!;
        public virtual DbSet<AfiUpcn> AfiUpcns { get; set; } = null!;
        public virtual DbSet<Afiliado> Afiliados { get; set; } = null!;
        public virtual DbSet<AfiliadoLugarPago> AfiliadoLugarPago { get; set; } = null!;
        public virtual DbSet<AfiliadoCorregido> AfiliadoCorregidos { get; set; } = null!;
        public virtual DbSet<AfiliadoDbf> AfiliadoDbfs { get; set; } = null!;
        public virtual DbSet<AfiliadoMaestra> AfiliadoMaestras { get; set; } = null!;
        public virtual DbSet<AfiliadoNroTarjetaNroGenerado> AfiliadoNroTarjetaNroGenerados { get; set; } = null!;
        public virtual DbSet<AfiliadoNroTarjetaTarEstado> AfiliadoNroTarjetaTarEstados { get; set; } = null!;
        public virtual DbSet<AfiliadosAdicional> AfiliadosAdicionals { get; set; } = null!;
        public virtual DbSet<AfiliadosCentroDeImagen> AfiliadosCentroDeImagens { get; set; } = null!;
        public virtual DbSet<AfiliadosDDJJ> AfiliadosDDJJs { get; set; } = null!;
        public virtual DbSet<AfiliadosHistorico> AfiliadosHistoricos { get; set; } = null!;
        public virtual DbSet<AfiliadosHistoricoTrigger> AfiliadosHistoricoTriggers { get; set; } = null!;
        public virtual DbSet<AfiliadosLugarPago> AfiliadosLugarPagos { get; set; } = null!;
        public virtual DbSet<Afiliados_prueba> Afiliados_pruebas { get; set; } = null!;
        public virtual DbSet<Alcance_Debito> Alcance_Debitos { get; set; } = null!;
        public virtual DbSet<AlfaBeta_AccioFar> AlfaBeta_AccioFars { get; set; } = null!;
        public virtual DbSet<AlfaBeta_Barextra> AlfaBeta_Barextras { get; set; } = null!;
        public virtual DbSet<AlfaBeta_ExtraBarra> AlfaBeta_ExtraBarras { get; set; } = null!;
        public virtual DbSet<AlfaBeta_Forma> AlfaBeta_Formas { get; set; } = null!;
        public virtual DbSet<AlfaBeta_Gtin1> AlfaBeta_Gtin1s { get; set; } = null!;
        public virtual DbSet<AlfaBeta_ManExtra> AlfaBeta_ManExtras { get; set; } = null!;
        public virtual DbSet<AlfaBeta_ManPato> AlfaBeta_ManPatos { get; set; } = null!;
        public virtual DbSet<AlfaBeta_ManualDat> AlfaBeta_ManualDats { get; set; } = null!;
        public virtual DbSet<AlfaBeta_MonoDro> AlfaBeta_MonoDros { get; set; } = null!;
        public virtual DbSet<AlfaBeta_Multidro> AlfaBeta_Multidros { get; set; } = null!;
        public virtual DbSet<AlfaBeta_Nuevadro> AlfaBeta_Nuevadros { get; set; } = null!;
        public virtual DbSet<AlfaBeta_RegNueva> AlfaBeta_RegNuevas { get; set; } = null!;
        public virtual DbSet<AlfaBeta_tipoUnid> AlfaBeta_tipoUnids { get; set; } = null!;
        public virtual DbSet<AlfaBeta_uPotenci> AlfaBeta_uPotencis { get; set; } = null!;
        public virtual DbSet<AlfaBeta_via> AlfaBeta_vias { get; set; } = null!;
        public virtual DbSet<Alfabeta_Tamano> Alfabeta_Tamanos { get; set; } = null!;
        public virtual DbSet<Ampliacion_Presupuesto> Ampliacion_Presupuestos { get; set; } = null!;
        public virtual DbSet<Articulo> Articulos { get; set; } = null!;
        public virtual DbSet<AsientosModelo> AsientosModelos { get; set; } = null!;
        public virtual DbSet<AsientosPartida> AsientosPartidas { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AutorizaDbf> AutorizaDbfs { get; set; } = null!;
        public virtual DbSet<AutorizacionSepelios_Detalle> AutorizacionSepelios_Detalles { get; set; } = null!;
        public virtual DbSet<AutorizacionSepelios_Encabezado> AutorizacionSepelios_Encabezados { get; set; } = null!;
        public virtual DbSet<Autorizacione> Autorizaciones { get; set; } = null!;
        public virtual DbSet<AutorizacionesCirugia> AutorizacionesCirugias { get; set; } = null!;
        public virtual DbSet<AutorizacionesMedicamentos_b_> AutorizacionesMedicamentos_b_s { get; set; } = null!;
        public virtual DbSet<Auxiliar_Bonos_Viejo> Auxiliar_Bonos_Viejos { get; set; } = null!;
        public virtual DbSet<Banco> Bancos { get; set; } = null!;
        public virtual DbSet<Banner> Banners { get; set; } = null!;
        public virtual DbSet<BioquimicosConsumo> BioquimicosConsumos { get; set; } = null!;
        public virtual DbSet<BioquimicosDetalle> BioquimicosDetalles { get; set; } = null!;
        public virtual DbSet<BioquimicosEncabezado> BioquimicosEncabezados { get; set; } = null!;
        public virtual DbSet<BloqueoAfiliadoOnline> BloqueoAfiliadoOnlines { get; set; } = null!;
        public virtual DbSet<BloqueoPreguntaOnline> BloqueoPreguntaOnlines { get; set; } = null!;
        public virtual DbSet<BonosAutorizado> BonosAutorizados { get; set; } = null!;
        public virtual DbSet<BonosAutorizados_bak> BonosAutorizados_baks { get; set; } = null!;
        public virtual DbSet<CabeceraLote> CabeceraLote { get; set; } = null!;
        public virtual DbSet<CajaCierre> CajaCierres { get; set; } = null!;
        public virtual DbSet<CajaCierreDeposito> CajaCierreDepositos { get; set; } = null!;
        public virtual DbSet<CajaOperadore> CajaOperadores { get; set; } = null!;
        public virtual DbSet<CajaTipoOrigen> CajaTipoOrigens { get; set; } = null!;
        public virtual DbSet<CalculoPrecio> CalculoPrecios { get; set; } = null!;
        public virtual DbSet<Capitulo> Capitulos { get; set; } = null!;
        public virtual DbSet<Carrera_Inscripcion> Carrera_Inscripcions { get; set; } = null!;
        public virtual DbSet<CartaPresentacion> CartaPresentacions { get; set; } = null!;
        public virtual DbSet<CartaPresentacionGrupoFliar> CartaPresentacionGrupoFliars { get; set; } = null!;
        public virtual DbSet<Cartera> Carteras { get; set; } = null!;
        public virtual DbSet<Catastrofico> Catastroficos { get; set; } = null!;
        public virtual DbSet<CategoriaPapele> CategoriaPapeles { get; set; } = null!;
        public virtual DbSet<Categoria_Aerobica> Categoria_Aerobicas { get; set; } = null!;
        public virtual DbSet<CategoriasDbf> CategoriasDbfs { get; set; } = null!;
        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<CentroRubroPrestador> CentroRubroPrestadors { get; set; } = null!;
        public virtual DbSet<CentrosDeImagen> CentrosDeImagens { get; set; } = null!;
        public virtual DbSet<CentrosPorGrupoDomicilio> CentrosPorGrupoDomicilios { get; set; } = null!;
        public virtual DbSet<CentrosPorGrupoPractica> CentrosPorGrupoPracticas { get; set; } = null!;
        public virtual DbSet<CentrosPorGrupoPracticasDetalle> CentrosPorGrupoPracticasDetalles { get; set; } = null!;
        public virtual DbSet<CentrosPorGrupoPracticasHistorial> CentrosPorGrupoPracticasHistorials { get; set; } = null!;
        public virtual DbSet<CentrosVacunacion> CentrosVacunacions { get; set; } = null!;
        public virtual DbSet<Centros_Salud> Centros_Saluds { get; set; } = null!;
        public virtual DbSet<Cheque> Cheques { get; set; } = null!;
        public virtual DbSet<ChequeAMano> ChequeAManos { get; set; } = null!;
        public virtual DbSet<ChequesEnBlanco> ChequesEnBlancos { get; set; } = null!;
        public virtual DbSet<CierreFactura> CierreFacturas { get; set; } = null!;
        public virtual DbSet<ClasificadorGasto> ClasificadorGastos { get; set; } = null!;
        public virtual DbSet<ClinicaCoseguro> ClinicaCoseguros { get; set; } = null!;
        public virtual DbSet<Cobro_ImpresionTarjetum> Cobro_ImpresionTarjeta { get; set; } = null!;
        public virtual DbSet<Codigo_Esquema> Codigo_Esquemas { get; set; } = null!;
        public virtual DbSet<Colore> Colores { get; set; } = null!;
        public virtual DbSet<ComprasFarmacium> ComprasFarmacia { get; set; } = null!;
        public virtual DbSet<ComprasTipo> ComprasTipos { get; set; } = null!;
        public virtual DbSet<ConceptoCaja> ConceptoCajas { get; set; } = null!;
        public virtual DbSet<ConciliacionBancarium> ConciliacionBancaria { get; set; } = null!;
        public virtual DbSet<CondicionAfiliado> CondicionAfiliados { get; set; } = null!;
        public virtual DbSet<ConfirmaCambioCentro> ConfirmaCambioCentros { get; set; } = null!;
        public virtual DbSet<ConstanciasAfiliado> ConstanciasAfiliados { get; set; } = null!;
        public virtual DbSet<ConstanciasNoAfiliado> ConstanciasNoAfiliados { get; set; } = null!;
        public virtual DbSet<ConsumoDetalle> ConsumoDetalles { get; set; } = null!;
        public virtual DbSet<ConsumoEncabezado> ConsumoEncabezados { get; set; } = null!;
        public virtual DbSet<Contable_Gasto> Contable_Gastos { get; set; } = null!;
        public virtual DbSet<Contable_Recurso> Contable_Recursos { get; set; } = null!;
        public virtual DbSet<ContencionFliarDetalle> ContencionFliarDetalles { get; set; } = null!;
        public virtual DbSet<ContencionFliarEncabezado> ContencionFliarEncabezados { get; set; } = null!;
        public virtual DbSet<ContencionFliarTipoDefuncion> ContencionFliarTipoDefuncions { get; set; } = null!;
        public virtual DbSet<ControlCambiosCentro> ControlCambiosCentros { get; set; } = null!;
        public virtual DbSet<ConvenioPracticaFacturacion> ConvenioPracticaFacturacions { get; set; } = null!;
        public virtual DbSet<ConvenioReciprocidad> ConvenioReciprocidads { get; set; } = null!;
        public virtual DbSet<CoseguroPlan> CoseguroPlans { get; set; } = null!;
        public virtual DbSet<Coseguro_> Coseguro_s { get; set; } = null!;
        public virtual DbSet<Cosspra> Cosspras { get; set; } = null!;
        public virtual DbSet<Cotizaciones_Envio> Cotizaciones_Envios { get; set; } = null!;
        public virtual DbSet<Cotizaciones_Licitacione> Cotizaciones_Licitaciones { get; set; } = null!;
        public virtual DbSet<Cotizaciones_Pedido> Cotizaciones_Pedidos { get; set; } = null!;
        public virtual DbSet<Cotizaciones_PedidoDetalle> Cotizaciones_PedidoDetalles { get; set; } = null!;
        public virtual DbSet<Cotizaciones_Respuestum> Cotizaciones_Respuesta { get; set; } = null!;
        public virtual DbSet<CronogramaAfiliadoProf> CronogramaAfiliadoProfs { get; set; } = null!;
        public virtual DbSet<CronogramaModificacione> CronogramaModificaciones { get; set; } = null!;
        public virtual DbSet<CronogramaProfEducEsp> CronogramaProfEducEsps { get; set; } = null!;
        public virtual DbSet<CtaCte> CtaCtes { get; set; } = null!;
        public virtual DbSet<CtaCte_Correccion> CtaCte_Correccions { get; set; } = null!;
        public virtual DbSet<CtaCte_DetalleFactura> CtaCte_DetalleFacturas { get; set; } = null!;
        public virtual DbSet<CtaCte_EmpresasIosep> CtaCte_EmpresasIoseps { get; set; } = null!;
        public virtual DbSet<CtaCte_IosepSalud> CtaCte_IosepSaluds { get; set; } = null!;
        public virtual DbSet<Cuentas_Banco> Cuentas_Bancos { get; set; } = null!;
        public virtual DbSet<Cuentas_Contable> Cuentas_Contables { get; set; } = null!;
        public virtual DbSet<Cuentas_Contables_Tradicional> Cuentas_Contables_Tradicionals { get; set; } = null!;
        public virtual DbSet<CuotaImporte> CuotaImportes { get; set; } = null!;
        public virtual DbSet<CreditosAnexo> CreditosAnexo { get; set; } = null!;
        public virtual DbSet<CreditosNoEfectuados> CreditosNoEfectuados { get; set; } = null!;
        public virtual DbSet<CreditosMotivoNoefec> CreditosMotivoNoefec { get; set; } = null!;
        public virtual DbSet<CreditosLotes> CreditosLotes { get; set; } = null!;
        public virtual DbSet<CreditosCredito> CreditosCredito { get; set; } = null!;
        public virtual DbSet<CreditosHcablTcr> CreditosHcablTcr { get; set; } = null!;
        public virtual DbSet<CreditosHlotEcrd> CreditosHlotEcrd { get; set; } = null!;
        public virtual DbSet<CreditosFichacta> CreditosFichacta { get; set; } = null!;
        public virtual DbSet<CreditosConcCred> CreditosConcCred { get; set; } = null!;
        public virtual DbSet<CreditosDetalle> CreditosDetalle { get; set; } = null!;
        public virtual DbSet<CreditosLoteDetalles> CreditosLoteDetalles { get; set; } = null!;
        public virtual DbSet<CreditosPagosCredito> CreditosPagosCredito { get; set; } = null!;
        public virtual DbSet<CreditosSalarioAfiliado> CreditosSalarioAfiliado { get; set; } = null!;
        public virtual DbSet<CreditosMotivoCancelado> CreditosMotivoCancelado { get; set; } = null!;
        public virtual DbSet<CreditosGarante> CreditosGarante { get; set; } = null!;
        public virtual DbSet<CreditoExtraJudicial> CreditoExtraJudicial { get; set; } = null!;
        public virtual DbSet<Ddjj> Ddjjs { get; set; } = null!;
        public virtual DbSet<Ddjj_Header> Ddjj_Headers { get; set; } = null!;
        public virtual DbSet<DelegacionPrestador> DelegacionPrestadors { get; set; } = null!;
        public virtual DbSet<Delegacione> Delegaciones { get; set; } = null!;
        public virtual DbSet<DetalleCartaPresentacion> DetalleCartaPresentacions { get; set; } = null!;
        public virtual DbSet<DetalleConvenio> DetalleConvenios { get; set; } = null!;
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; } = null!;
        public virtual DbSet<DetalleNotaDeCredito> DetalleNotaDeCreditos { get; set; } = null!;
        public virtual DbSet<DetallePreBono> DetallePreBonos { get; set; } = null!;
        public virtual DbSet<Detalle_AsientoModelo> Detalle_AsientoModelos { get; set; } = null!;
        public virtual DbSet<Detalle_Autorizacione> Detalle_Autorizaciones { get; set; } = null!;
        public virtual DbSet<Detalle_AutorizacionesAuditorium> Detalle_AutorizacionesAuditoria { get; set; } = null!;
        public virtual DbSet<Detalle_AutorizacionesModificado> Detalle_AutorizacionesModificados { get; set; } = null!;
        public virtual DbSet<Detalle_AutorizacionesPrueba> Detalle_AutorizacionesPruebas { get; set; } = null!;
        public virtual DbSet<Detalle_PresupuestoAutorizacione> Detalle_PresupuestoAutorizaciones { get; set; } = null!;
        public virtual DbSet<Dia> Dias { get; set; } = null!;
        public virtual DbSet<DiaCon_Borrar> DiaCon_Borrars { get; set; } = null!;
        public virtual DbSet<DiaInternado> DiaInternados { get; set; } = null!;
        public virtual DbSet<Diag> Diags { get; set; } = null!;
        public virtual DbSet<Diagnostico> Diagnosticos { get; set; } = null!;
        public virtual DbSet<DiagnosticoImagen> DiagnosticoImagens { get; set; } = null!;
        public virtual DbSet<DiagnosticoRelacionado> DiagnosticoRelacionados { get; set; } = null!;
        public virtual DbSet<DiagnosticoRelacionadoDetalle> DiagnosticoRelacionadoDetalles { get; set; } = null!;
        public virtual DbSet<Diagnosticos_Esquema> Diagnosticos_Esquemas { get; set; } = null!;
        public virtual DbSet<Discapacitado> Discapacitados { get; set; } = null!;
        public virtual DbSet<Domicilio> Domicilios { get; set; } = null!;
        public virtual DbSet<DomiciliosDDJJ> DomiciliosDDJJs { get; set; } = null!;
        public virtual DbSet<DomiciliosHabiltado> DomiciliosHabiltados { get; set; } = null!;
        public virtual DbSet<Edades_Vacuna> Edades_Vacunas { get; set; } = null!;
        public virtual DbSet<EmpresaSeguro> EmpresaSeguros { get; set; } = null!;
        public virtual DbSet<EmpresasAfiliadosDDJJ> EmpresasAfiliadosDDJJs { get; set; } = null!;
        public virtual DbSet<Empresas_Afiliado> Empresas_Afiliados { get; set; } = null!;
        public virtual DbSet<Empresas_IosepSalud> Empresas_IosepSaluds { get; set; } = null!;
        public virtual DbSet<EncabezadoConvenio> EncabezadoConvenios { get; set; } = null!;
        public virtual DbSet<EncabezadoNotaDeCredito> EncabezadoNotaDeCreditos { get; set; } = null!;
        public virtual DbSet<EncabezadoPreBono> EncabezadoPreBonos { get; set; } = null!;
        public virtual DbSet<Encabezado_AsientoModelo> Encabezado_AsientoModelos { get; set; } = null!;
        public virtual DbSet<Encabezado_AutorizacionAuditor> Encabezado_AutorizacionAuditors { get; set; } = null!;
        public virtual DbSet<Encabezado_AutorizacionAuditorPresup> Encabezado_AutorizacionAuditorPresups { get; set; } = null!;
        public virtual DbSet<Encabezado_Autorizacione> Encabezado_Autorizaciones { get; set; } = null!;
        public virtual DbSet<Encabezado_AutorizacionesAuditorium> Encabezado_AutorizacionesAuditoria { get; set; } = null!;
        public virtual DbSet<Encabezado_Factura> Encabezado_Facturas { get; set; } = null!;
        public virtual DbSet<Encabezado_PresupuestoAutorizacione> Encabezado_PresupuestoAutorizaciones { get; set; } = null!;
        public virtual DbSet<Enfermedades_Vacuna> Enfermedades_Vacunas { get; set; } = null!;
        public virtual DbSet<EntidadBancarium> EntidadBancaria { get; set; } = null!;
        public virtual DbSet<EquiposPractica> EquiposPracticas { get; set; } = null!;
        public virtual DbSet<Escuela> Escuelas { get; set; } = null!;
        public virtual DbSet<EscuelasDBF> EscuelasDBFs { get; set; } = null!;
        public virtual DbSet<EscuelasSPEP> EscuelasSPEPs { get; set; } = null!;
        public virtual DbSet<EspecialidadDDJJ> EspecialidadDDJJs { get; set; } = null!;
        public virtual DbSet<Especialidade> Especialidades { get; set; } = null!;
        public virtual DbSet<EsquemaDiasCobertura> EsquemaDiasCoberturas { get; set; } = null!;
        public virtual DbSet<Esquemas_Afiliado> Esquemas_Afiliados { get; set; } = null!;
        public virtual DbSet<Est_Iosep> Est_Ioseps { get; set; } = null!;
        public virtual DbSet<EstadoCivil> EstadoCivils { get; set; } = null!;
        public virtual DbSet<EstadoConsultaWebService> EstadoConsultaWebServices { get; set; } = null!;
        public virtual DbSet<Estado_NotaDePedido> Estado_NotaDePedidos { get; set; } = null!;
        public virtual DbSet<Estados_Cuenta> Estados_Cuentas { get; set; } = null!;
        public virtual DbSet<Estados_Internacion> Estados_Internacions { get; set; } = null!;
        public virtual DbSet<ExpedienteGlosado> ExpedienteGlosados { get; set; } = null!;
        public virtual DbSet<ExpedientesDigitalizado> ExpedientesDigitalizados { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Fallecido> Fallecidos { get; set; } = null!;
        public virtual DbSet<FarmaciaArchivo> FarmaciaArchivos { get; set; } = null!;
        public virtual DbSet<FarmaciaArchivosCierre> FarmaciaArchivosCierres { get; set; } = null!;
        public virtual DbSet<FarmaciaArchivosReceta> FarmaciaArchivosRecetas { get; set; } = null!;
        public virtual DbSet<FecliseNV> FecliseNVs { get; set; } = null!;
        public virtual DbSet<FormaPagoPractica> FormaPagoPracticas { get; set; } = null!;
        public virtual DbSet<Gastos_Compromiso> Gastos_Compromisos { get; set; } = null!;
        public virtual DbSet<Gastos_Preventivo> Gastos_Preventivos { get; set; } = null!;
        public virtual DbSet<Generado_Lugar> Generado_Lugars { get; set; } = null!;
        public virtual DbSet<Gerenciador> Gerenciadors { get; set; } = null!;
        public virtual DbSet<Gremio> Gremios { get; set; } = null!;
        public virtual DbSet<GremioLiquidacion> GremioLiquidacions { get; set; } = null!;
        public virtual DbSet<GrupoDetallePractica> GrupoDetallePracticas { get; set; } = null!;
        public virtual DbSet<GrupoDetallePrestadore> GrupoDetallePrestadores { get; set; } = null!;
        public virtual DbSet<GrupoDetalleSanatorio> GrupoDetalleSanatorios { get; set; } = null!;
        public virtual DbSet<GrupoPractica> GrupoPracticas { get; set; } = null!;
        public virtual DbSet<GrupoPracticasConfiguracion> GrupoPracticasConfiguracions { get; set; } = null!;
        public virtual DbSet<GrupoPrestadore> GrupoPrestadores { get; set; } = null!;
        public virtual DbSet<GrupoSanatorio> GrupoSanatorios { get; set; } = null!;
        public virtual DbSet<Grupos_Vacuna> Grupos_Vacunas { get; set; } = null!;
        public virtual DbSet<HCDigitalizadum> HCDigitalizada { get; set; } = null!;
        public virtual DbSet<HistoriaClinica> HistoriaClinicas { get; set; } = null!;
        public virtual DbSet<HistorialAuditorium> HistorialAuditoria { get; set; } = null!;
        public virtual DbSet<HistorialEmpresas_IosepSalud> HistorialEmpresas_IosepSaluds { get; set; } = null!;
        public virtual DbSet<HistorialMontoCarnet> HistorialMontoCarnets { get; set; } = null!;
        public virtual DbSet<HistorialMontoCredito> HistorialMontoCreditos { get; set; } = null!;
        public virtual DbSet<HistoricoCronogramaAfiliadoProf> HistoricoCronogramaAfiliadoProfs { get; set; } = null!;
        public virtual DbSet<HistoricoMovimientosPartida> HistoricoMovimientosPartidas { get; set; } = null!;
        public virtual DbSet<Historico_EstadosCuenta> Historico_EstadosCuentas { get; set; } = null!;
        public virtual DbSet<I_AutoriDbf> I_AutoriDbfs { get; set; } = null!;
        public virtual DbSet<ImpactarTucNorte> ImpactarTucNortes { get; set; } = null!;
        public virtual DbSet<ImpactarTucParque> ImpactarTucParques { get; set; } = null!;
        public virtual DbSet<Imprimir> Imprimirs { get; set; } = null!;
        public virtual DbSet<ImputacionesPagoFactura> ImputacionesPagoFacturas { get; set; } = null!;
        public virtual DbSet<InformeImpresion> InformeImpresions { get; set; } = null!;
        public virtual DbSet<Ingreso> Ingresos { get; set; } = null!;
        public virtual DbSet<IngresosMunicipio> IngresosMunicipios { get; set; } = null!;
        public virtual DbSet<IngresosMunicipiosTest> IngresosMunicipiosTests { get; set; } = null!;
        public virtual DbSet<Inmuniza_Vacuna> Inmuniza_Vacunas { get; set; } = null!;
        public virtual DbSet<Instructivo> Instructivos { get; set; } = null!;
        public virtual DbSet<InteresPorCredito> InteresPorCreditos { get; set; } = null!;
        public virtual DbSet<Internado> Internados { get; set; } = null!;
        public virtual DbSet<InternadoGremio> InternadoGremios { get; set; } = null!;
        public virtual DbSet<InternadosAfeccion> InternadosAfeccions { get; set; } = null!;
        public virtual DbSet<InternadosAutoriza> InternadosAutorizas { get; set; } = null!;
        public virtual DbSet<InternadosControl> InternadosControls { get; set; } = null!;
        public virtual DbSet<InternadosDetalleMedicamento> InternadosDetalleMedicamentos { get; set; } = null!;
        public virtual DbSet<InternadosEstudio> InternadosEstudios { get; set; } = null!;
        public virtual DbSet<InternadosEvolucion> InternadosEvolucions { get; set; } = null!;
        public virtual DbSet<InternadosLog> InternadosLogs { get; set; } = null!;
        public virtual DbSet<InternadosMedicamento> InternadosMedicamentos { get; set; } = null!;
        public virtual DbSet<InternadosQuirofano> InternadosQuirofanos { get; set; } = null!;
        public virtual DbSet<InternadosQuirofanoDetalle> InternadosQuirofanoDetalles { get; set; } = null!;
        public virtual DbSet<InternadosSector> InternadosSectors { get; set; } = null!;
        public virtual DbSet<IosepSaludBanco> IosepSaludBancos { get; set; } = null!;
        public virtual DbSet<IosepSaludBancoDetalle> IosepSaludBancoDetalles { get; set; } = null!;
        public virtual DbSet<IosepSaludHistorialCuota> IosepSaludHistorialCuotas { get; set; } = null!;
        public virtual DbSet<IosepSaludHistorialCuotasEmp> IosepSaludHistorialCuotasEmps { get; set; } = null!;
        public virtual DbSet<Jubilado> Jubilados { get; set; } = null!;
        public virtual DbSet<JubiladosComputo> JubiladosComputos { get; set; } = null!;
        public virtual DbSet<LegajoColegio> LegajoColegios { get; set; } = null!;
        public virtual DbSet<LimiteMontoGerencium> LimiteMontoGerencia { get; set; } = null!;
        public virtual DbSet<LiquidacionGremiosDetalle> LiquidacionGremiosDetalles { get; set; } = null!;
        public virtual DbSet<LiquidacionGremiosEncabezado> LiquidacionGremiosEncabezados { get; set; } = null!;
        public virtual DbSet<Listum> Lista { get; set; } = null!;
        public virtual DbSet<Localidade> Localidades { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<LogBajasProcesoNocturno> LogBajasProcesoNocturnos { get; set; } = null!;
        public virtual DbSet<LogCantidadBonosAnulado> LogCantidadBonosAnulados { get; set; } = null!;
        public virtual DbSet<LogExcepcione> LogExcepciones { get; set; } = null!;
        public virtual DbSet<LogGeneral> LogGenerals { get; set; } = null!;
        public virtual DbSet<LogHistoricoActivacion> LogHistoricoActivacions { get; set; } = null!;
        public virtual DbSet<LogWSConvenio> LogWSConvenios { get; set; } = null!;
        public virtual DbSet<LugarPagoDDJJ> LugarPagoDDJJs { get; set; } = null!;
        public virtual DbSet<ManualDatCobertura> ManualDatCoberturas { get; set; } = null!;
        public virtual DbSet<ManualDatCoberturaEncabezado> ManualDatCoberturaEncabezados { get; set; } = null!;
        public virtual DbSet<ManualDatHistorico> ManualDatHistoricos { get; set; } = null!;
        public virtual DbSet<MatsaImagenNorte> MatsaImagenNortes { get; set; } = null!;
        public virtual DbSet<Medicacion_Detalle_Esquema> Medicacion_Detalle_Esquemas { get; set; } = null!;
        public virtual DbSet<Medicacion_Detalle_Plane> Medicacion_Detalle_Planes { get; set; } = null!;
        public virtual DbSet<Medicacion_Esquema> Medicacion_Esquemas { get; set; } = null!;
        public virtual DbSet<Medicacion_plane> Medicacion_planes { get; set; } = null!;
        public virtual DbSet<MedicamentosCatastrofico> MedicamentosCatastroficos { get; set; } = null!;
        public virtual DbSet<MedicamentosRedFarmacium> MedicamentosRedFarmacia { get; set; } = null!;
        public virtual DbSet<Mese> Meses { get; set; } = null!;
        public virtual DbSet<Motivo> Motivos { get; set; } = null!;
        public virtual DbSet<MotivoAnulaCobroInt> MotivoAnulaCobroInts { get; set; } = null!;
        public virtual DbSet<MotivoAuditorium> MotivoAuditoria { get; set; } = null!;
        public virtual DbSet<MotivoBaja> MotivoBajas { get; set; } = null!;
        public virtual DbSet<MotivoCambioCentro> MotivoCambioCentros { get; set; } = null!;
        public virtual DbSet<MotivoCobertura> MotivoCoberturas { get; set; } = null!;
        public virtual DbSet<MotivoConstancium> MotivoConstancia { get; set; } = null!;
        public virtual DbSet<MotivoDerivacion> MotivoDerivacions { get; set; } = null!;
        public virtual DbSet<MotivoError> MotivoErrors { get; set; } = null!;
        public virtual DbSet<MotivoRestauracion> MotivoRestauracions { get; set; } = null!;
        public virtual DbSet<Motivo_Ganador> Motivo_Ganadors { get; set; } = null!;
        public virtual DbSet<Motivo_Reimpresion> Motivo_Reimpresions { get; set; } = null!;
        public virtual DbSet<MovimientoPracticasInternado> MovimientoPracticasInternados { get; set; } = null!;
        public virtual DbSet<Movimiento_Cuentum> Movimiento_Cuenta { get; set; } = null!;
        public virtual DbSet<MovimientosExpediente> MovimientosExpedientes { get; set; } = null!;
        public virtual DbSet<MovimientosInternado> MovimientosInternados { get; set; } = null!;
        public virtual DbSet<Movimientos_Vacuna> Movimientos_Vacunas { get; set; } = null!;
        public virtual DbSet<MujeresASuspender> MujeresASuspenders { get; set; } = null!;
        public virtual DbSet<Mujeres_Geriatrica> Mujeres_Geriatricas { get; set; } = null!;
        public virtual DbSet<Municipio> Municipios { get; set; } = null!;
        public virtual DbSet<NAsociadas_Autoriza> NAsociadas_Autorizas { get; set; } = null!;
        public virtual DbSet<NAsociadas_Facturacion> NAsociadas_Facturacions { get; set; } = null!;
        public virtual DbSet<NBU_9Julio> NBU_9Julios { get; set; } = null!;
        public virtual DbSet<NBU_Modelo> NBU_Modelos { get; set; } = null!;
        public virtual DbSet<NBU_Norte> NBU_Nortes { get; set; } = null!;
        public virtual DbSet<NBU_Parque> NBU_Parques { get; set; } = null!;
        public virtual DbSet<NCapitulo> NCapitulos { get; set; } = null!;
        public virtual DbSet<NEncabezado_Nomenclador> NEncabezado_Nomencladors { get; set; } = null!;
        public virtual DbSet<NExcluye_Autoriza> NExcluye_Autorizas { get; set; } = null!;
        public virtual DbSet<NExcluye_Facturacion> NExcluye_Facturacions { get; set; } = null!;
        public virtual DbSet<NNivel_Nomenclador> NNivel_Nomencladors { get; set; } = null!;
        public virtual DbSet<NNivel_Practica> NNivel_Practicas { get; set; } = null!;
        public virtual DbSet<NNomenclador> NNomencladors { get; set; } = null!;
        public virtual DbSet<NNomenclador_Base> NNomenclador_Bases { get; set; } = null!;
        public virtual DbSet<NPracticasAsociada> NPracticasAsociadas { get; set; } = null!;
        public virtual DbSet<NPracticas_Base> NPracticas_Bases { get; set; } = null!;
        public virtual DbSet<NRestriccione> NRestricciones { get; set; } = null!;
        public virtual DbSet<NTipo_Calculo> NTipo_Calculos { get; set; } = null!;
        public virtual DbSet<NTipo_Gasto> NTipo_Gastos { get; set; } = null!;
        public virtual DbSet<NTipo_Nomenclador> NTipo_Nomencladors { get; set; } = null!;
        public virtual DbSet<NTipo_Practica> NTipo_Practicas { get; set; } = null!;
        public virtual DbSet<NTipo_Unidad> NTipo_Unidads { get; set; } = null!;
        public virtual DbSet<NivelEscuela> NivelEscuelas { get; set; } = null!;
        public virtual DbSet<NomCapitulo> NomCapitulos { get; set; } = null!;
        public virtual DbSet<NomPracticaBase> NomPracticaBases { get; set; } = null!;
        public virtual DbSet<NomPracticaConvenio> NomPracticaConvenios { get; set; } = null!;
        public virtual DbSet<NomPracticaConvenioDetalle> NomPracticaConvenioDetalles { get; set; } = null!;
        public virtual DbSet<NomPracticaConvenioExcepcion> NomPracticaConvenioExcepcions { get; set; } = null!;
        public virtual DbSet<NomPracticaConvenioExcepcionDetalle> NomPracticaConvenioExcepcionDetalles { get; set; } = null!;
        public virtual DbSet<NomPracticaConvenioInactivacion> NomPracticaConvenioInactivacions { get; set; } = null!;
        public virtual DbSet<NomPracticaConvenioResolucion> NomPracticaConvenioResolucions { get; set; } = null!;
        public virtual DbSet<NomPracticaConvenioRestriccion> NomPracticaConvenioRestriccions { get; set; } = null!;
        public virtual DbSet<NomPracticaConvenioUnidad> NomPracticaConvenioUnidads { get; set; } = null!;
        public virtual DbSet<NomSubCapitulo> NomSubCapitulos { get; set; } = null!;
        public virtual DbSet<Nomen_Pension> Nomen_Pensions { get; set; } = null!;
        public virtual DbSet<Nomen_TipoUnidad> Nomen_TipoUnidads { get; set; } = null!;
        public virtual DbSet<Nomen_Unidade> Nomen_Unidades { get; set; } = null!;
        public virtual DbSet<Nomen_Valore> Nomen_Valores { get; set; } = null!;
        public virtual DbSet<Nomen_Vigencia> Nomen_Vigencias { get; set; } = null!;
        public virtual DbSet<NomenclaDbf> NomenclaDbfs { get; set; } = null!;
        public virtual DbSet<Nomenclador_Back> Nomenclador_Backs { get; set; } = null!;
        public virtual DbSet<Nomenclador_Vigencium> Nomenclador_Vigencia { get; set; } = null!;
        public virtual DbSet<NominaAnse> NominaAnses { get; set; } = null!;
        public virtual DbSet<NotaPedido_Detalle> NotaPedido_Detalles { get; set; } = null!;
        public virtual DbSet<NotaPedido_Detalle_Presupuesto> NotaPedido_Detalle_Presupuestos { get; set; } = null!;
        public virtual DbSet<NotaPedido_Encabezado> NotaPedido_Encabezados { get; set; } = null!;
        public virtual DbSet<NotaPedido_Presupuesto> NotaPedido_Presupuestos { get; set; } = null!;
        public virtual DbSet<NotaPedido_Proveedore> NotaPedido_Proveedores { get; set; } = null!;
        public virtual DbSet<NotasAuditoriaInternado> NotasAuditoriaInternados { get; set; } = null!;
        public virtual DbSet<NroTarjetum> NroTarjeta { get; set; } = null!;
        public virtual DbSet<NumeroCirugium> NumeroCirugia { get; set; } = null!;
        public virtual DbSet<Numeros_Movimiento> Numeros_Movimientos { get; set; } = null!;
        public virtual DbSet<ObrasSociale> ObrasSociales { get; set; } = null!;
        public virtual DbSet<OrdenAnuladaParaExpediente> OrdenAnuladaParaExpedientes { get; set; } = null!;
        public virtual DbSet<OrdenCompra_Comprobante> OrdenCompra_Comprobantes { get; set; } = null!;
        public virtual DbSet<OrdenCompra_Encabezado> OrdenCompra_Encabezados { get; set; } = null!;
        public virtual DbSet<OrdenPago_Anticipo> OrdenPago_Anticipos { get; set; } = null!;
        public virtual DbSet<OrdenPago_Beneficiario> OrdenPago_Beneficiarios { get; set; } = null!;
        public virtual DbSet<OrdenPago_CuentaContable> OrdenPago_CuentaContables { get; set; } = null!;
        public virtual DbSet<OrdenPago_DetalleCheque> OrdenPago_DetalleCheques { get; set; } = null!;
        public virtual DbSet<OrdenPago_Retencione> OrdenPago_Retenciones { get; set; } = null!;
        public virtual DbSet<OrdenSinCoseguro> OrdenSinCoseguros { get; set; } = null!;
        public virtual DbSet<Orden_Pago> Orden_Pagos { get; set; } = null!;
        public virtual DbSet<Ordene> Ordenes { get; set; } = null!;
        public virtual DbSet<OrdenesCobra> OrdenesCobras { get; set; } = null!;
        public virtual DbSet<OrdenesDbf> OrdenesDbfs { get; set; } = null!;
        public virtual DbSet<OrdenesExportar> OrdenesExportars { get; set; } = null!;
        public virtual DbSet<OrdenesExtra> OrdenesExtras { get; set; } = null!;
        public virtual DbSet<OrdenesManuale> OrdenesManuales { get; set; } = null!;
        public virtual DbSet<OrdenesTemporal> OrdenesTemporals { get; set; } = null!;
        public virtual DbSet<Ordenes_ContadorDBF> Ordenes_ContadorDBFs { get; set; } = null!;
        public virtual DbSet<Ordenes_Detalle> Ordenes_Detalles { get; set; } = null!;
        public virtual DbSet<Ordenes_Key> Ordenes_Keys { get; set; } = null!;
        public virtual DbSet<OtrosPrecio> OtrosPrecios { get; set; } = null!;
        public virtual DbSet<PROFE> PROves { get; set; } = null!;
        public virtual DbSet<PadronCM> PadronCMs { get; set; } = null!;
        public virtual DbSet<PadronImagenxCentro> PadronImagenxCentros { get; set; } = null!;
        public virtual DbSet<Pagos_Impresion> Pagos_Impresions { get; set; } = null!;
        public virtual DbSet<Paise> Paises { get; set; } = null!;
        public virtual DbSet<Papele> Papeles { get; set; } = null!;
        public virtual DbSet<PapelesDDJJ> PapelesDDJJs { get; set; } = null!;
        public virtual DbSet<PapelesDigitalizadosDDJJ> PapelesDigitalizadosDDJJs { get; set; } = null!;
        public virtual DbSet<ParametrosHoraHabil> ParametrosHoraHabils { get; set; } = null!;
        public virtual DbSet<ParametrosHoraHabilDetalle> ParametrosHoraHabilDetalles { get; set; } = null!;
        public virtual DbSet<Parcial_BonosTXT> Parcial_BonosTXTs { get; set; } = null!;
        public virtual DbSet<Pat_Biene> Pat_Bienes { get; set; } = null!;
        public virtual DbSet<Pat_DepreciacionDetalle> Pat_DepreciacionDetalles { get; set; } = null!;
        public virtual DbSet<Pat_Depreciacion_Resuman> Pat_Depreciacion_Resumen { get; set; } = null!;
        public virtual DbSet<Pat_GrupoBiene> Pat_GrupoBienes { get; set; } = null!;
        public virtual DbSet<Pat_Mejora> Pat_Mejoras { get; set; } = null!;
        public virtual DbSet<Pat_Movimiento> Pat_Movimientos { get; set; } = null!;
        public virtual DbSet<Pat_Reparacion> Pat_Reparacions { get; set; } = null!;
        public virtual DbSet<Pat_Reparacion_Detalle> Pat_Reparacion_Detalles { get; set; } = null!;
        public virtual DbSet<Patologia> Patologias { get; set; } = null!;
        public virtual DbSet<PedidoInterno_Detalle> PedidoInterno_Detalles { get; set; } = null!;
        public virtual DbSet<PedidoInterno_Encabezado> PedidoInterno_Encabezados { get; set; } = null!;
        public virtual DbSet<PedidoInterno_Motivo> PedidoInterno_Motivos { get; set; } = null!;
        public virtual DbSet<PedidoInterno_NotaPedido> PedidoInterno_NotaPedidos { get; set; } = null!;
        public virtual DbSet<PeriodosFacturacion> PeriodosFacturacions { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Persona_Tipo> Persona_Tipos { get; set; } = null!;
        public virtual DbSet<Personas_TipoDetalle> Personas_TipoDetalles { get; set; } = null!;
        public virtual DbSet<PlanDiagnostico> PlanDiagnosticos { get; set; } = null!;
        public virtual DbSet<PlanDiasCobertura> PlanDiasCoberturas { get; set; } = null!;
        public virtual DbSet<PlanEspecialidade> PlanEspecialidades { get; set; } = null!;
        public virtual DbSet<PlanMotivosDerivacion> PlanMotivosDerivacions { get; set; } = null!;
        public virtual DbSet<PlanTipoOperabilidad> PlanTipoOperabilidads { get; set; } = null!;
        public virtual DbSet<PlanUsuario> PlanUsuarios { get; set; } = null!;
        public virtual DbSet<Plane> Planes { get; set; } = null!;
        public virtual DbSet<PlanesAfiliado_Resolucion> PlanesAfiliado_Resolucions { get; set; } = null!;
        public virtual DbSet<Planes_Afiliado> Planes_Afiliados { get; set; } = null!;
        public virtual DbSet<Planes_Detalle> Planes_Detalles { get; set; } = null!;
        public virtual DbSet<Planes_VigenciaOnline> Planes_VigenciaOnlines { get; set; } = null!;
        public virtual DbSet<PorcentajeVium> PorcentajeVia { get; set; } = null!;
        public virtual DbSet<Practica> Practicas { get; set; } = null!;
        public virtual DbSet<PracticaCarencium> PracticaCarencia { get; set; } = null!;
        public virtual DbSet<PracticaFechaVencimiento> PracticaFechaVencimientos { get; set; } = null!;
        public virtual DbSet<PracticaPlanAutorizacion> PracticaPlanAutorizacions { get; set; } = null!;
        public virtual DbSet<PracticaPlanAutorizacionPresup> PracticaPlanAutorizacionPresups { get; set; } = null!;
        public virtual DbSet<PracticaPlanPresupAuditorium> PracticaPlanPresupAuditoria { get; set; } = null!;
        public virtual DbSet<PracticaTurno> PracticaTurnos { get; set; } = null!;
        public virtual DbSet<PracticasDelegacion> PracticasDelegacions { get; set; } = null!;
        public virtual DbSet<Practicas_esquema> Practicas_esquemas { get; set; } = null!;
        public virtual DbSet<Practicas_plane> Practicas_planes { get; set; } = null!;
        public virtual DbSet<PreciosAclise> PreciosAclises { get; set; } = null!;
        public virtual DbSet<PreciosColegio> PreciosColegios { get; set; } = null!;
        public virtual DbSet<PrescripcionElectronica> PrescripcionElectronicas { get; set; } = null!;
        public virtual DbSet<PrescripcionRecetum> PrescripcionReceta { get; set; } = null!;
        public virtual DbSet<PrescripcionRenglon> PrescripcionRenglons { get; set; } = null!;
        public virtual DbSet<PrestPlanificacion> PrestPlanificacions { get; set; } = null!;
        public virtual DbSet<PrestPlanificacionDetalle> PrestPlanificacionDetalles { get; set; } = null!;
        public virtual DbSet<PrestadorBloqueoDesbloqueo> PrestadorBloqueoDesbloqueos { get; set; } = null!;
        public virtual DbSet<PrestadorDDJJ> PrestadorDDJJs { get; set; } = null!;
        public virtual DbSet<PrestadorDDJJAcreditacionMedica> PrestadorDDJJAcreditacionMedicas { get; set; } = null!;
        public virtual DbSet<PrestadorDDJJDomiciliosHabilitado> PrestadorDDJJDomiciliosHabilitados { get; set; } = null!;
        public virtual DbSet<PrestadorDDJJEquiposPractica> PrestadorDDJJEquiposPracticas { get; set; } = null!;
        public virtual DbSet<PrestadorDDJJGerenciador> PrestadorDDJJGerenciadors { get; set; } = null!;
        public virtual DbSet<PrestadorDDJJReclamo> PrestadorDDJJReclamos { get; set; } = null!;
        public virtual DbSet<PrestadorDDJJServicioCentro> PrestadorDDJJServicioCentros { get; set; } = null!;
        public virtual DbSet<PrestadorDDJJServicioRealiza> PrestadorDDJJServicioRealizas { get; set; } = null!;
        public virtual DbSet<PrestadorDDJJSuspendido> PrestadorDDJJSuspendidos { get; set; } = null!;
        public virtual DbSet<PrestadorEspecialidadDDJJ> PrestadorEspecialidadDDJJs { get; set; } = null!;
        public virtual DbSet<PrestadorEstado> PrestadorEstados { get; set; } = null!;
        public virtual DbSet<PrestadorEstadoHistorico> PrestadorEstadoHistoricos { get; set; } = null!;
        public virtual DbSet<PrestadorHabilitacion> PrestadorHabilitacions { get; set; } = null!;
        public virtual DbSet<PrestadorMotivoReclamo> PrestadorMotivoReclamos { get; set; } = null!;
        public virtual DbSet<PrestadorMotivoSuspension> PrestadorMotivoSuspensions { get; set; } = null!;
        public virtual DbSet<Prestadore> Prestadores { get; set; } = null!;
        public virtual DbSet<PrestadoresCobise> PrestadoresCobises { get; set; } = null!;
        public virtual DbSet<PrestadoresMatriculado> PrestadoresMatriculados { get; set; } = null!;
        public virtual DbSet<PrestadoresMatriculadosCopium> PrestadoresMatriculadosCopia { get; set; } = null!;
        public virtual DbSet<PrestadoresMatriculados_> PrestadoresMatriculados_s { get; set; } = null!;
        public virtual DbSet<PrestadoresNovedadTrigger> PrestadoresNovedadTriggers { get; set; } = null!;
        public virtual DbSet<Presupuesto> Presupuestos { get; set; } = null!;
        public virtual DbSet<Presupuesto_Contable> Presupuesto_Contables { get; set; } = null!;
        public virtual DbSet<Presupuesto_Motivo> Presupuesto_Motivos { get; set; } = null!;
        public virtual DbSet<PresupuestosDetalle> PresupuestosDetalles { get; set; } = null!;
        public virtual DbSet<ProfesionalXFarmacium> ProfesionalXFarmacia { get; set; } = null!;
        public virtual DbSet<ProtesisDetalleSolicitud> ProtesisDetalleSolicituds { get; set; } = null!;
        public virtual DbSet<ProtesisDiagnosticoSolicitud> ProtesisDiagnosticoSolicituds { get; set; } = null!;
        public virtual DbSet<ProtesisEncabezadoSolicitud> ProtesisEncabezadoSolicituds { get; set; } = null!;
        public virtual DbSet<ProtesisEspecialidad> ProtesisEspecialidads { get; set; } = null!;
        public virtual DbSet<ProtesisGenerico> ProtesisGenericos { get; set; } = null!;
        public virtual DbSet<ProtesisMarca> ProtesisMarcas { get; set; } = null!;
        public virtual DbSet<ProtesisNombreComercial> ProtesisNombreComercials { get; set; } = null!;
        public virtual DbSet<ProtesisNomenclador> ProtesisNomencladors { get; set; } = null!;
        public virtual DbSet<ProtesisOrigen> ProtesisOrigens { get; set; } = null!;
        public virtual DbSet<ProtesisPlan> ProtesisPlans { get; set; } = null!;
        public virtual DbSet<ProtesisRubro> ProtesisRubros { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<Provincia> Provincias { get; set; } = null!;
        public virtual DbSet<ProvistoPor> ProvistoPors { get; set; } = null!;
        public virtual DbSet<Prueba_duplicado> Prueba_duplicados { get; set; } = null!;
        public virtual DbSet<Quirofano> Quirofanos { get; set; } = null!;
        public virtual DbSet<RadioColegio> RadioColegios { get; set; } = null!;
        public virtual DbSet<Radiologium> Radiologia { get; set; } = null!;
        public virtual DbSet<ReajusteCredito> ReajusteCreditos { get; set; } = null!;
        public virtual DbSet<RectificarPase> RectificarPases { get; set; } = null!;
        public virtual DbSet<RedLink_ArchivoControl> RedLink_ArchivoControls { get; set; } = null!;
        public virtual DbSet<RedLink_ArchivoControlDetalle> RedLink_ArchivoControlDetalles { get; set; } = null!;
        public virtual DbSet<RedLink_ArchivoExtract> RedLink_ArchivoExtracts { get; set; } = null!;
        public virtual DbSet<RedLink_ArchivoExtractDetalle> RedLink_ArchivoExtractDetalles { get; set; } = null!;
        public virtual DbSet<RedLink_ArchivoRefresh> RedLink_ArchivoRefreshes { get; set; } = null!;
        public virtual DbSet<RedLink_ArchivoRefreshDetalle> RedLink_ArchivoRefreshDetalles { get; set; } = null!;
        public virtual DbSet<ReemplazoOrden> ReemplazoOrdens { get; set; } = null!;
        public virtual DbSet<RegionesSISA> RegionesSISAs { get; set; } = null!;
        public virtual DbSet<ReimpresionBonosPractica> ReimpresionBonosPracticas { get; set; } = null!;
        public virtual DbSet<ReintegroImporteAGerencium> ReintegroImporteAGerencia { get; set; } = null!;
        public virtual DbSet<ReintegroNotasAuditor> ReintegroNotasAuditors { get; set; } = null!;
        public virtual DbSet<ReintegroSectore> ReintegroSectores { get; set; } = null!;
        public virtual DbSet<ReintegroUsuarioSector> ReintegroUsuarioSectors { get; set; } = null!;
        public virtual DbSet<Reintegro_Debito> Reintegro_Debitos { get; set; } = null!;
        public virtual DbSet<Reintegro_DescuentoIndebido> Reintegro_DescuentoIndebidos { get; set; } = null!;
        public virtual DbSet<Reintegro_DetalleFactura> Reintegro_DetalleFacturas { get; set; } = null!;
        public virtual DbSet<Reintegro_DetalleMedicacion> Reintegro_DetalleMedicacions { get; set; } = null!;
        public virtual DbSet<Reintegro_DetallePractica> Reintegro_DetallePracticas { get; set; } = null!;
        public virtual DbSet<Reintegro_DetalleServicio> Reintegro_DetalleServicios { get; set; } = null!;
        public virtual DbSet<ReintegrosServicioIosep> ReintegrosServicioIoseps { get; set; } = null!;
        public virtual DbSet<Reintegros_Encabezado> Reintegros_Encabezados { get; set; } = null!;
        public virtual DbSet<RendicionCaja> RendicionCajas { get; set; } = null!;
        public virtual DbSet<Reparticione> Reparticiones { get; set; } = null!;
        public virtual DbSet<ReporteRecupero> ReporteRecuperos { get; set; } = null!;
        public virtual DbSet<ReportesIosepSalud> ReportesIosepSaluds { get; set; } = null!;
        public virtual DbSet<RestriccionEmision> RestriccionEmisions { get; set; } = null!;
        public virtual DbSet<ResultadoDiagnostico> ResultadoDiagnosticos { get; set; } = null!;
        public virtual DbSet<ResultadoOrdenCoseguro> ResultadoOrdenCoseguro { get; set; } = null!;
        public virtual DbSet<ResumenCuentum> ResumenCuenta { get; set; } = null!;
        public virtual DbSet<Rubro> Rubros { get; set; } = null!;
        public virtual DbSet<RubrosDetalle> RubrosDetalles { get; set; } = null!;
        public virtual DbSet<RubroxCentroDiagxImag> RubroxCentroDiagxImags { get; set; } = null!;
        public virtual DbSet<SSM_AFIL> SSM_AFILs { get; set; } = null!;
        public virtual DbSet<SectorReintegro> SectorReintegros { get; set; } = null!;
        public virtual DbSet<Sector_Debito> Sector_Debitos { get; set; } = null!;
        public virtual DbSet<Sectores_Iosep> Sectores_Ioseps { get; set; } = null!;
        public virtual DbSet<SeguroMalaPraxi> SeguroMalaPraxis { get; set; } = null!;
        public virtual DbSet<SeguroMalaPraxiPago> SeguroMalaPraxiPagos { get; set; } = null!;
        public virtual DbSet<SepelioAutorizacion> SepelioAutorizacions { get; set; } = null!;
        public virtual DbSet<SepelioAutorizacionDetalle> SepelioAutorizacionDetalles { get; set; } = null!;
        public virtual DbSet<SepelioAutorizacionDetalleOrden> SepelioAutorizacionDetalleOrdens { get; set; } = null!;
        public virtual DbSet<SepelioAutorizacionDetalleSolicitude> SepelioAutorizacionDetalleSolicitudes { get; set; } = null!;
        public virtual DbSet<SepelioServicio> SepelioServicios { get; set; } = null!;
        public virtual DbSet<SepelioServicioDetalle> SepelioServicioDetalles { get; set; } = null!;
        public virtual DbSet<SepelioSolicitud> SepelioSolicituds { get; set; } = null!;
        public virtual DbSet<SepelioSolicitudFacturacion> SepelioSolicitudFacturacions { get; set; } = null!;
        public virtual DbSet<SepelioSolicitudFacturacionDetalle> SepelioSolicitudFacturacionDetalles { get; set; } = null!;
        public virtual DbSet<SepelioSolicitudFacturacionDetalleDetalle> SepelioSolicitudFacturacionDetalleDetalles { get; set; } = null!;
        public virtual DbSet<ServicioProfEducEsp> ServicioProfEducEsps { get; set; } = null!;
        public virtual DbSet<ServicoCentro> ServicoCentros { get; set; } = null!;
        public virtual DbSet<ServicoRealiza> ServicoRealizas { get; set; } = null!;
        public virtual DbSet<Sexo> Sexos { get; set; } = null!;
        public virtual DbSet<Siniestro> Siniestros { get; set; } = null!;
        public virtual DbSet<SituacionTributarium> SituacionTributaria { get; set; } = null!;
        public virtual DbSet<Solicitud_Gasto> Solicitud_Gastos { get; set; } = null!;
        public virtual DbSet<Sucursale> Sucursales { get; set; } = null!;
        public virtual DbSet<TablaAuxMedicamentosCompara> TablaAuxMedicamentosComparas { get; set; } = null!;
        public virtual DbSet<TablaRechazo> TablaRechazos { get; set; } = null!;
        public virtual DbSet<Table_TiposDato> Table_TiposDatos { get; set; } = null!;
        public virtual DbSet<TestOrden> TestOrdens { get; set; } = null!;
        public virtual DbSet<Tiempo> Tiempos { get; set; } = null!;
        public virtual DbSet<TipoAltum> TipoAlta { get; set; } = null!;
        public virtual DbSet<TipoCaja> TipoCajas { get; set; } = null!;
        public virtual DbSet<TipoCarencium> TipoCarencia { get; set; } = null!;
        public virtual DbSet<TipoCondicion> TipoCondicions { get; set; } = null!;
        public virtual DbSet<TipoCondicionIVA> TipoCondicionIVAs { get; set; } = null!;
        public virtual DbSet<TipoConsumo> TipoConsumos { get; set; } = null!;
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; } = null!;
        public virtual DbSet<TipoDomicilio> TipoDomicilios { get; set; } = null!;
        public virtual DbSet<TipoEspecialista> TipoEspecialistas { get; set; } = null!;
        public virtual DbSet<TipoFamiliar> TipoFamiliars { get; set; } = null!;
        public virtual DbSet<TipoFamiliar_Compatible> TipoFamiliar_Compatibles { get; set; } = null!;
        public virtual DbSet<TipoFormaPago> TipoFormaPagos { get; set; } = null!;
        public virtual DbSet<TipoFrecuencium> TipoFrecuencia { get; set; } = null!;
        public virtual DbSet<TipoGestion> TipoGestions { get; set; } = null!;
        public virtual DbSet<TipoInternacion> TipoInternacions { get; set; } = null!;
        public virtual DbSet<TipoInternacionPractica> TipoInternacionPracticas { get; set; } = null!;
        public virtual DbSet<TipoLugar> TipoLugars { get; set; } = null!; 
        public virtual DbSet<TipoMovimientoCuentum> TipoMovimientoCuenta { get; set; } = null!;
        public virtual DbSet<TipoNotaCredito> TipoNotaCreditos { get; set; } = null!;
        public virtual DbSet<TipoOperabilidad> TipoOperabilidads { get; set; } = null!;
        public virtual DbSet<TipoOperabilidadAfiliado> TipoOperabilidadAfiliados { get; set; } = null!;
        public virtual DbSet<TipoOrdenPago> TipoOrdenPagos { get; set; } = null!;
        public virtual DbSet<TipoPractica> TipoPracticas { get; set; } = null!;
        public virtual DbSet<TipoPrestador> TipoPrestadors { get; set; } = null!;
        public virtual DbSet<TipoPrestadorDDJJ> TipoPrestadorDDJJs { get; set; } = null!;
        public virtual DbSet<TipoReintegro> TipoReintegros { get; set; } = null!;
        public virtual DbSet<TipoRestriccion> TipoRestriccions { get; set; } = null!;
        public virtual DbSet<TipoSector> TipoSectors { get; set; } = null!;
        public virtual DbSet<TipoServicio_Sepelio> TipoServicio_Sepelios { get; set; } = null!;
        public virtual DbSet<TipoTransporte> TipoTransportes { get; set; } = null!;
        public virtual DbSet<TipoUnidad> TipoUnidads { get; set; } = null!;
        public virtual DbSet<TipoVium> TipoVia { get; set; } = null!;
        public virtual DbSet<Tipo_Comprobante> Tipo_Comprobantes { get; set; } = null!;
        public virtual DbSet<Tipo_CuentaContable> Tipo_CuentaContables { get; set; } = null!;
        public virtual DbSet<Tipo_Debito> Tipo_Debitos { get; set; } = null!;
        public virtual DbSet<Tipo_DescuentoAporte> Tipo_DescuentoAportes { get; set; } = null!;
        public virtual DbSet<Tipo_DetalleISalud> Tipo_DetalleISaluds { get; set; } = null!;
        public virtual DbSet<Tipo_FormaPagoClinica> Tipo_FormaPagoClinicas { get; set; } = null!;
        public virtual DbSet<Tipo_Gasto> Tipo_Gastos { get; set; } = null!;
        public virtual DbSet<Tipo_Ingreso> Tipo_Ingresos { get; set; } = null!;
        public virtual DbSet<Tipo_IngresoAfiliacion> Tipo_IngresoAfiliacions { get; set; } = null!;
        public virtual DbSet<Tipo_Institucion> Tipo_Institucions { get; set; } = null!;
        public virtual DbSet<Tipo_LugarPago> Tipo_LugarPagos { get; set; } = null!;
        public virtual DbSet<Tipo_MarcaAlfaBetum> Tipo_MarcaAlfaBeta { get; set; } = null!;
        public virtual DbSet<Tipo_MovimientoBanco> Tipo_MovimientoBancos { get; set; } = null!;
        public virtual DbSet<Tipo_MovimientoContable> Tipo_MovimientoContables { get; set; } = null!;
        public virtual DbSet<Tipo_MovimientoISalud> Tipo_MovimientoISaluds { get; set; } = null!;
        public virtual DbSet<Tipo_NormalAlterado> Tipo_NormalAlterados { get; set; } = null!;
        public virtual DbSet<Tipo_NotaDePedido> Tipo_NotaDePedidos { get; set; } = null!;
        public virtual DbSet<Tipo_Orden> Tipo_Ordens { get; set; } = null!;
        public virtual DbSet<Tipo_Oscultum> Tipo_Osculta { get; set; } = null!;
        public virtual DbSet<Tipo_PedidoInterno> Tipo_PedidoInternos { get; set; } = null!;
        public virtual DbSet<Tipo_PresentacionAlturaFeto> Tipo_PresentacionAlturaFetos { get; set; } = null!;
        public virtual DbSet<Tipo_Reintegro> Tipo_Reintegros { get; set; } = null!;
        public virtual DbSet<Tipo_Retencion> Tipo_Retencions { get; set; } = null!;
        public virtual DbSet<Tipo_Servicio> Tipo_Servicios { get; set; } = null!;
        public virtual DbSet<Tipo_SituacionLaboral> Tipo_SituacionLaborals { get; set; } = null!;
        public virtual DbSet<Tipo_VencimientoAfiliacione> Tipo_VencimientoAfiliaciones { get; set; } = null!;
        public virtual DbSet<Tipo_VentaAlfaBetum> Tipo_VentaAlfaBeta { get; set; } = null!;
        public virtual DbSet<TituloProfesional> TituloProfesionals { get; set; } = null!;
        public virtual DbSet<Token> Tokens { get; set; } = null!;
        public virtual DbSet<TopeInternacion> TopeInternacions { get; set; } = null!;
        public virtual DbSet<Transaccion_Ordene> Transaccion_Ordenes { get; set; } = null!;
        public virtual DbSet<Transferencium> Transferencia { get; set; } = null!;
        public virtual DbSet<TucumanNorte> TucumanNortes { get; set; } = null!;
        public virtual DbSet<Turno> Turnos { get; set; } = null!;
        public virtual DbSet<TurnosCaja> TurnosCajas { get; set; } = null!;
        public virtual DbSet<TurnosEscuela> TurnosEscuelas { get; set; } = null!;
        public virtual DbSet<TurnosPrestadore> TurnosPrestadores { get; set; } = null!;
        public virtual DbSet<Turnos_Bloqueo> Turnos_Bloqueos { get; set; } = null!;
        public virtual DbSet<Turnos_CentroMedico> Turnos_CentroMedicos { get; set; } = null!;
        public virtual DbSet<Tutore> Tutores { get; set; } = null!;
        public virtual DbSet<TxtNovedad> TxtNovedads { get; set; } = null!;
        public virtual DbSet<UltimosNumero> UltimosNumeros { get; set; } = null!;
        public virtual DbSet<UltimosNumerosCobroTarjeta> UltimosNumerosCobroTarjetas { get; set; } = null!;
        public virtual DbSet<UltimosNumerosComprobantePracticasInternado> UltimosNumerosComprobantePracticasInternados { get; set; } = null!;
        public virtual DbSet<UltimosNumerosOrdene> UltimosNumerosOrdenes { get; set; } = null!;
        public virtual DbSet<UltimosNumerosOrdenesPractica> UltimosNumerosOrdenesPracticas { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<User_Perfile> User_Perfiles { get; set; } = null!;
        public virtual DbSet<User_PerfilesUsuario> User_PerfilesUsuarios { get; set; } = null!;
        public virtual DbSet<User_Usuario> User_Usuarios { get; set; } = null!;
        public virtual DbSet<UsoSupervisor> UsoSupervisors { get; set; } = null!;
        public virtual DbSet<VW_VISTA_PROVISORIA_NOMENCLADOR_GENERAL_VALORE> VW_VISTA_PROVISORIA_NOMENCLADOR_GENERAL_VALOREs { get; set; } = null!;
        public virtual DbSet<Vacuna> Vacunas { get; set; } = null!;
        public virtual DbSet<Vacunas_Edade> Vacunas_Edades { get; set; } = null!;
        public virtual DbSet<Vacunas_Grupo> Vacunas_Grupos { get; set; } = null!;
        public virtual DbSet<Vacunas_Paciente> Vacunas_Pacientes { get; set; } = null!;
        public virtual DbSet<VademecumDetalle> VademecumDetalles { get; set; } = null!;
        public virtual DbSet<VademecumFeclise> VademecumFeclises { get; set; } = null!;
        public virtual DbSet<ValorRestriccion> ValorRestriccions { get; set; } = null!;
        public virtual DbSet<VencimientoAfiliacione> VencimientoAfiliaciones { get; set; } = null!;
        public virtual DbSet<VencimientosPeriodosFacturacion> VencimientosPeriodosFacturacions { get; set; } = null!;
        public virtual DbSet<VentasFarmacium> VentasFarmacia { get; set; } = null!;
        public virtual DbSet<Ventas_PtoVentum> Ventas_PtoVenta { get; set; } = null!;
        public virtual DbSet<Via> Vias { get; set; } = null!;
        public virtual DbSet<Vias_Cirugia> Vias_Cirugias { get; set; } = null!;
        public virtual DbSet<VwAfiliado> VwAfiliados { get; set; } = null!;
        public virtual DbSet<VwAfiliadosDdjj> VwAfiliadosDdjjs { get; set; } = null!;
        public virtual DbSet<VwAfiliadosDdjjFamiliar> VwAfiliadosDdjjFamiliars { get; set; } = null!;
        public virtual DbSet<VwAfiliadosFamiliar> VwAfiliadosFamiliars { get; set; } = null!;
        public virtual DbSet<VwAfiliadosIdTit> VwAfiliadosIdTits { get; set; } = null!;
        public virtual DbSet<VwAfiliadosMaraton> VwAfiliadosMaratons { get; set; } = null!;
        public virtual DbSet<VwAlta> VwAltas { get; set; } = null!;
        public virtual DbSet<VwAltasImp> VwAltasImps { get; set; } = null!;
        public virtual DbSet<VwAutoMapa> VwAutoMapas { get; set; } = null!;
        public virtual DbSet<VwAutorizaMedicamento> VwAutorizaMedicamentos { get; set; } = null!;
        public virtual DbSet<VwAutorizaPractica> VwAutorizaPracticas { get; set; } = null!;
        public virtual DbSet<VwAutorizarPractica> VwAutorizarPracticas { get; set; } = null!;
        public virtual DbSet<VwCaja> VwCajas { get; set; } = null!;
        public virtual DbSet<VwCajaConOrdene> VwCajaConOrdenes { get; set; } = null!;
        public virtual DbSet<VwCisnero> VwCisneros { get; set; } = null!;
        public virtual DbSet<VwDdjj> VwDdjjs { get; set; } = null!;
        public virtual DbSet<VwDiaInternado> VwDiaInternados { get; set; } = null!;
        public virtual DbSet<VwDiagnostico> VwDiagnosticos { get; set; } = null!;
        public virtual DbSet<VwDomicilio> VwDomicilios { get; set; } = null!;
        public virtual DbSet<VwDomicilioGrilla> VwDomicilioGrillas { get; set; } = null!;
        public virtual DbSet<VwDomicilioGrillaDdjj> VwDomicilioGrillaDdjjs { get; set; } = null!;
        public virtual DbSet<VwDroga> VwDrogas { get; set; } = null!;
        public virtual DbSet<VwEntregaTurno> VwEntregaTurnos { get; set; } = null!;
        public virtual DbSet<VwEntregaTurnos1> VwEntregaTurnos1s { get; set; } = null!;
        public virtual DbSet<VwEntregaTurnos2> VwEntregaTurnos2s { get; set; } = null!;
        public virtual DbSet<VwEnvioCredencialesxCorreo> VwEnvioCredencialesxCorreos { get; set; } = null!;
        public virtual DbSet<VwEsqPlanxAfi> VwEsqPlanxAfis { get; set; } = null!;
        public virtual DbSet<VwEsquemaPracticas_output> VwEsquemaPracticas_outputs { get; set; } = null!;
        public virtual DbSet<VwEsquemaProcedure> VwEsquemaProcedures { get; set; } = null!;
        public virtual DbSet<VwEvolucion> VwEvolucions { get; set; } = null!;
        public virtual DbSet<VwFamiliaresBono> VwFamiliaresBonos { get; set; } = null!;
        public virtual DbSet<VwGetSectorxInternado> VwGetSectorxInternados { get; set; } = null!;
        public virtual DbSet<VwHistorialInternado> VwHistorialInternados { get; set; } = null!;
        public virtual DbSet<VwHistorialMedicamento> VwHistorialMedicamentos { get; set; } = null!;
        public virtual DbSet<VwHistorialOrdene> VwHistorialOrdenes { get; set; } = null!;
        public virtual DbSet<VwHistorialOrdenes1> VwHistorialOrdenes1s { get; set; } = null!;
        public virtual DbSet<VwInfoInternadopAutMed> VwInfoInternadopAutMeds { get; set; } = null!;
        public virtual DbSet<VwInfoInternadopAutPra> VwInfoInternadopAutPras { get; set; } = null!;
        public virtual DbSet<VwInicioAuditorium> VwInicioAuditoria { get; set; } = null!;
        public virtual DbSet<VwIntHisCli> VwIntHisClis { get; set; } = null!;
        public virtual DbSet<VwIntImp> VwIntImps { get; set; } = null!;
        public virtual DbSet<VwInterOtraClinica> VwInterOtraClinicas { get; set; } = null!;
        public virtual DbSet<VwInternado> VwInternados { get; set; } = null!;
        public virtual DbSet<VwInternadoEvolucion> VwInternadoEvolucions { get; set; } = null!;
        public virtual DbSet<VwInternadosImp> VwInternadosImps { get; set; } = null!;
        public virtual DbSet<VwInternados_Alta> VwInternados_Altas { get; set; } = null!;
        public virtual DbSet<VwInternados_Auditorium> VwInternados_Auditoria { get; set; } = null!;
        public virtual DbSet<VwInternados_HistoriaClinicaPorAfiliado> VwInternados_HistoriaClinicaPorAfiliados { get; set; } = null!;
        public virtual DbSet<VwNomenValore> VwNomenValores { get; set; } = null!;
        public virtual DbSet<VwNomen_Valore> VwNomen_Valores { get; set; } = null!;
        public virtual DbSet<VwOrdene> VwOrdenes { get; set; } = null!;
        public virtual DbSet<VwOrdenes1> VwOrdenes1s { get; set; } = null!;
        public virtual DbSet<VwOrdenesAnular> VwOrdenesAnulars { get; set; } = null!;
        public virtual DbSet<VwOrdenesCaja> VwOrdenesCajas { get; set; } = null!;
        public virtual DbSet<VwPesca> VwPescas { get; set; } = null!;
        public virtual DbSet<VwPlanesNoGral_Sp> VwPlanesNoGral_Sps { get; set; } = null!;
        public virtual DbSet<VwPlanes_Sp> VwPlanes_Sps { get; set; } = null!;
        public virtual DbSet<VwPracticasHC> VwPracticasHCs { get; set; } = null!;
        public virtual DbSet<VwPracticasxImp> VwPracticasxImps { get; set; } = null!;
        public virtual DbSet<VwPracxPlan> VwPracxPlans { get; set; } = null!;
        public virtual DbSet<VwSector> VwSectors { get; set; } = null!;
        public virtual DbSet<VwSolPra> VwSolPras { get; set; } = null!;
        public virtual DbSet<VwTipoUnidade> VwTipoUnidades { get; set; } = null!;
        public virtual DbSet<VwTurnosCentroMedico> VwTurnosCentroMedicos { get; set; } = null!;
        public virtual DbSet<VwTurnosMedico> VwTurnosMedicos { get; set; } = null!;
        public virtual DbSet<VwVerQuirofano> VwVerQuirofanos { get; set; } = null!;
        public virtual DbSet<VwVerifyDium> VwVerifyDia { get; set; } = null!;
        public virtual DbSet<VwVerifyQuirofano> VwVerifyQuirofanos { get; set; } = null!;
        public virtual DbSet<Vw_Afiliado> Vw_Afiliados { get; set; } = null!;
        public virtual DbSet<Vw_AfiliadosDato> Vw_AfiliadosDatos { get; set; } = null!;
        public virtual DbSet<Vw_AfiliadosEnTransito> Vw_AfiliadosEnTransitos { get; set; } = null!;
        public virtual DbSet<Vw_AfiliadosExtranaJurisdiccion> Vw_AfiliadosExtranaJurisdiccions { get; set; } = null!;
        public virtual DbSet<Vw_AfiliadosViewModel> Vw_AfiliadosViewModels { get; set; } = null!;
        public virtual DbSet<Vw_AportesMunicipio> Vw_AportesMunicipios { get; set; } = null!;
        public virtual DbSet<Vw_Autorizacione> Vw_Autorizaciones { get; set; } = null!;
        public virtual DbSet<Vw_AutorizacionesClinica> Vw_AutorizacionesClinicas { get; set; } = null!;
        public virtual DbSet<Vw_AutorizacionesMedicamento> Vw_AutorizacionesMedicamentos { get; set; } = null!;
        public virtual DbSet<Vw_BonosFarmacium> Vw_BonosFarmacia { get; set; } = null!;
        public virtual DbSet<Vw_Bonos_Practica> Vw_Bonos_Practicas { get; set; } = null!;
        public virtual DbSet<Vw_ClinicaMedicamentosSolicitado> Vw_ClinicaMedicamentosSolicitados { get; set; } = null!;
        public virtual DbSet<Vw_ClinicasPresupuesto> Vw_ClinicasPresupuestos { get; set; } = null!;
        public virtual DbSet<Vw_ComprasFarmacium> Vw_ComprasFarmacia { get; set; } = null!;
        public virtual DbSet<Vw_ComprasListado> Vw_ComprasListados { get; set; } = null!;
        public virtual DbSet<Vw_CtaCteAfiliado> Vw_CtaCteAfiliados { get; set; } = null!;
        public virtual DbSet<Vw_CtaCteAfiliados1> Vw_CtaCteAfiliados1s { get; set; } = null!;
        public virtual DbSet<Vw_CtaCteAfiliados2> Vw_CtaCteAfiliados2s { get; set; } = null!;
        public virtual DbSet<Vw_CtaCteAfiliadosDH> Vw_CtaCteAfiliadosDHs { get; set; } = null!;
        public virtual DbSet<Vw_CtaCteAnuladasAfiliado> Vw_CtaCteAnuladasAfiliados { get; set; } = null!;
        public virtual DbSet<Vw_CtaCteEmpresa> Vw_CtaCteEmpresas { get; set; } = null!;
        public virtual DbSet<Vw_DiagnosticoRelacionado> Vw_DiagnosticoRelacionados { get; set; } = null!;
        public virtual DbSet<Vw_Diagnosticos_Consulta> Vw_Diagnosticos_Consultas { get; set; } = null!;
        public virtual DbSet<Vw_Empresas_Afiliado> Vw_Empresas_Afiliados { get; set; } = null!;
        public virtual DbSet<Vw_Empresas_Dato> Vw_Empresas_Datos { get; set; } = null!;
        public virtual DbSet<Vw_Empresas_DatosDetalle> Vw_Empresas_DatosDetalles { get; set; } = null!;
        public virtual DbSet<Vw_EsquemasMedicamentosDescuento> Vw_EsquemasMedicamentosDescuentos { get; set; } = null!;
        public virtual DbSet<Vw_EstadisticasOrdene> Vw_EstadisticasOrdenes { get; set; } = null!;
        public virtual DbSet<Vw_GetEsquema> Vw_GetEsquemas { get; set; } = null!;
        public virtual DbSet<Vw_Institucione> Vw_Instituciones { get; set; } = null!;
        public virtual DbSet<Vw_ManualDatCobertura> Vw_ManualDatCoberturas { get; set; } = null!;
        public virtual DbSet<Vw_ManualDatCobertura2> Vw_ManualDatCobertura2s { get; set; } = null!;
        public virtual DbSet<Vw_Medicamento> Vw_Medicamentos { get; set; } = null!;
        public virtual DbSet<Vw_Nomen_DatosNomenclador> Vw_Nomen_DatosNomencladors { get; set; } = null!;
        public virtual DbSet<Vw_Nomen_Practica> Vw_Nomen_Practicas { get; set; } = null!;
        public virtual DbSet<Vw_Nomen_PracticasAsociada> Vw_Nomen_PracticasAsociadas { get; set; } = null!;
        public virtual DbSet<Vw_Nomen_PracticasAsociadasPresupuesto> Vw_Nomen_PracticasAsociadasPresupuestos { get; set; } = null!;
        public virtual DbSet<Vw_Nomen_PracticasNoAsociada> Vw_Nomen_PracticasNoAsociadas { get; set; } = null!;
        public virtual DbSet<Vw_Nomen_PracticasNoAsociadasPresupuesto> Vw_Nomen_PracticasNoAsociadasPresupuestos { get; set; } = null!;
        public virtual DbSet<Vw_Nomen_TipoUnidad> Vw_Nomen_TipoUnidads { get; set; } = null!;
        public virtual DbSet<Vw_Nomenclador_feclisCC> Vw_Nomenclador_feclisCCs { get; set; } = null!;
        public virtual DbSet<Vw_Plane> Vw_Planes { get; set; } = null!;
        public virtual DbSet<Vw_Planes_Detalle> Vw_Planes_Detalles { get; set; } = null!;
        public virtual DbSet<Vw_Prestadore> Vw_Prestadores { get; set; } = null!;
        public virtual DbSet<Vw_PrestadoresEspecialidad> Vw_PrestadoresEspecialidads { get; set; } = null!;
        public virtual DbSet<Vw_Presupuesto> Vw_Presupuestos { get; set; } = null!;
        public virtual DbSet<Vw_PresupuestosComprobante> Vw_PresupuestosComprobantes { get; set; } = null!;
        public virtual DbSet<Vw_Proveedore> Vw_Proveedores { get; set; } = null!;
        public virtual DbSet<Vw_RelacionSectorPension> Vw_RelacionSectorPensions { get; set; } = null!;
        public virtual DbSet<Vw_User_UsuariosyPerfile> Vw_User_UsuariosyPerfiles { get; set; } = null!;
        public virtual DbSet<Vw_VentasFarmacium> Vw_VentasFarmacia { get; set; } = null!;
        public virtual DbSet<Vw_VistaCobrosBanco> Vw_VistaCobrosBancos { get; set; } = null!;
        public virtual DbSet<Z_VwObraSocial> Z_VwObraSocials { get; set; } = null!;
        public virtual DbSet<Zona> Zonas { get; set; } = null!;
        public virtual DbSet<__MigrationHistory> __MigrationHistories { get; set; } = null!;
        public virtual DbSet<aclisePrecio> aclisePrecios { get; set; } = null!;
        public virtual DbSet<aclisePreciosEnero> aclisePreciosEneros { get; set; } = null!;
        public virtual DbSet<aporte> aportes { get; set; } = null!;
        public virtual DbSet<aux_i_autori> aux_i_autoris { get; set; } = null!;
        public virtual DbSet<comprobante> comprobantes { get; set; } = null!;
        public virtual DbSet<comprobanteDetalle> comprobanteDetalles { get; set; } = null!;
        public virtual DbSet<comprobanteLog> comprobanteLogs { get; set; } = null!;
        public virtual DbSet<empresa> empresas { get; set; } = null!;
        public virtual DbSet<empresaLog> empresaLogs { get; set; } = null!;
        public virtual DbSet<empresa_afiliado> empresa_afiliados { get; set; } = null!;
        public virtual DbSet<gastosDiciembre20> gastosDiciembre20s { get; set; } = null!;
        public virtual DbSet<gastosEnero21> gastosEnero21s { get; set; } = null!;
        public virtual DbSet<honorariosDiciembre20> honorariosDiciembre20s { get; set; } = null!;
        public virtual DbSet<honorariosEnero21> honorariosEnero21s { get; set; } = null!;
        public virtual DbSet<impactar> impactars { get; set; } = null!;
        public virtual DbSet<impactarNuevosHon> impactarNuevosHons { get; set; } = null!;
        public virtual DbSet<impactarRadiol> impactarRadiols { get; set; } = null!;
        public virtual DbSet<iosepNomina> iosepNominas { get; set; } = null!;
        public virtual DbSet<legajosNuevo> legajosNuevos { get; set; } = null!;
        public virtual DbSet<prueba> pruebas { get; set; } = null!;
        public virtual DbSet<socio> socios { get; set; } = null!;
        public virtual DbSet<tbl_App_Perfile> tbl_App_Perfiles { get; set; } = null!;
        public virtual DbSet<testAut> testAuts { get; set; } = null!;
        public virtual DbSet<tyoEnero> tyoEneros { get; set; } = null!;
        public virtual DbSet<vw_AfiliadosDom> vw_AfiliadosDoms { get; set; } = null!;
        public virtual DbSet<zLog> zLogs { get; set; } = null!;
        public virtual DbSet<z_PROFE> z_PROves { get; set; } = null!;
        public virtual DbSet<z_exc_iosepSalud> z_exc_iosepSaluds { get; set; } = null!;
        public virtual DbSet<z_ssm_afi> z_ssm_afis { get; set; } = null!;

        // Para SPs
        public virtual DbSet<Comprobante> Comprobante { get; set; }
        public virtual DbSet<ComprobanteVM> ComprobanteVM { get; set; }
        public virtual DbSet<DetalleMovimiento> DetalleMovimiento { get; set; }
        public virtual DbSet<MovimientoDetalle> MovimientoDetalle { get; set; }
        public virtual DbSet<CuotaVM> CuotaVM { get; set; }
        public virtual DbSet<imprimir_ctacteVW> ImprimirCtaCte { get; set; }
        public virtual DbSet<imprimir_PagoCtaCte> ImprimirPagoCtaCte { get; set; }
        public virtual DbSet<NotaCredito> NotaCreditos { get; set; }
        public virtual DbSet<NotaCreditoEmpresa> NotaCreditoEmpresas { get; set; }
        public virtual DbSet<imprimir_PeriodoPago> ImprimirPeriodo { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=172.17.0.10;Database=IOSEP;User ID=sa;Password=donJuan@2178;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ANCapitulo>(entity =>
            {
                entity.ToTable("ANCapitulo");

                entity.Property(e => e.Codigo).HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<ANCapituloSubcapitulo>(entity =>
            {
                entity.ToTable("ANCapituloSubcapitulo");

                entity.Property(e => e.Codigo).HasMaxLength(25);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.HasOne(d => d.ANCapitulo)
                    .WithMany(p => p.ANCapituloSubcapitulos)
                    .HasForeignKey(d => d.ANCapituloID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANCapituloSubcapitulo_ANCapitulo");
            });

            modelBuilder.Entity<ANConvenio>(entity =>
            {
                entity.ToTable("ANConvenio");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");
            });

            modelBuilder.Entity<ANConvenioPractica>(entity =>
            {
                entity.ToTable("ANConvenioPractica");

                entity.Property(e => e.Tipo).HasMaxLength(20);

                entity.HasOne(d => d.ANConvenio)
                    .WithMany(p => p.ANConvenioPracticas)
                    .HasForeignKey(d => d.ANConvenioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANConvenioPractica_ANConvenio");

                entity.HasOne(d => d.ANPracticaBase)
                    .WithMany(p => p.ANConvenioPracticas)
                    .HasForeignKey(d => d.ANPracticaBaseID)
                    .HasConstraintName("FK_ANConvenioPractica_ANPracticasBase");

                entity.HasOne(d => d.ANPracticaModulo)
                    .WithMany(p => p.ANConvenioPracticas)
                    .HasForeignKey(d => d.ANPracticaModuloID)
                    .HasConstraintName("FK_ANConvenioPractica_ANPracticasModulo");
            });

            modelBuilder.Entity<ANConvenioRestriccion>(entity =>
            {
                entity.ToTable("ANConvenioRestriccion");

                entity.HasOne(d => d.ANConvenio)
                    .WithMany(p => p.ANConvenioRestriccions)
                    .HasForeignKey(d => d.ANConvenioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANConvenioRestriccion_ANConvenio");

                entity.HasOne(d => d.ANConvenioPractica)
                    .WithMany(p => p.ANConvenioRestriccions)
                    .HasForeignKey(d => d.ANConvenioPracticaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANConvenioRestriccion_ANConvenioPractica");

                entity.HasOne(d => d.ANTipoRestriccion)
                    .WithMany(p => p.ANConvenioRestriccions)
                    .HasForeignKey(d => d.ANTipoRestriccionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANConvenioRestriccion_ANTipo");

                entity.HasOne(d => d.ANTipoRestriccionValor)
                    .WithMany(p => p.ANConvenioRestriccions)
                    .HasForeignKey(d => d.ANTipoRestriccionValorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANConvenioRestriccion_ANTipoValor");
            });

            modelBuilder.Entity<ANConvenioValor>(entity =>
            {
                entity.ToTable("ANConvenioValor");

                entity.Property(e => e.CoseguroGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CoseguroHonorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReconoceGastos).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ReconoceHonorarios).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalHonorarios).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ANConvenio)
                    .WithMany(p => p.ANConvenioValors)
                    .HasForeignKey(d => d.ANConvenioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANConvenioValor_ANConvenio");

                entity.HasOne(d => d.ANConvenioPractica)
                    .WithMany(p => p.ANConvenioValors)
                    .HasForeignKey(d => d.ANConvenioPracticaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANConvenioValor_ANConvenioPractica");
            });

            modelBuilder.Entity<ANPracticasBase>(entity =>
            {
                entity.ToTable("ANPracticasBase");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.HasOne(d => d.ANTipoCalculo)
                    .WithMany(p => p.ANPracticasBases)
                    .HasForeignKey(d => d.ANTipoCalculoID)
                    .HasConstraintName("FK_ANPracticasBase_ANTipoCalculo");

                entity.HasOne(d => d.ANTipoPractica)
                    .WithMany(p => p.ANPracticasBases)
                    .HasForeignKey(d => d.ANTipoPracticaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANPracticasBase_ANTipoPractica");

                entity.HasOne(d => d.ANTipoUnidad)
                    .WithMany(p => p.ANPracticasBases)
                    .HasForeignKey(d => d.ANTipoUnidadID)
                    .HasConstraintName("FK_ANPracticasBase_ANTipoUnidad");
            });

            modelBuilder.Entity<ANPracticasModulo>(entity =>
            {
                entity.HasKey(e => e.ANPracticaModuloID);

                entity.ToTable("ANPracticasModulo");

                entity.HasOne(d => d.ANCapitulo)
                    .WithMany(p => p.ANPracticasModulos)
                    .HasForeignKey(d => d.ANCapituloID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANPracticasModulo_ANCapitulo");

                entity.HasOne(d => d.ANCapituloSubcapitulo)
                    .WithMany(p => p.ANPracticasModulos)
                    .HasForeignKey(d => d.ANCapituloSubcapituloID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANPracticasModulo_ANCapituloSubcapitulo");

                entity.HasOne(d => d.ANPracticaBase)
                    .WithMany(p => p.ANPracticasModulos)
                    .HasForeignKey(d => d.ANPracticaBaseID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANPracticasModulo_ANPracticasBase");
            });

            modelBuilder.Entity<ANSolicitudCambio>(entity =>
            {
                entity.ToTable("ANSolicitudCambio");

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaEstado).HasColumnType("date");

                entity.Property(e => e.FechaSolicitud).HasColumnType("date");

                entity.Property(e => e.NumeroSolicitud)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.ObservacionesAutorizar).HasMaxLength(100);

                entity.Property(e => e.ObservacionesReenviar).HasMaxLength(100);

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.ANTipoSolicitud)
                    .WithMany(p => p.ANSolicitudCambios)
                    .HasForeignKey(d => d.ANTipoSolicitudID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambio_ANTipoSolicitud");
            });

            modelBuilder.Entity<ANSolicitudCambioDetalleAN>(entity =>
            {
                entity.ToTable("ANSolicitudCambioDetalleAN");

                entity.Property(e => e.EstadoAutorizar).HasMaxLength(20);

                entity.HasOne(d => d.ANConvenioPractica)
                    .WithMany(p => p.ANSolicitudCambioDetalleANs)
                    .HasForeignKey(d => d.ANConvenioPracticaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleAN_ANConvenioPractica");

                entity.HasOne(d => d.ANSolicitudCambio)
                    .WithMany(p => p.ANSolicitudCambioDetalleANs)
                    .HasForeignKey(d => d.ANSolicitudCambioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleAN_ANSolicitudCambio1");
            });

            modelBuilder.Entity<ANSolicitudCambioDetalleAV>(entity =>
            {
                entity.ToTable("ANSolicitudCambioDetalleAV");

                entity.Property(e => e.EstadoAutorizar).HasMaxLength(20);

                entity.Property(e => e.PorcentajeAjusteGastos).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PorcentajeAjusteHonorarios).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.ANConvenioPractica)
                    .WithMany(p => p.ANSolicitudCambioDetalleAVs)
                    .HasForeignKey(d => d.ANConvenioPracticaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleAV_ANConvenioPractica");

                entity.HasOne(d => d.ANConvenioValor)
                    .WithMany(p => p.ANSolicitudCambioDetalleAVs)
                    .HasForeignKey(d => d.ANConvenioValorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleAV_ANConvenioValor");

                entity.HasOne(d => d.ANSolicitudCambio)
                    .WithMany(p => p.ANSolicitudCambioDetalleAVs)
                    .HasForeignKey(d => d.ANSolicitudCambioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleAV_ANSolicitudCambio");
            });

            modelBuilder.Entity<ANSolicitudCambioDetalleNP>(entity =>
            {
                entity.ToTable("ANSolicitudCambioDetalleNP");

                entity.Property(e => e.EstadoAutorizar).HasMaxLength(20);

                entity.HasOne(d => d.ANPracticaBase)
                    .WithMany(p => p.ANSolicitudCambioDetalleNPs)
                    .HasForeignKey(d => d.ANPracticaBaseID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleNP_ANPracticasBase");

                entity.HasOne(d => d.ANSolicitudCambio)
                    .WithMany(p => p.ANSolicitudCambioDetalleNPs)
                    .HasForeignKey(d => d.ANSolicitudCambioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleNP_ANSolicitudCambio");
            });

            modelBuilder.Entity<ANSolicitudCambioDetalleRestricAN>(entity =>
            {
                entity.ToTable("ANSolicitudCambioDetalleRestricAN");

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.EstadoAutorizar).HasMaxLength(20);

                entity.HasOne(d => d.ANConvenioRestriccion)
                    .WithMany(p => p.ANSolicitudCambioDetalleRestricANs)
                    .HasForeignKey(d => d.ANConvenioRestriccionID)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleRestricAN_ANConvenioRestriccion");

                entity.HasOne(d => d.ANSolicitudCambioDetalleAN)
                    .WithMany(p => p.ANSolicitudCambioDetalleRestricANs)
                    .HasForeignKey(d => d.ANSolicitudCambioDetalleANID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleRestricAN_ANSolicitudCambioDetalleAN");

                entity.HasOne(d => d.ANTipoRestriccion)
                    .WithMany(p => p.ANSolicitudCambioDetalleRestricANs)
                    .HasForeignKey(d => d.ANTipoRestriccionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleRestricAN_ANTipoRestriccion");

                entity.HasOne(d => d.ANTipoRestriccionValor)
                    .WithMany(p => p.ANSolicitudCambioDetalleRestricANs)
                    .HasForeignKey(d => d.ANTipoRestriccionValorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleRestricAN_ANTipoRestriccionValor");
            });

            modelBuilder.Entity<ANSolicitudCambioDetalleRestricNP>(entity =>
            {
                entity.ToTable("ANSolicitudCambioDetalleRestricNP");

                entity.Property(e => e.EstadoAutorizar).HasMaxLength(20);

                entity.HasOne(d => d.ANSolicitudCambioDetalleNP)
                    .WithMany(p => p.ANSolicitudCambioDetalleRestricNPs)
                    .HasForeignKey(d => d.ANSolicitudCambioDetalleNPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleRestricNP_ANSolicitudCambioDetalleNP");

                entity.HasOne(d => d.ANTipoRestriccion)
                    .WithMany(p => p.ANSolicitudCambioDetalleRestricNPs)
                    .HasForeignKey(d => d.ANTipoRestriccionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleRestricNP_ANTipo");

                entity.HasOne(d => d.ANTipoRestriccionValor)
                    .WithMany(p => p.ANSolicitudCambioDetalleRestricNPs)
                    .HasForeignKey(d => d.ANTipoRestriccionValorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleRestricNP_ANTipoValor");
            });

            modelBuilder.Entity<ANSolicitudCambioDetalleValNP>(entity =>
            {
                entity.ToTable("ANSolicitudCambioDetalleValNP");

                entity.Property(e => e.CoseguroGastos).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CoseguroHonorarios).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.EstadoAutorizar).HasMaxLength(20);

                entity.Property(e => e.ReconoceGastos).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ReconoceHonorarios).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalHonorarios).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ANSolicitudCambioDetalleNP)
                    .WithMany(p => p.ANSolicitudCambioDetalleValNPs)
                    .HasForeignKey(d => d.ANSolicitudCambioDetalleNPID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANSolicitudCambioDetalleValNP_ANSolicitudCambioDetalleNP");
            });

            modelBuilder.Entity<ANSolicitudCambioMovimiento>(entity =>
            {
                entity.ToTable("ANSolicitudCambioMovimiento");

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.FechaEstado).HasColumnType("date");

                entity.Property(e => e.NumeroSolicitud)
                    .HasMaxLength(12)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ANTipoCalculo>(entity =>
            {
                entity.ToTable("ANTipoCalculo");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<ANTipoPractica>(entity =>
            {
                entity.ToTable("ANTipoPractica");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<ANTipoRestriccion>(entity =>
            {
                entity.ToTable("ANTipoRestriccion");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<ANTipoRestriccionValor>(entity =>
            {
                entity.ToTable("ANTipoRestriccionValor");

                entity.Property(e => e.Valor).HasMaxLength(50);

                entity.Property(e => e.ValorAbreviatura).HasMaxLength(5);

                entity.HasOne(d => d.ANTipoRestriccion)
                    .WithMany(p => p.ANTipoRestriccionValors)
                    .HasForeignKey(d => d.ANTipoRestriccionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ANTipoValor_ANTipo");
            });

            modelBuilder.Entity<ANTipoSolicitud>(entity =>
            {
                entity.ToTable("ANTipoSolicitud");

                entity.Property(e => e.Abreviatura).HasMaxLength(5);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<ANTipoUnidad>(entity =>
            {
                entity.ToTable("ANTipoUnidad");

                entity.Property(e => e.Abreviatura).HasMaxLength(3);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<AccionFarmacologica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccionFarmacologica");

                entity.Property(e => e.AccioFar)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Laboratorio)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.MonoDro)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AcliseMayo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AcliseMayo");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.Gastos).HasColumnType("money");

                entity.Property(e => e.Gastos_Ene_21)
                    .HasColumnType("money")
                    .HasColumnName("Gastos-Ene/21");

                entity.Property(e => e.Hon_Ene_21)
                    .HasColumnType("money")
                    .HasColumnName("Hon-Ene/21");

                entity.Property(e => e.Honorarios).HasColumnType("money");

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.Vigencia).HasColumnType("datetime");
            });

            modelBuilder.Entity<AcliseRX>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AcliseRX");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Gastos).HasColumnType("money");

                entity.Property(e => e.Honorarios).HasColumnType("money");

                entity.Property(e => e.VIGENCIA).HasColumnType("datetime");
            });

            modelBuilder.Entity<AcreditacionesMedica>(entity =>
            {
                entity.ToTable("AcreditacionesMedica");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Afeccion>(entity =>
            {
                entity.HasKey(e => e.IdAfeccion);

                entity.ToTable("Afeccion");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<AfiAtsa>(entity =>
            {
                entity.HasKey(e => e.IdAfiAtsa);

                entity.ToTable("AfiAtsa");

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Entidad)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(75);
            });

            modelBuilder.Entity<AfiInte>(entity =>
            {
                entity.ToTable("AfiInte");

                entity.Property(e => e.A_NUMERO)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DIAGNOSTIC)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EFECTOR)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EMPRESA)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.E_CAUSA)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.E_FECHA).HasColumnType("date");

                entity.Property(e => e.FAMILIAR)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.FECHA_FIN).HasColumnType("date");

                entity.Property(e => e.HORA_CARGA)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.HORA_FIN)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.INSTITUCIO)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.I_CAUSA)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.I_FECHA).HasColumnType("date");

                entity.Property(e => e.NOMBRE).HasMaxLength(100);

                entity.Property(e => e.OBS)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.OPERADOR)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OPERA_FIN)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OP_FECHA).HasColumnType("date");

                entity.Property(e => e.O_SOCIAL)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PLAN)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PRESCRIBE)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PROT_NRO).HasMaxLength(10);

                entity.Property(e => e.PROT_SUC)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiLuga>(entity =>
            {
                entity.HasKey(e => e.IdAfiLuga);

                entity.ToTable("AfiLuga");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Adicional).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Adicional2).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Af_Adic).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Aporte).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Aportes).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Control)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.F_Releve).HasColumnType("date");

                entity.Property(e => e.Familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Familiares).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Haber).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Haberes).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LugarPa)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.NCtrol).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Veces).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Viejo)
                    .HasMaxLength(5)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiUPCN2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AfiUPCN2");

                entity.Property(e => e.apellidos).HasMaxLength(255);

                entity.Property(e => e.nombres).HasMaxLength(255);

                entity.Property(e => e.nro_doc).HasMaxLength(255);
            });

            modelBuilder.Entity<AfiUPCN3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AfiUPCN3");

                entity.Property(e => e.apellidos).HasMaxLength(255);

                entity.Property(e => e.nombres).HasMaxLength(255);

                entity.Property(e => e.nro_doc).HasMaxLength(255);
            });

            modelBuilder.Entity<AfiUpcn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AfiUpcn");

                entity.Property(e => e.apellidos).HasMaxLength(255);

                entity.Property(e => e.cuil).HasMaxLength(255);

                entity.Property(e => e.nombres).HasMaxLength(255);

                entity.Property(e => e.nro_doc).HasMaxLength(255);

                entity.Property(e => e.tipo_doc).HasMaxLength(255);
            });

            modelBuilder.Entity<Afiliado>(entity =>
            {
                entity.HasKey(e => e.IdAfiliado);

                entity.HasIndex(e => e.IdTipoFamiliar, "INdex_MotivoBaja");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.IdLugarPago, e.IdSituacionLaboral, e.IosepSalud, e.Anulado }, "ISAportesMensuales");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.IdSituacionLaboral, e.IosepSalud, e.Anulado }, "ISAportesMensuales1");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.Anulado }, "Index");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.IdTipoFamiliar, e.IosepSalud }, "IndexAfiBajaTipoIosep>");

                entity.HasIndex(e => new { e.IdDelegacion, e.IdMotivoBaja }, "IndexAfiDelMotivoBaja");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.IdTipoFamiliar, e.IdAfiliado }, "IndexAfiliado3");

                entity.HasIndex(e => new { e.IdSexo, e.IdMotivoBaja, e.IdTipoFamiliar, e.IdAfiliado }, "IndexAfiliado4");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.IdTipoFamiliar }, "IndexAfiliados1");

                entity.HasIndex(e => e.IdDelegacion, "IndexDelegacionCUil");

                entity.HasIndex(e => e.Cuil, "Index_Afi_Cuil");

                entity.HasIndex(e => e.IosepSalud, "Index_AfiliadoIosepSalud");

                entity.HasIndex(e => e.IosepSalud, "Index_Afiliado_Busqueda_Iosep");

                entity.HasIndex(e => new { e.LetArc, e.CodArc }, "Index_Afiliados_LetCod");

                entity.HasIndex(e => e.IdMotivoBaja, "Index_Afiliados_MotivoBaja");

                entity.HasIndex(e => new { e.CuilTitular, e.IdMotivoBaja, e.FechadeNacimiento }, "Index_Afiliados_TitBajaFecNac");

                entity.HasIndex(e => e.IdEstadoCivil, "Index_IdEstadoCivil");

                entity.HasIndex(e => new { e.IdTipoFamiliar, e.IdLugarPago, e.IdSituacionLaboral, e.IosepSalud }, "Indice");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.Anulado }, "Indice1");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.IdTipoFamiliar, e.IdSituacionLaboral, e.IosepSalud, e.Anulado }, "Indice4560");

                entity.HasIndex(e => new { e.IdSituacionLaboral, e.IosepSalud, e.Anulado }, "IndiceAfiliadosIosepSalud");

                entity.HasIndex(e => new { e.IosepSalud, e.Anulado }, "IndiceAfiliadosIosepSalud2");

                entity.HasIndex(e => new { e.IdTipoFamiliar, e.IdLugarPago, e.IdSituacionLaboral, e.IosepSalud }, "IndiceAfiliadosIosepSalud3");

                entity.HasIndex(e => new { e.Documento, e.IdTipoFamiliar }, "Indx_Afiliados_DocIdTIpoFamiliar");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.IdTipoFamiliar, e.IosepSalud }, "Tabler_Afiliados");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.IosepSalud }, "Tabler_Afiliados2");

                entity.HasIndex(e => new { e.IdMotivoBaja, e.Anulado }, "Vacunas_BuscarPersona");

                entity.HasIndex(e => e.A_Numero, "i_afi_a_num1");

                entity.HasIndex(e => e.DbfAfiliado, "i_afi_regdbf1");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodArc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnType("date")
                    .HasComment("Esta fecha indica hasta cuando el afiliado puede operar en el sistema.\r\nSi se encuentra vacio tiene uso de la obra social ilimitado.");

                entity.Property(e => e.Fecha_CtaCTe)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.Fliar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.LetArc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.Afiliados)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .HasConstraintName("FK_Afiliados_EstadoCivil");

                entity.HasOne(d => d.IdNacionalidadNavigation)
                    .WithMany(p => p.Afiliados)
                    .HasForeignKey(d => d.IdNacionalidad)
                    .HasConstraintName("FK_Afiliados_Paises");

                entity.HasOne(d => d.Sexo)
                    .WithMany(p => p.Afiliados)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Afiliados_Sexo2");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Afiliados)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Afiliados_TipoDocumento");

                entity.HasOne(d => d.IdTipoFamiliarNavigation)
                    .WithMany(p => p.Afiliados)
                    .HasForeignKey(d => d.IdTipoFamiliar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Afiliados_TipoFamiliar");
            });

            modelBuilder.Entity<AfiliadoCorregido>(entity =>
            {
                entity.ToTable("AfiliadoCorregido");

                entity.Property(e => e.CuilNuevo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilViejo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaCoreccion).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiliadoDbf>(entity =>
            {
                entity.HasKey(e => e.IdAfiliado);

                entity.ToTable("AfiliadoDbf");

                entity.HasIndex(e => e.d_nro, "IndexDbf");

                entity.HasIndex(e => e.fecha, "Index_Fecha");

                entity.HasIndex(e => new { e.a_numero, e.estado }, "afi_a_num_est");

                entity.HasIndex(e => e.estado, "afi_conv");

                entity.HasIndex(e => new { e.cuil, e.estado }, "afi_cui_est");

                entity.HasIndex(e => new { e.estado, e.fecha }, "ix_afi_fEst_fFec");

                entity.Property(e => e.a_numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.categoria)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.chequeado).HasColumnType("datetime");

                entity.Property(e => e.codarc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.cta_apo)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.d_nro)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.d_tipo)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.delegacion)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.dis_fdes).HasColumnType("date");

                entity.Property(e => e.dis_fhas).HasColumnType("date");

                entity.Property(e => e.domicilio)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.dto)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.e_civil)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.e_fecha).HasColumnType("date");

                entity.Property(e => e.empresa)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.est_fdes).HasColumnType("date");

                entity.Property(e => e.est_fhas).HasColumnType("date");

                entity.Property(e => e.f_ult_cens).HasColumnType("date");

                entity.Property(e => e.familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.fecha).HasColumnType("date");

                entity.Property(e => e.fecha_nacimiento).HasColumnType("date");

                entity.Property(e => e.i_fecha).HasColumnType("date");

                entity.Property(e => e.imp_aporte)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.jub_benef)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.letarc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.localidad)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.mat_fdes).HasColumnType("date");

                entity.Property(e => e.mat_fhas).HasColumnType("date");

                entity.Property(e => e.materno).HasDefaultValueSql("((0))");

                entity.Property(e => e.motivo1)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.periodo_aporte)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.piso).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.plan_esp)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.provincia)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.puerta).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.telefono)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.tipo_disc)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.tipo_dom)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.v_fecha).HasColumnType("date");

                entity.Property(e => e.ven_fecha).HasColumnType("date");

                entity.Property(e => e.zona)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiliadoMaestra>(entity =>
            {
                entity.ToTable("AfiliadoMaestra");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiliadoNroTarjetaNroGenerado>(entity =>
            {
                entity.ToTable("AfiliadoNroTarjetaNroGenerado");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiliadoNroTarjetaTarEstado>(entity =>
            {
                entity.HasKey(e => e.IdAfiNroTarEst)
                    .HasName("PK_AfiliadoNroTarjetaTarEstado_1");

                entity.ToTable("AfiliadoNroTarjetaTarEstado");

                entity.HasIndex(e => new { e.AfiliadoNroTarjetaTarEstadoCodigo, e.AfiliadoNroTarjetaTarEstadoHasta, e.AfiliadoCuil }, "Index");

                entity.HasIndex(e => e.AfiliadoCuil, "afi_tst_cuil");

                entity.Property(e => e.AfiliadoCuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.AfiliadoNroTarjetaNroTarjeta).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.AfiliadoNroTarjetaTarEstadoCodigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AfiliadoNroTarjetaTarEstadoDesde).HasColumnType("datetime");

                entity.Property(e => e.AfiliadoNroTarjetaTarEstadoHasta).HasColumnType("datetime");

                entity.Property(e => e.AfiliadoNroTarjetaTarEstadoMotivo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Machine)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.UserAC)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.UserMod)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UserSave)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiliadosAdicional>(entity =>
            {
                entity.HasKey(e => e.AfiliadoAdicionalID)
                    .HasName("PK_AfiliadoAdicional");

                entity.ToTable("AfiliadosAdicional");

                entity.HasIndex(e => new { e.IdAfiliado, e.TipoVencimientoID, e.Anulado, e.FechaVencimiento }, "Index_AfiliadosAdicional");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiliadosCentroDeImagen>(entity =>
            {
                entity.HasKey(e => e.IdAfiliadoCentroDeImagen);

                entity.ToTable("AfiliadosCentroDeImagen");

                entity.HasIndex(e => e.Anulado, "IdexAfiCentroImagenesAfi");

                entity.HasIndex(e => new { e.IdCentroPorGrupo, e.Anulado }, "IndexGrupoAfiAnulado");

                entity.HasIndex(e => e.Anulado, "IndexGrupoAfiliado");

                entity.HasIndex(e => new { e.IdCentroPorGrupo, e.Anulado }, "IndexIdAfiliadoGrupoAnulado");

                entity.HasIndex(e => new { e.IdAfiliado, e.Anulado }, "IndexIdCentroGrupoAfi");

                entity.Property(e => e.A_Numero).HasMaxLength(20);

                entity.Property(e => e.Cuil).HasMaxLength(11);

                entity.Property(e => e.CuilTitular).HasMaxLength(11);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.PedidoCambio).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdAfiliadoNavigation)
                    .WithMany(p => p.AfiliadosCentroDeImagens)
                    .HasForeignKey(d => d.IdAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AfiliadosCentroDeImagen_Afiliados");

                entity.HasOne(d => d.IdCentroPorGrupoNavigation)
                    .WithMany(p => p.AfiliadosCentroDeImagens)
                    .HasForeignKey(d => d.IdCentroPorGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AfiliadosCentroDeImagen_CentrosPorGrupoPracticas");
            });
            modelBuilder.Entity<AfiliadoLugarPago>(entity =>
            {
                entity.HasKey(e => e.IdAfiliadosLugarPago);

            });
                modelBuilder.Entity<AfiliadosDDJJ>(entity =>
            {
                entity.HasKey(e => e.IdDdjj);

                entity.ToTable("AfiliadosDDJJ");

                entity.HasIndex(e => new { e.Cuil, e.Anulado }, "IndexDDJJ");

                entity.HasIndex(e => new { e.IdAfiliado, e.Anulado }, "IndexDDJJAfi");

                entity.Property(e => e.A_Numero).HasMaxLength(20);

                entity.Property(e => e.ApellidoMaterno).HasMaxLength(50);

                entity.Property(e => e.ApellidoPaterno).HasMaxLength(50);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVenceAfiliacion).HasColumnType("date");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnType("date")
                    .HasComment("Esta fecha indica hasta cuando el afiliado puede operar en el sistema.\r\nSi se encuentra vacio tiene uso de la obra social ilimitado.");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.Fliar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Motivo).HasMaxLength(200);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Observaciones).HasMaxLength(500);

                entity.Property(e => e.OperAnula).HasMaxLength(11);

                entity.HasOne(d => d.IdCosspraNavigation)
                    .WithMany(p => p.AfiliadosDDJJs)
                    .HasForeignKey(d => d.IdCosspra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AfiliadosDDJJ_Cosspra");

                entity.HasOne(d => d.IdDdjjHeaderNavigation)
                    .WithMany(p => p.AfiliadosDDJJs)
                    .HasForeignKey(d => d.IdDdjjHeader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AfiliadosDDJJ_Ddjj_Header");

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.AfiliadosDDJJs)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .HasConstraintName("FK_AfiliadosDDJJ_EstadoCivil");

                entity.HasOne(d => d.IdNacionalidadNavigation)
                    .WithMany(p => p.AfiliadosDDJJs)
                    .HasForeignKey(d => d.IdNacionalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AfiliadosDDJJ_Paises");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.AfiliadosDDJJs)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AfiliadosDDJJ_Sexo2");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.AfiliadosDDJJs)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AfiliadosDDJJ_TipoDocumento");

                entity.HasOne(d => d.IdTipoFamiliarNavigation)
                    .WithMany(p => p.AfiliadosDDJJs)
                    .HasForeignKey(d => d.IdTipoFamiliar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AfiliadosDDJJ_TipoFamiliar");

                entity.HasOne(d => d.IdTipoIngresoAfiliacionNavigation)
                    .WithMany(p => p.AfiliadosDDJJs)
                    .HasForeignKey(d => d.IdTipoIngresoAfiliacion)
                    .HasConstraintName("FK_AfiliadosDDJJ_Tipo_IngresoAfiliacion");
            });

            modelBuilder.Entity<AfiliadosHistorico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AfiliadosHistorico");

                entity.HasIndex(e => e.Cuil, "IdEstadosAfiliado");

                entity.HasIndex(e => e.FechaCrea, "IndexAfiliadoHistoricoXFechaCrea");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodArc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnType("date")
                    .HasComment("Esta fecha indica hasta cuando el afiliado puede operar en el sistema.\r\nSi se encuentra vacio tiene uso de la obra social ilimitado.");

                entity.Property(e => e.Fecha_CtaCTe).HasColumnType("date");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.Fliar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.LetArc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiliadosHistoricoTrigger>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoAfiliado);

                entity.ToTable("AfiliadosHistoricoTrigger");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodArc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.Fecha_CtaCTe).HasColumnType("datetime");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.Fliar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.LetArc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiliadosLugarPago>(entity =>
            {
                entity.HasKey(e => e.IdAfiliadosLugarPago);

                entity.ToTable("AfiliadosLugarPago");

                entity.HasIndex(e => e.Anulado, "Index_AfiliadosLugarP_Anulado");

                entity.HasIndex(e => new { e.IdAfiliado, e.Anulado }, "Index_AfiliadosLugarP_IdAfiAnulado");

                entity.HasIndex(e => new { e.IdLugarPago, e.Anulado }, "Index_AfiliadosLugarPago");

                entity.HasIndex(e => new { e.IdLugarPago, e.IdAfiliado, e.Anulado }, "Ix_Id_Afi_anu");

                entity.Property(e => e.Adicional).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Aporte).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha_Desde).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Hasta).HasColumnType("datetime");

                entity.Property(e => e.NumBeneficioAnses)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(3000)
                    .IsFixedLength();

                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Afiliados_prueba>(entity =>
            {
                entity.HasKey(e => e.IdAfiliado);

                entity.ToTable("Afiliados_prueba");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodArc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.Fecha_CtaCTe)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.Fliar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.LetArc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Alcance_Debito>(entity =>
            {
                entity.HasKey(e => e.IdAlcance_Debito);

                entity.ToTable("Alcance_Debito");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AlfaBeta_AccioFar>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_AccioFar_1");

                entity.ToTable("AlfaBeta_AccioFar");

                entity.HasIndex(e => e.Codigo, "IX_AccioFar")
                    .IsUnique();

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(32)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AlfaBeta_Barextra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlfaBeta_Barextra");

                entity.Property(e => e.CodigoBarra)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.HasOne(d => d.NroRegistroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NroRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_Barextra_AlfaBeta_ManualDat");
            });

            modelBuilder.Entity<AlfaBeta_ExtraBarra>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodigoBarra)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.HasOne(d => d.NroRegistroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NroRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ExtraBarras_AlfaBeta_ManualDat");
            });

            modelBuilder.Entity<AlfaBeta_Forma>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formas_1");

                entity.HasIndex(e => e.Codigo, "IX_Formas")
                    .IsUnique();

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AlfaBeta_Gtin1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlfaBeta_Gtin1");

                entity.HasIndex(e => e.NroRegistro, "Index_EntradasSucursal");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.HasOne(d => d.NroRegistroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NroRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_Gtin1_AlfaBeta_ManualDat");
            });

            modelBuilder.Entity<AlfaBeta_ManExtra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlfaBeta_ManExtra");

                entity.HasIndex(e => e.NroRegistro, "Index_NroReg");

                entity.Property(e => e.Acciofar).HasComment("Acciofar.txt");

                entity.Property(e => e.Formas).HasComment("Formas.txt");

                entity.Property(e => e.Monodro).HasComment("Monodro.txt");

                entity.Property(e => e.NroRegistro).HasComment("Manual.Dat");

                entity.Property(e => e.Potencia)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Tamanos).HasComment("Tamanos.txt");

                entity.Property(e => e.Vias).HasComment("Vias.txt");

                entity.Property(e => e.tipoUnid).HasComment("tipoUnid.txt");

                entity.Property(e => e.uPotenci).HasComment("uPotenci.txt");

                entity.HasOne(d => d.AcciofarNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Acciofar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_AccioFar");

                entity.HasOne(d => d.FormasNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Formas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_Formas");

                entity.HasOne(d => d.MonodroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Monodro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_MonoDro");

                entity.HasOne(d => d.NroRegistroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NroRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_ManualDat");

                entity.HasOne(d => d.ViasNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Vias)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_vias");

                entity.HasOne(d => d.tipoUn)
                    .WithMany()
                    .HasForeignKey(d => d.tipoUnid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_tipoUnid");

                entity.HasOne(d => d.uPotenciNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.uPotenci)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManExtra_AlfaBeta_uPotenci");
            });

            modelBuilder.Entity<AlfaBeta_ManPato>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlfaBeta_ManPato");

                entity.HasOne(d => d.IdPatologiaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPatologia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManPato_Patologias");

                entity.HasOne(d => d.MonodroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Monodro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManPato_AlfaBeta_MonoDro");
            });

            modelBuilder.Entity<AlfaBeta_ManualDat>(entity =>
            {
                entity.HasKey(e => e.NroRegistro)
                    .HasName("PK_ManualDat_1");

                entity.ToTable("AlfaBeta_ManualDat");

                entity.HasIndex(e => e.Baja, "Index_Busqueda_Con_Stock");

                entity.Property(e => e.NroRegistro).ValueGeneratedNever();

                entity.Property(e => e.Baja)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("0 = Presentación activa.\r\n1 = Presentación dada de baja.");

                entity.Property(e => e.Blanco)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("Espacios en blanco.");

                entity.Property(e => e.Blanco2)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("Fecha de vigencia del precio.(AAAAMMDD)");

                entity.Property(e => e.Gravamen)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Heladera)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("1 = Debe conservarse en heladera.");

                entity.Property(e => e.Importado)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("1 = Importado; 0 = Nacional");

                entity.Property(e => e.Ioma1).HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Ioma2)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("Marca de uso Normatizado. (‘N’ = No / ‘S’ = Si / ‘A’ = Anexo II / ‘E’ = Plan\r\nSER / ‘T’ = Diag. Tuber., Lepra o Miastenia gravis / ‘C’ = IOMA ACC. )");

                entity.Property(e => e.Ioma3)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("Marca de cobertura en Internación. (N/S)");

                entity.Property(e => e.Iva)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("1 = con IVA a farmacia.");

                entity.Property(e => e.Laboratorio)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("Descripción del laboratorio.");

                entity.Property(e => e.Marca)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("0 = No controlado\r\n2 = Psicotrópico II\r\n3 = Psicotrópico III\r\n4 = Psicotrópico IV\r\n6 = Estupefaciente I\r\n7 = Estupefaciente II\r\n8 = Estupefaciente III\r\n9 = Succinilcolina\r\nA = Venta Vigilada");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Pami)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("0 = Sin Información (Sin descuento)\r\n1 = 70%\r\n2 = 50 %.\r\n3 = 45%\r\n4 = 100% EMPADRONAMIENTO PREVIO\r\n5 = 30%.\r\n6 = 80 %.\r\n7 = 40%\r\n8 = 60%\r\n9 = 65%\r\nA =USO AUTORIZADO\r\nB = 55%\r\nC = 75%\r\nD = 35%\r\nE = 100% CON AUTORIZACIÓN PREVIA");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("Precio sugerido al público en pesos. (Multiplicado por 100, sin decimales)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Sifar)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("Marca de cobertura de SIFAR. (N/S)");

                entity.Property(e => e.Tamano)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("1 = Menor,\r\n2 = Siguiente,\r\n3 = Grande (de dos presentaciones),\r\n4 = Gigante,\r\n5 = Grande (de mas de dos presentaciones),\r\n6 = Antibiótico Monodosis,\r\n7 = Antibiótico Multidosis,\r\n8 = Soluciones Parenterales,\r\n9 = Hospitalario, A = No clasificado");

                entity.Property(e => e.TipoVenta)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("1 = Vta. Libre\r\n2 = Vta. Bajo Receta\r\n3 = Vta. Bajo Receta Archivada\r\n4 = Vta. Bajo Receta Oficial\r\n5 = Pendiente\r\n6 = Bajo control médico recomendado\r\n7 = No clasificado");

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(4, 0)")
                    .HasComment("1 = El producto no es divisible.");

                entity.HasOne(d => d.TipoVentaNavigation)
                    .WithMany(p => p.AlfaBeta_ManualDats)
                    .HasForeignKey(d => d.TipoVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_ManualDat_Tipo_VentaAlfaBeta");
            });

            modelBuilder.Entity<AlfaBeta_MonoDro>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_MonoDro_1");

                entity.ToTable("AlfaBeta_MonoDro");

                entity.HasIndex(e => e.Codigo, "IX_MonoDro")
                    .IsUnique();

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(32)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AlfaBeta_Multidro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlfaBeta_Multidro");

                entity.HasIndex(e => e.NroRegistro, "Index_x_Busqueda");

                entity.Property(e => e.NuevaDro).HasComment("Archivo nuevadro.txt");

                entity.HasOne(d => d.NroRegistroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NroRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_Multidro_AlfaBeta_ManualDat");

                entity.HasOne(d => d.NuevaDroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NuevaDro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_Multidro_AlfaBeta_Nuevadro");
            });

            modelBuilder.Entity<AlfaBeta_Nuevadro>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Nuevadro_1");

                entity.ToTable("AlfaBeta_Nuevadro");

                entity.HasIndex(e => e.Codigo, "IX_Nuevadro")
                    .IsUnique();

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(36)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AlfaBeta_RegNueva>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlfaBeta_RegNueva");

                entity.Property(e => e.Potencia)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.HasOne(d => d.MonoDroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MonoDro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_RegNueva_AlfaBeta_Nuevadro");

                entity.HasOne(d => d.NroRegistroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.NroRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_RegNueva_AlfaBeta_ManualDat");

                entity.HasOne(d => d.uPotenciNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.uPotenci)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlfaBeta_RegNueva_AlfaBeta_uPotenci");
            });

            modelBuilder.Entity<AlfaBeta_tipoUnid>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_tipoUnid_1");

                entity.ToTable("AlfaBeta_tipoUnid");

                entity.HasIndex(e => e.Codigo, "IX_tipoUnid")
                    .IsUnique();

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AlfaBeta_uPotenci>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_uPotenci_1");

                entity.ToTable("AlfaBeta_uPotenci");

                entity.HasIndex(e => e.Codigo, "IX_uPotenci")
                    .IsUnique();

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AlfaBeta_via>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_vias_1");

                entity.HasIndex(e => e.Codigo, "IX_vias")
                    .IsUnique();

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Alfabeta_Tamano>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(32)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ampliacion_Presupuesto>(entity =>
            {
                entity.HasKey(e => e.AmpliacionPresupuestoId);

                entity.ToTable("Ampliacion_Presupuesto");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Gasto_Recurso)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero_Expediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Periodo_Aplicacion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.HasOne(d => d.PresupuestoContable)
                    .WithMany(p => p.Ampliacion_Presupuestos)
                    .HasForeignKey(d => d.PresupuestoContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ampliacion_Presupuesto_Presupuesto_Contable");
            });

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.NroRegistro);

                entity.HasIndex(e => new { e.Anulado, e.Articulo1 }, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.Anulado, e.Articulo1 }, "Index_BusquedaArticulosNoMed");

                entity.Property(e => e.Articulo1)
                    .HasMaxLength(1)
                    .HasColumnName("Articulo")
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength();

                entity.Property(e => e.Codbarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_UltCompra).HasColumnType("date");

                entity.Property(e => e.Heladera)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Iva).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Precio_Compra).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AsientosModelo>(entity =>
            {
                entity.HasKey(e => e.AsientoModeloId);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CuentaPresupuestaria)
                    .WithMany(p => p.AsientosModelos)
                    .HasForeignKey(d => d.CuentaPresupuestariaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsientosModelos_Cuentas_Contables");

                entity.HasOne(d => d.CuentaTradicional)
                    .WithMany(p => p.AsientosModelos)
                    .HasForeignKey(d => d.CuentaTradicionalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsientosModelos_Cuentas_Contables_Tradicional");
            });

            modelBuilder.Entity<AsientosPartida>(entity =>
            {
                entity.HasKey(e => e.AsientosPartidasID);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_RoleId");

                            j.HasIndex(new[] { "UserId" }, "IX_UserId");

                            j.IndexerProperty<string>("UserId").HasMaxLength(128);

                            j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AutorizaDbf>(entity =>
            {
                entity.HasKey(e => e.IdAutorizaDbf);

                entity.ToTable("AutorizaDbf");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Caja).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Cobertu).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Efector)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Empresa)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_e).HasColumnType("date");

                entity.Property(e => e.Fecha_i).HasColumnType("date");

                entity.Property(e => e.Fecha_v).HasColumnType("date");

                entity.Property(e => e.Hora_Carga)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Hora_Cza)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Imp_Afi_G).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Imp_Afi_H).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Imp_Tot_G).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Imp_Tot_H).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Int_Nro)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Int_Suc)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Lp_su)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Nomenclado)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Nro_Aut)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.O_social)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Obs)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Ope_Cza)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Prescribe)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Suc_Aut)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.T_Emite)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Tip_Aut)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.c_Plan)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.f_Cobro).HasColumnType("date");

                entity.Property(e => e.p_codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.t_Prestac)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AutorizacionSepelios_Detalle>(entity =>
            {
                entity.HasKey(e => e.IdAutorizacionSepeliosDetalle);

                entity.ToTable("AutorizacionSepelios_Detalle");

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Traslado_Desde).HasMaxLength(50);

                entity.Property(e => e.Traslado_Hasta).HasMaxLength(50);

                entity.HasOne(d => d.IdAutorizacionSepeliosNavigation)
                    .WithMany(p => p.AutorizacionSepelios_Detalles)
                    .HasForeignKey(d => d.IdAutorizacionSepelios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutorizacionSepelios_Detalle_AutorizacionSepelios_Encabezado");

                entity.HasOne(d => d.IdTipoServicioSepeliosNavigation)
                    .WithMany(p => p.AutorizacionSepelios_Detalles)
                    .HasForeignKey(d => d.IdTipoServicioSepelios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutorizacionSepelios_Detalle_TipoServicio_Sepelios");
            });

            modelBuilder.Entity<AutorizacionSepelios_Encabezado>(entity =>
            {
                entity.HasKey(e => e.IdAutorizacionSepelios);

                entity.ToTable("AutorizacionSepelios_Encabezado");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Fallecimiento).HasColumnType("date");

                entity.Property(e => e.Nro_Acta).HasMaxLength(50);

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdAfiliadoNavigation)
                    .WithMany(p => p.AutorizacionSepelios_Encabezados)
                    .HasForeignKey(d => d.IdAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutorizacionSepelios_Encabezado_Afiliados");
            });

            modelBuilder.Entity<Autorizacione>(entity =>
            {
                entity.HasKey(e => e.IdAutoriza)
                    .HasName("PK_autorizaciones");

                entity.Property(e => e.Auditor_Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Autorizacion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Cobertura).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Coseguro_Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro_Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vence).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reconoce_Honorarios).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<AutorizacionesCirugia>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdAutorizacionesCirugias).ValueGeneratedOnAdd();

                entity.Property(e => e.MismaVia)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<AutorizacionesMedicamentos_b_>(entity =>
            {
                entity.HasKey(e => e.IdAutoriza)
                    .HasName("PK_autorizacionesMedicamentos");

                entity.ToTable("AutorizacionesMedicamentos(b)");

                entity.Property(e => e.Auditor_Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Autorizacion)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Cobertura).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Coseguro_Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro_Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vence).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reconoce_Honorarios).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<Auxiliar_Bonos_Viejo>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.id, "Index_Viejos");

                entity.Property(e => e.Familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.a_numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.femision)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.fvence)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.id).ValueGeneratedOnAdd();

                entity.Property(e => e.importe)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.nrobono)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.o_social)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.operador)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.tipobono)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.tipoprac)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.HasKey(e => e.IdBanner);

                entity.ToTable("Banner");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BioquimicosConsumo>(entity =>
            {
                entity.HasKey(e => e.IdBioquimicosConsumo);

                entity.ToTable("BioquimicosConsumo");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BioquimicosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdBioquimicosDetalle);

                entity.ToTable("BioquimicosDetalle");

                entity.Property(e => e.CodigoPractica).HasMaxLength(10);

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CoseguroPorcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombrePractica).HasMaxLength(150);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdBioquimicoEncabezadoNavigation)
                    .WithMany(p => p.BioquimicosDetalles)
                    .HasForeignKey(d => d.IdBioquimicoEncabezado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BioquimicosDetalle_BioquimicosEncabezado");
            });

            modelBuilder.Entity<BioquimicosEncabezado>(entity =>
            {
                entity.HasKey(e => e.IdBioquimicosEncabezado);

                entity.ToTable("BioquimicosEncabezado");

                entity.Property(e => e.CIE10).HasMaxLength(6);

                entity.Property(e => e.CUIL)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaPrescripcion).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.NombreAfiliado).HasMaxLength(100);

                entity.Property(e => e.NombrePrescriptor).HasMaxLength(75);

                entity.Property(e => e.Numero).HasMaxLength(14);

                entity.Property(e => e.NumeroAfiliado).HasMaxLength(20);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PlanNombre).HasMaxLength(75);

                entity.Property(e => e.Prescriptor).HasMaxLength(10);

                entity.HasOne(d => d.IdBioquimicosConsumoNavigation)
                    .WithMany(p => p.BioquimicosEncabezados)
                    .HasForeignKey(d => d.IdBioquimicosConsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BioquimicosEncabezado_BioquimicosConsumo");
            });

            modelBuilder.Entity<BloqueoAfiliadoOnline>(entity =>
            {
                entity.HasKey(e => e.BloqueoID);

                entity.ToTable("BloqueoAfiliadoOnline");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.HastaFechaBloqueo).HasColumnType("date");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BloqueoPreguntaOnline>(entity =>
            {
                entity.HasKey(e => e.PreguntaID);

                entity.ToTable("BloqueoPreguntaOnline");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Pregunta).HasMaxLength(300);

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BonosAutorizado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ART)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.A_NUMERO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CAJA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CANTIDAD)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COBERTU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COBRADA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONSUMIDO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIAGNOSTIC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIAS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIGI)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ECG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EFECTOR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMISION_A)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMPRESA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ESTADO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EXCEPCION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EXE_TOPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAMILIAR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_E)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_I)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_V)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F_COBRO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HORA_CARGA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HORA_CZA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_AFI_G)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_AFI_H)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_TOT_G)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_TOT_H)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INT_NRO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INT_SUC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LP_SU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NOMENCLADO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NRO_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPERADOR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPE_CZA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.O_SOCIAL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PRESCRIBE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P_CODIGO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMISOS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUC_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TIP_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRANSAC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_ARANCEL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_COBERTU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_EMITE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_PRESTAC)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BonosAutorizados_bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BonosAutorizados_bak");

                entity.Property(e => e.ART)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.A_NUMERO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CAJA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CANTIDAD)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COBERTU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COBRADA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONSUMIDO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIAGNOSTIC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIAS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIGI)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ECG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EFECTOR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMISION_A)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMPRESA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ESTADO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EXCEPCION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EXE_TOPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAMILIAR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_E)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_I)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_V)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F_COBRO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HORA_CARGA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HORA_CZA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_AFI_G)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_AFI_H)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_TOT_G)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_TOT_H)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INT_NRO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INT_SUC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LP_SU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NOMENCLADO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NRO_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPERADOR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPE_CZA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.O_SOCIAL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PRESCRIBE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P_CODIGO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMISOS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUC_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TIP_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRANSAC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_ARANCEL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_COBERTU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_EMITE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_PRESTAC)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<CabeceraLote>(entity =>
            {
                entity.HasKey(e => e.Nropaq);
            });
            modelBuilder.Entity<CajaCierre>(entity =>
            {
                entity.HasKey(e => e.IdCierre)
                    .HasName("PK_CajaCierre_1");

                entity.ToTable("CajaCierre");

                entity.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<CajaCierreDeposito>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cargado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.IdCajaCierreDeposito).ValueGeneratedOnAdd();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroTransaccion)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OperadorConfirma)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Terminal)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.TipoDeposito)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CajaOperadore>(entity =>
            {
                entity.HasKey(e => e.IdCaja)
                    .HasName("PK_Ordenes_Caja");

                entity.HasIndex(e => new { e.Anulado, e.comprobante_original }, "Index1");

                entity.HasIndex(e => new { e.Anulado, e.comprobante_original }, "Index2");

                entity.HasIndex(e => new { e.Anulado, e.comprobante_original }, "Index3");

                entity.HasIndex(e => new { e.Anulado, e.comprobante_original }, "Index4");

                entity.HasIndex(e => new { e.Cajero, e.IdCierreCaja, e.Anulado }, "Index_Caj_Cie_Anu");

                entity.HasIndex(e => new { e.Anulado, e.Fecha, e.IdTipoCaja, e.IdCierreCaja }, "Index_CajaAnulFechaTipoCajaIdCierre");

                entity.HasIndex(e => new { e.Anulado, e.Fecha, e.IdTipoCaja }, "Index_CajaAnuladoFecha");

                entity.HasIndex(e => e.numero_comprobante, "Index_Compr");

                entity.HasIndex(e => new { e.IdTipoCaja, e.Cajero, e.IdCierreCaja, e.Anulado }, "Index_ResumenCaja");

                entity.Property(e => e.Cajero)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Pagado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.comprobante_original)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.numero_comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.HasOne(d => d.IdCierreCajaNavigation)
                    .WithMany(p => p.CajaOperadores)
                    .HasForeignKey(d => d.IdCierreCaja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CajaOperadores_CajaCierre");

                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany(p => p.CajaOperadores)
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CajaOperadores_ConceptoCaja");

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.CajaOperadores)
                    .HasForeignKey(d => d.IdFormaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CajaOperadores_TipoFormaPago");

                entity.HasOne(d => d.IdLugarNavigation)
                    .WithMany(p => p.CajaOperadores)
                    .HasForeignKey(d => d.IdLugar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CajaOperadores_TipoLugar");

                entity.HasOne(d => d.IdTipoCajaNavigation)
                    .WithMany(p => p.CajaOperadores)
                    .HasForeignKey(d => d.IdTipoCaja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CajaOperadores_TipoCaja");
            });
             

            modelBuilder.Entity<CajaTipoOrigen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CajaTipoOrigen");

                entity.Property(e => e.IdCajaTipoOrigen).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CalculoPrecio>(entity =>
            {
                entity.ToTable("CalculoPrecio");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Capitulo>(entity =>
            {
                entity.HasKey(e => e.Capitulo1);

                entity.Property(e => e.Capitulo1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Capitulo");

                entity.Property(e => e.Desde)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Hasta)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(400)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Carrera_Inscripcion>(entity =>
            {
                entity.ToTable("Carrera_Inscripcion");

                entity.Property(e => e.Celular)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.FecNac).HasColumnType("date");

                entity.Property(e => e.FechaEntregaKits).HasColumnType("datetime");

                entity.Property(e => e.FechaPreInscripcion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Carrera_Inscripcions)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carrera_Inscripcion_Categoria_Aerobica");
            });

            modelBuilder.Entity<CartaPresentacion>(entity =>
            {
                entity.ToTable("CartaPresentacion");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CartaPresentacionGrupoFliar>(entity =>
            {
                entity.HasKey(e => e.CartaPresGrupoFliarID)
                    .HasName("PK_EsquemaGrupoFliar");

                entity.ToTable("CartaPresentacionGrupoFliar");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cartera>(entity =>
            {
                entity.HasKey(e => e.IdCartera);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Catastrofico>(entity =>
            {
                entity.HasKey(e => e.IdCatastrofico);

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<CategoriaPapele>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaPapeles);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.CategoriaPapeles)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoriaPapeles_Categoria");

                entity.HasOne(d => d.IdPapelNavigation)
                    .WithMany(p => p.CategoriaPapeles)
                    .HasForeignKey(d => d.IdPapel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoriaPapeles_Papeles");
            });

            modelBuilder.Entity<Categoria_Aerobica>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("Categoria_Aerobica");

                entity.Property(e => e.Edad_Comparacion)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CategoriasDbf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CategoriasDbf");

                entity.Property(e => e.ADICIONAL).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.APORTE).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CODIGO)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.COD_ANSES).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ESTLABOR).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HFEM).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HMAS).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NOMBRE).HasMaxLength(45);

                entity.Property(e => e.TITULAR).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.Adicional).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Aporte).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CentroRubroPrestador>(entity =>
            {
                entity.HasKey(e => e.IdCentroRubroPrestador);

                entity.ToTable("CentroRubroPrestador");
            });

            modelBuilder.Entity<CentrosDeImagen>(entity =>
            {
                entity.HasKey(e => e.IdCentroDeImagen);

                entity.ToTable("CentrosDeImagen");

                entity.Property(e => e.Ambulatorio).HasDefaultValueSql("((1))");

                entity.Property(e => e.Internados).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre).HasMaxLength(75);
            });

            modelBuilder.Entity<CentrosPorGrupoDomicilio>(entity =>
            {
                entity.HasKey(e => e.IdCentroPorGrupoDomicilio);

                entity.Property(e => e.Domicilio).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(75);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula).HasMaxLength(11);

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.Telefono).HasMaxLength(75);

                entity.HasOne(d => d.IdCentroDeImagenNavigation)
                    .WithMany(p => p.CentrosPorGrupoDomicilios)
                    .HasForeignKey(d => d.IdCentroDeImagen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CentrosPorGrupoDomicilios_CentrosDeImagen");

                entity.HasOne(d => d.IdGrupoPracticasNavigation)
                    .WithMany(p => p.CentrosPorGrupoDomicilios)
                    .HasForeignKey(d => d.IdGrupoPracticas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CentrosPorGrupoDomicilios_GrupoPracticas");
            });

            modelBuilder.Entity<CentrosPorGrupoPractica>(entity =>
            {
                entity.HasKey(e => e.IdCentroPorGrupo);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula).HasMaxLength(11);

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdCentroDeImagenNavigation)
                    .WithMany(p => p.CentrosPorGrupoPracticas)
                    .HasForeignKey(d => d.IdCentroDeImagen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CentrosPorGrupoPracticas_CentrosDeImagen");

                entity.HasOne(d => d.IdGrupoPracticasNavigation)
                    .WithMany(p => p.CentrosPorGrupoPracticas)
                    .HasForeignKey(d => d.IdGrupoPracticas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CentrosPorGrupoPracticas_GrupoPracticas");
            });

            modelBuilder.Entity<CentrosPorGrupoPracticasDetalle>(entity =>
            {
                entity.HasKey(e => e.IdCentroPorGrupoDetalle);

                entity.ToTable("CentrosPorGrupoPracticasDetalle");

                entity.Property(e => e.Cupo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            });

            modelBuilder.Entity<CentrosPorGrupoPracticasHistorial>(entity =>
            {
                entity.HasKey(e => e.IdCentroPorGrupoHistorial);

                entity.ToTable("CentrosPorGrupoPracticasHistorial");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula).HasMaxLength(11);

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CentrosVacunacion>(entity =>
            {
                entity.ToTable("CentrosVacunacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Centros_Salud>(entity =>
            {
                entity.HasKey(e => e.IdCentro);

                entity.ToTable("Centros_Salud");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cheque>(entity =>
            {
                entity.HasKey(e => e.IdCheque);

                entity.Property(e => e.CuilPersona)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaImprime).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombreImpreso)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.OperadorAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorImprime)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Serie)
                    .HasMaxLength(29)
                    .IsFixedLength();

                entity.HasOne(d => d.ChequesBlancos)
                    .WithMany(p => p.Cheques)
                    .HasForeignKey(d => d.ChequesBlancosID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cheques_ChequesEnBlanco");
            });

            modelBuilder.Entity<ChequeAMano>(entity =>
            {
                entity.ToTable("ChequeAMano");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.ImporteCheque).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroCheque)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(14)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ChequesEnBlanco>(entity =>
            {
                entity.HasKey(e => e.ChequesBlancosID);

                entity.ToTable("ChequesEnBlanco");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NumDesde)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.NumHasta)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.CuentaBanco)
                    .WithMany(p => p.ChequesEnBlancos)
                    .HasForeignKey(d => d.CuentaBancoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChequesEnBlanco_Cuentas_Bancos");
            });

            modelBuilder.Entity<CierreFactura>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCierre).ValueGeneratedOnAdd();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ClasificadorGasto>(entity =>
            {
                entity.HasKey(e => e.ClasificadorGastosID);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ClinicaCoseguro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClinicaCoseguro");

                entity.Property(e => e.LimitexAfiliado).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LimitexClinica).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Cobro_ImpresionTarjetum>(entity =>
            {
                entity.HasKey(e => e.Cobro_ImpresionTarjetaID);

                entity.Property(e => e.AfiliadoCuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.MontoReimpresion).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumComprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OpeCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpeModif)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Codigo_Esquema>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Codigo_Esquema");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Colore>(entity =>
            {
                entity.HasKey(e => e.ColorID);

                entity.Property(e => e.Codigo).HasMaxLength(50);
            });

            modelBuilder.Entity<ComprasFarmacium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cargado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(14)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdComprasFarmacia).ValueGeneratedOnAdd();

                entity.Property(e => e.NroLote)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.QR)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ComprasTipo>(entity =>
            {
                entity.HasKey(e => e.IdComprasTipo);

                entity.ToTable("ComprasTipo");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConceptoCaja>(entity =>
            {
                entity.HasKey(e => e.IdConcepto);

                entity.ToTable("ConceptoCaja");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConciliacionBancarium>(entity =>
            {
                entity.HasKey(e => e.IdConciliacionBancaria);

                entity.Property(e => e.Concepto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMovimiento).HasColumnType("date");

                entity.Property(e => e.FechaValor).HasColumnType("date");

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Referencia)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaBancariaNavigation)
                    .WithMany(p => p.ConciliacionBancaria)
                    .HasForeignKey(d => d.IdCuentaBancaria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConciliacionBancaria_Cuentas_Bancos");
            });

            modelBuilder.Entity<CondicionAfiliado>(entity =>
            {
                entity.HasKey(e => e.IdCondicion);

                entity.ToTable("CondicionAfiliado");

                entity.Property(e => e.Desde).HasColumnType("date");

                entity.Property(e => e.Expediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Hasta).HasColumnType("date");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(120)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.IdTipoCondicionNavigation)
                    .WithMany(p => p.CondicionAfiliados)
                    .HasForeignKey(d => d.IdTipoCondicion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CondicionAfiliado_TipoCondicion");
            });

            modelBuilder.Entity<ConfirmaCambioCentro>(entity =>
            {
                entity.HasKey(e => e.CambioCentroID);

                entity.ToTable("ConfirmaCambioCentro");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCambia)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConstanciasAfiliado>(entity =>
            {
                entity.ToTable("ConstanciasAfiliado");

                entity.Property(e => e.CodigoVerificacion)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IP)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConstanciasNoAfiliado>(entity =>
            {
                entity.HasKey(e => e.ConstanciaNoAfiliadoId);

                entity.ToTable("ConstanciasNoAfiliado");

                entity.Property(e => e.DniNoAfiliado)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.DniSolicitante)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaConstancia).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaVenceConstancia).HasColumnType("datetime");

                entity.Property(e => e.NombreApellidoSolicitante).HasMaxLength(250);

                entity.Property(e => e.NombreNoAfiliado).HasMaxLength(250);

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConsumoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdConsumoDetalle);

                entity.ToTable("ConsumoDetalle");

                entity.Property(e => e.Caras)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPractica).HasMaxLength(10);

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CoseguroPorcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombrePractica).HasMaxLength(150);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdConsumoEncabezadoNavigation)
                    .WithMany(p => p.ConsumoDetalles)
                    .HasForeignKey(d => d.IdConsumoEncabezado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsumoDetalle_ConsumoEncabezado");
            });

            modelBuilder.Entity<ConsumoEncabezado>(entity =>
            {
                entity.HasKey(e => e.IdConsumoEncabezado);

                entity.ToTable("ConsumoEncabezado");

                entity.Property(e => e.CIE10).HasMaxLength(6);

                entity.Property(e => e.CUIL)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Efector)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EfectorCobise)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaPrescripcion).HasColumnType("date");

                entity.Property(e => e.FechaPrestacion).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.NombreAfiliado).HasMaxLength(100);

                entity.Property(e => e.NombrePrescriptor).HasMaxLength(100);

                entity.Property(e => e.Numero).HasMaxLength(14);

                entity.Property(e => e.NumeroAfiliado).HasMaxLength(20);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PlanNombre).HasMaxLength(75);

                entity.Property(e => e.Prescriptor).HasMaxLength(10);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('normal')");
            });

            modelBuilder.Entity<Contable_Gasto>(entity =>
            {
                entity.HasKey(e => e.ContableGastosId);

                entity.Property(e => e.Afectacion_Definitiva).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Afectacion_Preventiva).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha_Ampliacion).HasColumnType("date");

                entity.Property(e => e.Fecha_Aprobacion).HasColumnType("date");

                entity.Property(e => e.Importe_Ampliacion).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Comprometido).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Credito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mandado_APagar).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CuentaContable)
                    .WithMany(p => p.Contable_Gastos)
                    .HasForeignKey(d => d.CuentaContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contable_Gastos_Cuentas_Contables");

                entity.HasOne(d => d.PresupuestoContable)
                    .WithMany(p => p.Contable_Gastos)
                    .HasForeignKey(d => d.PresupuestoContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contable_Gastos_Presupuesto_Contable");
            });

            modelBuilder.Entity<Contable_Recurso>(entity =>
            {
                entity.HasKey(e => e.ContableRecursosId);

                entity.Property(e => e.Fecha_Ampliacion).HasColumnType("date");

                entity.Property(e => e.Fecha_Aprobacion).HasColumnType("date");

                entity.Property(e => e.Importe_Ampliacion).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Diferencias).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Efectivo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Estimado).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CuentaContable)
                    .WithMany(p => p.Contable_Recursos)
                    .HasForeignKey(d => d.CuentaContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contable_Recursos_Cuentas_Contables");

                entity.HasOne(d => d.PresupuestoContable)
                    .WithMany(p => p.Contable_Recursos)
                    .HasForeignKey(d => d.PresupuestoContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contable_Recursos_Presupuesto_Contable");
            });

            modelBuilder.Entity<ContencionFliarDetalle>(entity =>
            {
                entity.HasKey(e => e.DetalleContencionFliarID)
                    .HasName("PK_ContencionFliarDetalle_1");

                entity.ToTable("ContencionFliarDetalle");

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.PrecioPractica).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ContencionFliarEncabezado>(entity =>
            {
                entity.HasKey(e => e.EncabezadoContencionID);

                entity.ToTable("ContencionFliarEncabezado");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaDefuncion).HasColumnType("date");

                entity.Property(e => e.FechaExpediente).HasColumnType("date");

                entity.Property(e => e.FechaTramite).HasColumnType("date");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ContencionFliarTipoDefuncion>(entity =>
            {
                entity.ToTable("ContencionFliarTipoDefuncion");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ControlCambiosCentro>(entity =>
            {
                entity.ToTable("ControlCambiosCentro");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCambio).HasMaxLength(11);
            });

            modelBuilder.Entity<ConvenioPracticaFacturacion>(entity =>
            {
                entity.HasKey(e => e.IdConvenioPractica)
                    .HasName("PK_ConvenioPractica");

                entity.ToTable("ConvenioPracticaFacturacion");

                entity.Property(e => e.Anulado)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ConvenioReciprocidad>(entity =>
            {
                entity.ToTable("ConvenioReciprocidad");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CoseguroPlan>(entity =>
            {
                entity.ToTable("CoseguroPlan");

                entity.Property(e => e.PorcentajeCobertura).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Coseguro_>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Coseguro$");

                entity.Property(e => e.CODIGO).HasMaxLength(255);

                entity.Property(e => e.GASTOS).HasColumnType("money");

                entity.Property(e => e.HONORARIOS).HasColumnType("money");

                entity.Property(e => e.NOMBRE).HasMaxLength(255);

                entity.Property(e => e.PBASEFIJO).HasColumnType("money");

                entity.Property(e => e.PRECIOBASE).HasColumnType("money");
            });

            modelBuilder.Entity<Cosspra>(entity =>
            {
                entity.HasKey(e => e.IdCosspra);

                entity.ToTable("Cosspra");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Cotizaciones_Envio>(entity =>
            {
                entity.HasKey(e => e.IdCotizaciones_Envio);

                entity.ToTable("Cotizaciones_Envio");

                entity.Property(e => e.Envio_mail)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Pedido)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha_Respuesta)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha_envio)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Presupuesto_Nro)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Usuario_Respuesta)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cotizaciones_Licitacione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaAnulado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha_Licitacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdCotizaciones_Propuesto).ValueGeneratedOnAdd();

                entity.Property(e => e.Operador)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OperadorAnulado)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cotizaciones_Pedido>(entity =>
            {
                entity.HasKey(e => e.IdCotizaciones_Pedido);

                entity.ToTable("Cotizaciones_Pedido");

                entity.Property(e => e.CalculoDesde)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CalculoHasta)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha_Cierre)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha_Inicio)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha_Requerimiento)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fecha_Vencimiento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdPlan)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.TipoPedido)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("A - Afiliado , P - Plan , C - Calculado");
            });

            modelBuilder.Entity<Cotizaciones_PedidoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdCotizaciones_PedidoDetalle);

                entity.ToTable("Cotizaciones_PedidoDetalle");

                entity.Property(e => e.Asignado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("Valor IdManual del Medicamento");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Presupuestado).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdCotizaciones_PedidoNavigation)
                    .WithMany(p => p.Cotizaciones_PedidoDetalles)
                    .HasForeignKey(d => d.IdCotizaciones_Pedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cotizaciones_PedidoDetalle_Cotizaciones_Pedido");
            });

            modelBuilder.Entity<Cotizaciones_Respuestum>(entity =>
            {
                entity.HasKey(e => e.IdCotizaciones_Respuesta);

                entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Detalle)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha_respuesta)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdCotizaciones_EnvioNavigation)
                    .WithMany(p => p.Cotizaciones_Respuesta)
                    .HasForeignKey(d => d.IdCotizaciones_Envio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cotizaciones_Respuesta_Cotizaciones_Envio");
            });

            modelBuilder.Entity<CreditosMotivoNoefec>(entity =>
            {
                entity.HasKey(e => e.IdMotivo);
            });
            modelBuilder.Entity<CreditosMotivoCancelado>(entity =>
            {
                entity.HasKey(e => e.idMotivoCancelado);
            });
            modelBuilder.Entity<CreditosGarante>(entity =>
            {
                entity.HasKey(e => e.IdGarante);
            });
            modelBuilder.Entity<CreditoExtraJudicial>(entity =>
            {
                entity.HasKey(e => e.IdExtraJudicial);
            });
            modelBuilder.Entity<CreditosNoEfectuados>(entity =>
            {
                entity.HasKey(e => e.IdNoefect);
            });
            modelBuilder.Entity<CreditosAnexo>(entity =>
            {
                entity.HasKey(e => e.IdAnexo);
            });
            modelBuilder.Entity<CreditosLotes>(entity =>
            {
                entity.HasKey(e => e.IdLote);
            });
            modelBuilder.Entity<CreditosCredito>(entity =>
            {
                entity.HasKey(e => e.IdCredito);
            });
            modelBuilder.Entity<CreditosHcablTcr>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<CreditosHlotEcrd>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<CreditosFichacta>(entity =>
            {
                entity.HasKey(e => e.IdFichacta);
            });
            modelBuilder.Entity<CreditosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCredito);
            });
            modelBuilder.Entity<CreditosConcCred>(entity =>
            {
                entity.HasKey(e => e.IdConcCred);
            });
            modelBuilder.Entity<CreditosLoteDetalles>(entity =>
            {
                entity.HasKey(e => e.IdLoteDetalle);
            });
            modelBuilder.Entity<CreditosPagosCredito>(entity =>
            {
                entity.HasKey(e => e.IdPago);
            });
            modelBuilder.Entity<CreditosSalarioAfiliado>(entity =>
            {
                entity.HasKey(e => e.IdSalario);
            });
            modelBuilder.Entity<CronogramaAfiliadoProf>(entity =>
            {
                entity.ToTable("CronogramaAfiliadoProf");

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Desde)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.Hasta)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CronogramaModificacione>(entity =>
            {
                entity.HasKey(e => e.CronogramaModifID);

                entity.Property(e => e.datos).IsUnicode(false);

                entity.Property(e => e.fechaMod).HasColumnType("datetime");

                entity.Property(e => e.operacion).IsUnicode(false);

                entity.Property(e => e.tabla).IsUnicode(false);

                entity.Property(e => e.usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CronogramaProfEducEsp>(entity =>
            {
                entity.HasKey(e => e.CronogramaID);

                entity.ToTable("CronogramaProfEducEsp");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.Frecuencia)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.M_Desde)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.M_Hasta)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModif)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.S_Desde)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.S_Hasta)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.T_Desde)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.T_Hasta)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CtaCte>(entity =>
            {
                entity.HasKey(e => e.IdCtaCte);

                entity.ToTable("CtaCte");

                entity.HasIndex(e => e.Comprobante, "Index");

                entity.HasIndex(e => e.Comprobante, "Index1");

                entity.HasIndex(e => e.Comprobante, "Index2");

                entity.HasIndex(e => e.Comprobante, "Index3");

                entity.HasIndex(e => e.Comprobante, "Index4");

                entity.HasIndex(e => e.Comprobante, "Index5");

                entity.Property(e => e.AnulaFecha).HasColumnType("datetime");

                entity.Property(e => e.AnulaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CodigoBarra)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(14)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Detalle)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MotivoAnulacionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<CtaCte_Correccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CtaCte_Correccion");

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(18)
                    .IsFixedLength();

                entity.Property(e => e.ImporteFact).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteReal).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<CtaCte_DetalleFactura>(entity =>
            {
                entity.HasKey(e => e.IdDetalleFactura);

                entity.ToTable("CtaCte_DetalleFactura");

                entity.HasIndex(e => new { e.Periodo, e.Anulado }, "Index");

                entity.HasIndex(e => new { e.Periodo, e.Anulado }, "Index1");

                entity.HasIndex(e => new { e.Anulado, e.IdEmpresa }, "Index_CtaCte_DetFac_Anu_IdEmp");

                entity.Property(e => e.AfiliadosIncorporados)
                    .HasMaxLength(400)
                    .IsFixedLength();

                entity.Property(e => e.CodigoBarra)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Cupon_Coseguro)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DetalleFactura)
                    .HasMaxLength(240)
                    .IsFixedLength();

                entity.Property(e => e.Facturacion_Global).HasColumnType("date");

                entity.Property(e => e.Fecha_Emision).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CtaCte_EmpresasIosep>(entity =>
            {
                entity.HasKey(e => e.idEmpresaCtaCte)
                    .HasName("PK_CteCte_EmpresasIosep");

                entity.ToTable("CtaCte_EmpresasIosep");

                entity.Property(e => e.Importe_Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.codbarra)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.cuota_afiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.fecha_emision)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.fecha_vencimiento1)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.fecha_vencimiento2)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.importe_vencimiento1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.importe_vencimiento2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.numero_comprobante)
                    .HasMaxLength(14)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.paga_comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.periodo)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CtaCte_IosepSalud>(entity =>
            {
                entity.HasKey(e => e.IdCtaCteIosep);

                entity.ToTable("CtaCte_IosepSalud");

                entity.HasIndex(e => new { e.Paga_Comprobante_Nro, e.Anulado }, "Index_CtaCteIosep_Paga");

                entity.HasIndex(e => new { e.IdAfiliado, e.Anulado }, "Index_CtaCte_IosepSalud_IdAfi_Anu");

                entity.HasIndex(e => new { e.Cuil, e.Anulado }, "Ix_CtaCteIosep_Cuil_Anu");

                entity.HasIndex(e => e.Numero_Comprobante, "ix_iosep_ctacte_NroComp");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Cantidad_Cuotas).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Cupon_Coseguro)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Emision)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha_Vencimiento1)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha_Vencimiento2)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdPresupuesto)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Para Vincular con Prsupuesto, Campo IdCajaClinica de la tabla CajaClinicas");

                entity.Property(e => e.Importe_Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(14)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Paga_Comprobante_Nro)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Pagada)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 = no esta pagada, Si es Nro <> 0 es el idCtaCtaIosep de la factura que se paga");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cuentas_Banco>(entity =>
            {
                entity.HasKey(e => e.CuentaBancoID);

                entity.Property(e => e.Cuenta)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Rol)
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.Banco)
                    .WithMany(p => p.Cuentas_Bancos)
                    .HasForeignKey(d => d.BancoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuentas_Bancos_Bancos");
            });

            modelBuilder.Entity<Cuentas_Contable>(entity =>
            {
                entity.HasKey(e => e.CuentaContableId);

                entity.Property(e => e.Cod_Referencia)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.HasOne(d => d.TipoCuentaContable)
                    .WithMany(p => p.Cuentas_Contables)
                    .HasForeignKey(d => d.TipoCuentaContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuentas_Contables_Tipo_CuentaContable");
            });

            modelBuilder.Entity<Cuentas_Contables_Tradicional>(entity =>
            {
                entity.HasKey(e => e.CuentaContableTradicionalId);

                entity.ToTable("Cuentas_Contables_Tradicional");

                entity.Property(e => e.Cod_Referencia)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.HasOne(d => d.TipoCuentaContable)
                    .WithMany(p => p.Cuentas_Contables_Tradicionals)
                    .HasForeignKey(d => d.TipoCuentaContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cuentas_Contables_Tradicional_Tipo_CuentaContable");
            });

            modelBuilder.Entity<CuotaImporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CuotaImporte");

                entity.Property(e => e.FechaCarga)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdCuota).ValueGeneratedOnAdd();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Ddjj>(entity =>
            {
                entity.HasKey(e => e.IdDdjj);

                entity.ToTable("Ddjj");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodArc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnType("date")
                    .HasComment("Esta fecha indica hasta cuando el afiliado puede operar en el sistema.\r\nSi se encuentra vacio tiene uso de la obra social ilimitado.");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.IdEmpresa).HasDefaultValueSql("((0))");

                entity.Property(e => e.LetArc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.Ddjjs)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .HasConstraintName("FK_Ddjj_EstadoCivil");

                entity.HasOne(d => d.IdNacionalidadNavigation)
                    .WithMany(p => p.Ddjjs)
                    .HasForeignKey(d => d.IdNacionalidad)
                    .HasConstraintName("FK_Ddjj_Paises");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Ddjjs)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ddjj_Sexo2");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Ddjjs)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ddjj_TipoDocumento");

                entity.HasOne(d => d.IdTipoFamiliarNavigation)
                    .WithMany(p => p.Ddjjs)
                    .HasForeignKey(d => d.IdTipoFamiliar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ddjj_TipoFamiliar");
            });

            modelBuilder.Entity<Ddjj_Header>(entity =>
            {
                entity.HasKey(e => e.IdDdjjHeader);

                entity.ToTable("Ddjj_Header");

                entity.Property(e => e.Cobranzas).HasDefaultValueSql("((0))");

                entity.Property(e => e.Expediente).HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCierra).HasColumnType("datetime");

                entity.Property(e => e.FechaConfirma).HasColumnType("datetime");

                entity.Property(e => e.OpeCierra)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpeConfirma)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DelegacionPrestador>(entity =>
            {
                entity.HasKey(e => e.IdDelegacionPrestador);

                entity.ToTable("DelegacionPrestador");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Delegacione>(entity =>
            {
                entity.HasKey(e => e.IdDelegacion);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.ConsultasInf).HasDefaultValueSql("((0))");

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.MonodrogasInf).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.PracticasInf).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DetalleCartaPresentacion>(entity =>
            {
                entity.ToTable("DetalleCartaPresentacion");

                entity.Property(e => e.CoberturaTransporte).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaRenovacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRenueva).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioRenueva)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DetalleConvenio>(entity =>
            {
                entity.HasKey(e => e.IdDetalleConvenio);

                entity.ToTable("DetalleConvenio");

                entity.Property(e => e.Desde).HasColumnType("date");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasColumnType("date");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEncabezadoConvenioNavigation)
                    .WithMany(p => p.DetalleConvenios)
                    .HasForeignKey(d => d.IdEncabezadoConvenio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleConvenio_EncabezadoConvenio");
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.ToTable("DetalleFactura");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DetalleNotaDeCredito>(entity =>
            {
                entity.ToTable("DetalleNotaDeCredito");

                entity.Property(e => e.Cajero)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.ImporteBono).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteBonoInteres).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroBono)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.EncabezadoNotaDeCredito)
                    .WithMany(p => p.DetalleNotaDeCreditos)
                    .HasForeignKey(d => d.EncabezadoNotaDeCreditoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleNotaDeCredito_EncabezadoNotaDeCredito");

                entity.HasOne(d => d.TipoNotaCredito)
                    .WithMany(p => p.DetalleNotaDeCreditos)
                    .HasForeignKey(d => d.TipoNotaCreditoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleNotaDeCredito_TipoNotaCredito");
            });

            modelBuilder.Entity<DetallePreBono>(entity =>
            {
                entity.ToTable("DetallePreBono");

                entity.Property(e => e.Coseguro_Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro_Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Factura_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Factura_Honorarios).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaPrestacion).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Motivo_Rechazo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reconoce_Honorarios).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.EncabezadoPreBono)
                    .WithMany(p => p.DetallePreBonos)
                    .HasForeignKey(d => d.EncabezadoPreBonoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetallePreBono_EncabezadoPreBono");

                entity.HasOne(d => d.IdNomencladorNavigation)
                    .WithMany(p => p.DetallePreBonos)
                    .HasForeignKey(d => d.IdNomenclador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetallePreBono_NPracticas_Base");
            });

            modelBuilder.Entity<Detalle_AsientoModelo>(entity =>
            {
                entity.HasKey(e => e.DetalleModeloId);

                entity.ToTable("Detalle_AsientoModelo");

                entity.Property(e => e.Debe_Haber)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.CuentaContableTradicional)
                    .WithMany(p => p.Detalle_AsientoModelos)
                    .HasForeignKey(d => d.CuentaContableTradicionalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_AsientoModelo_Cuentas_Contables_Tradicional");

                entity.HasOne(d => d.EncabezadoModelo)
                    .WithMany(p => p.Detalle_AsientoModelos)
                    .HasForeignKey(d => d.EncabezadoModeloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_AsientoModelo_Encabezado_AsientoModelo");
            });

            modelBuilder.Entity<Detalle_Autorizacione>(entity =>
            {
                entity.HasKey(e => e.DetalleID);

                entity.HasIndex(e => new { e.EstadoAutorizacion, e.Anulada, e.IdNomenclador }, "Index1");

                entity.HasIndex(e => new { e.Anulada, e.EstadoAutorizacion }, "Index_DetAut_AnuladaEstadoCant");

                entity.HasIndex(e => e.AutorizacionesId, "Index_Detalle_Historial");

                entity.Property(e => e.Coseguro_Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro_Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasComment("P - ' ' Pendiente De Autorizar/E-Enviada a IOSEP/R-Con Respuesta a Institucion/X-Rechazada/A-Autorizada/H-Pide Historia Clinica/S-Solicita Aclaracion a la Institucion/O-Aclaracion Enviada");

                entity.Property(e => e.Factura_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Factura_Honorarios).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaPrestacion).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Motivo_Rechazo).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reconoce_Honorarios).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Autorizaciones)
                    .WithMany(p => p.Detalle_Autorizaciones)
                    .HasForeignKey(d => d.AutorizacionesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_Autorizaciones_Encabezado_Autorizaciones");
            });

            modelBuilder.Entity<Detalle_AutorizacionesAuditorium>(entity =>
            {
                entity.HasKey(e => e.Detalle_AutorizacionesAuditoriaID);

                entity.Property(e => e.Coseguro_Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro_Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Motivo_Rechazo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NumeroBono)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reconoce_Honorarios).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<Detalle_AutorizacionesModificado>(entity =>
            {
                entity.HasKey(e => e.ModificaId);

                entity.ToTable("Detalle_AutorizacionesModificado");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Detalle_AutorizacionesPrueba>(entity =>
            {
                entity.HasKey(e => e.DetalleID);

                entity.ToTable("Detalle_AutorizacionesPrueba");

                entity.Property(e => e.Coseguro_Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro_Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Motivo_Rechazo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reconoce_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reconoce_Honorarios).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<Detalle_PresupuestoAutorizacione>(entity =>
            {
                entity.HasKey(e => e.Detalle_PresupuestoAutorizacionesID);

                entity.HasIndex(e => e.NumeroBono, "IX_SP_BonosARemiso");

                entity.HasIndex(e => e.Anulada, "Index");

                entity.HasIndex(e => new { e.Encabezado_PresupuestoAutorizacionesId, e.Anulada }, "Index6");

                entity.Property(e => e.BonoAmbulatorio)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.CambioCentro).HasDefaultValueSql("((0))");

                entity.Property(e => e.Coseguro_Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro_Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdCentroAfiliado).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdGrupoPractica).HasDefaultValueSql("((0))");

                entity.Property(e => e.MotivoAnulacion).HasMaxLength(300);

                entity.Property(e => e.NumeroBono)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reconoce_Honorarios).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dia>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DiaCon_Borrar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DiaCon_Borrar");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DiagnosticosConsultasID).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DiaInternado>(entity =>
            {
                entity.HasKey(e => e.IdDiaInternado);

                entity.ToTable("DiaInternado");

                entity.Property(e => e.DiaHora).HasColumnType("datetime");

                entity.Property(e => e.DiaHora_Anterior).HasColumnType("datetime");

                entity.Property(e => e.Tarjeta)
                    .HasMaxLength(300)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Diag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Diag");

                entity.Property(e => e.codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Diagnostico>(entity =>
            {
                entity.HasKey(e => e.IdDiagnostico);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiagnosticoImagen>(entity =>
            {
                entity.ToTable("DiagnosticoImagen");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DiagnosticoRelacionado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DiagnosticoRelacionado");

                entity.Property(e => e.IdDiagnostico)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdDiagnosticoRelacionado).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DiagnosticoRelacionadoDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DiagnosticoRelacionadoDetalle");

                entity.Property(e => e.IdDiagnosticoDetalle).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Diagnosticos_Esquema>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Diagnosticos_Esquema");
            });

            modelBuilder.Entity<Discapacitado>(entity =>
            {
                entity.HasKey(e => e.IdDiscapacitados);

                entity.Property(e => e.Discapacidad_Desde).HasColumnType("date");

                entity.Property(e => e.Discapacidad_Hasta).HasColumnType("date");

                entity.Property(e => e.Expediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(120)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.IdAfiliadoNavigation)
                    .WithMany(p => p.Discapacitados)
                    .HasForeignKey(d => d.IdAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discapacitados_Afiliados");
            });

            modelBuilder.Entity<Domicilio>(entity =>
            {
                entity.HasKey(e => e.IdDomicilio);

                entity.HasIndex(e => e.IdAfiliado, "IndexIdAfiliadoDomicilio");

                entity.HasIndex(e => e.IdAfiliado, "i_dom_idafi1");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom1");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom10");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom11");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom12");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom13");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom14");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom15");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom16");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom17");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom18");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom19");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom2");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom20");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom3");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom4");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom5");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom6");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom7");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom8");

                entity.HasIndex(e => new { e.Anulado, e.IdLocalidad }, "indiceDom9");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Departamento)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio1).HasColumnName("Domicilio");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Km)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Lote)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.MZA)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.NroPuerta).HasMaxLength(10);

                entity.Property(e => e.Piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular).HasMaxLength(50);

                entity.Property(e => e.TelefonoFijo).HasMaxLength(50);

                entity.Property(e => e.TelefonoReferencia).HasMaxLength(50);

                entity.Property(e => e.Torre)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.Domicilios)
                    .HasForeignKey(d => d.IdLocalidad)
                    .HasConstraintName("FK_Domicilios_Localidades");

                entity.HasOne(d => d.IdTipoDomicilioNavigation)
                    .WithMany(p => p.Domicilios)
                    .HasForeignKey(d => d.IdTipoDomicilio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Domicilios_TipoDomicilio");

                entity.HasOne(d => d.IdZonaNavigation)
                    .WithMany(p => p.Domicilios)
                    .HasForeignKey(d => d.IdZona)
                    .HasConstraintName("FK_Domicilios_Zonas");
            });

            modelBuilder.Entity<DomiciliosDDJJ>(entity =>
            {
                entity.HasKey(e => e.Iddomicilio)
                    .HasName("PK_Ddjj_Domicilios");

                entity.ToTable("DomiciliosDDJJ");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Departamento)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Km)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Lote)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.MZA)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.NroPuerta).HasMaxLength(10);

                entity.Property(e => e.Piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular).HasMaxLength(50);

                entity.Property(e => e.TelefonoFijo).HasMaxLength(50);

                entity.Property(e => e.Torre)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDdjjNavigation)
                    .WithMany(p => p.DomiciliosDDJJs)
                    .HasForeignKey(d => d.IdDdjj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomiciliosDDJJ_AfiliadosDDJJ");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.DomiciliosDDJJs)
                    .HasForeignKey(d => d.IdLocalidad)
                    .HasConstraintName("FK_Ddjj_Domicilios_Localidades");

                entity.HasOne(d => d.IdTipoDomicilioNavigation)
                    .WithMany(p => p.DomiciliosDDJJs)
                    .HasForeignKey(d => d.IdTipoDomicilio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ddjj_Domicilios_TipoDomicilio");

                entity.HasOne(d => d.IdZonaNavigation)
                    .WithMany(p => p.DomiciliosDDJJs)
                    .HasForeignKey(d => d.IdZona)
                    .HasConstraintName("FK_Ddjj_Domicilios_Zonas");
            });

            modelBuilder.Entity<DomiciliosHabiltado>(entity =>
            {
                entity.HasKey(e => e.DomiciliosHabiltadosID);

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroHabilitacionMinisterial)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioBaja)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Edades_Vacuna>(entity =>
            {
                entity.HasKey(e => e.IdEdades);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EmpresaSeguro>(entity =>
            {
                entity.ToTable("EmpresaSeguro");

                entity.Property(e => e.LocalidadID).HasDefaultValueSql("((97231))");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpresasAfiliadosDDJJ>(entity =>
            {
                entity.HasKey(e => e.IdEmpresasAfiliadosDDJJ);

                entity.ToTable("EmpresasAfiliadosDDJJ");

                entity.Property(e => e.ContratoLocacion).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CuotaAfiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDDJJNavigation)
                    .WithMany(p => p.EmpresasAfiliadosDDJJs)
                    .HasForeignKey(d => d.IdDDJJ)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpresasAfiliadosDDJJ_AfiliadosDDJJ");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.EmpresasAfiliadosDDJJs)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpresasAfiliadosDDJJ_Empresas_IosepSalud");
            });

            modelBuilder.Entity<Empresas_Afiliado>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.IdAfiliado, "Indice45601");

                entity.HasIndex(e => new { e.Anulado, e.IdEmpresa }, "IxEmpresaAfi");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuotaAfiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaCarga)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdEmpresaAfiliados).ValueGeneratedOnAdd();

                entity.Property(e => e.InhabilitadoMotivo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.SuspendidoMotivo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Empresas_IosepSalud>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("Empresas_IosepSalud");

                entity.Property(e => e.CUIT)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModif)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.codigopostal)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.cuota_afiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.descuento_prontopago).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.fecha_fin)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.fecha_inicio)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.importe_prontopago).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.localidad)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.renovar_el)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EncabezadoConvenio>(entity =>
            {
                entity.HasKey(e => e.IdEncabezadoConvenio);

                entity.ToTable("EncabezadoConvenio");

                entity.Property(e => e.Desde).HasColumnType("date");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasColumnType("date");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EncabezadoNotaDeCredito>(entity =>
            {
                entity.ToTable("EncabezadoNotaDeCredito");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.OperadorAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EncabezadoPreBono>(entity =>
            {
                entity.ToTable("EncabezadoPreBono");

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.Motivo_Rechazo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Internacion)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdInstitucionNavigation)
                    .WithMany(p => p.EncabezadoPreBonos)
                    .HasForeignKey(d => d.IdInstitucion)
                    .HasConstraintName("FK_EncabezadoPreBono_Prestadores");
            });

            modelBuilder.Entity<Encabezado_AsientoModelo>(entity =>
            {
                entity.HasKey(e => e.EncabezadoModeloId);

                entity.ToTable("Encabezado_AsientoModelo");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.HasOne(d => d.CuentaContable)
                    .WithMany(p => p.Encabezado_AsientoModelos)
                    .HasForeignKey(d => d.CuentaContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encabezado_AsientoModelo_Cuentas_Contables");
            });

            modelBuilder.Entity<Encabezado_AutorizacionAuditor>(entity =>
            {
                entity.HasKey(e => e.EncabezadoAutorizacionAudID);

                entity.ToTable("Encabezado_AutorizacionAuditor");

                entity.HasIndex(e => new { e.Auditor, e.FechaAuditoria }, "Index_EncabezadoAuditorFecha");

                entity.HasIndex(e => e.FechaAuditoria, "Index_EncabezadoFechaAuditoria");

                entity.Property(e => e.Auditor)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaAuditoria).HasColumnType("datetime");

                entity.Property(e => e.TipoPractica)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Encabezado_AutorizacionAuditorPresup>(entity =>
            {
                entity.HasKey(e => e.EncabezadoAutorizacionAudPresupID);

                entity.ToTable("Encabezado_AutorizacionAuditorPresup");

                entity.Property(e => e.Auditor)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaAuditoria).HasColumnType("datetime");

                entity.Property(e => e.TipoPractica)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Encabezado_Autorizacione>(entity =>
            {
                entity.HasKey(e => e.AutorizacionesId);

                entity.HasIndex(e => new { e.IdAfiliado, e.Anulada, e.Fecha_Prescripcion }, "Encabe_Index_Historial");

                entity.HasIndex(e => e.Remiso, "IX_SP_BonosARemiso");

                entity.HasIndex(e => new { e.IdInternado, e.EstadoAutorizacion, e.Anulada, e.Fecha_Emision }, "Index");

                entity.HasIndex(e => new { e.IdInternado, e.IdDelegacion, e.EstadoAutorizacion, e.Anulada, e.Fecha_Emision }, "Index1");

                entity.HasIndex(e => new { e.IdDelegacion, e.EstadoAutorizacion, e.Anulada, e.IdInternado, e.Fecha_Emision }, "Index2");

                entity.HasIndex(e => new { e.FueraProvincia, e.Fecha_Emision }, "Index3");

                entity.HasIndex(e => new { e.IdInternado, e.Anulada, e.IdGrupoPractica, e.Fecha_Emision }, "IndexInternadoCentro");

                entity.HasIndex(e => new { e.IdPlan, e.Anulada }, "IndexPlanAnuladaEncAut>");

                entity.HasIndex(e => new { e.Anulada, e.IdGrupoPractica, e.IdCentroImpresion, e.Fecha_Emision }, "Index_EncAut_IdGrupoIdCentroFechaEmision");

                entity.HasIndex(e => new { e.Anulada, e.IdInternado }, "Index_EncabezadoAnuladaIdInternado");

                entity.HasIndex(e => e.Numero, "Index_EncabezadoNumero");

                entity.HasIndex(e => e.Fecha_Emision, "Indice_EncAut");

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasComment("P - ' ' Pendiente De Autorizar/E-Enviada a IOSEP/R-Con Respuesta a Institucion/X-Rechazada/A-Autorizada/H-Pide Historia Clinica/S-Solicita Aclaracion a la Institucion/O-Aclaracion Enviada");

                entity.Property(e => e.FechaImprime).HasColumnType("datetime");

                entity.Property(e => e.FechaRemiso).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.IdCentroAfiliado).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCentroImpresion).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdGrupoPractica).HasDefaultValueSql("((0))");

                entity.Property(e => e.Marca).HasDefaultValueSql("((0))");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.Motivo_Rechazo).IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Internacion)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OperRemiso)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Remiso).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemisoCobrado).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioImprime)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdAfiliadoNavigation)
                    .WithMany(p => p.Encabezado_Autorizaciones)
                    .HasForeignKey(d => d.IdAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encabezado_Autorizaciones_Afiliados");

                entity.HasOne(d => d.IdDelegacionNavigation)
                    .WithMany(p => p.Encabezado_Autorizaciones)
                    .HasForeignKey(d => d.IdDelegacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encabezado_Autorizaciones_Delegaciones");

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.Encabezado_Autorizaciones)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encabezado_Autorizaciones_Diagnosticos");

                entity.HasOne(d => d.IdEfectorNavigation)
                    .WithMany(p => p.Encabezado_AutorizacioneIdEfectorNavigations)
                    .HasForeignKey(d => d.IdEfector)
                    .HasConstraintName("FK_Encabezado_Autorizaciones_Prestadores1");

                entity.HasOne(d => d.IdInternadoNavigation)
                    .WithMany(p => p.Encabezado_Autorizaciones)
                    .HasForeignKey(d => d.IdInternado)
                    .HasConstraintName("FK_Encabezado_Autorizaciones_Internados");

                entity.HasOne(d => d.IdMedico_PrescriptorNavigation)
                    .WithMany(p => p.Encabezado_AutorizacioneIdMedico_PrescriptorNavigations)
                    .HasForeignKey(d => d.IdMedico_Prescriptor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encabezado_Autorizaciones_Prestadores");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.Encabezado_Autorizaciones)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encabezado_Autorizaciones_Planes");
            });

            modelBuilder.Entity<Encabezado_AutorizacionesAuditorium>(entity =>
            {
                entity.HasKey(e => e.Encabezado_AutorizacionesAuditoriaId);

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.Motivo_Rechazo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Internacion)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Encabezado_Factura>(entity =>
            {
                entity.HasKey(e => e.IdEncabezadoFactura);

                entity.Property(e => e.Expediente).HasMaxLength(50);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.MotivoAnula).HasMaxLength(200);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Encabezado_PresupuestoAutorizacione>(entity =>
            {
                entity.HasKey(e => e.Encabezado_PresupuestoAutorizacionesId);

                entity.HasIndex(e => new { e.IdDelegacion, e.EstadoAutorizacion, e.Anulada, e.IosepSalud, e.IdInternado, e.Fecha_Emision }, "Index");

                entity.HasIndex(e => new { e.EstadoAutorizacion, e.Anulada }, "Index1");

                entity.HasIndex(e => new { e.Aprobado, e.Fecha_Emision }, "Index5");

                entity.Property(e => e.Cobrado).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaRechaza).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Aprobacion).HasColumnType("datetime");

                entity.Property(e => e.Fecha_AprobacionParcial).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Internacion)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRechaza)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorAprueba)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Enfermedades_Vacuna>(entity =>
            {
                entity.HasKey(e => e.IdEnfermedades);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EntidadBancarium>(entity =>
            {
                entity.HasKey(e => e.EntidadBancariaID);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModif)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Telefono).HasMaxLength(50);
            });

            modelBuilder.Entity<EquiposPractica>(entity =>
            {
                entity.HasKey(e => e.EquiposPracticasID);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Escuela>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodEscuela)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EscuelaId).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperMod)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular).HasMaxLength(50);

                entity.Property(e => e.TelefonoFijo).HasMaxLength(50);

                entity.HasOne(d => d.NivelEscuela)
                    .WithMany()
                    .HasForeignKey(d => d.NivelEscuelaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Escuelas_NivelEscuela");
            });

            modelBuilder.Entity<EscuelasDBF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EscuelasDBF");

                entity.Property(e => e.CATEGORIA).HasMaxLength(1);

                entity.Property(e => e.CODESC).HasMaxLength(5);

                entity.Property(e => e.COD_POSTAL).HasMaxLength(4);

                entity.Property(e => e.CUENTA).HasMaxLength(10);

                entity.Property(e => e.DIRECCION).HasMaxLength(30);

                entity.Property(e => e.DIRECTOR).HasMaxLength(30);

                entity.Property(e => e.ESTABLE).HasMaxLength(1);

                entity.Property(e => e.FECCARGA).HasColumnType("datetime");

                entity.Property(e => e.FECING).HasColumnType("datetime");

                entity.Property(e => e.FUNCIONA).HasMaxLength(30);

                entity.Property(e => e.GRUPO).HasMaxLength(2);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NOMBRE).HasMaxLength(30);

                entity.Property(e => e.TELEFONO).HasMaxLength(25);

                entity.Property(e => e.TIPDEP).HasMaxLength(1);

                entity.Property(e => e.VIGENCIA).HasMaxLength(1);
            });

            modelBuilder.Entity<EscuelasSPEP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EscuelasSPEP");

                entity.Property(e => e.CODDEP).HasMaxLength(12);

                entity.Property(e => e.DESCRIPCIO).HasMaxLength(55);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LOCAL).HasMaxLength(40);

                entity.Property(e => e.NIVEL).HasMaxLength(1);
            });

            modelBuilder.Entity<EspecialidadDDJJ>(entity =>
            {
                entity.ToTable("EspecialidadDDJJ");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidad);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<EsquemaDiasCobertura>(entity =>
            {
                entity.ToTable("EsquemaDiasCobertura");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.MotivoModCobID).HasDefaultValueSql("((0))");

                entity.Property(e => e.NroExpediente).HasMaxLength(50);

                entity.Property(e => e.NroResolucion).HasMaxLength(50);

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Esquemas_Afiliado>(entity =>
            {
                entity.HasKey(e => e.IdEsquema)
                    .HasName("PK_Esquemas");

                entity.ToTable("Esquemas_Afiliado");

                entity.HasIndex(e => new { e.IdAfiliado, e.Anulado }, "index1");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Inicio).HasColumnType("date");

                entity.Property(e => e.Modifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModificaFecha).HasColumnType("datetime");

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento).HasColumnType("date");
            });

            modelBuilder.Entity<Est_Iosep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Est_Iosep");

                entity.Property(e => e.AF_TRANS).HasMaxLength(2);

                entity.Property(e => e.ANO_APORTE).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ANO_LECT).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.APORTES).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.A_NUMERO).HasMaxLength(15);

                entity.Property(e => e.CANADI).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CANGRU).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CATEGORIA).HasMaxLength(2);

                entity.Property(e => e.COBRADOR).HasMaxLength(5);

                entity.Property(e => e.CODARC).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CRED_ESPE).HasMaxLength(2);

                entity.Property(e => e.CRED_NORM).HasMaxLength(2);

                entity.Property(e => e.CTA_APO).HasMaxLength(5);

                entity.Property(e => e.CUIL).HasMaxLength(13);

                entity.Property(e => e.CUIT).HasMaxLength(11);

                entity.Property(e => e.C_FECHA).HasColumnType("datetime");

                entity.Property(e => e.DELEGACION).HasMaxLength(4);

                entity.Property(e => e.DIS_FDES).HasColumnType("datetime");

                entity.Property(e => e.DIS_FHAS).HasColumnType("datetime");

                entity.Property(e => e.DOMICILIO).HasMaxLength(45);

                entity.Property(e => e.DTO).HasMaxLength(2);

                entity.Property(e => e.D_NRO).HasMaxLength(8);

                entity.Property(e => e.D_TIPO).HasMaxLength(2);

                entity.Property(e => e.EDAD).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EMPRESA).HasMaxLength(5);

                entity.Property(e => e.EMP_APORTE).HasMaxLength(5);

                entity.Property(e => e.ESTADO).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ESTAFICHA).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EST_FDES).HasColumnType("datetime");

                entity.Property(e => e.EST_FHAS).HasColumnType("datetime");

                entity.Property(e => e.E_CIVIL).HasMaxLength(2);

                entity.Property(e => e.E_FECHA).HasColumnType("datetime");

                entity.Property(e => e.FAMILIAR).HasMaxLength(2);

                entity.Property(e => e.FECHA).HasColumnType("datetime");

                entity.Property(e => e.FECVTOCAR).HasColumnType("datetime");

                entity.Property(e => e.F_ACTIVA).HasColumnType("datetime");

                entity.Property(e => e.F_CRED_E).HasColumnType("datetime");

                entity.Property(e => e.F_CRED_N).HasColumnType("datetime");

                entity.Property(e => e.F_PARTO_D).HasColumnType("datetime");

                entity.Property(e => e.F_PARTO_H).HasColumnType("datetime");

                entity.Property(e => e.F_TRAN_E).HasColumnType("datetime");

                entity.Property(e => e.F_TRAN_F).HasColumnType("datetime");

                entity.Property(e => e.F_ULT_CENS).HasColumnType("datetime");

                entity.Property(e => e.F_VENC_E).HasColumnType("datetime");

                entity.Property(e => e.F_VENC_N).HasColumnType("datetime");

                entity.Property(e => e.HORA).HasMaxLength(5);

                entity.Property(e => e.IMP_APORTE).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.I_FECHA).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.JUB_BENEF).HasMaxLength(13);

                entity.Property(e => e.LETARC).HasMaxLength(1);

                entity.Property(e => e.LOCALIDAD).HasMaxLength(8);

                entity.Property(e => e.MAT_FDES).HasColumnType("datetime");

                entity.Property(e => e.MAT_FHAS).HasColumnType("datetime");

                entity.Property(e => e.MED_CAB).HasMaxLength(10);

                entity.Property(e => e.MES_APORTE).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MOTIVO1).HasMaxLength(2);

                entity.Property(e => e.NACIONALID).HasMaxLength(3);

                entity.Property(e => e.NOMBRE).HasMaxLength(45);

                entity.Property(e => e.NRO_TARJ).HasMaxLength(20);

                entity.Property(e => e.N_FECHA).HasColumnType("datetime");

                entity.Property(e => e.OBS).HasMaxLength(80);

                entity.Property(e => e.OBS2).HasMaxLength(20);

                entity.Property(e => e.OPERADOR).HasMaxLength(8);

                entity.Property(e => e.O_SOCIAL).HasMaxLength(6);

                entity.Property(e => e.PISO).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PLAN_ESP).HasMaxLength(5);

                entity.Property(e => e.PLN_FECHA).HasColumnType("datetime");

                entity.Property(e => e.PROMOTOR).HasMaxLength(5);

                entity.Property(e => e.PROVINCIA).HasMaxLength(2);

                entity.Property(e => e.PRO_APORTE).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PUERTA).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Plan).HasMaxLength(5);

                entity.Property(e => e.SEXO).HasMaxLength(1);

                entity.Property(e => e.SIT_LABORA).HasMaxLength(2);

                entity.Property(e => e.TARJETA).HasMaxLength(5);

                entity.Property(e => e.TELEFONO).HasMaxLength(20);

                entity.Property(e => e.TIPOAFIL).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TIPO_DISC).HasMaxLength(2);

                entity.Property(e => e.TIPO_DOM).HasMaxLength(5);

                entity.Property(e => e.TIPO_EMI).HasMaxLength(1);

                entity.Property(e => e.T_IVA).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VEN_FECHA).HasColumnType("datetime");

                entity.Property(e => e.V_FECHA).HasColumnType("datetime");

                entity.Property(e => e.ZONA).HasMaxLength(2);
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCivil);

                entity.ToTable("EstadoCivil");

                entity.Property(e => e.IdEstadoCivil).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EstadoConsultaWebService>(entity =>
            {
                entity.HasKey(e => e.IdEstadoConsulta);

                entity.ToTable("EstadoConsultaWebService");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Estado_NotaDePedido>(entity =>
            {
                entity.HasKey(e => e.EstadoNotaDePedidoId);

                entity.ToTable("Estado_NotaDePedido");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estados_Cuenta>(entity =>
            {
                entity.HasKey(e => e.EstadoCuentaID);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpeCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.SaldoActual).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Estados_Internacion>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("Estados_Internacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ExpedienteGlosado>(entity =>
            {
                entity.ToTable("ExpedienteGlosado");

                entity.Property(e => e.FechaExpediente).HasMaxLength(10);
            });

            modelBuilder.Entity<ExpedientesDigitalizado>(entity =>
            {
                entity.HasKey(e => e.ExpedienteDigitalizadoId);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaExpediente).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.Property(e => e.CAE).HasMaxLength(50);

                entity.Property(e => e.CAI).HasMaxLength(50);

                entity.Property(e => e.CUIT)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Codigo).HasMaxLength(50);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MotivoAnula).HasMaxLength(200);

                entity.Property(e => e.Numero).HasMaxLength(50);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Proveedor).HasMaxLength(250);

                entity.HasOne(d => d.IdEncabezadoFacturaNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdEncabezadoFactura)
                    .HasConstraintName("FK_Facturas_Encabezado_Facturas");

                entity.HasOne(d => d.TipoComprobante)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.TipoComprobanteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facturas_Tipo_Comprobante");
            });

            modelBuilder.Entity<Fallecido>(entity =>
            {
                entity.HasKey(e => e.IdFallecido);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaConfirma).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaDefuncion).HasColumnType("datetime");

                entity.Property(e => e.MotivoAnula).HasMaxLength(200);

                entity.Property(e => e.NumeroActa).HasMaxLength(20);

                entity.Property(e => e.Observacion).HasMaxLength(500);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UserConfirma)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FarmaciaArchivo>(entity =>
            {
                entity.HasKey(e => e.IdFarmaciaArchivos)
                    .HasName("PK_ArchivosFarmacia");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivo).HasMaxLength(75);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FarmaciaArchivosCierre>(entity =>
            {
                entity.HasKey(e => e.IdFarmaciaArchivosCierre);

                entity.ToTable("FarmaciaArchivosCierre");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.IdCaratula).HasMaxLength(20);

                entity.Property(e => e.ImporteCargoAfiliado).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ImporteCargoObraSocial).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ImporteRecetas).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NombreConvenio).HasMaxLength(50);

                entity.Property(e => e.NombreFarmacia).HasMaxLength(50);

                entity.Property(e => e.NombrePlan).HasMaxLength(50);

                entity.Property(e => e.NumeroAutorizacion).HasMaxLength(20);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FarmaciaArchivosReceta>(entity =>
            {
                entity.HasKey(e => e.IdFarmaciaArchivosReceta)
                    .HasName("PK_ArchivosFarmaciaDetalle");

                entity.Property(e => e.CodigoAlfabeta).HasMaxLength(10);

                entity.Property(e => e.CogidoBarra).HasMaxLength(13);

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaPrescripcion).HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");

                entity.Property(e => e.FechaVenta).HasColumnType("datetime");

                entity.Property(e => e.ImporteAfiliado).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ImporteAfiliadoRenglon).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ImporteObraSocial).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ImporteObraSocialRenglon).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ImporteReceta).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ImporteRenglon).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NombreFarmacia).HasMaxLength(50);

                entity.Property(e => e.NombrePlan).HasMaxLength(50);

                entity.Property(e => e.NroAfiliado).HasMaxLength(20);

                entity.Property(e => e.NroAutorizacion).HasMaxLength(20);

                entity.Property(e => e.NroReceta).HasMaxLength(20);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PrecioReferenciaObraSocial).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecioVentaPublico).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TipoMatricula).HasMaxLength(1);

                entity.Property(e => e.Troquel).HasMaxLength(10);
            });

            modelBuilder.Entity<FecliseNV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FecliseNV");

                entity.Property(e => e.codigo).HasMaxLength(6);

                entity.Property(e => e.cos_amb)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.cos_int)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.gastos).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.honorarios)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.id_practica).HasDefaultValueSql("((0))");

                entity.Property(e => e.nombre).HasMaxLength(255);
            });

            modelBuilder.Entity<FormaPagoPractica>(entity =>
            {
                entity.HasKey(e => e.FormaPagoPracticasID);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.ImporteCuotas).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCredito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCreditoSinInt)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ValorCuotaSinInt).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Gastos_Compromiso>(entity =>
            {
                entity.HasKey(e => e.Gastos_CompromisosID);

                entity.HasIndex(e => e.Anulado, "CompromisosSinOP");

                entity.Property(e => e.Beneficiario).HasMaxLength(500);

                entity.Property(e => e.CuilBeneficiario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaCompromiso).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Importe_Comprometido).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Observaciones).HasMaxLength(250);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Gastos_Preventivos)
                    .WithMany(p => p.Gastos_Compromisos)
                    .HasForeignKey(d => d.Gastos_PreventivosID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gastos_Compromisos_Gastos_Preventivos");
            });

            modelBuilder.Entity<Gastos_Preventivo>(entity =>
            {
                entity.HasKey(e => e.Gastos_PreventivosID);

                entity.Property(e => e.AfectacionPreventiva).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Concepto).HasMaxLength(200);

                entity.Property(e => e.FechaAfectacion).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.ImporteComprometido).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Observaciones).HasMaxLength(250);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ContableGastos)
                    .WithMany(p => p.Gastos_Preventivos)
                    .HasForeignKey(d => d.ContableGastosID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gastos_Preventivos_Contable_Gastos");
            });

            modelBuilder.Entity<Generado_Lugar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Generado_Lugar");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.idGenerado).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Gerenciador>(entity =>
            {
                entity.ToTable("Gerenciador");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gremio>(entity =>
            {
                entity.HasKey(e => e.IdGremio);

                entity.Property(e => e.Nombre).HasMaxLength(250);
            });

            modelBuilder.Entity<GremioLiquidacion>(entity =>
            {
                entity.HasKey(e => e.IdGremioLiquidacion);

                entity.ToTable("GremioLiquidacion");

                entity.Property(e => e.EstadoInternacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.ImporteAuditadoGremio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteSolicitadoOS).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<GrupoDetallePractica>(entity =>
            {
                entity.HasKey(e => e.IdGrupoDetallePracticas);

                entity.HasIndex(e => new { e.IdPractica, e.Anulado }, "Index_GDP_IdPracticaAnulado");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdGrupoPracticasNavigation)
                    .WithMany(p => p.GrupoDetallePracticas)
                    .HasForeignKey(d => d.IdGrupoPracticas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoDetallePracticas_GrupoPracticas");

                entity.HasOne(d => d.IdPracticaNavigation)
                    .WithMany(p => p.GrupoDetallePracticas)
                    .HasForeignKey(d => d.IdPractica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoDetallePracticas_NPracticas_Base");
            });

            modelBuilder.Entity<GrupoDetallePrestadore>(entity =>
            {
                entity.HasKey(e => e.IdGrupoDetallePrestador);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdGrupoPrestadorNavigation)
                    .WithMany(p => p.GrupoDetallePrestadores)
                    .HasForeignKey(d => d.IdGrupoPrestador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoDetallePrestadores_GrupoPrestadores");
            });

            modelBuilder.Entity<GrupoDetalleSanatorio>(entity =>
            {
                entity.HasKey(e => e.IdGrupoDetalleSanatorios);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdGrupoSanatoriosNavigation)
                    .WithMany(p => p.GrupoDetalleSanatorios)
                    .HasForeignKey(d => d.IdGrupoSanatorios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoDetalleSanatorios_GrupoSanatorios");
            });

            modelBuilder.Entity<GrupoPractica>(entity =>
            {
                entity.HasKey(e => e.IdGrupoPracticas);

                entity.Property(e => e.ControlCupo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NombreGrupo).HasMaxLength(150);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.SectorId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GrupoPracticasConfiguracion>(entity =>
            {
                entity.HasKey(e => e.IdGrupoPracticasConfiguracion);

                entity.ToTable("GrupoPracticasConfiguracion");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GrupoPrestadore>(entity =>
            {
                entity.HasKey(e => e.IdGrupoPrestador);

                entity.Property(e => e.Centro).HasMaxLength(75);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdGrupoPracticasNavigation)
                    .WithMany(p => p.GrupoPrestadores)
                    .HasForeignKey(d => d.IdGrupoPracticas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrupoPrestadores_GrupoPracticas");
            });

            modelBuilder.Entity<GrupoSanatorio>(entity =>
            {
                entity.HasKey(e => e.IdGrupoSanatorios);

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NombreGrupo).HasMaxLength(150);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Grupos_Vacuna>(entity =>
            {
                entity.HasKey(e => e.IdGrupos);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Plan)
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HCDigitalizadum>(entity =>
            {
                entity.HasKey(e => e.HCDigitalizadaID);

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaUltMod).HasColumnType("datetime");

                entity.Property(e => e.NumeroHC)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioUltMod)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.fechaPrimerConsulta).HasColumnType("date");

                entity.HasOne(d => d.IdAfiliadoNavigation)
                    .WithMany(p => p.HCDigitalizada)
                    .HasForeignKey(d => d.IdAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HCDigitalizada_Afiliados");

                entity.HasOne(d => d.MedicoCabecera)
                    .WithMany(p => p.HCDigitalizada)
                    .HasForeignKey(d => d.MedicoCabeceraID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HCDigitalizada_Prestadores");
            });

            modelBuilder.Entity<HistoriaClinica>(entity =>
            {
                entity.HasKey(e => e.IdHistoria);

                entity.ToTable("HistoriaClinica");

                entity.Property(e => e.Antecedentes)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AnulaFecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AnulaOperador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Estudios)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExamenFisico)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modificaria)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Motivo)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<HistorialAuditorium>(entity =>
            {
                entity.HasKey(e => e.HistorialAuditoriaID);

                entity.Property(e => e.FechaAperturaAuditoria).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAperturaAuditoria)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HistorialEmpresas_IosepSalud>(entity =>
            {
                entity.HasKey(e => e.HistorialEmpresaID)
                    .HasName("PK_HistorialEmpresaID");

                entity.ToTable("HistorialEmpresas_IosepSalud");

                entity.Property(e => e.CUIT)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModif)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.codigopostal)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.cuota_afiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.descuento_prontopago).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.fecha_fin).HasColumnType("date");

                entity.Property(e => e.fecha_inicio).HasColumnType("date");

                entity.Property(e => e.importe_prontopago).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.localidad)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.renovar_el).HasColumnType("date");
            });

            modelBuilder.Entity<HistorialMontoCarnet>(entity =>
            {
                entity.ToTable("HistorialMontoCarnet");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.VigenciaDesde).HasColumnType("date");

                entity.Property(e => e.VigenciaHasta).HasColumnType("date");
            });

            modelBuilder.Entity<HistorialMontoCredito>(entity =>
            {
                entity.HasKey(e => e.HistorialMontoCredito1);

                entity.ToTable("HistorialMontoCredito");

                entity.Property(e => e.HistorialMontoCredito1).HasColumnName("HistorialMontoCredito");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.MontoNuevo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MontoOriginal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HistoricoCronogramaAfiliadoProf>(entity =>
            {
                entity.ToTable("HistoricoCronogramaAfiliadoProf");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Desde)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.Hasta)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HistoricoMovimientosPartida>(entity =>
            {
                entity.HasKey(e => e.HistoricoMovimientosId);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Tipo_MovimientoContable)
                    .WithMany(p => p.HistoricoMovimientosPartida)
                    .HasForeignKey(d => d.Tipo_MovimientoContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoMovimientosPartidas_Tipo_MovimientoContable");
            });

            modelBuilder.Entity<Historico_EstadosCuenta>(entity =>
            {
                entity.HasKey(e => e.HistoricoEstadosCuentasID);

                entity.Property(e => e.FechaSaldoActual).HasColumnType("date");

                entity.Property(e => e.FechaSaldoAnterior).HasColumnType("date");

                entity.Property(e => e.FechaSaldoInicial).HasColumnType("date");

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.SaldoActual).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaldoAnterior).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<I_AutoriDbf>(entity =>
            {
                entity.HasKey(e => e.IdI_AutoriDbf);

                entity.ToTable("I_AutoriDbf");

                entity.Property(e => e.AFICAR).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.A_NUMERO)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.COSEG_G).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.COSEG_H).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.DIAGNOSTIC)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.E_CAUSA)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.E_FECHA).HasColumnType("date");

                entity.Property(e => e.FAMILIAR)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.FECHA).HasColumnType("date");

                entity.Property(e => e.GASTOS).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.HONORARIO).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.HORA_CARGA)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.I_CAUSA)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.NOMENCLADO)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.NRO_AUT)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.NUMERO)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OBS)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.OPERADOR)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.O_SOCIAL)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.PRESCRIBE)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.P_CODIGO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.SUC_AUT)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.TIP_AUT)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TOTAL).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.T_PRESTAC)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ImpactarTucNorte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ImpactarTucNorte");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.Gastos).HasMaxLength(255);

                entity.Property(e => e.Honorario).HasMaxLength(255);

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.NuevoGastos).HasMaxLength(255);

                entity.Property(e => e.NuevoHon).HasMaxLength(255);

                entity.Property(e => e._Sin_nombre_de_columna_)
                    .HasColumnType("datetime")
                    .HasColumnName("(Sin nombre de columna)");
            });

            modelBuilder.Entity<ImpactarTucParque>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ImpactarTucParque");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.Gastos).HasMaxLength(255);

                entity.Property(e => e.Honorario).HasMaxLength(255);

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.NuevoGastos).HasMaxLength(255);

                entity.Property(e => e.NuevoHon).HasMaxLength(255);

                entity.Property(e => e._Sin_nombre_de_columna_)
                    .HasColumnType("datetime")
                    .HasColumnName("(Sin nombre de columna)");
            });

            modelBuilder.Entity<Imprimir>(entity =>
            {
                entity.HasKey(e => e.IdImprimir);

                entity.ToTable("Imprimir", "usuario");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Impreso).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario).HasMaxLength(256);
            });

            modelBuilder.Entity<ImputacionesPagoFactura>(entity =>
            {
                entity.HasKey(e => e.IdImputacionPago);

                entity.Property(e => e.ComprobantePago).HasMaxLength(14);

                entity.Property(e => e.FacturaAnterior).HasMaxLength(14);

                entity.Property(e => e.FacturaNueva).HasMaxLength(14);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImportePagado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InformeImpresion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InformeImpresion");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FraseAnual)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.IdInformeImpresion).ValueGeneratedOnAdd();

                entity.Property(e => e.Provincia)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Web)
                    .HasMaxLength(60)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ingreso>(entity =>
            {
                entity.HasKey(e => e.IdIngresos);

                entity.Property(e => e.Beneficiario)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero_Expediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.HasOne(d => d.TipoIngreso)
                    .WithMany(p => p.Ingresos)
                    .HasForeignKey(d => d.TipoIngresoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ingresos_Tipo_Ingresos");
            });

            modelBuilder.Entity<IngresosMunicipio>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.APORTES).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CONTRIB).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.COSEGURO).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CUIL).HasMaxLength(11);

                entity.Property(e => e.IdIngresosMunicipios).ValueGeneratedOnAdd();

                entity.Property(e => e.MUNICOMI).HasMaxLength(11);

                entity.Property(e => e.NOMBRE)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PERIODO).HasMaxLength(6);

                entity.Property(e => e.PRESENTA).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SUJETO).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<IngresosMunicipiosTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IngresosMunicipiosTest");

                entity.Property(e => e.APORTES).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CONTRIB).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.COSEGURO).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CUIL).HasMaxLength(11);

                entity.Property(e => e.IdIngresosMunicipios).ValueGeneratedOnAdd();

                entity.Property(e => e.MUNICOMI).HasMaxLength(11);

                entity.Property(e => e.NOMBRE)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PERIODO).HasMaxLength(6);

                entity.Property(e => e.PRESENTA).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SUJETO).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Inmuniza_Vacuna>(entity =>
            {
                entity.HasKey(e => e.IdInmuniza);
            });

            modelBuilder.Entity<Instructivo>(entity =>
            {
                entity.ToTable("Instructivo");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Duracion)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.ImagenPreliminar)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InteresPorCredito>(entity =>
            {
                entity.ToTable("InteresPorCredito");

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Internado>(entity =>
            {
                entity.HasKey(e => e.IdInternado);

                entity.HasIndex(e => new { e.IdClinica, e.Anulada, e.Fecha_Internacion }, "Index");

                entity.HasIndex(e => new { e.Anulada, e.Fecha_Internacion }, "ListaInternados");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaConsulta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.IdEstadoConsultaWS).HasDefaultValueSql("((0))");

                entity.Property(e => e.MotivoAnula).HasMaxLength(1000);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UserCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.Internados)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Internados_Diagnosticos");
            });

            modelBuilder.Entity<InternadoGremio>(entity =>
            {
                entity.HasKey(e => e.IdInternadoGremio);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaBajaGremio).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaInternado).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InternadosAfeccion>(entity =>
            {
                entity.HasKey(e => e.IdInternadoAfeccion);

                entity.ToTable("InternadosAfeccion");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdAfeccionNavigation)
                    .WithMany(p => p.InternadosAfeccions)
                    .HasForeignKey(d => d.IdAfeccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternadosAfeccion_Afeccion");
            });

            modelBuilder.Entity<InternadosAutoriza>(entity =>
            {
                entity.ToTable("InternadosAutoriza");

                entity.Property(e => e.AccidenteTansito).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.UserCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InternadosControl>(entity =>
            {
                entity.HasKey(e => e.IdInternadoControl);

                entity.ToTable("InternadosControl");

                entity.HasIndex(e => new { e.IdInternado, e.Anulado }, "IndexInternadoControl");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UserCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdInternadoNavigation)
                    .WithMany(p => p.InternadosControls)
                    .HasForeignKey(d => d.IdInternado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternadosControl_Internados");
            });

            modelBuilder.Entity<InternadosDetalleMedicamento>(entity =>
            {
                entity.HasKey(e => e.IdDetalleMedicamentos);

                entity.Property(e => e.Dosis).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Factura)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(200);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdInternadoMedicamentoNavigation)
                    .WithMany(p => p.InternadosDetalleMedicamentos)
                    .HasForeignKey(d => d.IdInternadoMedicamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternadosDetalleMedicamentos_InternadosMedicamentos");
            });

            modelBuilder.Entity<InternadosEstudio>(entity =>
            {
                entity.HasKey(e => e.IdHistoria)
                    .HasName("PK_InternadosHistoriaClinica");

                entity.Property(e => e.Antecedentes).HasColumnType("ntext");

                entity.Property(e => e.Diagnostico).HasColumnType("ntext");

                entity.Property(e => e.Estudios).HasColumnType("ntext");

                entity.Property(e => e.ExamenFisico).HasColumnType("ntext");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Latitud)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Longitud)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Modificaria).HasColumnType("ntext");

                entity.Property(e => e.Motivo).HasColumnType("ntext");

                entity.HasOne(d => d.IdInternadoNavigation)
                    .WithMany(p => p.InternadosEstudios)
                    .HasForeignKey(d => d.IdInternado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternadosHistoriaClinica_Internados");
            });

            modelBuilder.Entity<InternadosEvolucion>(entity =>
            {
                entity.HasKey(e => e.IdEvolucion);

                entity.ToTable("InternadosEvolucion");

                entity.Property(e => e.Crea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.IP).HasMaxLength(15);

                entity.Property(e => e.Latitud).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Longitud).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdInternadoNavigation)
                    .WithMany(p => p.InternadosEvolucions)
                    .HasForeignKey(d => d.IdInternado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternadosEvolucion_Internados");
            });

            modelBuilder.Entity<InternadosLog>(entity =>
            {
                entity.HasKey(e => e.IdInternadoLog);

                entity.ToTable("InternadosLog");

                entity.Property(e => e.FechaControl).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");
            });

            modelBuilder.Entity<InternadosMedicamento>(entity =>
            {
                entity.HasKey(e => e.IdInternadoMedicamento);

                entity.Property(e => e.FechaAdministrado).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdInternadoNavigation)
                    .WithMany(p => p.InternadosMedicamentos)
                    .HasForeignKey(d => d.IdInternado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternadosMedicamentos_Internados");
            });

            modelBuilder.Entity<InternadosQuirofano>(entity =>
            {
                entity.HasKey(e => e.QuirofanoID);

                entity.ToTable("InternadosQuirofano");

                entity.Property(e => e.FecCrea).HasColumnType("datetime");

                entity.Property(e => e.FecModi).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observacion).HasMaxLength(200);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdInternadoNavigation)
                    .WithMany(p => p.InternadosQuirofanos)
                    .HasForeignKey(d => d.IdInternado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternadosQuirofano_Internados");
            });

            modelBuilder.Entity<InternadosQuirofanoDetalle>(entity =>
            {
                entity.HasKey(e => e.QuirofanoDetalleID);

                entity.ToTable("InternadosQuirofanoDetalle");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Especialista)
                    .WithMany(p => p.InternadosQuirofanoDetalles)
                    .HasForeignKey(d => d.EspecialistaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternadosQuirofanoDetalle_TipoEspecialistas");

                entity.HasOne(d => d.Quirofano)
                    .WithMany(p => p.InternadosQuirofanoDetalles)
                    .HasForeignKey(d => d.QuirofanoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternadosQuirofanoDetalle_InternadosQuirofano");
            });

            modelBuilder.Entity<InternadosSector>(entity =>
            {
                entity.HasKey(e => e.SectorID);

                entity.ToTable("InternadosSector");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IosepSaludBanco>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IosepSaludBanco");

                entity.HasIndex(e => e.NombreArchivo, "Index");

                entity.Property(e => e.FechaCargado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdIosepSaludBanco).ValueGeneratedOnAdd();

                entity.Property(e => e.Linea_Control)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.NombreArchivo)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.TotalMontoIncorrecto)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRegistrosArchivo).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRegistrosIncorrectos).HasDefaultValueSql("((0))");

                entity.Property(e => e.Total_cobrado).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<IosepSaludBancoDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IosepSaludBancoDetalle");

                entity.Property(e => e.IdIosepSaludBancoDetalle).ValueGeneratedOnAdd();

                entity.Property(e => e.MotivoErrorID).HasDefaultValueSql("((0))");

                entity.Property(e => e.codbarra)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.comprobante)
                    .HasMaxLength(14)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.fecha_cobro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.fecha_proceso)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.grupoterminal)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.hora)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.moneda)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.nrorendicion)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.succod)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.sucursal)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.tipo_mov)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.usuario)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IosepSaludHistorialCuota>(entity =>
            {
                entity.HasKey(e => e.IdIosepSaludHistorialCuotas);

                entity.Property(e => e.Adicional7).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cargada)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Esposa1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Esposa2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Esposa3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Esposa4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Esposa5).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaHastaAnterior).HasColumnType("date");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.Hijo1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hijo2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hijo3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hijo4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hijo5).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteConvenio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModif)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorCarga)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Titular1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Titular2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Titular3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Titular4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Titular5).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Titular6).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Titular7).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VigenciaDesde)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VigenciaHasta)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<IosepSaludHistorialCuotasEmp>(entity =>
            {
                entity.ToTable("IosepSaludHistorialCuotasEmp");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModif)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.VigenciaDesde).HasColumnType("date");

                entity.Property(e => e.VigenciaHasta).HasColumnType("date");
            });

            modelBuilder.Entity<Jubilado>(entity =>
            {
                entity.HasKey(e => e.IdJubilado);

                entity.Property(e => e.NroJubilatorio)
                    .HasMaxLength(13)
                    .IsFixedLength();
            });

            modelBuilder.Entity<JubiladosComputo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JubiladosComputo");

                entity.Property(e => e.Afiliado).HasMaxLength(255);

                entity.Property(e => e.Beneficio).HasMaxLength(20);

                entity.Property(e => e.Cod_Anses).HasColumnName("Cod Anses");

                entity.Property(e => e.Cuil).HasMaxLength(11);

                entity.Property(e => e.DNI).HasMaxLength(8);

                entity.Property(e => e.Fec_Nac)
                    .HasColumnType("date")
                    .HasColumnName("Fec#Nac");

                entity.Property(e => e.Filler).HasMaxLength(255);

                entity.Property(e => e.Iosep).HasMaxLength(255);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LegajoColegio>(entity =>
            {
                entity.HasKey(e => e.IdLegajoColegio);

                entity.ToTable("LegajoColegio");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<LimiteMontoGerencium>(entity =>
            {
                entity.HasKey(e => e.LimiteMontoGciaID);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.MontoLimite).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperMod)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LiquidacionGremiosDetalle>(entity =>
            {
                entity.ToTable("LiquidacionGremiosDetalle");

                entity.Property(e => e.CantidadCuotas)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ImporteCuota).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteGremio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteOS).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.LiquidacionGremiosEncabezado)
                    .WithMany(p => p.LiquidacionGremiosDetalles)
                    .HasForeignKey(d => d.LiquidacionGremiosEncabezadoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiquidacionGremiosDetalle_LiquidacionGremiosEncabezado1");
            });

            modelBuilder.Entity<LiquidacionGremiosEncabezado>(entity =>
            {
                entity.ToTable("LiquidacionGremiosEncabezado");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Gremio)
                    .WithMany(p => p.LiquidacionGremiosEncabezados)
                    .HasForeignKey(d => d.GremioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiquidacionGremiosEncabezado_Gremios");
            });

            modelBuilder.Entity<Listum>(entity =>
            {
                entity.HasKey(e => e.IdLista);

                entity.Property(e => e.Anestesia).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Ayuda_1).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Ayuda_2).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Ayuda_3).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Ayuda_4).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CODIGO)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Cos_amb).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cos_int).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fijo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Honorario).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Instrumen).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.P_CODIGO)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.V_FECHA).HasColumnType("date");

                entity.Property(e => e.Ver).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Localidade>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Departamento)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Localidades)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Localidades_Provincias");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("Log");

                entity.Property(e => e.Detalle).HasColumnType("ntext");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Operador)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Tabla)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LogBajasProcesoNocturno>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("LogBajasProcesoNocturno");

                entity.Property(e => e.Cuil).HasMaxLength(11);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCrea).HasMaxLength(11);
            });

            modelBuilder.Entity<LogCantidadBonosAnulado>(entity =>
            {
                entity.HasKey(e => e.BonoAnuladoID);

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.TipoBono)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LogExcepcione>(entity =>
            {
                entity.HasKey(e => e.IdExcepcion);

                entity.Property(e => e.Accion).HasMaxLength(49);

                entity.Property(e => e.Controlador).HasMaxLength(40);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IP_Origen).HasMaxLength(15);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LogGeneral>(entity =>
            {
                entity.HasKey(e => e.LogGeneralID);

                entity.ToTable("LogGeneral");

                entity.Property(e => e.Accion).HasMaxLength(300);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Tabla).HasMaxLength(100);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LogHistoricoActivacion>(entity =>
            {
                entity.HasKey(e => e.IDLogActivacion);

                entity.ToTable("LogHistoricoActivacion");

                entity.Property(e => e.FechaActivacion).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.NroBono).HasMaxLength(14);

                entity.Property(e => e.TipoBono)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioActiva)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnulo)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LogWSConvenio>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.Property(e => e.API).HasMaxLength(75);

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.IP_Solicitud).HasMaxLength(15);
            });

            modelBuilder.Entity<LugarPagoDDJJ>(entity =>
            {
                entity.HasKey(e => e.IdLugarPagoDDJJ);

                entity.ToTable("LugarPagoDDJJ");

                entity.Property(e => e.Aporte).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Desde).HasColumnType("date");

                entity.Property(e => e.Fecha_Hasta).HasColumnType("date");

                entity.Property(e => e.NumBeneficioAnses)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones).HasMaxLength(3000);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdDdjjNavigation)
                    .WithMany(p => p.LugarPagoDDJJs)
                    .HasForeignKey(d => d.IdDdjj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LugarPagoDDJJ_AfiliadosDDJJ");

                entity.HasOne(d => d.IdLugarPagoNavigation)
                    .WithMany(p => p.LugarPagoDDJJs)
                    .HasForeignKey(d => d.IdLugarPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LugarPagoDDJJ_Tipo_LugarPago");

                entity.HasOne(d => d.IdSituacionLaboralNavigation)
                    .WithMany(p => p.LugarPagoDDJJs)
                    .HasForeignKey(d => d.IdSituacionLaboral)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LugarPagoDDJJ_Tipo_SituacionLaboral");
            });

            modelBuilder.Entity<ManualDatCobertura>(entity =>
            {
                entity.HasKey(e => e.IdManualDatCobertura)
                    .HasName("PK__ManualDa__2687BFC968A93BE1");

                entity.ToTable("ManualDatCobertura");

                entity.HasIndex(e => new { e.registro, e.fec_act }, "Index_FarPrecio");

                entity.Property(e => e.Cobertura_Internado).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cobertura_ambulatorio).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Vigencia_Cobertura).HasColumnType("date");

                entity.Property(e => e.barras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.fec_act).HasColumnType("date");

                entity.Property(e => e.fecha).HasColumnType("date");

                entity.Property(e => e.ioma)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.laborat)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.present)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ManualDatCoberturaEncabezado>(entity =>
            {
                entity.HasKey(e => e.ManualDatCoberturaID);

                entity.ToTable("ManualDatCoberturaEncabezado");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.NombreArchivo).HasMaxLength(300);

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ManualDatHistorico>(entity =>
            {
                entity.HasKey(e => e.IdManualDatHistorico)
                    .HasName("PK__ManualDa__35ABA2EA63E486C4");

                entity.ToTable("ManualDatHistorico");

                entity.HasIndex(e => new { e.NroRegistro, e.fec_act }, "INDEX_QUERY_STOCK");

                entity.HasIndex(e => e.fec_act, "Index_Fec_Act");

                entity.HasIndex(e => new { e.troquel, e.fec_act }, "Index_ManualDatTroquelPrecio");

                entity.HasIndex(e => e.NroRegistro, "Index_NroRegistroFechaPrecio2");

                entity.Property(e => e.Baja)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Blanco)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Blanco2)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Gravamen)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Heladera)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Importado)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ioma1).HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Ioma2)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Ioma3)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Iva)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Marca)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Pami)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sifar)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tamaño)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TipoVenta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Unidades).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.barras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.fec_act).HasColumnType("date");

                entity.Property(e => e.fecha)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.laborat)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.precio).HasColumnType("numeric(9, 0)");

                entity.Property(e => e.precio2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.present)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MatsaImagenNorte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MatsaImagenNorte");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Práctica).HasMaxLength(255);

                entity.Property(e => e.valor).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Medicacion_Detalle_Esquema>(entity =>
            {
                entity.HasKey(e => e.IdMedicacionDetalleEsquema);

                entity.ToTable("Medicacion_Detalle_Esquema");

                entity.HasIndex(e => e.Anulado, "Index");

                entity.Property(e => e.Anual).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bimestral).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CincoMeses)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cuatrimestral).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Diario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Dias45)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Inicio).HasColumnType("date");

                entity.Property(e => e.InicioResol).HasColumnType("date");

                entity.Property(e => e.Mensual).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Modifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModificaFecha).HasColumnType("datetime");

                entity.Property(e => e.MotivoAnulaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.NroExpediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.PorUnicaVez)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Reconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ref_Expediente).IsUnicode(false);

                entity.Property(e => e.Ref_Resolucion).IsUnicode(false);

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Semanal)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Semestral).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TipoFrecuenciaID)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TipoReconoce)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Trimestral).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UID).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vencimiento).HasColumnType("date");

                entity.Property(e => e.VencimientoAnterior).HasColumnType("datetime");

                entity.Property(e => e.VencimientoResol).HasColumnType("date");

                entity.Property(e => e.Vida).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Medicacion_Detalle_Plane>(entity =>
            {
                entity.HasKey(e => e.IdMedicacionDetallePlanes);

                entity.Property(e => e.Auditoria).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CincoMeses).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Gtin)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.InicioResol).HasColumnType("datetime");

                entity.Property(e => e.Modifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModificaFecha).HasColumnType("datetime");

                entity.Property(e => e.PorUnicaVez).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProvistoPor).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TipoReconoce)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento).HasColumnType("datetime");

                entity.Property(e => e.VencimientoResol).HasColumnType("datetime");
            });

            modelBuilder.Entity<Medicacion_Esquema>(entity =>
            {
                entity.HasKey(e => e.IdMedicacionEsquema);

                entity.ToTable("Medicacion_Esquema");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Inicio).HasColumnType("date");

                entity.Property(e => e.Modifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModificaFecha).HasColumnType("datetime");

                entity.Property(e => e.NroExpediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ref_Expediente).IsUnicode(false);

                entity.Property(e => e.Ref_Resolucion).IsUnicode(false);

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento).HasColumnType("date");

                entity.HasOne(d => d.IdEsquemaNavigation)
                    .WithMany(p => p.Medicacion_Esquemas)
                    .HasForeignKey(d => d.IdEsquema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicacion_Esquema_Esquemas_Afiliado");
            });

            modelBuilder.Entity<Medicacion_plane>(entity =>
            {
                entity.HasKey(e => e.IdMedicacionPlan)
                    .HasName("PK_Medicacion_Planes");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Inicio).HasColumnType("date");

                entity.Property(e => e.Modifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModificaFecha).HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Vencimiento).HasColumnType("date");

                entity.HasOne(d => d.IdDetalle_PlanesNavigation)
                    .WithMany(p => p.Medicacion_planes)
                    .HasForeignKey(d => d.IdDetalle_Planes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicacion_Planes_Detalle_Planes");
            });

            modelBuilder.Entity<MedicamentosCatastrofico>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Barra)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Cober)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IdMedicamentosCatastroficos).ValueGeneratedOnAdd();

                entity.Property(e => e.Lab)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Nomiose)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Presenta)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Principio)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MedicamentosRedFarmacium>(entity =>
            {
                entity.HasKey(e => e.MedicamentoRedFarmaciaID)
                    .HasName("PK_MedicacionRedFarmacia");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Desde).HasColumnType("date");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Hasta).HasColumnType("date");

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnidadesInternacDiarias).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.VencimientoAnterior).HasColumnType("datetime");
            });

            modelBuilder.Entity<Mese>(entity =>
            {
                entity.HasKey(e => e.MesID);

                entity.Property(e => e.Mes).HasMaxLength(50);
            });

            modelBuilder.Entity<Motivo>(entity =>
            {
                entity.HasKey(e => e.IdMotivo);

                entity.Property(e => e.Detalle).HasMaxLength(200);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MotivoAnulaCobroInt>(entity =>
            {
                entity.ToTable("MotivoAnulaCobroInt");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.NroBono)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MotivoAuditorium>(entity =>
            {
                entity.HasKey(e => e.MotivoAuditoriaID);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MotivoBaja>(entity =>
            {
                entity.HasKey(e => e.IdMotivoBaja);

                entity.ToTable("MotivoBaja");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MotivoCambioCentro>(entity =>
            {
                entity.ToTable("MotivoCambioCentro");

                entity.Property(e => e.Descripcion).HasMaxLength(200);
            });

            modelBuilder.Entity<MotivoCobertura>(entity =>
            {
                entity.ToTable("MotivoCobertura");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MotivoConstancium>(entity =>
            {
                entity.HasKey(e => e.MotivoConstanciaID);

                entity.Property(e => e.Nombre).HasMaxLength(300);
            });

            modelBuilder.Entity<MotivoDerivacion>(entity =>
            {
                entity.ToTable("MotivoDerivacion");

                entity.Property(e => e.FechaActiva).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.OperActiva)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MotivoError>(entity =>
            {
                entity.ToTable("MotivoError");
            });

            modelBuilder.Entity<MotivoRestauracion>(entity =>
            {
                entity.ToTable("MotivoRestauracion");
            });

            modelBuilder.Entity<Motivo_Ganador>(entity =>
            {
                entity.HasKey(e => e.MotivoGanadorID)
                    .HasName("PK_MotivoGanador");

                entity.ToTable("Motivo_Ganador");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Motivo_Reimpresion>(entity =>
            {
                entity.HasKey(e => e.MotivoReimpresionID);

                entity.ToTable("Motivo_Reimpresion");

                entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MovimientoPracticasInternado>(entity =>
            {
                entity.ToTable("MovimientoPracticasInternado");

                entity.HasIndex(e => e.EncabezadoID, "Index");

                entity.HasIndex(e => e.EncabezadoID, "Index1");

                entity.HasIndex(e => e.InternadoID, "Index2");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<Movimiento_Cuentum>(entity =>
            {
                entity.HasKey(e => e.MovimientoCuentaID);

                entity.Property(e => e.Anulado)
                    .IsRequired()
                    .HasDefaultValueSql("((0)-(1))");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.CuentaBanco)
                    .WithMany(p => p.Movimiento_Cuenta)
                    .HasForeignKey(d => d.CuentaBancoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movimiento_Cuenta_Cuentas_Bancos");

                entity.HasOne(d => d.TipoMovimientoCuenta)
                    .WithMany(p => p.Movimiento_Cuenta)
                    .HasForeignKey(d => d.TipoMovimientoCuentaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movimiento_Cuenta_TipoMovimientoCuenta");
            });

            modelBuilder.Entity<MovimientosExpediente>(entity =>
            {
                entity.HasKey(e => e.MovimientoExpedienteID);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MovimientosInternado>(entity =>
            {
                entity.HasKey(e => e.MovInternadoID)
                    .HasName("PK_Movimientos_internaciones");

                entity.HasIndex(e => e.IdInternado, "Index");

                entity.HasIndex(e => e.Activo, "Indice_PanelInternadoMovimientos");

                entity.Property(e => e.Cama)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.IP).HasMaxLength(15);

                entity.Property(e => e.Latitud).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Longitud).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCreaFecha).HasColumnType("datetime");

                entity.Property(e => e.Pabellon)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.MovimientosInternados)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movimientos_internaciones_Estados_Internacion");

                entity.HasOne(d => d.IdInternadoNavigation)
                    .WithMany(p => p.MovimientosInternados)
                    .HasForeignKey(d => d.IdInternado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movimientos_internaciones_Internados");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.MovimientosInternados)
                    .HasForeignKey(d => d.SectorID)
                    .HasConstraintName("FK_MovimientosInternados_InternadosSector");

                entity.HasOne(d => d.TipoAlta)
                    .WithMany(p => p.MovimientosInternados)
                    .HasForeignKey(d => d.TipoAltaID)
                    .HasConstraintName("FK_MovimientosInternados_TipoAlta");

                entity.HasOne(d => d.TipoInternacion)
                    .WithMany(p => p.MovimientosInternados)
                    .HasForeignKey(d => d.TipoInternacionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovimientosInternados_TipoInternacion");
            });

            modelBuilder.Entity<Movimientos_Vacuna>(entity =>
            {
                entity.HasKey(e => e.IdMovimientos);

                entity.Property(e => e.Avisado).HasColumnType("date");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEdadNavigation)
                    .WithMany(p => p.Movimientos_Vacunas)
                    .HasForeignKey(d => d.IdEdad)
                    .HasConstraintName("FK_Movimientos_Vacunas_Edades_Vacunas");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Movimientos_Vacunas)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("FK_Movimientos_Vacunas_Grupos_Vacunas");
            });

            modelBuilder.Entity<MujeresASuspender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MujeresASuspender");

                entity.Property(e => e.A_Numero).HasMaxLength(255);

                entity.Property(e => e.Documento).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);
            });

            modelBuilder.Entity<Mujeres_Geriatrica>(entity =>
            {
                entity.HasKey(e => e.idMujeres);

                entity.Property(e => e.A_numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio);

                entity.Property(e => e.AGRUPA).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CATEG).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CODCTA).HasMaxLength(15);

                entity.Property(e => e.CUIT).HasMaxLength(11);

                entity.Property(e => e.DESCTA).HasMaxLength(80);

                entity.Property(e => e.DOMICI).HasMaxLength(80);

                entity.Property(e => e.ESTADO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FECALT).HasColumnType("date");

                entity.Property(e => e.FECBAJ).HasColumnType("date");

                entity.Property(e => e.GENDEB)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IMPUTA)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TIPCTA)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NAsociadas_Autoriza>(entity =>
            {
                entity.HasKey(e => e.IdAsociadas_Autoriza);

                entity.ToTable("NAsociadas_Autoriza");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.cantidad).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<NAsociadas_Facturacion>(entity =>
            {
                entity.HasKey(e => e.IdAsociadas_Facturacion);

                entity.ToTable("NAsociadas_Facturacion");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<NBU_9Julio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NBU_9Julio");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Practica).HasMaxLength(255);
            });

            modelBuilder.Entity<NBU_Modelo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NBU_Modelo");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Practica).HasMaxLength(255);
            });

            modelBuilder.Entity<NBU_Norte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NBU_Norte");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Practica).HasMaxLength(255);
            });

            modelBuilder.Entity<NBU_Parque>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NBU_Parque");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Practica).HasMaxLength(255);
            });

            modelBuilder.Entity<NCapitulo>(entity =>
            {
                entity.HasKey(e => e.IdCapitulo);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NEncabezado_Nomenclador>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEncabezado_Nomenclador");

                entity.Property(e => e.IdEncabezado_Nomenclador).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdEncabezado_NomencladorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEncabezado_Nomenclador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NEncabezado_Nomenclador_NTipo_Nomenclador");

                entity.HasOne(d => d.idprestadorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.idprestador)
                    .HasConstraintName("FK_NEncabezado_Nomenclador_Prestadores");
            });

            modelBuilder.Entity<NExcluye_Autoriza>(entity =>
            {
                entity.HasKey(e => e.IdExcluye_Autoriza);

                entity.ToTable("NExcluye_Autoriza");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<NExcluye_Facturacion>(entity =>
            {
                entity.HasKey(e => e.IdExcluye_Facturacion);

                entity.ToTable("NExcluye_Facturacion");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<NNivel_Nomenclador>(entity =>
            {
                entity.HasKey(e => e.IdNivel_Nomenclador)
                    .HasName("PK_NNivel_Nomenclador_1");

                entity.ToTable("NNivel_Nomenclador");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NNivel_Practica>(entity =>
            {
                entity.HasKey(e => e.IdNivel_Nomenclador)
                    .HasName("PK_NNivel_Nomenclador");

                entity.ToTable("NNivel_Practica");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NNomenclador>(entity =>
            {
                entity.HasKey(e => e.IdNNomenclador);

                entity.ToTable("NNomenclador");
            });

            modelBuilder.Entity<NNomenclador_Base>(entity =>
            {
                entity.HasKey(e => e.IdNomenclador_Base);

                entity.ToTable("NNomenclador_Base");

                entity.HasOne(d => d.IdNivel_NomencladorNavigation)
                    .WithMany(p => p.NNomenclador_Bases)
                    .HasForeignKey(d => d.IdNivel_Nomenclador)
                    .HasConstraintName("FK_NNomenclador_Base_NNivel_Nomenclador");

                entity.HasOne(d => d.IdPractica_BaseNavigation)
                    .WithMany(p => p.NNomenclador_Bases)
                    .HasForeignKey(d => d.IdPractica_Base)
                    .HasConstraintName("FK_NNomenclador_Base_NPracticas_Base");

                entity.HasOne(d => d.IdTipo_CalculoNavigation)
                    .WithMany(p => p.NNomenclador_Bases)
                    .HasForeignKey(d => d.IdTipo_Calculo)
                    .HasConstraintName("FK_NNomenclador_Base_NTipo_Calculo");

                entity.HasOne(d => d.IdTipo_NomencladorNavigation)
                    .WithMany(p => p.NNomenclador_Bases)
                    .HasForeignKey(d => d.IdTipo_Nomenclador)
                    .HasConstraintName("FK_NNomenclador_Base_NTipo_Nomenclador");
            });

            modelBuilder.Entity<NPracticasAsociada>(entity =>
            {
                entity.HasKey(e => e.IdPracticaAsociada);

                entity.Property(e => e.Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<NPracticas_Base>(entity =>
            {
                entity.HasKey(e => e.IdPractica_Base);

                entity.ToTable("NPracticas_Base");

                entity.HasIndex(e => e.Codigo, "<Name of Missing Index, sysname,>");

                entity.Property(e => e.Anulado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.IdSexo).HasDefaultValueSql("((3))");

                entity.Property(e => e.NoNomenclada).HasMaxLength(2);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Unidad_Anestesista).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unidad_Ayudante1).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unidad_Ayudante2).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unidad_Ayudante3).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unidad_Ayudante4).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unidad_Especialista).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unidad_Gastos).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unidad_Honorarios).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unidad_Instrumentista).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.IdSubCapituloNavigation)
                    .WithMany(p => p.NPracticas_Bases)
                    .HasForeignKey(d => d.IdSubCapitulo)
                    .HasConstraintName("FK_NPracticas_Base_NomSubCapitulo");

                entity.HasOne(d => d.IdTipo_PracticaNavigation)
                    .WithMany(p => p.NPracticas_Bases)
                    .HasForeignKey(d => d.IdTipo_Practica)
                    .HasConstraintName("FK_NPracticas_Base_TipoPractica");
            });

            modelBuilder.Entity<NRestriccione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Carencias).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdRrestricciones).ValueGeneratedOnAdd();

                entity.Property(e => e.anual).HasDefaultValueSql("((0))");

                entity.Property(e => e.auditoria).HasDefaultValueSql("((0))");

                entity.Property(e => e.bimestral).HasDefaultValueSql("((0))");

                entity.Property(e => e.edad_maxima).HasDefaultValueSql("((255))");

                entity.Property(e => e.edad_minima).HasDefaultValueSql("((0))");

                entity.Property(e => e.idsexo).HasDefaultValueSql("(N'A')");

                entity.Property(e => e.informa).HasDefaultValueSql("((0))");

                entity.Property(e => e.mensual).HasDefaultValueSql("((0))");

                entity.Property(e => e.semestral).HasDefaultValueSql("((0))");

                entity.Property(e => e.trimestral).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NTipo_Calculo>(entity =>
            {
                entity.HasKey(e => e.IdTipo_Calculo);

                entity.ToTable("NTipo_Calculo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NTipo_Gasto>(entity =>
            {
                entity.HasKey(e => e.IdTipo_Gasto);

                entity.ToTable("NTipo_Gasto");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NTipo_Nomenclador>(entity =>
            {
                entity.HasKey(e => e.IdTipo_Nomenclador)
                    .HasName("PK_Nomen_TipoNom");

                entity.ToTable("NTipo_Nomenclador");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NTipo_Practica>(entity =>
            {
                entity.HasKey(e => e.IdTipo_Practica)
                    .HasName("PK_Tipo_Practicas");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NTipo_Unidad>(entity =>
            {
                entity.HasKey(e => e.IdTipo_Unidad);

                entity.ToTable("NTipo_Unidad");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NivelEscuela>(entity =>
            {
                entity.ToTable("NivelEscuela");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.MotivoAnulaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModif)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NomCapitulo>(entity =>
            {
                entity.ToTable("NomCapitulo");

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<NomPracticaBase>(entity =>
            {
                entity.ToTable("NomPracticaBase");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NomPracticaConvenio>(entity =>
            {
                entity.ToTable("NomPracticaConvenio");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaCreado).HasColumnType("date");

                entity.Property(e => e.IdProvincia).HasDefaultValueSql("((14))");

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Tipo).HasMaxLength(50);

                entity.HasOne(d => d.Institucion)
                    .WithMany(p => p.NomPracticaConvenios)
                    .HasForeignKey(d => d.InstitucionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NomPracticaConvenio_Prestadores");
            });

            modelBuilder.Entity<NomPracticaConvenioDetalle>(entity =>
            {
                entity.ToTable("NomPracticaConvenioDetalle");

                entity.HasIndex(e => new { e.NomPracticaConvenioID, e.Anulado }, "Index");

                entity.HasIndex(e => new { e.NomPracticaConvenioID, e.IdPractica, e.Anulado }, "Index1");

                entity.Property(e => e.Anestesista).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CoseguroAmbulatorio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CoseguroInternado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaVigenciaDesde).HasColumnType("date");

                entity.Property(e => e.FechaVigenciaHasta).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Instrumentador).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion).HasMaxLength(20);

                entity.Property(e => e.Vigente)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.NomPracticaConvenio)
                    .WithMany(p => p.NomPracticaConvenioDetalles)
                    .HasForeignKey(d => d.NomPracticaConvenioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NomPracticaConvenioDetalle_NomPracticaConvenio");
            });

            modelBuilder.Entity<NomPracticaConvenioExcepcion>(entity =>
            {
                entity.ToTable("NomPracticaConvenioExcepcion");

                entity.Property(e => e.NombreExcepcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NomPracticaConvenioExcepcionDetalle>(entity =>
            {
                entity.ToTable("NomPracticaConvenioExcepcionDetalle");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.NomPracticaConvenioExcepcion)
                    .WithMany(p => p.NomPracticaConvenioExcepcionDetalles)
                    .HasForeignKey(d => d.NomPracticaConvenioExcepcionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NomPracticaConvenioExcepcionDetalle_NomPracticaConvenioExcepcion");
            });

            modelBuilder.Entity<NomPracticaConvenioInactivacion>(entity =>
            {
                entity.ToTable("NomPracticaConvenioInactivacion");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.NroResolucion).HasMaxLength(50);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.NomPracticaConvenio)
                    .WithMany(p => p.NomPracticaConvenioInactivacions)
                    .HasForeignKey(d => d.NomPracticaConvenioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NomPracticaConvenioInactivacion_NomPracticaConvenio");
            });

            modelBuilder.Entity<NomPracticaConvenioResolucion>(entity =>
            {
                entity.ToTable("NomPracticaConvenioResolucion");

                entity.Property(e => e.Accion).HasMaxLength(50);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCargaResolucion).HasColumnType("date");

                entity.Property(e => e.FechaVigenciaDesde).HasColumnType("date");

                entity.Property(e => e.NroResolucion).HasMaxLength(20);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NomPracticaConvenioRestriccion>(entity =>
            {
                entity.ToTable("NomPracticaConvenioRestriccion");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.NomPracticaConvenio)
                    .WithMany(p => p.NomPracticaConvenioRestriccions)
                    .HasForeignKey(d => d.NomPracticaConvenioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NomPracticaConvenioRestriccion_NomPracticaConvenio");
            });

            modelBuilder.Entity<NomPracticaConvenioUnidad>(entity =>
            {
                entity.ToTable("NomPracticaConvenioUnidad");

                entity.Property(e => e.Desde).HasColumnType("date");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaResolucion).HasColumnType("date");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion).HasMaxLength(20);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.IdTipoUnidadNavigation)
                    .WithMany(p => p.NomPracticaConvenioUnidads)
                    .HasForeignKey(d => d.IdTipoUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NomPracticaConvenioUnidad_TipoUnidad");

                entity.HasOne(d => d.NomPracticaConvenio)
                    .WithMany(p => p.NomPracticaConvenioUnidads)
                    .HasForeignKey(d => d.NomPracticaConvenioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NomPracticaConvenioUnidad_NomPracticaConvenio");
            });

            modelBuilder.Entity<NomSubCapitulo>(entity =>
            {
                entity.ToTable("NomSubCapitulo");

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.HasOne(d => d.NomCapitulo)
                    .WithMany(p => p.NomSubCapitulos)
                    .HasForeignKey(d => d.NomCapituloID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NomSubCapitulo_NomCapitulo");
            });

            modelBuilder.Entity<Nomen_Pension>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Nomen_Pension");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.IdPension).ValueGeneratedOnAdd();

                entity.Property(e => e.Importe100).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe80).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Nomen_TipoUnidad>(entity =>
            {
                entity.HasKey(e => e.IdNomTipoUnidad)
                    .HasName("PK_TipoUnidad");

                entity.ToTable("Nomen_TipoUnidad");

                entity.Property(e => e.Año)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Cobertura).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaResolucion).HasColumnType("date");

                entity.Property(e => e.FinConvenio).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Letra)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.TipoCobertura)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.VigenciaDesde).HasColumnType("date");

                entity.Property(e => e.VigenciaHasta).HasColumnType("date");
            });

            modelBuilder.Entity<Nomen_Unidade>(entity =>
            {
                entity.HasKey(e => e.IdNomen_Unidades);

                entity.Property(e => e.Anestesista).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante_1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante_2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante_3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante_4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Especialista).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GastoUnidades).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HonorarioUnidades).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Instrumentadora).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalHonorarios).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Nomen_Valore>(entity =>
            {
                entity.HasKey(e => e.IdNomen_Valores)
                    .HasName("PK_Nomen_Valores1");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Nomen_Vigencia>(entity =>
            {
                entity.HasKey(e => e.IdNomen_Vigencia);

                entity.Property(e => e.Año)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FechaResolucion).HasColumnType("date");

                entity.Property(e => e.FinConvenio).HasColumnType("date");

                entity.Property(e => e.IdTipoModalidad).HasComment("Tipo 1: Valores\r\nTipo 2: Unidades");

                entity.Property(e => e.Letra)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.VigenciaDesde).HasColumnType("date");

                entity.Property(e => e.VigenciaHasta).HasColumnType("date");
            });

            modelBuilder.Entity<NomenclaDbf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NomenclaDbf");

                entity.Property(e => e.ANESTESIA).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AUDITOR).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AYUDA_1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AYUDA_2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AYUDA_3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AYUDA_4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CODIGO).HasMaxLength(2);

                entity.Property(e => e.COLUMNA).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DIASINT).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GASTOS).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.G_TIPO).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HONORARIO).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.INSTRUMEN).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdNomencla).ValueGeneratedOnAdd();

                entity.Property(e => e.MAXEDA).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MINEDA).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NIVEL).HasMaxLength(3);

                entity.Property(e => e.NOMBRE).HasMaxLength(45);

                entity.Property(e => e.O_CODIGO).HasMaxLength(8);

                entity.Property(e => e.P_CODIGO).HasMaxLength(8);

                entity.Property(e => e.P_TIPO).HasMaxLength(1);

                entity.Property(e => e.SERIADA).HasMaxLength(8);

                entity.Property(e => e.SEXO).HasMaxLength(1);

                entity.Property(e => e.TOPANU).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TOPMEN).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TOPSEM).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TOPTRI).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Nomenclador_Back>(entity =>
            {
                entity.HasKey(e => e.IdNomenclador)
                    .HasName("PK__Nomencla__27704C9F48AEF318");

                entity.ToTable("Nomenclador_Back");

                entity.Property(e => e.Anestesista).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ayudante_1).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ayudante_2).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ayudante_3).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ayudante_4).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Factura_Codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Gastos).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Instrumentista).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Seriada)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tope_Semestral)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.nivel)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.p_tipo)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Nomenclador_Vigencium>(entity =>
            {
                entity.HasKey(e => e.IdNomenclador_Vigencia)
                    .HasName("PK__Nomencla__D020061483EFDF92");

                entity.HasIndex(e => e.p_codigo, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.codigo, e.p_codigo, e.anulado }, "Index_Nomenclador_Vigencia_Cod_p_Cod_Anul");

                entity.HasIndex(e => new { e.p_codigo, e.IdInstitucion, e.v_fecha }, "NomencladorVigencia_Precios");

                entity.HasIndex(e => e.IdInstitucion, "Nomenclador_Vigencia_IdInstitucion");

                entity.Property(e => e.Resolucion).HasMaxLength(20);

                entity.Property(e => e.anestesia).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_1).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_2).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_3).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_4).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.codigo)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.cos_amb).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.cos_int).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.fijo).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.gastos).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.honorario).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.instrumen).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.p_codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.v_fecha).HasColumnType("date");
            });

            modelBuilder.Entity<NominaAnse>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Column_0)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Column 0");
            });

            modelBuilder.Entity<NotaPedido_Detalle>(entity =>
            {
                entity.HasKey(e => e.NotaPedidoDetalleId);

                entity.ToTable("NotaPedido_Detalle");

                entity.Property(e => e.Alicuota_IVA).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(10, 4)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.OpModi).HasMaxLength(11);

                entity.Property(e => e.Precio_Neto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Precio_Unitario).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MotivoGanador)
                    .WithMany(p => p.NotaPedido_Detalles)
                    .HasForeignKey(d => d.MotivoGanadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Detalle_Motivo_Ganador");

                entity.HasOne(d => d.NotaPedidoEncabezado)
                    .WithMany(p => p.NotaPedido_Detalles)
                    .HasForeignKey(d => d.NotaPedidoEncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Detalle_NotaPedido_Encabezado");
            });

            modelBuilder.Entity<NotaPedido_Detalle_Presupuesto>(entity =>
            {
                entity.HasKey(e => e.NotadePedidoGanadoresId);

                entity.ToTable("NotaPedido_Detalle_Presupuesto");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.NotaPedidoDetalle)
                    .WithMany(p => p.NotaPedido_Detalle_Presupuestos)
                    .HasForeignKey(d => d.NotaPedidoDetalleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Detalle_Presupuesto_NotaPedido_Detalle");

                entity.HasOne(d => d.NotaPedidoPresupuesto)
                    .WithMany(p => p.NotaPedido_Detalle_Presupuestos)
                    .HasForeignKey(d => d.NotaPedidoPresupuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Detalle_Presupuesto_NotaPedido_Presupuesto");
            });

            modelBuilder.Entity<NotaPedido_Encabezado>(entity =>
            {
                entity.HasKey(e => e.NotaPedidoEncabezadoId);

                entity.ToTable("NotaPedido_Encabezado");

                entity.Property(e => e.Anio)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Asunto)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.EstimativoTotal).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.FecHoraApertura).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Numero_Expediente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero_NotaDePedido)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.OpModi).HasMaxLength(11);

                entity.HasOne(d => d.CuentaContable)
                    .WithMany(p => p.NotaPedido_Encabezados)
                    .HasForeignKey(d => d.CuentaContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Encabezado_Cuentas_Contables");

                entity.HasOne(d => d.EstadoNotaDePedido)
                    .WithMany(p => p.NotaPedido_Encabezados)
                    .HasForeignKey(d => d.EstadoNotaDePedidoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Encabezado_Estado_NotaDePedido");

                entity.HasOne(d => d.TipoNotadePedido)
                    .WithMany(p => p.NotaPedido_Encabezados)
                    .HasForeignKey(d => d.TipoNotadePedidoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Encabezado_Tipo_NotaDePedido");
            });

            modelBuilder.Entity<NotaPedido_Presupuesto>(entity =>
            {
                entity.HasKey(e => e.NotaPedidoPresupuestoId);

                entity.ToTable("NotaPedido_Presupuesto");

                entity.Property(e => e.Alicuota_Iva).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.OpModi).HasMaxLength(11);

                entity.Property(e => e.Precio_Unitario).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.NotaPedidoEncabezado)
                    .WithMany(p => p.NotaPedido_Presupuestos)
                    .HasForeignKey(d => d.NotaPedidoEncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Presupuesto_NotaPedido_Encabezado");

                entity.HasOne(d => d.PresupuestoMotivo)
                    .WithMany(p => p.NotaPedido_Presupuestos)
                    .HasForeignKey(d => d.PresupuestoMotivoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Presupuesto_Presupuesto_Motivo");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.NotaPedido_Presupuestos)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Presupuesto_Proveedores");
            });

            modelBuilder.Entity<NotaPedido_Proveedore>(entity =>
            {
                entity.HasKey(e => e.NotaPedidoProveedoresId);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.OpModi).HasMaxLength(11);

                entity.HasOne(d => d.NotaPedidoEncabezado)
                    .WithMany(p => p.NotaPedido_Proveedores)
                    .HasForeignKey(d => d.NotaPedidoEncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Proveedores_NotaPedido_Encabezado");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.NotaPedido_Proveedores)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaPedido_Proveedores_Proveedores");
            });

            modelBuilder.Entity<NotasAuditoriaInternado>(entity =>
            {
                entity.HasKey(e => e.NotaAuditoriaID);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NroTarjetum>(entity =>
            {
                entity.HasKey(e => e.IdNroTarjeta);

                entity.Property(e => e.AfiliadoCuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Ano)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodigoSeguridad)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.DigitoVerificador)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NumeroCirugium>(entity =>
            {
                entity.HasKey(e => e.NumeroCirugiaID);

                entity.Property(e => e.DescripcionCorta).HasMaxLength(50);
            });

            modelBuilder.Entity<Numeros_Movimiento>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Anio)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumerosMovimientosId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ObrasSociale>(entity =>
            {
                entity.HasKey(e => e.IdObraSocial);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenAnuladaParaExpediente>(entity =>
            {
                entity.HasKey(e => e.OrdenAnuladaId);

                entity.Property(e => e.OrdenAnuladaId).ValueGeneratedNever();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.NumeroBono).HasMaxLength(14);

                entity.Property(e => e.UsuarioAnula).HasMaxLength(11);
            });

            modelBuilder.Entity<OrdenCompra_Comprobante>(entity =>
            {
                entity.HasKey(e => e.OrdenCompraComprobanteId)
                    .HasName("PK_OrdenCompra_Facturas");

                entity.ToTable("OrdenCompra_Comprobante");

                entity.Property(e => e.CAI)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CUIT)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Comprobante).HasColumnType("date");

                entity.Property(e => e.Importe_Bruto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Iva).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Neto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Retencion).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.HasOne(d => d.OrdenCompraEncabezado)
                    .WithMany(p => p.OrdenCompra_Comprobantes)
                    .HasForeignKey(d => d.OrdenCompraEncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenCompra_Facturas_OrdenCompra_Encabezado");

                entity.HasOne(d => d.TipoComprobante)
                    .WithMany(p => p.OrdenCompra_Comprobantes)
                    .HasForeignKey(d => d.TipoComprobanteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenCompra_Comprobante_Tipo_Comprobante");
            });

            modelBuilder.Entity<OrdenCompra_Encabezado>(entity =>
            {
                entity.HasKey(e => e.OrdenCompraEncabezadoId);

                entity.ToTable("OrdenCompra_Encabezado");

                entity.Property(e => e.Anio)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Importe_Total).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Expediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Numero_OrdenCompra)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.OpModi).HasMaxLength(11);

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CuentaContable)
                    .WithMany(p => p.OrdenCompra_Encabezados)
                    .HasForeignKey(d => d.CuentaContableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenCompra_Encabezado_Cuentas_Contables");
            });

            modelBuilder.Entity<OrdenPago_Anticipo>(entity =>
            {
                entity.HasKey(e => e.OrdenPagoAnticiposID);

                entity.Property(e => e.Fecha_Anticipo).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.HasOne(d => d.OrdenPago)
                    .WithMany(p => p.OrdenPago_Anticipos)
                    .HasForeignKey(d => d.OrdenPagoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenPago_Anticipos_Orden_Pago");
            });

            modelBuilder.Entity<OrdenPago_Beneficiario>(entity =>
            {
                entity.Property(e => e.Beneficiario).HasMaxLength(250);

                entity.Property(e => e.Concepto)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CuilBeneficiario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.OrdenPago)
                    .WithMany(p => p.OrdenPago_Beneficiarios)
                    .HasForeignKey(d => d.OrdenPagoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenPago_Beneficiarios_Orden_Pago");
            });

            modelBuilder.Entity<OrdenPago_CuentaContable>(entity =>
            {
                entity.ToTable("OrdenPago_CuentaContable");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Importe_Parcial).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CuentaBanco)
                    .WithMany(p => p.OrdenPago_CuentaContables)
                    .HasForeignKey(d => d.CuentaBancoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenPago_CuentaContable_Cuentas_Bancos");

                entity.HasOne(d => d.OrdenPago)
                    .WithMany(p => p.OrdenPago_CuentaContables)
                    .HasForeignKey(d => d.OrdenPagoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenPago_CuentaContable_Orden_Pago");
            });

            modelBuilder.Entity<OrdenPago_DetalleCheque>(entity =>
            {
                entity.HasKey(e => e.OrdenPagoDetalleChequesID);

                entity.Property(e => e.Fecha_Emision).HasColumnType("date");

                entity.Property(e => e.Fecha_Entrega).HasColumnType("date");

                entity.Property(e => e.Fecha_Impresion).HasColumnType("date");

                entity.Property(e => e.Fecha_Ingreso).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.HasOne(d => d.OrdenPago)
                    .WithMany(p => p.OrdenPago_DetalleCheques)
                    .HasForeignKey(d => d.OrdenPagoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenPago_DetalleCheques_Orden_Pago1");

                entity.HasOne(d => d.TipoMovimientosBanco)
                    .WithMany(p => p.OrdenPago_DetalleCheques)
                    .HasForeignKey(d => d.TipoMovimientosBancoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenPago_DetalleCheques_Tipo_MovimientoBanco");
            });

            modelBuilder.Entity<OrdenPago_Retencione>(entity =>
            {
                entity.HasKey(e => e.OrdenPagoRetencionesID);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Importe_Retenido).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.HasOne(d => d.OrdenPago)
                    .WithMany(p => p.OrdenPago_Retenciones)
                    .HasForeignKey(d => d.OrdenPagoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenPago_Retenciones_Orden_Pago");

                entity.HasOne(d => d.TipoRetencion)
                    .WithMany(p => p.OrdenPago_Retenciones)
                    .HasForeignKey(d => d.TipoRetencionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenPago_Retenciones_Tipo_Retencion");
            });

            modelBuilder.Entity<OrdenSinCoseguro>(entity =>
            {
                entity.HasKey(e => e.IdOrdenSinCoseguro);

                entity.ToTable("OrdenSinCoseguro");

                entity.HasIndex(e => e.Numero, "Index");

                entity.HasIndex(e => e.Numero, "Index1");

                entity.HasIndex(e => e.IdDelegacion, "Index_OrdenSinCoseguroDelegacion");

                entity.Property(e => e.ComprobanteIncluye)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.ComprobantePaga)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debitado)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Definitivo).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaDebito).HasColumnType("datetime");

                entity.Property(e => e.FechaFacturado).HasColumnType("datetime");

                entity.Property(e => e.IdPlan).HasDefaultValueSql("((1))");

                entity.Property(e => e.IdTipoDebito).HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OpDebito).HasMaxLength(11);

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'C')")
                    .IsFixedLength();

                entity.Property(e => e.UserCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Orden_Pago>(entity =>
            {
                entity.HasKey(e => e.OrdenPagoID);

                entity.ToTable("Orden_Pago");

                entity.HasIndex(e => new { e.Anulado, e.CuilProveedor }, "<Name of Missing Index, sysname,>");

                entity.Property(e => e.Anio)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Beneficiario).HasMaxLength(300);

                entity.Property(e => e.CuilProveedor)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCrea).HasColumnType("datetime");

                entity.Property(e => e.Fecha_ATesoreria).HasColumnType("datetime");

                entity.Property(e => e.Importe_Anticipos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Neto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Pagado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Retenido).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MotivoAnulacion)
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Expediente).HasMaxLength(50);

                entity.Property(e => e.Numero_OrdenPago)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Referencia_Expediente)
                    .HasMaxLength(256)
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento).HasColumnType("date");

                entity.HasOne(d => d.ClasificadorGastos)
                    .WithMany(p => p.Orden_Pagos)
                    .HasForeignKey(d => d.ClasificadorGastosID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orden_Pago_ClasificadorGastos");

                entity.HasOne(d => d.TipoOrdenPago)
                    .WithMany(p => p.Orden_Pagos)
                    .HasForeignKey(d => d.TipoOrdenPagoID)
                    .HasConstraintName("FK_Orden_Pago_TipoOrdenPago");
            });

            modelBuilder.Entity<Ordene>(entity =>
            {
                entity.HasKey(e => e.IdOrden);

                entity.HasIndex(e => new { e.Anulada, e.Fecha_Emision }, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => e.IdOrden, "IX_Ordenes")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdDelegacion, e.Anulada, e.IosepSalud, e.Fecha_Emision }, "Index_Estadistica");

                entity.HasIndex(e => e.Numero, "Index_Numero");

                entity.HasIndex(e => e.IdPlan, "Index_OrdenIdPlan");

                entity.HasIndex(e => new { e.IdAfiliado, e.IdNomenclador, e.Anulada, e.IdPlan, e.Fecha_Emision }, "Index_Ordenes1");

                entity.HasIndex(e => new { e.IdAfiliado, e.TipoOrden, e.Anulada, e.Fecha_Emision }, "Index_OrdenesIdAfiliadoTipoAnul");

                entity.HasIndex(e => new { e.IdPlan, e.Anulada, e.Fecha_Emision }, "SP_Ordenes_Estadisticas_Autorizadas");

                entity.HasIndex(e => new { e.IdAfiliado, e.Anulada }, "indexOrdenesNI");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vence).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TipoAutorizacion).HasDefaultValueSql("((5))");

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TipoReconoce)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<OrdenesCobra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrdenesCobra");

                entity.Property(e => e.A_NUMERO)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.BANCO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.CAJA)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CAJERO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.COSEGURO).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DEB_CAJA)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.DEB_CAJERO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.DEB_DIGI).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DEB_FECHA).HasColumnType("date");

                entity.Property(e => e.DEB_HORA)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.DEB_TRANS).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DEB_TURNO)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.DIGITO).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DIGITO_CAJ).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FAMILIAR)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.FECHA_CAJ).HasColumnType("date");

                entity.Property(e => e.FECHA_CHE).HasColumnType("date");

                entity.Property(e => e.FECHA_ORD).HasColumnType("date");

                entity.Property(e => e.HISTORIC).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HORA_MOV)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.IMPORTE).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IMP_BON).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IMP_CHE).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IMP_DEBI).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IMP_DOC).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IMP_DOL).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IMP_EFE).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IMP_TARJ).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IVA).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NRO_AUT)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.NRO_CHE)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NRO_DEBI)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.NRO_DOCU)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.NRO_TARJ)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.O_SOCIAL)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.P_CODIGO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.REI_CAJA)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.REI_CAJERO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.REI_DIGI).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.REI_FECHA).HasColumnType("date");

                entity.Property(e => e.REI_HORA)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.REI_TRANS).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.REI_TURNO)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.SUC_AUT)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SUC_DOCU)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.TIPO_ANUL).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TIPO_BONO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.TIPO_TARJ)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.TIP_AUT)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TRANSAC).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TRANS_CAJ).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TURNO)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.T_EMITE)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesDbf>(entity =>
            {
                entity.HasKey(e => e.IdOrdenDbf);

                entity.ToTable("OrdenesDbf");

                entity.HasIndex(e => new { e.Suc_Aut, e.Nro_Aut }, "Index_OrdenesDbf_SucNro");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Caja).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Cobertu).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Efector)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Empresa)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_e).HasColumnType("date");

                entity.Property(e => e.Fecha_i).HasColumnType("date");

                entity.Property(e => e.Fecha_v).HasColumnType("date");

                entity.Property(e => e.Hora_Carga)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Hora_Cza)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Imp_Afi_G).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Imp_Afi_H).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Imp_Tot_G).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Imp_Tot_H).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.Int_Nro)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Int_Suc)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Lp_su)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Nomenclado)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Nro_Aut)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Obs)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Ope_Cza)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Prescribe)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Suc_Aut)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.T_Emite)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Tip_Aut)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.c_Plan)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.f_Cobro).HasColumnType("date");

                entity.Property(e => e.p_codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.t_Prestac)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesExportar>(entity =>
            {
                entity.HasKey(e => e.IdOrden);

                entity.ToTable("OrdenesExportar");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vence).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TipoReconoce)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<OrdenesExtra>(entity =>
            {
                entity.Property(e => e.AnulaFecha).HasColumnType("datetime");

                entity.Property(e => e.AnulaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Inicio).HasColumnType("date");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Vencimiento).HasColumnType("date");
            });

            modelBuilder.Entity<OrdenesManuale>(entity =>
            {
                entity.HasKey(e => e.IdOrdenManual);

                entity.Property(e => e.COD_AUT)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FECHA).HasColumnType("date");

                entity.Property(e => e.HORA)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.NUMERO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.OPERADOR)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SUCURSAL)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.TRANSAC)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.T_EMITE)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdenesTemporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrdenesTemporal");

                entity.Property(e => e.a_numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.caja).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.cobertu).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.diagnostic)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.efector)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.empresa)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.f_cobro).HasColumnType("date");

                entity.Property(e => e.familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.fecha_e).HasColumnType("date");

                entity.Property(e => e.fecha_i).HasColumnType("date");

                entity.Property(e => e.fecha_v).HasColumnType("date");

                entity.Property(e => e.hora_carga)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.hora_cza)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.imp_afi_g).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.imp_afi_h).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.imp_tot_g).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.imp_tot_h).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.int_nro)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.int_suc)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.lp_su)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.nomenclado)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.nro_aut)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.o_social)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.obs)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.ope_cza)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.operador)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.p_codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.plan)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.prescribe)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.suc_aut)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.t_emite)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.t_prestac)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.tip_aut)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ordenes_ContadorDBF>(entity =>
            {
                entity.HasKey(e => e.IdContador);

                entity.ToTable("Ordenes_ContadorDBF");
            });

            modelBuilder.Entity<Ordenes_Detalle>(entity =>
            {
                entity.HasKey(e => e.OrdenDetalleID);

                entity.ToTable("Ordenes_Detalle");

                entity.Property(e => e.Coseguro_Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro_Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reconoce_Gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reconoce_Honorarios).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<Ordenes_Key>(entity =>
            {
                entity.HasKey(e => e.IdOrdenes)
                    .HasName("PK_IdOrden");

                entity.HasIndex(e => e.Codigo_Delegacion, "IX_Codigo_Delegacion")
                    .IsUnique();

                entity.Property(e => e.IdOrdenes).ValueGeneratedNever();

                entity.Property(e => e.Codigo_Delegacion)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Ultimo_Nro)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OtrosPrecio>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.anestesia).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_1).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_2).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_3).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_4).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.codigo)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.cos_amb).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.cos_int).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.fijo).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.gastos).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.honora).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.instrumen).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.p_codigo)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.v_fecha).HasColumnType("date");
            });

            modelBuilder.Entity<PROFE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROFE");

                entity.Property(e => e.ApeNom).HasMaxLength(30);

                entity.Property(e => e.Cod_Pos).HasMaxLength(8);

                entity.Property(e => e.Dom_Calle).HasMaxLength(50);

                entity.Property(e => e.Dom_Dpto).HasMaxLength(3);

                entity.Property(e => e.FeNac).HasColumnType("datetime");

                entity.Property(e => e.Fech_Alta).HasColumnType("datetime");

                entity.Property(e => e.LeyAplicada).HasMaxLength(2);

                entity.Property(e => e.Sexo).HasMaxLength(1);

                entity.Property(e => e.Tipo_Doc).HasMaxLength(2);
            });

            modelBuilder.Entity<PadronCM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PadronCM");

                entity.Property(e => e.Apellido_Nombre)
                    .HasMaxLength(255)
                    .HasColumnName("Apellido Nombre");
            });

            modelBuilder.Entity<PadronImagenxCentro>(entity =>
            {
                entity.ToTable("PadronImagenxCentro");
            });

            modelBuilder.Entity<Pagos_Impresion>(entity =>
            {
                entity.HasKey(e => e.PagoID);

                entity.ToTable("Pagos_Impresion");

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Paise>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Papele>(entity =>
            {
                entity.HasKey(e => e.IdPapel);

                entity.Property(e => e.Nombre).HasMaxLength(200);

                entity.Property(e => e.PeriodoVence)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.PeriodoVence2)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PapelesDDJJ>(entity =>
            {
                entity.HasKey(e => e.IdPapelesDDJJ);

                entity.ToTable("PapelesDDJJ");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaPresentacion).HasColumnType("date");

                entity.Property(e => e.FechaRealizacion).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDdjjNavigation)
                    .WithMany(p => p.PapelesDDJJs)
                    .HasForeignKey(d => d.IdDdjj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PapelesDDJJ_AfiliadosDDJJ");

                entity.HasOne(d => d.IdPapelNavigation)
                    .WithMany(p => p.PapelesDDJJs)
                    .HasForeignKey(d => d.IdPapel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PapelesDDJJ_Papeles");
            });

            modelBuilder.Entity<PapelesDigitalizadosDDJJ>(entity =>
            {
                entity.HasKey(e => e.IdPapelDigitalizado);

                entity.ToTable("PapelesDigitalizadosDDJJ");
            });

            modelBuilder.Entity<ParametrosHoraHabil>(entity =>
            {
                entity.HasKey(e => e.IdParametroHoraHabil);

                entity.ToTable("ParametrosHoraHabil");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(75);

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ParametrosHoraHabilDetalle>(entity =>
            {
                entity.HasKey(e => e.IdParametrosHoraHabilDet);

                entity.ToTable("ParametrosHoraHabilDetalle");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdParametrosHoraHabilNavigation)
                    .WithMany(p => p.ParametrosHoraHabilDetalles)
                    .HasForeignKey(d => d.IdParametrosHoraHabil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParametrosHoraHabilDetalle_ParametrosHoraHabil");
            });

            modelBuilder.Entity<Parcial_BonosTXT>(entity =>
            {
                entity.ToTable("Parcial_BonosTXT");

                entity.Property(e => e.Familiar)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Imp_tot_h)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.T_emite)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.a_numero)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.fecha_e)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.fecha_v)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.imp_afi_g)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.nro_aut)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.o_social_)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("o_social ");

                entity.Property(e => e.operador)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.p_codigo)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.suc_aut)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pat_Biene>(entity =>
            {
                entity.HasKey(e => e.IdBien);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.DebeCompra)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.DebeDepr)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCrea)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaModi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HaberCompra)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.HaberDepr)
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Valor).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Valorresidual).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.IdGrupo_BienNavigation)
                    .WithMany(p => p.Pat_Bienes)
                    .HasForeignKey(d => d.IdGrupo_Bien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pat_Bienes_Pat_GrupoBienes");
            });

            modelBuilder.Entity<Pat_DepreciacionDetalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle);

                entity.ToTable("Pat_DepreciacionDetalle");

                entity.Property(e => e.Depreciacion).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.FechaCrea)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.ValorBien).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.opCrea)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.HasOne(d => d.IdBienNavigation)
                    .WithMany(p => p.Pat_DepreciacionDetalles)
                    .HasForeignKey(d => d.IdBien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pat_DepreciacionDetalle_Pat_Bienes");

                entity.HasOne(d => d.IdResumenNavigation)
                    .WithMany(p => p.Pat_DepreciacionDetalles)
                    .HasForeignKey(d => d.IdResumen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pat_DepreciacionDetalle_Pat_Depreciacion_Resumen");
            });

            modelBuilder.Entity<Pat_Depreciacion_Resuman>(entity =>
            {
                entity.HasKey(e => e.IdResumen);

                entity.Property(e => e.FechaModi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.fechaCrea)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Pat_GrupoBiene>(entity =>
            {
                entity.HasKey(e => e.IdGrupo_Bien);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaModi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pat_Mejora>(entity =>
            {
                entity.HasKey(e => e.IdMotivo);

                entity.ToTable("Pat_Mejora");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCrea)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaModi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Valor).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdBienNavigation)
                    .WithMany(p => p.Pat_Mejoras)
                    .HasForeignKey(d => d.IdBien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pat_Mejora_Pat_Bienes");
            });

            modelBuilder.Entity<Pat_Movimiento>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaCrea)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaModi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaMov)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdMovimiento).ValueGeneratedOnAdd();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.TipoMov)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdSectorDestinoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSectorDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pat_Movimientos_Sectores_Iosep1");

                entity.HasOne(d => d.IdSectorOrigenNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSectorOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pat_Movimientos_Sectores_Iosep");
            });

            modelBuilder.Entity<Pat_Reparacion>(entity =>
            {
                entity.HasKey(e => e.IdReparacion);

                entity.ToTable("Pat_Reparacion");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCrea)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaModi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pat_Reparacion_Detalle>(entity =>
            {
                entity.HasKey(e => e.IdRepDetalle);

                entity.ToTable("Pat_Reparacion_Detalle");

                entity.Property(e => e.FechaCrea)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaModi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.HasOne(d => d.IdBienNavigation)
                    .WithMany(p => p.Pat_Reparacion_Detalles)
                    .HasForeignKey(d => d.IdBien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pat_Reparacion_Detalle_Pat_Bienes");

                entity.HasOne(d => d.IdReparacionNavigation)
                    .WithMany(p => p.Pat_Reparacion_Detalles)
                    .HasForeignKey(d => d.IdReparacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pat_Reparacion_Detalle_Pat_Reparacion");

                entity.HasOne(d => d.IdSectorNavigation)
                    .WithMany(p => p.Pat_Reparacion_Detalles)
                    .HasForeignKey(d => d.IdSector)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pat_Reparacion_Detalle_Sectores_Iosep");
            });

            modelBuilder.Entity<Patologia>(entity =>
            {
                entity.HasKey(e => e.IdPatologia);

                entity.Property(e => e.Patologia1)
                    .HasMaxLength(50)
                    .HasColumnName("Patologia")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PedidoInterno_Detalle>(entity =>
            {
                entity.HasKey(e => e.PedidoInternoDetalleId);

                entity.ToTable("PedidoInterno_Detalle");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.OpModi).HasMaxLength(11);

                entity.Property(e => e.Precio_Unitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tipo_Entrega)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdMotivoNavigation)
                    .WithMany(p => p.PedidoInterno_Detalles)
                    .HasForeignKey(d => d.IdMotivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoInterno_Detalle_PedidoInterno_Motivo");

                entity.HasOne(d => d.PedidoInternoEncabezado)
                    .WithMany(p => p.PedidoInterno_Detalles)
                    .HasForeignKey(d => d.PedidoInternoEncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoInterno_Detalle_PedidoInterno_Encabezado");
            });

            modelBuilder.Entity<PedidoInterno_Encabezado>(entity =>
            {
                entity.HasKey(e => e.PedidoInternoEncabezadoId);

                entity.ToTable("PedidoInterno_Encabezado");

                entity.Property(e => e.Anio)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EstimativoTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Numero_PedidoInterno)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Remito_Proveedor)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.Destino_Sector)
                    .WithMany(p => p.PedidoInterno_EncabezadoDestino_Sectors)
                    .HasForeignKey(d => d.Destino_SectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoInterno_Encabezado_Sectores_Iosep1");

                entity.HasOne(d => d.Solicita_Sector)
                    .WithMany(p => p.PedidoInterno_EncabezadoSolicita_Sectors)
                    .HasForeignKey(d => d.Solicita_SectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoInterno_Encabezado_Sectores_Iosep");

                entity.HasOne(d => d.TipoPedidoInterno)
                    .WithMany(p => p.PedidoInterno_Encabezados)
                    .HasForeignKey(d => d.TipoPedidoInternoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoInterno_Encabezado_Tipo_PedidoInterno");
            });

            modelBuilder.Entity<PedidoInterno_Motivo>(entity =>
            {
                entity.ToTable("PedidoInterno_Motivo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PedidoInterno_NotaPedido>(entity =>
            {
                entity.HasKey(e => e.PedidoInternoNotaPedidoId);

                entity.ToTable("PedidoInterno_NotaPedido");

                entity.HasOne(d => d.NotaPedidoDetalle)
                    .WithMany(p => p.PedidoInterno_NotaPedidos)
                    .HasForeignKey(d => d.NotaPedidoDetalleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoInterno_NotaPedido_NotaPedido_Detalle");

                entity.HasOne(d => d.PedidoInternoDetalleo)
                    .WithMany(p => p.PedidoInterno_NotaPedidos)
                    .HasForeignKey(d => d.PedidoInternoDetalleoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PedidoInterno_NotaPedido_PedidoInterno_Detalle");
            });

            modelBuilder.Entity<PeriodosFacturacion>(entity =>
            {
                entity.HasKey(e => e.PeriodoFacturacionID);

                entity.ToTable("PeriodosFacturacion");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CBU)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Clave_Tributaria)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Conograma)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio_Laboral)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Alta).HasColumnType("date");

                entity.Property(e => e.Fecha_Baja).HasColumnType("date");

                entity.Property(e => e.Fecha_Nacimiento).HasColumnType("date");

                entity.Property(e => e.IdClasificaGasto).HasComment("Código de clasificación...Indica cual es el id del clasificador de gastos.");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Cuenta)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Razon_Social)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .HasComment("Referencia al usuario de la tabla iosepweb.dbo.aspnetuser");

                entity.HasOne(d => d.SituacionTrib)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.SituacionTribID)
                    .HasConstraintName("FK_Personas_SituacionTributaria");
            });

            modelBuilder.Entity<Persona_Tipo>(entity =>
            {
                entity.HasKey(e => e.TipoPersonaID);

                entity.ToTable("Persona_Tipo");

                entity.Property(e => e.TipoPersonaID).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Tabla)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Personas_TipoDetalle>(entity =>
            {
                entity.HasKey(e => e.TipoDetalleID);

                entity.ToTable("Personas_TipoDetalle");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Personas_TipoDetalles)
                    .HasForeignKey(d => d.PersonaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personas_TipoDetalle_Personas");

                entity.HasOne(d => d.TipoPersona)
                    .WithMany(p => p.Personas_TipoDetalles)
                    .HasForeignKey(d => d.TipoPersonaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personas_TipoDetalle_Persona_Tipo");
            });

            modelBuilder.Entity<PlanDiagnostico>(entity =>
            {
                entity.ToTable("PlanDiagnostico");

                entity.Property(e => e.CartaPresentacionID).HasDefaultValueSql("((0))");

                entity.Property(e => e.EsquemaID).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.IdAfiliado).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdPlan).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdPlanes_Afiliado).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdPlanes_AfiliadoNavigation)
                    .WithMany(p => p.PlanDiagnosticos)
                    .HasForeignKey(d => d.IdPlanes_Afiliado)
                    .HasConstraintName("FK_PlanDiagnostico_Planes_Afiliado");
            });

            modelBuilder.Entity<PlanDiasCobertura>(entity =>
            {
                entity.ToTable("PlanDiasCobertura");

                entity.Property(e => e.Cobertura).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PlanEspecialidade>(entity =>
            {
                entity.HasKey(e => e.PlanEspecialidadID);

                entity.Property(e => e.CartaPresentacionID).HasDefaultValueSql("((0))");

                entity.Property(e => e.EsquemaID).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.IdPlanes_Afiliado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PlanMotivosDerivacion>(entity =>
            {
                entity.ToTable("PlanMotivosDerivacion");

                entity.Property(e => e.CartaPresentacionID).HasDefaultValueSql("((0))");

                entity.Property(e => e.EsquemaID).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.IdPlanes_Afiliado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PlanTipoOperabilidad>(entity =>
            {
                entity.ToTable("PlanTipoOperabilidad");

                entity.Property(e => e.CartaPresentacionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.EsquemaID).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.IdPlanes_Afiliado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PlanUsuario>(entity =>
            {
                entity.ToTable("PlanUsuario");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.OperadorAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorMod)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioID).HasMaxLength(128);
            });

            modelBuilder.Entity<Plane>(entity =>
            {
                entity.HasKey(e => e.IdPlan)
                    .HasName("PK_Planes_1");

                entity.Property(e => e.CambBono).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OperModif)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Relacion)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PlanesAfiliado_Resolucion>(entity =>
            {
                entity.HasKey(e => e.IdPlanesAfiliado_Resolucion);

                entity.ToTable("PlanesAfiliado_Resolucion");

                entity.Property(e => e.CartaPresentacionID).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.ModificaFecha).HasColumnType("datetime");

                entity.Property(e => e.ModificaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.NroExpediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ref_Expediente).IsUnicode(false);

                entity.Property(e => e.Ref_Resolucion).IsUnicode(false);

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento).HasColumnType("datetime");
            });

            modelBuilder.Entity<Planes_Afiliado>(entity =>
            {
                entity.HasKey(e => e.IdPlanes_Afiliado)
                    .HasName("PK_Planes_Esquema");

                entity.ToTable("Planes_Afiliado");

                entity.HasIndex(e => e.IdAfiliado, "Index_IdAfiliado");

                entity.HasIndex(e => new { e.IdPlan, e.Anulado }, "Indice1");

                entity.HasIndex(e => new { e.IdPlan, e.Anulado, e.Inicio }, "Indice2");

                entity.Property(e => e.Acompaniante).HasDefaultValueSql("((0))");

                entity.Property(e => e.AnulaFecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AnulaOperador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.CantAcompaniantes).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantHorasAutorizadas).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantKilometros)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoberturaTransporte)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsultaCantExtraOrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsultasCantidadTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsultasReconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsultasReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EscuelaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.FarmaciaCantExtraOrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.FarmaciaCantidadTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.FarmaciaReconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FarmaciaReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngresoPlan).HasColumnType("date");

                entity.Property(e => e.FechaProbableParto).HasColumnType("date");

                entity.Property(e => e.FechaRenovacion).HasColumnType("date");

                entity.Property(e => e.FrecuenciaTipoConsulta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FrecuenciaTipoFarmacia)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inicio)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaestraId).HasDefaultValueSql("((0))");

                entity.Property(e => e.MotivoAnulaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Padres).HasDefaultValueSql("((0))");

                entity.Property(e => e.TurnoId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TutorId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ValOrdenCon).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValOrdenFar).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vencimiento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VencimientoAnterior).HasColumnType("datetime");

                entity.HasOne(d => d.IdAfiliadoNavigation)
                    .WithMany(p => p.Planes_Afiliados)
                    .HasForeignKey(d => d.IdAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planes_Afiliado_Afiliados");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.Planes_Afiliados)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planes_Afiliado_Planes");
            });

            modelBuilder.Entity<Planes_Detalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle_Planes)
                    .HasName("PK_Planes");

                entity.ToTable("Planes_Detalle");

                entity.Property(e => e.AnulaFecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AnulaOperador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ConsultasReconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsultasReconoceTipo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.FarmaciaReconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FarmaciaReconoceTipo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FrecuenciaTipo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('S')")
                    .IsFixedLength()
                    .HasComment("S: Semanal - M:Mensual - B:Bimestral - Q:Cuatrimestral - T:Semestral - A:Anual");

                entity.Property(e => e.FrecuenciaTipoConsulta)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')")
                    .IsFixedLength()
                    .HasComment("S: Semanal - M:Mensual - B:Bimestral - Q:Cuatrimestral - T:Semestral - A:Anual");

                entity.Property(e => e.FrecuenciaTipoFarmacia)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')")
                    .IsFixedLength()
                    .HasComment("S: Semanal - M:Mensual - B:Bimestral - Q:Cuatrimestral - T:Semestral - A:Anual");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.ValOrdenCon).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValOrdenFar).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.Planes_Detalles)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_Planes_Planes");
            });

            modelBuilder.Entity<Planes_VigenciaOnline>(entity =>
            {
                entity.HasKey(e => e.VigenciaOnlineID);

                entity.ToTable("Planes_VigenciaOnline");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.VigenciaDesde).HasColumnType("date");

                entity.Property(e => e.VigenciaHasta).HasColumnType("date");
            });

            modelBuilder.Entity<PorcentajeVium>(entity =>
            {
                entity.HasKey(e => e.PorcentajeViaID);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.NumeroCirugia)
                    .WithMany(p => p.PorcentajeVia)
                    .HasForeignKey(d => d.NumeroCirugiaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PorcentajeVia_NumeroCirugia");

                entity.HasOne(d => d.TipoVia)
                    .WithMany(p => p.PorcentajeVia)
                    .HasForeignKey(d => d.TipoViaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PorcentajeVia_TipoVia");
            });

            modelBuilder.Entity<Practica>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.coseguro_gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.coseguro_honorario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.idpractica).ValueGeneratedOnAdd();

                entity.Property(e => e.reconoce_gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.reconoce_honorarios).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<PracticaCarencium>(entity =>
            {
                entity.HasKey(e => e.IdPracticaCarencia);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PracticaFechaVencimiento>(entity =>
            {
                entity.ToTable("PracticaFechaVencimiento");

                entity.Property(e => e.FechaCambia).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimientoNueva).HasColumnType("date");

                entity.Property(e => e.FechaVencimientoOriginal).HasColumnType("date");

                entity.Property(e => e.UsuarioCambia)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PracticaPlanAutorizacion>(entity =>
            {
                entity.ToTable("PracticaPlanAutorizacion");

                entity.Property(e => e.DescripcionCobertura).HasMaxLength(250);
            });

            modelBuilder.Entity<PracticaPlanAutorizacionPresup>(entity =>
            {
                entity.ToTable("PracticaPlanAutorizacionPresup");

                entity.Property(e => e.DescripcionCobertura).HasMaxLength(250);
            });

            modelBuilder.Entity<PracticaPlanPresupAuditorium>(entity =>
            {
                entity.HasKey(e => e.PracticaPlanPresupAuditoriaID);

                entity.Property(e => e.DescripcionCobertura).HasMaxLength(250);
            });

            modelBuilder.Entity<PracticaTurno>(entity =>
            {
                entity.HasOne(d => d.IdPractica_BaseNavigation)
                    .WithMany(p => p.PracticaTurnos)
                    .HasForeignKey(d => d.IdPractica_Base)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticaTurnos_PracticaTurnos");
            });

            modelBuilder.Entity<PracticasDelegacion>(entity =>
            {
                entity.HasKey(e => e.IdPracticaDelegacion);

                entity.ToTable("PracticasDelegacion");

                entity.Property(e => e.IdPracticaDelegacion).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.UserCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDelegacionNavigation)
                    .WithMany(p => p.PracticasDelegacions)
                    .HasForeignKey(d => d.IdDelegacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticasDelegacion_Delegaciones");

                entity.HasOne(d => d.IdPracticaDelegacionNavigation)
                    .WithOne(p => p.PracticasDelegacion)
                    .HasForeignKey<PracticasDelegacion>(d => d.IdPracticaDelegacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticasDelegacion_NPracticas_Base");
            });

            modelBuilder.Entity<Practicas_esquema>(entity =>
            {
                entity.HasKey(e => e.IdPracticasEsquemas);

                entity.ToTable("Practicas_esquema");

                entity.Property(e => e.CincoMeses).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.IdPlan).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.InicioResol).HasColumnType("datetime");

                entity.Property(e => e.Modifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModificaFecha).HasColumnType("datetime");

                entity.Property(e => e.MotivoAnulaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.NroExpediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.PorUnicaVez).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReconoceTipo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'%')")
                    .IsFixedLength();

                entity.Property(e => e.Ref_Expediente).IsUnicode(false);

                entity.Property(e => e.Ref_Resolucion).IsUnicode(false);

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Semanal).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoFrecuenciaID)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento).HasColumnType("datetime");

                entity.Property(e => e.VencimientoResol).HasColumnType("datetime");

                entity.HasOne(d => d.IdEsquemaNavigation)
                    .WithMany(p => p.Practicas_esquemas)
                    .HasForeignKey(d => d.IdEsquema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Practicas_esquema_Esquemas_Afiliado");
            });

            modelBuilder.Entity<Practicas_plane>(entity =>
            {
                entity.HasKey(e => e.IdPracticasPlan)
                    .HasName("PK_Practicas_Planes");

                entity.Property(e => e.Auditoria).HasDefaultValueSql("((0))");

                entity.Property(e => e.CincoMeses).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOperador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.IdPlan).HasDefaultValueSql("((0))");

                entity.Property(e => e.Informa).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.InicioResol).HasColumnType("datetime");

                entity.Property(e => e.Modifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ModificaFecha).HasColumnType("datetime");

                entity.Property(e => e.PorUnicaVez).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReconoceTipo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'%')")
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento).HasColumnType("datetime");

                entity.Property(e => e.VencimientoResol).HasColumnType("datetime");

                entity.Property(e => e.ViaID).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdDetalle_PlanesNavigation)
                    .WithMany(p => p.Practicas_planes)
                    .HasForeignKey(d => d.IdDetalle_Planes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Practicas_Planes_Detalle_Planes");
            });

            modelBuilder.Entity<PreciosAclise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PreciosAclise");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.F8).HasMaxLength(255);

                entity.Property(e => e.Gastos).HasMaxLength(255);

                entity.Property(e => e.Honorario).HasMaxLength(255);

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.NuevoGastos).HasMaxLength(255);

                entity.Property(e => e.NuevoHon).HasMaxLength(255);

                entity.Property(e => e._Sin_nombre_de_columna_)
                    .HasColumnType("datetime")
                    .HasColumnName("(Sin nombre de columna)");
            });

            modelBuilder.Entity<PreciosColegio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PreciosColegio");

                entity.Property(e => e.Codigo).HasMaxLength(6);

                entity.Property(e => e.F8).HasMaxLength(255);

                entity.Property(e => e.Gastos).HasMaxLength(255);

                entity.Property(e => e.Honorario).HasMaxLength(255);

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.NuevoGastos).HasMaxLength(255);

                entity.Property(e => e.NuevoHon).HasMaxLength(255);

                entity.Property(e => e._Sin_nombre_de_columna_)
                    .HasColumnType("datetime")
                    .HasColumnName("(Sin nombre de columna)");
            });

            modelBuilder.Entity<PrescripcionElectronica>(entity =>
            {
                entity.HasKey(e => e.IdPrescripcionElectronica);

                entity.ToTable("PrescripcionElectronica");

                entity.Property(e => e.BeneficiarioCUIL).HasMaxLength(11);

                entity.Property(e => e.BeneficiarioCelular).HasMaxLength(20);

                entity.Property(e => e.BeneficiarioCorreo).HasMaxLength(100);

                entity.Property(e => e.BeneficiarioDocumento).HasMaxLength(10);

                entity.Property(e => e.BeneficiarioNombre).HasMaxLength(100);

                entity.Property(e => e.BeneficiarioNumero).HasMaxLength(15);

                entity.Property(e => e.BeneficiarioTipoDocumento).HasMaxLength(5);

                entity.Property(e => e.CodigoRNOS).HasMaxLength(10);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.ObraSocial).HasMaxLength(250);

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.PrescriptorCUIT).HasMaxLength(11);

                entity.Property(e => e.PrescriptorMatricula).HasMaxLength(10);

                entity.Property(e => e.PrescriptorNombre).HasMaxLength(150);
            });

            modelBuilder.Entity<PrescripcionRecetum>(entity =>
            {
                entity.HasKey(e => e.IdPrescripcionReceta);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Numero).HasMaxLength(50);

                entity.Property(e => e.OpCrea).HasMaxLength(11);
            });

            modelBuilder.Entity<PrescripcionRenglon>(entity =>
            {
                entity.HasKey(e => e.IdPrescripcionRenglon);

                entity.ToTable("PrescripcionRenglon");

                entity.Property(e => e.CIE10).HasMaxLength(6);

                entity.Property(e => e.CantidadEnvases).HasMaxLength(5);

                entity.Property(e => e.Diagnostico).HasMaxLength(150);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.ProductoCodigoAlfaBeta).HasMaxLength(10);

                entity.Property(e => e.ProductoCodigoBarras).HasMaxLength(50);

                entity.Property(e => e.ProductoTroquel).HasMaxLength(25);

                entity.Property(e => e.TipoPrescripcion).HasMaxLength(5);
            });

            modelBuilder.Entity<PrestPlanificacion>(entity =>
            {
                entity.ToTable("PrestPlanificacion");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrestPlanificacionDetalle>(entity =>
            {
                entity.ToTable("PrestPlanificacionDetalle");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraHasta).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrestadorBloqueoDesbloqueo>(entity =>
            {
                entity.HasKey(e => e.BloqueoDesbloqueoID);

                entity.ToTable("PrestadorBloqueoDesbloqueo");

                entity.Property(e => e.FechaBloqueoDesbloqueo).HasColumnType("datetime");

                entity.Property(e => e.UsuarioBloqueoDesb)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrestadorDDJJ>(entity =>
            {
                entity.ToTable("PrestadorDDJJ");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CIU)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CelularParticular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoColegio).HasMaxLength(10);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.DomicilioParticular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModEstado).HasColumnType("datetime");

                entity.Property(e => e.MatriculaProfesional)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumExpediente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelFijoParticular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioModEstado)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.PrestadorEstado)
                    .WithMany(p => p.PrestadorDDJJs)
                    .HasForeignKey(d => d.PrestadorEstadoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJ_PrestadorEstado");

                entity.HasOne(d => d.TipoCondicionIva)
                    .WithMany(p => p.PrestadorDDJJs)
                    .HasForeignKey(d => d.TipoCondicionIvaID)
                    .HasConstraintName("FK_PrestadorDDJJ_TipoCondicionIVA");

                entity.HasOne(d => d.TipoPrestador)
                    .WithMany(p => p.PrestadorDDJJs)
                    .HasForeignKey(d => d.TipoPrestadorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJ_TipoPrestadorDDJJ");

                entity.HasOne(d => d.TituloProfesional)
                    .WithMany(p => p.PrestadorDDJJs)
                    .HasForeignKey(d => d.TituloProfesionalID)
                    .HasConstraintName("FK_PrestadorDDJJ_TituloProfesional");
            });

            modelBuilder.Entity<PrestadorDDJJAcreditacionMedica>(entity =>
            {
                entity.ToTable("PrestadorDDJJAcreditacionMedica");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.NroExpediente)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.AcreditacionesMedica)
                    .WithMany(p => p.PrestadorDDJJAcreditacionMedicas)
                    .HasForeignKey(d => d.AcreditacionesMedicaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJAcreditacionMedica_AcreditacionesMedica");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorDDJJAcreditacionMedicas)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJAcreditacionMedica_PrestadorDDJJ");
            });

            modelBuilder.Entity<PrestadorDDJJDomiciliosHabilitado>(entity =>
            {
                entity.HasKey(e => e.PrestadorDDJJDomiciliosHabilitadosID);

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.HasOne(d => d.DomiciliosHabiltados)
                    .WithMany(p => p.PrestadorDDJJDomiciliosHabilitados)
                    .HasForeignKey(d => d.DomiciliosHabiltadosID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJDomiciliosHabilitados_DomiciliosHabiltados");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorDDJJDomiciliosHabilitados)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJDomiciliosHabilitados_PrestadorDDJJ");
            });

            modelBuilder.Entity<PrestadorDDJJEquiposPractica>(entity =>
            {
                entity.HasKey(e => e.PrestadorDDJJEquiposPracticasID);

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.NComprobante)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NExpediente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.EquiposPracticas)
                    .WithMany(p => p.PrestadorDDJJEquiposPracticas)
                    .HasForeignKey(d => d.EquiposPracticasID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJEquiposPracticas_EquiposPracticas");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorDDJJEquiposPracticas)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJEquiposPracticas_PrestadorDDJJ");
            });

            modelBuilder.Entity<PrestadorDDJJGerenciador>(entity =>
            {
                entity.ToTable("PrestadorDDJJGerenciador");

                entity.Property(e => e.CondigoIdentificador)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.HasOne(d => d.Gerenciador)
                    .WithMany(p => p.PrestadorDDJJGerenciadors)
                    .HasForeignKey(d => d.GerenciadorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJGerenciador_Gerenciador");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorDDJJGerenciadors)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJGerenciador_PrestadorDDJJ");
            });

            modelBuilder.Entity<PrestadorDDJJReclamo>(entity =>
            {
                entity.ToTable("PrestadorDDJJReclamo");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaReclamo).HasColumnType("date");

                entity.Property(e => e.NumExpediente).HasMaxLength(20);

                entity.Property(e => e.Observaciones).HasMaxLength(200);

                entity.Property(e => e.Usuario).HasMaxLength(30);

                entity.HasOne(d => d.MotivoReclamo)
                    .WithMany(p => p.PrestadorDDJJReclamos)
                    .HasForeignKey(d => d.MotivoReclamoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJReclamo_PrestadorMotivoReclamo");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorDDJJReclamos)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJReclamo_PrestadorDDJJ");
            });

            modelBuilder.Entity<PrestadorDDJJServicioCentro>(entity =>
            {
                entity.ToTable("PrestadorDDJJServicioCentro");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorDDJJServicioCentroPrestadorDDJJs)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJServicioCentro_PrestadorDDJJ1");

                entity.HasOne(d => d.PrestadorDDJJIDaCargoNavigation)
                    .WithMany(p => p.PrestadorDDJJServicioCentroPrestadorDDJJIDaCargoNavigations)
                    .HasForeignKey(d => d.PrestadorDDJJIDaCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJServicioCentro_PrestadorDDJJ");

                entity.HasOne(d => d.ServicioCentro)
                    .WithMany(p => p.PrestadorDDJJServicioCentros)
                    .HasForeignKey(d => d.ServicioCentroID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJServicioCentro_ServicoCentro");
            });

            modelBuilder.Entity<PrestadorDDJJServicioRealiza>(entity =>
            {
                entity.ToTable("PrestadorDDJJServicioRealiza");

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.FechaBaja).HasColumnType("date");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorDDJJServicioRealizas)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJServicioRealiza_PrestadorDDJJ");

                entity.HasOne(d => d.ServicoRealiza)
                    .WithMany(p => p.PrestadorDDJJServicioRealizas)
                    .HasForeignKey(d => d.ServicoRealizaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJServicioRealiza_ServicoRealiza");
            });

            modelBuilder.Entity<PrestadorDDJJSuspendido>(entity =>
            {
                entity.ToTable("PrestadorDDJJSuspendido");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaSuspendidoDesde).HasColumnType("date");

                entity.Property(e => e.FechaSuspendidoHasta).HasColumnType("date");

                entity.Property(e => e.NumExpediente).HasMaxLength(20);

                entity.Property(e => e.NumResolucion).HasMaxLength(20);

                entity.Property(e => e.Observaciones).HasMaxLength(200);

                entity.Property(e => e.Usuario).HasMaxLength(30);

                entity.HasOne(d => d.MotivoSuspension)
                    .WithMany(p => p.PrestadorDDJJSuspendidos)
                    .HasForeignKey(d => d.MotivoSuspensionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJSuspendido_PrestadorMotivoSuspension");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorDDJJSuspendidos)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDDJJSuspendido_PrestadorDDJJ");
            });

            modelBuilder.Entity<PrestadorEspecialidadDDJJ>(entity =>
            {
                entity.ToTable("PrestadorEspecialidadDDJJ");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.MatriculaEspecialidad)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NroExpediente)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.EspecialidadDDJJ)
                    .WithMany(p => p.PrestadorEspecialidadDDJJs)
                    .HasForeignKey(d => d.EspecialidadDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorEspecialidadDDJJ_EspecialidadDDJJ");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorEspecialidadDDJJs)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorEspecialidadDDJJ_PrestadorDDJJ");
            });

            modelBuilder.Entity<PrestadorEstado>(entity =>
            {
                entity.ToTable("PrestadorEstado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrestadorEstadoHistorico>(entity =>
            {
                entity.ToTable("PrestadorEstadoHistorico");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorEstadoHistoricos)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorEstadoHistorico_PrestadorDDJJ");

                entity.HasOne(d => d.PrestadorEstado)
                    .WithMany(p => p.PrestadorEstadoHistoricos)
                    .HasForeignKey(d => d.PrestadorEstadoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorEstadoHistorico_PrestadorEstado");
            });

            modelBuilder.Entity<PrestadorHabilitacion>(entity =>
            {
                entity.ToTable("PrestadorHabilitacion");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.PrestadorHabilitacions)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorHabilitacion_PrestadorDDJJ");
            });

            modelBuilder.Entity<PrestadorMotivoReclamo>(entity =>
            {
                entity.ToTable("PrestadorMotivoReclamo");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<PrestadorMotivoSuspension>(entity =>
            {
                entity.ToTable("PrestadorMotivoSuspension");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Prestadore>(entity =>
            {
                entity.HasKey(e => e.idprestador);

                entity.HasIndex(e => e.cuil, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => e.matricula, "IX_Matricula");

                entity.Property(e => e.CODIGO)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CONTACTO)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.CodNomenclador)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Codigo_Colegio)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.DESCESP)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Descuento).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ESPECIAL)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.E_FECHA).HasColumnType("date");

                entity.Property(e => e.FECHACOL).HasColumnType("date");

                entity.Property(e => e.F_INACT).HasColumnType("date");

                entity.Property(e => e.GANANCIAS)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.GS_FECHA).HasColumnType("date");

                entity.Property(e => e.HS_FECHA).HasColumnType("date");

                entity.Property(e => e.INTERMEDIA)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.I_BRUTOS)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.I_FECHA).HasColumnType("date");

                entity.Property(e => e.LOCALIDAD)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.M_NRO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.NRO_BRU)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.NRO_GAN)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.NRO_INSTI)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NRO_IVA)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.NRO_MUN)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OBS)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.PLUS_FECHA).HasColumnType("date");

                entity.Property(e => e.PLUS_NRO)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.PROVINCIA)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.TELEFONO)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ZONA)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.matricula).HasMaxLength(9);

                entity.Property(e => e.nombre).HasMaxLength(200);

                entity.HasOne(d => d.TipoPrestador)
                    .WithMany(p => p.Prestadores)
                    .HasForeignKey(d => d.TipoPrestadorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestadores_TipoPrestador");
            });

            modelBuilder.Entity<PrestadoresCobise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PrestadoresCobise");

                entity.Property(e => e.NOMBRE).HasMaxLength(255);
            });

            modelBuilder.Entity<PrestadoresMatriculado>(entity =>
            {
                entity.HasKey(e => e.IdPrestador);

                entity.Property(e => e.Caducidad).HasColumnType("date");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Obtencion).HasColumnType("date");

                entity.Property(e => e.Revalida)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrestadoresMatriculadosCopium>(entity =>
            {
                entity.HasKey(e => e.IdPrestador)
                    .HasName("PK_PrestadoresMatriculados2");

                entity.Property(e => e.Caducidad).HasColumnType("date");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Obtencion).HasColumnType("date");

                entity.Property(e => e.Revalida)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrestadoresMatriculados_>(entity =>
            {
                entity.HasKey(e => e.IdPrestador);

                entity.ToTable("PrestadoresMatriculados$");

                entity.Property(e => e.IdPrestador).ValueGeneratedNever();

                entity.Property(e => e.Caducidad).HasColumnType("date");

                entity.Property(e => e.Especialidad).HasMaxLength(255);

                entity.Property(e => e.Matricula).HasMaxLength(6);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.Obtención).HasColumnType("date");

                entity.Property(e => e.Revalida).HasMaxLength(5);
            });

            modelBuilder.Entity<PrestadoresNovedadTrigger>(entity =>
            {
                entity.HasKey(e => e.IdPrestadorNovedad)
                    .HasName("PK_PrestadoresNovedad");

                entity.ToTable("PrestadoresNovedadTrigger");

                entity.Property(e => e.CUIL)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoFijo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Presupuesto>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdPresupuesto).ValueGeneratedOnAdd();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Presupuesto_Contable>(entity =>
            {
                entity.HasKey(e => e.PresupuestoContableId);

                entity.ToTable("Presupuesto_Contable");

                entity.Property(e => e.Anio)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Expediente)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Aprobacion).HasColumnType("date");
            });

            modelBuilder.Entity<Presupuesto_Motivo>(entity =>
            {
                entity.HasKey(e => e.PresupuestoMotivoId);

                entity.ToTable("Presupuesto_Motivo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PresupuestosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdPresupuestoDetalle)
                    .HasName("PK_PresupuestoDetalle");

                entity.ToTable("PresupuestosDetalle");

                entity.Property(e => e.Auditor_Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodigoPractica)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Prescripcion)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.TipoIdAutoriza).HasComment("0 = vacio 1 = Practica 2= Medicamentos");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCoseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalIosep).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ProfesionalXFarmacium>(entity =>
            {
                entity.HasKey(e => e.ProfesionalXFarmaciaID);

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.ProfesionalXFarmacia)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfesionalXFarmacia_PrestadorDDJJ");
            });

            modelBuilder.Entity<ProtesisDetalleSolicitud>(entity =>
            {
                entity.ToTable("ProtesisDetalleSolicitud");

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.PrecioProtesis).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisDiagnosticoSolicitud>(entity =>
            {
                entity.ToTable("ProtesisDiagnosticoSolicitud");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisEncabezadoSolicitud>(entity =>
            {
                entity.ToTable("ProtesisEncabezadoSolicitud");

                entity.Property(e => e.CodigoSolicitud)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaCirugia).HasColumnType("date");

                entity.Property(e => e.FechaExpediente).HasColumnType("date");

                entity.Property(e => e.FechaSolicitud).HasColumnType("date");

                entity.Property(e => e.FechaVinculacion).HasColumnType("datetime");

                entity.Property(e => e.MatriculaNacional)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisEspecialidad>(entity =>
            {
                entity.ToTable("ProtesisEspecialidad");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisGenerico>(entity =>
            {
                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisMarca>(entity =>
            {
                entity.HasKey(e => e.MarcaProtesisID)
                    .HasName("PK_MarcaProtesis");

                entity.ToTable("ProtesisMarca");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisNombreComercial>(entity =>
            {
                entity.ToTable("ProtesisNombreComercial");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisNomenclador>(entity =>
            {
                entity.ToTable("ProtesisNomenclador");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.PrecioReferencia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.VigenciaDesde).HasColumnType("date");

                entity.Property(e => e.VigenciaHasta).HasColumnType("date");
            });

            modelBuilder.Entity<ProtesisOrigen>(entity =>
            {
                entity.HasKey(e => e.OrigenProtesisID);

                entity.ToTable("ProtesisOrigen");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisPlan>(entity =>
            {
                entity.ToTable("ProtesisPlan");

                entity.Property(e => e.Cobertura).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisRubro>(entity =>
            {
                entity.Property(e => e.CodigoRubro).HasMaxLength(255);

                entity.Property(e => e.DescripcionRubro).HasMaxLength(255);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.ProveedorID);

                entity.Property(e => e.CBU)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CUIT)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Ingresos_Brutos)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Nombre_Fantasia)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Obra_Social)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Superficie).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Provincias_Paises");
            });

            modelBuilder.Entity<ProvistoPor>(entity =>
            {
                entity.ToTable("ProvistoPor");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioMod)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Prueba_duplicado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.numero)
                    .HasMaxLength(14)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Quirofano>(entity =>
            {
                entity.HasKey(e => e.IdQuirofano);

                entity.ToTable("Quirofano");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.Varios)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.HasOne(d => d.IdInternadoNavigation)
                    .WithMany(p => p.Quirofanos)
                    .HasForeignKey(d => d.IdInternado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quirofano_Internados");
            });

            modelBuilder.Entity<RadioColegio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RadioColegio");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.Gastos).HasColumnType("money");

                entity.Property(e => e.Honorario).HasColumnType("money");

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.NuevoGastos).HasColumnType("money");

                entity.Property(e => e.NuevoHon).HasColumnType("money");

                entity.Property(e => e._No_column_name_)
                    .HasColumnType("datetime")
                    .HasColumnName("(No column name)");
            });

            modelBuilder.Entity<Radiologium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CODIGO).HasMaxLength(255);

                entity.Property(e => e.F10).HasMaxLength(255);

                entity.Property(e => e.F11).HasMaxLength(255);

                entity.Property(e => e.F12).HasMaxLength(255);

                entity.Property(e => e.F13).HasMaxLength(255);

                entity.Property(e => e.F14).HasMaxLength(255);

                entity.Property(e => e.F15).HasMaxLength(255);

                entity.Property(e => e.F16).HasMaxLength(255);

                entity.Property(e => e.F17).HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F5).HasMaxLength(255);

                entity.Property(e => e.F6).HasMaxLength(255);

                entity.Property(e => e.F7).HasMaxLength(255);

                entity.Property(e => e.F8).HasMaxLength(255);

                entity.Property(e => e.F9).HasMaxLength(255);

                entity.Property(e => e.Gastos).HasColumnType("money");

                entity.Property(e => e.Honorarios).HasColumnType("money");

                entity.Property(e => e.NOMBRE).HasMaxLength(255);
            });

            modelBuilder.Entity<ReajusteCredito>(entity =>
            {
                entity.ToTable("ReajusteCredito");

                entity.Property(e => e.FechaReajuste).HasColumnType("datetime");

                entity.Property(e => e.MontoNotaCredito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MontoReajuste).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MontoTotalCred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.EncabezadoNotaDeCredito)
                    .WithMany(p => p.ReajusteCreditos)
                    .HasForeignKey(d => d.EncabezadoNotaDeCreditoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReajusteCredito_EncabezadoNotaDeCredito");
            });

            modelBuilder.Entity<RectificarPase>(entity =>
            {
                entity.HasKey(e => e.RectificaPaseID);

                entity.ToTable("RectificarPase");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Usuario).HasMaxLength(11);
            });

            modelBuilder.Entity<RedLink_ArchivoControl>(entity =>
            {
                entity.HasKey(e => e.ControlID);

                entity.ToTable("RedLink_ArchivoControl");

                entity.Property(e => e.Anulado)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.RF_FechaUltimoVencimiento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.RF_IdentificacionFinal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.RF_TotalPrimerVencimiento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RF_TotalSegundoVencimiento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RI_Codigo)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RI_Fecha)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.RI_IdentificacionInicio)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.RI_LongitudArchivo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RI_NombreArchivoRefresh)
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RedLink_ArchivoControlDetalle>(entity =>
            {
                entity.HasKey(e => e.ControlDetalleID);

                entity.ToTable("RedLink_ArchivoControlDetalle");

                entity.Property(e => e.IdentificacionDatos)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.SumaPrimerVencimientoLote).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SumaSegundoVencimientoLote).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<RedLink_ArchivoExtract>(entity =>
            {
                entity.HasKey(e => e.ExtractID)
                    .HasName("PK_redLing_ArchivoExtract");

                entity.ToTable("RedLink_ArchivoExtract");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.RF_SumaImportes).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.RF_TipoRegistro)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.RI_Codigo)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RI_FechaProceso)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.RI_TipoRegistro)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RedLink_ArchivoExtractDetalle>(entity =>
            {
                entity.HasKey(e => e.ExtractDetalleID)
                    .HasName("PK_RedLing_ArchivoExtractDetalle");

                entity.ToTable("RedLink_ArchivoExtractDetalle");

                entity.Property(e => e.Discrecional)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FechaPago)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.IdentificadorConcepto)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.IdentificadorDeuda)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.IdentificadorUsuario)
                    .HasMaxLength(19)
                    .IsFixedLength();

                entity.Property(e => e.ImportePagado).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TipoRegistro)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RedLink_ArchivoRefresh>(entity =>
            {
                entity.HasKey(e => e.EnvioID);

                entity.ToTable("RedLink_ArchivoRefresh");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NombreArchivo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.RF_IdentRegistro)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.RF_TotalPrimerVenc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RF_TotalSegundoVenc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RI_Codigo)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RI_FechaProc)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.RI_IdentRegistro)
                    .HasMaxLength(13)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RedLink_ArchivoRefreshDetalle>(entity =>
            {
                entity.HasKey(e => e.DetalleEnvioID);

                entity.ToTable("RedLink_ArchivoRefreshDetalle");

                entity.Property(e => e.Anulado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Discrecional)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FechaPrimerVencimiento)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.FechaSegundoVencimiento)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.IdentificacionUsuario)
                    .HasMaxLength(19)
                    .IsFixedLength();

                entity.Property(e => e.IdentificadorConcepto)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.IdentificadorDeuda)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.ImportePrimerVencimiento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteSegundoVencimiento).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ReemplazoOrden>(entity =>
            {
                entity.HasKey(e => e.IdReemplazoOrden);

                entity.ToTable("ReemplazoOrden");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.MotivoAnula).HasMaxLength(200);

                entity.Property(e => e.NuevoNumero).HasMaxLength(14);

                entity.Property(e => e.Numero)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RegionesSISA>(entity =>
            {
                entity.HasKey(e => e.IdRegion);

                entity.ToTable("RegionesSISA");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Superficie).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ReimpresionBonosPractica>(entity =>
            {
                entity.HasKey(e => e.ImpresionBonosID);
            });

            modelBuilder.Entity<ReintegroImporteAGerencium>(entity =>
            {
                entity.HasKey(e => e.ImporteAGerenciaID);

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReintegroNotasAuditor>(entity =>
            {
                entity.ToTable("ReintegroNotasAuditor");

                entity.Property(e => e.Auditor)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.SectorID).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ReintegroSectore>(entity =>
            {
                entity.HasKey(e => e.ReintegroSectoresID);

                entity.HasIndex(e => new { e.ReintegrosEncabezadoID, e.SectorDestinoID }, "Index");

                entity.HasIndex(e => new { e.ReintegrosEncabezadoID, e.SectorDestinoID }, "Index1");

                entity.Property(e => e.FechaEnvia).HasColumnType("datetime");

                entity.Property(e => e.UsuarioEnvia)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReintegroUsuarioSector>(entity =>
            {
                entity.ToTable("ReintegroUsuarioSector");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperMod)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioID).HasMaxLength(128);
            });

            modelBuilder.Entity<Reintegro_Debito>(entity =>
            {
                entity.HasKey(e => e.Reintegros_DebitosID);

                entity.Property(e => e.CantidadDebitada).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaDebito).HasColumnType("datetime");

                entity.Property(e => e.ImporteDebitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioDebita)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Reintegro_DescuentoIndebido>(entity =>
            {
                entity.HasKey(e => e.ReintegroDescuentoIndebidoID);

                entity.ToTable("Reintegro_DescuentoIndebido");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaAudita).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("datetime");

                entity.Property(e => e.HaberConAporte).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdFactura).HasDefaultValueSql("((0))");

                entity.Property(e => e.MesAnio)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.OperRechazo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TotalDescuento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAudita)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Reintegro_DetalleFactura>(entity =>
            {
                entity.HasKey(e => e.ReintegroDetalleFacturaID);

                entity.ToTable("Reintegro_DetalleFactura");

                entity.HasIndex(e => e.Anulado, "Index");

                entity.HasIndex(e => e.Anulado, "Index1");

                entity.Property(e => e.CAI).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazaGcia).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Comprobante).HasColumnType("date");

                entity.Property(e => e.IdPais).HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero_Comprobante).HasMaxLength(50);

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRechazaGcia)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRechazo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.PersonaID).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProveedorID).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ReintegrosEncabezado)
                    .WithMany(p => p.Reintegro_DetalleFacturas)
                    .HasForeignKey(d => d.ReintegrosEncabezadoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reintegro_DetalleFactura_Reintegros_Encabezado");

                entity.HasOne(d => d.TipoInstitucion)
                    .WithMany(p => p.Reintegro_DetalleFacturas)
                    .HasForeignKey(d => d.TipoInstitucionID)
                    .HasConstraintName("FK_Reintegro_DetalleFactura_Tipo_Institucion");
            });

            modelBuilder.Entity<Reintegro_DetalleMedicacion>(entity =>
            {
                entity.HasKey(e => e.ReintegroDetalleMedicacionID);

                entity.ToTable("Reintegro_DetalleMedicacion");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CantidadReintegrar).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaAudita).HasColumnType("datetime");

                entity.Property(e => e.FechaAuditaGcia).HasColumnType("datetime");

                entity.Property(e => e.FechaMarca).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazaGcia).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("datetime");

                entity.Property(e => e.IdFarmacia).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImporteACargoAfiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteACargoIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperAuditaGcia)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperMarca)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRechazaGcia)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRechazo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PersonaID).HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcentajeReconocido).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PrecioIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAudita)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdFarmaciaNavigation)
                    .WithMany(p => p.Reintegro_DetalleMedicacions)
                    .HasForeignKey(d => d.IdFarmacia)
                    .HasConstraintName("FK_Reintegro_DetalleMedicacion_Prestadores");

                entity.HasOne(d => d.ReintegroDetalleFactura)
                    .WithMany(p => p.Reintegro_DetalleMedicacions)
                    .HasForeignKey(d => d.ReintegroDetalleFacturaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reintegro_DetalleMedicacion_Reintegro_DetalleFactura");
            });

            modelBuilder.Entity<Reintegro_DetallePractica>(entity =>
            {
                entity.HasKey(e => e.ReintegroDetallePracticasID);

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CantidadReintegrar).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaAudita).HasColumnType("datetime");

                entity.Property(e => e.FechaAuditaGcia).HasColumnType("datetime");

                entity.Property(e => e.FechaMarca).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazaGcia).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("datetime");

                entity.Property(e => e.IdPrestador).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImporteACargoAfiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteACargoIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperAuditaGcia)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperMarca)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRechazaGcia)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRechazo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PersonaID).HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcentajeReconocido).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PrecioIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAudita)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.ReintegroDetalleFactura)
                    .WithMany(p => p.Reintegro_DetallePracticas)
                    .HasForeignKey(d => d.ReintegroDetalleFacturaID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reintegro_DetallePracticas_Reintegro_DetalleFactura");
            });

            modelBuilder.Entity<Reintegro_DetalleServicio>(entity =>
            {
                entity.HasKey(e => e.ReintegroDetalleServiciosID);

                entity.HasIndex(e => e.ReintegroDetalleFacturaID, "Index");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CantidadReintegrar).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaAudita).HasColumnType("datetime");

                entity.Property(e => e.FechaAuditaGcia).HasColumnType("datetime");

                entity.Property(e => e.FechaMarca).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazaGcia).HasColumnType("datetime");

                entity.Property(e => e.FechaRechazo).HasColumnType("datetime");

                entity.Property(e => e.ImporteACargoAfiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteACargoIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperAuditaGcia)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperMarca)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRechazaGcia)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRechazo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PersonaID).HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcentajeReconocido).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PrecioIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProveedorID).HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAudita)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReintegrosServicioIosep>(entity =>
            {
                entity.HasKey(e => e.ReintegroServicioIosepId);

                entity.ToTable("ReintegrosServicioIosep");

                entity.Property(e => e.CodServicio)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.FechaAnul).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.OperAnul)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperMod)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Reintegros_Encabezado>(entity =>
            {
                entity.HasKey(e => e.ReintegrosEncabezadoID);

                entity.ToTable("Reintegros_Encabezado");

                entity.HasIndex(e => new { e.Cheque_Emitido, e.Cheque_Entregado, e.Anulado, e.Informado, e.FinGerencia, e.NroTransferencia }, "Index");

                entity.Property(e => e.AAuditoria).HasColumnType("datetime");

                entity.Property(e => e.AAuditoriaGerencia).HasColumnType("datetime");

                entity.Property(e => e.AGerencia).HasColumnType("datetime");

                entity.Property(e => e.Cheque_Cobrado).HasColumnType("datetime");

                entity.Property(e => e.Cheque_Emitido).HasColumnType("datetime");

                entity.Property(e => e.Cheque_Entregado).HasColumnType("datetime");

                entity.Property(e => e.CuilChequeANomDe)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.EstadoDev)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'A')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaArchiva).HasColumnType("datetime");

                entity.Property(e => e.FechaExpediente).HasColumnType("datetime");

                entity.Property(e => e.FechaTransferencia).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Modificacion).HasColumnType("datetime");

                entity.Property(e => e.FinGerencia).HasColumnType("datetime");

                entity.Property(e => e.IdAfiliado).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdPrestador).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdProveedor).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdTitular).HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Cheque).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Informado).HasColumnType("datetime");

                entity.Property(e => e.Liquidado).HasColumnType("datetime");

                entity.Property(e => e.Liquidado_Prestador).HasColumnType("datetime");

                entity.Property(e => e.MontoTransferencia)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NotasAuditoria).HasDefaultValueSql("('')");

                entity.Property(e => e.NroTransferencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Numero_Cheque)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Resolucion)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Referencia_Expediente)
                    .HasMaxLength(256)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioArchiva)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Usuario_Crea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Usuario_Emite)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Usuario_Entrega)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Usuario_Gerencia)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Usuario_Informa)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Usuario_Liquida)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Usuario_Modif)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.TipoReintegro)
                    .WithMany(p => p.Reintegros_Encabezados)
                    .HasForeignKey(d => d.TipoReintegroID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reintegros_Encabezado_Tipo_Reintegro");
            });

            modelBuilder.Entity<RendicionCaja>(entity =>
            {
                entity.HasKey(e => e.RendicionID);

                entity.ToTable("RendicionCaja");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.IdFormaPago).HasDefaultValueSql("((1))");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdCierreNavigation)
                    .WithMany(p => p.RendicionCajas)
                    .HasForeignKey(d => d.IdCierre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RendicionCaja_CajaCierre");

                entity.HasOne(d => d.IdTurnoCajaNavigation)
                    .WithMany(p => p.RendicionCajas)
                    .HasForeignKey(d => d.IdTurnoCaja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RendicionCaja_TurnosCaja");
            });

            modelBuilder.Entity<Reparticione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.idreparticiones).ValueGeneratedOnAdd();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReporteRecupero>(entity =>
            {
                entity.ToTable("ReporteRecupero");

                entity.Property(e => e.Desde).HasMaxLength(12);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaReporte).HasColumnType("datetime");

                entity.Property(e => e.Hasta).HasMaxLength(12);

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioReporte)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReportesIosepSalud>(entity =>
            {
                entity.ToTable("ReportesIosepSalud");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaGenera).HasColumnType("datetime");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioGenera)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RestriccionEmision>(entity =>
            {
                entity.HasKey(e => e.IdRestriccionEmision);

                entity.ToTable("RestriccionEmision");

                entity.Property(e => e.ImprimeGrupoFamiliar)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ResultadoDiagnostico>(entity =>
            {
                entity.ToTable("ResultadoDiagnostico");
            });
            modelBuilder.Entity<ResultadoOrdenCoseguro>(entity =>
            {
                entity.HasKey(e => e.Nrocred);
            });
            modelBuilder.Entity<ResumenCuentum>(entity =>
            {
                entity.HasKey(e => e.ResumenCuentaId);

                entity.Property(e => e.CBU)
                    .HasMaxLength(22)
                    .IsFixedLength();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Credito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OperadorCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Saldos).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Rubro>(entity =>
            {
                entity.HasKey(e => e.IdRubro);

                entity.Property(e => e.Nombre).HasMaxLength(75);
            });

            modelBuilder.Entity<RubrosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdRubroDetalle);

                entity.ToTable("RubrosDetalle");

                entity.HasOne(d => d.IdRubroNavigation)
                    .WithMany(p => p.RubrosDetalles)
                    .HasForeignKey(d => d.IdRubro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RubrosDetalle_Rubros");
            });

            modelBuilder.Entity<RubroxCentroDiagxImag>(entity =>
            {
                entity.ToTable("RubroxCentroDiagxImag");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.PorcentajeAfiliados).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SSM_AFIL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SSM_AFIL");

                entity.Property(e => e.APNOM)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DIR)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.F_NAC).HasColumnType("datetime");

                entity.Property(e => e.LEGAJO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_TER_1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_TER_2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_TER_3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SEXO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SectorReintegro>(entity =>
            {
                entity.ToTable("SectorReintegro");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Sector_Debito>(entity =>
            {
                entity.HasKey(e => e.IdSector_Debito)
                    .HasName("PK__Sector_D__38011326187A1D35");

                entity.ToTable("Sector_Debito");

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sectores_Iosep>(entity =>
            {
                entity.HasKey(e => e.SectorId);

                entity.ToTable("Sectores_Iosep");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SeguroMalaPraxi>(entity =>
            {
                entity.ToTable("SeguroMalaPraxi");

                entity.Property(e => e.BaseCobertura)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("date");

                entity.Property(e => e.FechaHasta).HasColumnType("date");

                entity.Property(e => e.NPoliza)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SPlan)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SumaAsegurada).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UbicacionRiesgo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAnula).HasMaxLength(11);

                entity.HasOne(d => d.EmpresaSeguro)
                    .WithMany(p => p.SeguroMalaPraxis)
                    .HasForeignKey(d => d.EmpresaSeguroID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeguroMalaPraxi_EmpresaSeguro");

                entity.HasOne(d => d.PrestadorDDJJ)
                    .WithMany(p => p.SeguroMalaPraxis)
                    .HasForeignKey(d => d.PrestadorDDJJID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeguroMalaPraxi_PrestadorDDJJ");
            });

            modelBuilder.Entity<SeguroMalaPraxiPago>(entity =>
            {
                entity.HasKey(e => e.SeguroMalaPraxiPagosID);

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.HasOne(d => d.SeguroMalaPraxi)
                    .WithMany(p => p.SeguroMalaPraxiPagos)
                    .HasForeignKey(d => d.SeguroMalaPraxiID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeguroMalaPraxiPagos_SeguroMalaPraxi");
            });

            modelBuilder.Entity<SepelioAutorizacion>(entity =>
            {
                entity.ToTable("SepelioAutorizacion");

                entity.Property(e => e.FechaAutorizacion).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.ImporteAutorizado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.ObservacionesSociales).HasMaxLength(100);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Tipo).HasMaxLength(25);

                entity.HasOne(d => d.SepelioSolicitud)
                    .WithMany(p => p.SepelioAutorizacions)
                    .HasForeignKey(d => d.SepelioSolicitudID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioAutorizacion_SepelioSolicitud");
            });

            modelBuilder.Entity<SepelioAutorizacionDetalle>(entity =>
            {
                entity.ToTable("SepelioAutorizacionDetalle");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Observaciones).HasMaxLength(100);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.SepelioAutorizacion)
                    .WithMany(p => p.SepelioAutorizacionDetalles)
                    .HasForeignKey(d => d.SepelioAutorizacionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioAutorizacionDetalle_SepelioAutorizacion");

                entity.HasOne(d => d.SepelioServicioDetalle)
                    .WithMany(p => p.SepelioAutorizacionDetalles)
                    .HasForeignKey(d => d.SepelioServicioDetalleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioAutorizacionDetalle_SepelioServicioDetalle");

                entity.HasOne(d => d.SepelioServicio)
                    .WithMany(p => p.SepelioAutorizacionDetalles)
                    .HasForeignKey(d => d.SepelioServicioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioAutorizacionDetalle_SepelioServicio");
            });

            modelBuilder.Entity<SepelioAutorizacionDetalleOrden>(entity =>
            {
                entity.ToTable("SepelioAutorizacionDetalleOrden");

                entity.Property(e => e.FechaOrden).HasColumnType("date");

                entity.Property(e => e.NumeroActa).HasMaxLength(10);

                entity.Property(e => e.NumeroOrden).HasMaxLength(12);

                entity.Property(e => e.TipoOrden).HasMaxLength(20);

                entity.HasOne(d => d.LocalidadDestino)
                    .WithMany(p => p.SepelioAutorizacionDetalleOrdenLocalidadDestinos)
                    .HasForeignKey(d => d.LocalidadDestinoID)
                    .HasConstraintName("FK_SepelioAutorizacionDetalleOrden_Localidades1");

                entity.HasOne(d => d.LocalidadOrigen)
                    .WithMany(p => p.SepelioAutorizacionDetalleOrdenLocalidadOrigens)
                    .HasForeignKey(d => d.LocalidadOrigenID)
                    .HasConstraintName("FK_SepelioAutorizacionDetalleOrden_Localidades");

                entity.HasOne(d => d.ProvinciaDestino)
                    .WithMany(p => p.SepelioAutorizacionDetalleOrdenProvinciaDestinos)
                    .HasForeignKey(d => d.ProvinciaDestinoID)
                    .HasConstraintName("FK_SepelioAutorizacionDetalleOrden_Provincias1");

                entity.HasOne(d => d.ProvinciaOrigen)
                    .WithMany(p => p.SepelioAutorizacionDetalleOrdenProvinciaOrigens)
                    .HasForeignKey(d => d.ProvinciaOrigenID)
                    .HasConstraintName("FK_SepelioAutorizacionDetalleOrden_Provincias");

                entity.HasOne(d => d.SepelioAutorizacionDetalle)
                    .WithMany(p => p.SepelioAutorizacionDetalleOrdens)
                    .HasForeignKey(d => d.SepelioAutorizacionDetalleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioAutorizacionDetalleOrden_SepelioAutorizacionDetalle");
            });

            modelBuilder.Entity<SepelioAutorizacionDetalleSolicitude>(entity =>
            {
                entity.HasKey(e => e.SepelioAutorizacionDetalleSolicitudesID);

                entity.HasOne(d => d.SepelioAutorizacion)
                    .WithMany(p => p.SepelioAutorizacionDetalleSolicitudes)
                    .HasForeignKey(d => d.SepelioAutorizacionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioAutorizacionDetalleSolicitudes_SepelioAutorizacion");
            });

            modelBuilder.Entity<SepelioServicio>(entity =>
            {
                entity.ToTable("SepelioServicio");

                entity.Property(e => e.NombreServicio).HasMaxLength(80);
            });

            modelBuilder.Entity<SepelioServicioDetalle>(entity =>
            {
                entity.ToTable("SepelioServicioDetalle");

                entity.Property(e => e.NombreDetalle).HasMaxLength(80);

                entity.HasOne(d => d.SepelioServicio)
                    .WithMany(p => p.SepelioServicioDetalles)
                    .HasForeignKey(d => d.SepelioServicioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioServicioDetalle_SepelioServicio");
            });

            modelBuilder.Entity<SepelioSolicitud>(entity =>
            {
                entity.ToTable("SepelioSolicitud");

                entity.Property(e => e.EstadoSolicitud).HasMaxLength(50);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaDenunciaFallecimiento).HasColumnType("date");

                entity.Property(e => e.FechaFallecimiento).HasColumnType("date");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.FechaRecepcionAfiliaciones).HasColumnType("date");

                entity.Property(e => e.NumeroActa).HasMaxLength(20);

                entity.Property(e => e.NumeroSolicitud)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones).HasMaxLength(100);

                entity.Property(e => e.ObservacionesAfiliaciones).HasMaxLength(100);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Afiliado)
                    .WithMany(p => p.SepelioSolicituds)
                    .HasForeignKey(d => d.AfiliadoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioSolicitud_Afiliados");

                entity.HasOne(d => d.Prestador)
                    .WithMany(p => p.SepelioSolicituds)
                    .HasForeignKey(d => d.PrestadorID)
                    .HasConstraintName("FK_SepelioSolicitud_Prestadores");
            });

            modelBuilder.Entity<SepelioSolicitudFacturacion>(entity =>
            {
                entity.ToTable("SepelioSolicitudFacturacion");

                entity.Property(e => e.EstadoSolicitud).HasMaxLength(50);

                entity.Property(e => e.FechaCrea).HasColumnType("date");

                entity.Property(e => e.FechaModi).HasColumnType("date");

                entity.Property(e => e.FechaSolicitud).HasColumnType("date");

                entity.Property(e => e.ImporteTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroSolicitudFacturacion)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones).HasMaxLength(100);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.SepelioSolicitud)
                    .WithMany(p => p.SepelioSolicitudFacturacions)
                    .HasForeignKey(d => d.SepelioSolicitudID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioSolicitudFacturacion_SepelioSolicitud");
            });

            modelBuilder.Entity<SepelioSolicitudFacturacionDetalle>(entity =>
            {
                entity.ToTable("SepelioSolicitudFacturacionDetalle");

                entity.Property(e => e.FechaCrea).HasColumnType("date");

                entity.Property(e => e.FechaModi).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Observaciones).HasMaxLength(100);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.SepelioServicio)
                    .WithMany(p => p.SepelioSolicitudFacturacionDetalles)
                    .HasForeignKey(d => d.SepelioServicioID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioSolicitudFacturacionDetalle_SepelioServicio");

                entity.HasOne(d => d.SepelioSolicitudFacturacion)
                    .WithMany(p => p.SepelioSolicitudFacturacionDetalles)
                    .HasForeignKey(d => d.SepelioSolicitudFacturacionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioSolicitudFacturacionDetalle_SepelioSolicitudFacturacion");
            });

            modelBuilder.Entity<SepelioSolicitudFacturacionDetalleDetalle>(entity =>
            {
                entity.ToTable("SepelioSolicitudFacturacionDetalleDetalle");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.LocalidadDestino)
                    .WithMany(p => p.SepelioSolicitudFacturacionDetalleDetalleLocalidadDestinos)
                    .HasForeignKey(d => d.LocalidadDestinoID)
                    .HasConstraintName("FK_SepelioSolicitudFacturacionDetalleDetalle_Localidades1");

                entity.HasOne(d => d.LocalidadOrigen)
                    .WithMany(p => p.SepelioSolicitudFacturacionDetalleDetalleLocalidadOrigens)
                    .HasForeignKey(d => d.LocalidadOrigenID)
                    .HasConstraintName("FK_SepelioSolicitudFacturacionDetalleDetalle_Localidades");

                entity.HasOne(d => d.ProvinciaDestino)
                    .WithMany(p => p.SepelioSolicitudFacturacionDetalleDetalleProvinciaDestinos)
                    .HasForeignKey(d => d.ProvinciaDestinoID)
                    .HasConstraintName("FK_SepelioSolicitudFacturacionDetalleDetalle_Provincias1");

                entity.HasOne(d => d.ProvinciaOrigen)
                    .WithMany(p => p.SepelioSolicitudFacturacionDetalleDetalleProvinciaOrigens)
                    .HasForeignKey(d => d.ProvinciaOrigenID)
                    .HasConstraintName("FK_SepelioSolicitudFacturacionDetalleDetalle_Provincias");

                entity.HasOne(d => d.SepelioServicioDetalle)
                    .WithMany(p => p.SepelioSolicitudFacturacionDetalleDetalles)
                    .HasForeignKey(d => d.SepelioServicioDetalleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioSolicitudFacturacionDetalleDetalle_SepelioServicioDetalle");

                entity.HasOne(d => d.SepelioSolicitudFacturacionDetalle)
                    .WithMany(p => p.SepelioSolicitudFacturacionDetalleDetalles)
                    .HasForeignKey(d => d.SepelioSolicitudFacturacionDetalleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SepelioSolicitudFacturacionDetalleDetalle_SepelioSolicitudFacturacionDetalle");
            });

            modelBuilder.Entity<ServicioProfEducEsp>(entity =>
            {
                entity.HasKey(e => e.ServicioPEEID);

                entity.ToTable("ServicioProfEducEsp");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ServicoCentro>(entity =>
            {
                entity.ToTable("ServicoCentro");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServicoRealiza>(entity =>
            {
                entity.ToTable("ServicoRealiza");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.HasKey(e => e.IdSexo);

                entity.ToTable("Sexo");

                entity.Property(e => e.IdSexo).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Siniestro>(entity =>
            {
                entity.ToTable("Siniestro");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaSiniestro).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SituacionTributarium>(entity =>
            {
                entity.HasKey(e => e.SituacionTribID);

                entity.Property(e => e.Iva).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Solicitud_Gasto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Solicitud_Gasto");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero_Expediente)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Gasto)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Resolucion)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.HasOne(d => d.OrdenCompraEncabezado)
                    .WithMany()
                    .HasForeignKey(d => d.OrdenCompraEncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Solicitud_Gasto_OrdenCompra_Encabezado");

                entity.HasOne(d => d.TipoGasto)
                    .WithMany()
                    .HasForeignKey(d => d.TipoGastoId)
                    .HasConstraintName("FK_Solicitud_Gasto_Tipo_Gastos");

                entity.HasOne(d => d.TipoServicio)
                    .WithMany()
                    .HasForeignKey(d => d.TipoServicioId)
                    .HasConstraintName("FK_Solicitud_Gasto_Tipo_Servicio");
            });

            modelBuilder.Entity<Sucursale>(entity =>
            {
                entity.HasKey(e => e.IdSucursal);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TablaAuxMedicamentosCompara>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TablaAuxMedicamentosCompara");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Laboratorio).HasMaxLength(250);

                entity.Property(e => e.Medicamento).HasMaxLength(250);

                entity.Property(e => e.PrecioF1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioF2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioF3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioF4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioI1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioI2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioI3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioI4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Presentacion).HasMaxLength(250);
            });

            modelBuilder.Entity<TablaRechazo>(entity =>
            {
                entity.HasKey(e => e.IdTablaRechazo);

                entity.ToTable("TablaRechazo");

                entity.Property(e => e.CODCAT)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CODINHA)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRICORT).HasMaxLength(30);
            });

            modelBuilder.Entity<Table_TiposDato>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e._char)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("char")
                    .IsFixedLength();

                entity.Property(e => e._decimal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decimal");

                entity.Property(e => e._float).HasColumnName("float");

                entity.Property(e => e._int).HasColumnName("int");

                entity.Property(e => e.binary)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.date).HasColumnType("date");

                entity.Property(e => e.datetime).HasColumnType("datetime");

                entity.Property(e => e.image).HasColumnType("image");

                entity.Property(e => e.money).HasColumnType("money");

                entity.Property(e => e.nchar)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ntext).HasColumnType("ntext");

                entity.Property(e => e.numeric).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.nvarchar).HasMaxLength(50);

                entity.Property(e => e.smalldatetime).HasColumnType("smalldatetime");

                entity.Property(e => e.smallmoney).HasColumnType("smallmoney");

                entity.Property(e => e.sql_variant).HasColumnType("sql_variant");

                entity.Property(e => e.text).HasColumnType("text");

                entity.Property(e => e.timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.varchar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.varcharmax).IsUnicode(false);

                entity.Property(e => e.xml).HasColumnType("xml");
            });

            modelBuilder.Entity<TestOrden>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TestOrden");

                entity.Property(e => e.ComprobanteIncluye)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.ComprobantePaga)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaFacturado).HasColumnType("datetime");

                entity.Property(e => e.IdOrdenSinCoseguro).ValueGeneratedOnAdd();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UserCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tiempo>(entity =>
            {
                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoAltum>(entity =>
            {
                entity.HasKey(e => e.TipoAltaID);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(35)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoCaja>(entity =>
            {
                entity.HasKey(e => e.IdTipoCaja);

                entity.ToTable("TipoCaja");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoCarencium>(entity =>
            {
                entity.HasKey(e => e.IdTipoCarencia);

                entity.Property(e => e.IdTipoCarencia).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoCondicion>(entity =>
            {
                entity.HasKey(e => e.IdTipoCondicion);

                entity.ToTable("TipoCondicion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoCondicionIVA>(entity =>
            {
                entity.ToTable("TipoCondicionIVA");

                entity.Property(e => e.IVA).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoConsumo>(entity =>
            {
                entity.HasKey(e => e.IdTipoConsumo);

                entity.ToTable("TipoConsumo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento);

                entity.ToTable("TipoDocumento");

                entity.Property(e => e.IdTipoDocumento).ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Codigo_Anses)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoDomicilio>(entity =>
            {
                entity.HasKey(e => e.idtipodomicilio);

                entity.ToTable("TipoDomicilio");

                entity.Property(e => e.idtipodomicilio).ValueGeneratedOnAdd();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoEspecialista>(entity =>
            {
                entity.HasKey(e => e.EspecialistaID);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoFamiliar>(entity =>
            {
                entity.HasKey(e => e.IdTipoFamiliar);

                entity.ToTable("TipoFamiliar");

                entity.Property(e => e.IdTipoFamiliar).ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo_Anses)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.compatible)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoFamiliar_Compatible>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TipoFamiliar_Compatible");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoFormaPago>(entity =>
            {
                entity.HasKey(e => e.IdTipoFormaPago);

                entity.ToTable("TipoFormaPago");

                entity.Property(e => e.Credito)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Cuenta_Contable)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoFrecuencium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Detalle)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Esquemas)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("1 - Esquemas y Planes 2 - Medicamentos");

                entity.Property(e => e.FrecuenciaTipo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Medicamentos)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoGestion>(entity =>
            {
                entity.HasKey(e => e.IdTipoGestion);

                entity.ToTable("TipoGestion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoInternacion>(entity =>
            {
                entity.ToTable("TipoInternacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoInternacionPractica>(entity =>
            {
                entity.HasKey(e => e.IdTipoInternacionPractica);

                entity.ToTable("TipoInternacionPractica");
            });

            modelBuilder.Entity<TipoLugar>(entity =>
            {
                entity.HasKey(e => e.IdTipoLugar);

                entity.ToTable("TipoLugar");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoMovimientoCuentum>(entity =>
            {
                entity.HasKey(e => e.TipoMovimientoCuentaID);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoNotaCredito>(entity =>
            {
                entity.ToTable("TipoNotaCredito");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoOperabilidad>(entity =>
            {
                entity.ToTable("TipoOperabilidad");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoOperabilidadAfiliado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TipoOperabilidadAfiliado");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModifica).HasColumnType("datetime");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TipoOperabilidadAfiliadoID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TipoOrdenPago>(entity =>
            {
                entity.ToTable("TipoOrdenPago");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPractica>(entity =>
            {
                entity.ToTable("TipoPractica");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPrestador>(entity =>
            {
                entity.ToTable("TipoPrestador");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoPrestadorDDJJ>(entity =>
            {
                entity.ToTable("TipoPrestadorDDJJ");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoReintegro>(entity =>
            {
                entity.ToTable("TipoReintegro");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoRestriccion>(entity =>
            {
                entity.ToTable("TipoRestriccion");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModi)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoSector>(entity =>
            {
                entity.HasKey(e => e.IdSector);

                entity.ToTable("TipoSector");

                entity.Property(e => e.IdSector).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoServicio_Sepelio>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicioSepelios);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoTransporte>(entity =>
            {
                entity.ToTable("TipoTransporte");

                entity.Property(e => e.FechaActiva).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OperActiva)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoUnidad>(entity =>
            {
                entity.HasKey(e => e.IdTipoUnidad)
                    .HasName("PK_TipoUnidad_1");

                entity.ToTable("TipoUnidad");

                entity.Property(e => e.HonGas)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Letra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<TipoVium>(entity =>
            {
                entity.HasKey(e => e.TipoViaID);
            });

            modelBuilder.Entity<Tipo_Comprobante>(entity =>
            {
                entity.HasKey(e => e.TipoComprobanteId);

                entity.ToTable("Tipo_Comprobante");
            });

            modelBuilder.Entity<Tipo_CuentaContable>(entity =>
            {
                entity.HasKey(e => e.TipoCuentaContableId)
                    .HasName("PK_Tipo_CuentaContableId");

                entity.ToTable("Tipo_CuentaContable");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_Debito>(entity =>
            {
                entity.HasKey(e => e.IdTipo_Debito);

                entity.ToTable("Tipo_Debito");

                entity.Property(e => e.campo)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_DescuentoAporte>(entity =>
            {
                entity.HasKey(e => e.CodigoDescuentoID);

                entity.Property(e => e.CodigoDescuentoID)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_DetalleISalud>(entity =>
            {
                entity.HasKey(e => e.idDetalle);

                entity.ToTable("Tipo_DetalleISalud");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.debe_haber)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_FormaPagoClinica>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago);

                entity.ToTable("Tipo_FormaPagoClinica");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_Gasto>(entity =>
            {
                entity.HasKey(e => e.TipoGastoId);

                entity.Property(e => e.TipoGastoId).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.HasOne(d => d.TipoServicio)
                    .WithMany(p => p.Tipo_Gastos)
                    .HasForeignKey(d => d.TipoServicioId)
                    .HasConstraintName("FK_Tipo_Gastos_Tipo_Servicio");
            });

            modelBuilder.Entity<Tipo_Ingreso>(entity =>
            {
                entity.HasKey(e => e.TipoIngresoId);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_IngresoAfiliacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoIngresoAfiliacion);

                entity.ToTable("Tipo_IngresoAfiliacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_Institucion>(entity =>
            {
                entity.HasKey(e => e.TipoInstitucionID);

                entity.ToTable("Tipo_Institucion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_LugarPago>(entity =>
            {
                entity.HasKey(e => e.IdPago);

                entity.ToTable("Tipo_LugarPago");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_MarcaAlfaBetum>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_MovimientoBanco>(entity =>
            {
                entity.HasKey(e => e.TipoMovimientosBancoID);

                entity.ToTable("Tipo_MovimientoBanco");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_MovimientoContable>(entity =>
            {
                entity.ToTable("Tipo_MovimientoContable");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Tipo_MovimientoISalud>(entity =>
            {
                entity.HasKey(e => e.idtipo_movimiento);

                entity.ToTable("Tipo_MovimientoISalud");

                entity.Property(e => e.codigo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.debe_haber)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_NormalAlterado>(entity =>
            {
                entity.HasKey(e => e.NormalAlteradoID);

                entity.ToTable("Tipo_NormalAlterado");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_NotaDePedido>(entity =>
            {
                entity.HasKey(e => e.TipoNotadePedidoId);

                entity.ToTable("Tipo_NotaDePedido");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.MontoDesde).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MontoHasta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Normativa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tipo_Orden>(entity =>
            {
                entity.HasKey(e => e.IdTipo_Orden)
                    .HasName("PK__Tipo_Ord__7920F57E8EAB2D35");

                entity.ToTable("Tipo_Orden");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_Oscultum>(entity =>
            {
                entity.HasKey(e => e.OscultaID);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_PedidoInterno>(entity =>
            {
                entity.HasKey(e => e.TipoPedidoInternoId);

                entity.ToTable("Tipo_PedidoInterno");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.MontoDesde).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MontoHasta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Normativa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tipo_PresentacionAlturaFeto>(entity =>
            {
                entity.HasKey(e => e.PresentacionAlturaFetoID)
                    .HasName("PK_Tipo_PresentacionFeto");

                entity.ToTable("Tipo_PresentacionAlturaFeto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_Reintegro>(entity =>
            {
                entity.HasKey(e => e.TipoReintegroID);

                entity.ToTable("Tipo_Reintegro");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_Retencion>(entity =>
            {
                entity.HasKey(e => e.TipoRetencionID);

                entity.ToTable("Tipo_Retencion");

                entity.Property(e => e.Alicuota_Basica)
                    .HasColumnType("decimal(10, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Alicuota_Incremento)
                    .HasColumnType("decimal(10, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Alicuota_Maxima)
                    .HasColumnType("decimal(10, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Importe_Incremento)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Maximo)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe_Minimo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Procentaje_Retencion).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Tipo_Servicio>(entity =>
            {
                entity.HasKey(e => e.TipoServicioId);

                entity.ToTable("Tipo_Servicio");

                entity.Property(e => e.TipoServicioId).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_SituacionLaboral>(entity =>
            {
                entity.HasKey(e => e.IdSituacionLaboral);

                entity.ToTable("Tipo_SituacionLaboral");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_VencimientoAfiliacione>(entity =>
            {
                entity.HasKey(e => e.TipoVencimientoID);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(300)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipo_VentaAlfaBetum>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TituloProfesional>(entity =>
            {
                entity.ToTable("TituloProfesional");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.HasKey(e => e.Id_Token);

                entity.Property(e => e.App).HasMaxLength(50);

                entity.Property(e => e.Authorization).HasMaxLength(50);

                entity.Property(e => e.CampoPassword).HasMaxLength(50);

                entity.Property(e => e.CampoUsuario).HasMaxLength(50);

                entity.Property(e => e.ExpiraToken).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Token1)
                    .HasMaxLength(150)
                    .HasColumnName("Token");

                entity.Property(e => e.URL).HasMaxLength(150);

                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<TopeInternacion>(entity =>
            {
                entity.HasKey(e => e.IdTopeInternacion);

                entity.ToTable("TopeInternacion");

                entity.Property(e => e.IdTopeInternacion).ValueGeneratedNever();
            });

            modelBuilder.Entity<Transaccion_Ordene>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Numero_Bono)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Transaccion)
                    .HasMaxLength(17)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_bono).HasMaxLength(50);
            });

            modelBuilder.Entity<Transferencium>(entity =>
            {
                entity.HasKey(e => e.TransferenciaID);

                entity.Property(e => e.ComprobantePago)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.FechaTransferencia)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImporteTransferencia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroCredito).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCarga)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TucumanNorte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TucumanNorte");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.Vigencia).HasColumnType("datetime");
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.HasKey(e => e.IdTurnos);

                entity.Property(e => e.Anterior)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cambiar)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Detalle)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.FecDia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Hora_Inici)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Llego)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.NoDar)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Oper_Inic)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Primera)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Tiempo)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TurnosCaja>(entity =>
            {
                entity.HasKey(e => e.IdTurnoCaja);

                entity.ToTable("TurnosCaja");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(25);
            });

            modelBuilder.Entity<TurnosEscuela>(entity =>
            {
                entity.HasKey(e => e.TurnoEscuelaId);

                entity.ToTable("TurnosEscuela");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModif).HasColumnType("datetime");

                entity.Property(e => e.MotivoAnulaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModif)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TurnosPrestadore>(entity =>
            {
                entity.HasKey(e => e.idturnoprestador);

                entity.Property(e => e.desde)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.dia)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.hasta)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.HasOne(d => d.idprestadorNavigation)
                    .WithMany(p => p.TurnosPrestadores)
                    .HasForeignKey(d => d.idprestador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TurnosPrestadores_Prestadores");
            });

            modelBuilder.Entity<Turnos_Bloqueo>(entity =>
            {
                entity.HasKey(e => e.IdBloqueo);

                entity.ToTable("Turnos_Bloqueo");

                entity.Property(e => e.CheckIN).HasColumnType("datetime");

                entity.Property(e => e.CheckOUT).HasColumnType("datetime");
            });

            modelBuilder.Entity<Turnos_CentroMedico>(entity =>
            {
                entity.HasKey(e => e.idturno);

                entity.ToTable("Turnos_CentroMedico");

                entity.Property(e => e.Operador_Atendio)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.fecha_hora).HasColumnType("smalldatetime");

                entity.Property(e => e.hora_atendido)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.hora_llegada)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.observacion)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.operador_anulo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.operador_dio)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.telefono)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tutore>(entity =>
            {
                entity.HasKey(e => e.TutorId);

                entity.Property(e => e.CUIL).HasMaxLength(11);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMod).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.IdSexo).HasDefaultValueSql("((1))");

                entity.Property(e => e.NumDocumento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperMod)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular).HasMaxLength(50);
            });

            modelBuilder.Entity<TxtNovedad>(entity =>
            {
                entity.HasKey(e => e.IdTxtNovedad);

                entity.ToTable("TxtNovedad");

                entity.Property(e => e.Beneficio)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.CodigoConcepto)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodigoEmpresa)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodigoOficina)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Concepto).HasMaxLength(1);

                entity.Property(e => e.Cuotas)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.FechaCarga)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Filler)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.GrupoNovedad)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.HoraCarga)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Importe)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.ImporteTotal)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Porcentaje)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Reserva)
                    .HasMaxLength(87)
                    .IsFixedLength();

                entity.Property(e => e.Sistema)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.StoredProcedure).HasMaxLength(100);

                entity.Property(e => e.TipoConcepto)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UltimosNumero>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Letters)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Numbers)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UltimosNumerosCobroTarjeta>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UltimosNumerosComprobantePracticasInternado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UltimosNumerosComprobantePracticasInternado");

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UltimosNumerosOrdene>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UltimosNumerosOrdenesPractica>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "usuario");

                entity.Property(e => e.App).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LastAccess).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Roles).IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Token).HasMaxLength(50);

                entity.Property(e => e.UserID).HasMaxLength(256);

                entity.Property(e => e.UserRelationship)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User_Perfile>(entity =>
            {
                entity.HasKey(e => e.IdPerfil);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<User_PerfilesUsuario>(entity =>
            {
                entity.HasKey(e => e.IdPerfiles);
            });

            modelBuilder.Entity<User_Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK_Usuarios");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UsoSupervisor>(entity =>
            {
                entity.HasKey(e => e.IdUsoSupervisor);

                entity.ToTable("UsoSupervisor");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Origen).HasMaxLength(100);

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioSolicita)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VW_VISTA_PROVISORIA_NOMENCLADOR_GENERAL_VALORE>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_VISTA_PROVISORIA_NOMENCLADOR_GENERAL_VALORES");

                entity.Property(e => e.Anestesista).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante_1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante_2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante_3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ayudante_4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Año)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Especialista).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaFinConvenio).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaResolucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Instrumentadora).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Letra)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VigenciaDesde).HasColumnType("smalldatetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("smalldatetime");

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.nivel)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.p_tipo)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vacuna>(entity =>
            {
                entity.Property(e => e.Descripción)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Edad)
                    .WithMany(p => p.Vacunas)
                    .HasForeignKey(d => d.EdadID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vacunas_Vacunas_Edades");

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.Vacunas)
                    .HasForeignKey(d => d.GrupoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vacunas_Vacunas_Grupos");
            });

            modelBuilder.Entity<Vacunas_Edade>(entity =>
            {
                entity.HasKey(e => e.EdadID);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vacunas_Grupo>(entity =>
            {
                entity.HasKey(e => e.GrupoId);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vacunas_Paciente>(entity =>
            {
                entity.HasKey(e => e.VacunasID);

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.FechaAplica).HasColumnType("datetime");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.NLote)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Vacuna)
                    .WithMany(p => p.Vacunas_Pacientes)
                    .HasForeignKey(d => d.VacunaID)
                    .HasConstraintName("FK_Vacunas_Pacientes_Vacunas");
            });

            modelBuilder.Entity<VademecumDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVademecumDetalle)
                    .HasName("PK_VademecumDetalle_1");

                entity.ToTable("VademecumDetalle");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Laboratorio).HasMaxLength(50);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Unitario).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdVademecumNavigation)
                    .WithMany(p => p.VademecumDetalles)
                    .HasForeignKey(d => d.IdVademecum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VademecumDetalle_VademecumFeclise");
            });

            modelBuilder.Entity<VademecumFeclise>(entity =>
            {
                entity.HasKey(e => e.IdVademecum);

                entity.ToTable("VademecumFeclise");

                entity.Property(e => e.Cantidad).HasMaxLength(15);

                entity.Property(e => e.ConDescuento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Droga).HasMaxLength(75);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Presentacion).HasMaxLength(100);

                entity.Property(e => e.UnitarioPromedio).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ValorRestriccion>(entity =>
            {
                entity.ToTable("ValorRestriccion");

                entity.Property(e => e.Descripción)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Valor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.TipoRestriccion)
                    .WithMany(p => p.ValorRestriccions)
                    .HasForeignKey(d => d.TipoRestriccionID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ValorRestriccion_TipoRestriccion");
            });

            modelBuilder.Entity<VencimientoAfiliacione>(entity =>
            {
                entity.HasKey(e => e.VencimientoAfiliacionesID);

                entity.Property(e => e.Vencimiento)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VencimientosPeriodosFacturacion>(entity =>
            {
                entity.HasKey(e => e.idPeriodo);

                entity.ToTable("VencimientosPeriodosFacturacion");

                entity.Property(e => e.Interes_1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Interes_2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Lugar_de_pago1)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Lugar_de_pago2)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Renglon_1)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Renglon_2)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Renglon_3)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento_1).HasColumnType("date");

                entity.Property(e => e.Vencimiento_2).HasColumnType("date");

                entity.Property(e => e.Vencimiento_ProntoPago).HasColumnType("date");
            });

            modelBuilder.Entity<VentasFarmacium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(14)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Coseguro).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdVentasFarmacia).ValueGeneratedOnAdd();

                entity.Property(e => e.Importe)
                    .HasColumnType("decimal(6, 2)")
                    .HasComment("valor del medicamento segun nomenclador");

                entity.Property(e => e.NroLote)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(6, 2)")
                    .HasComment("Valor final que abona el afiliado esta incluido el descuento del Coseguro y Reconoce");

                entity.Property(e => e.QR)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Reconoce).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ventas_PtoVentum>(entity =>
            {
                entity.HasKey(e => e.IdPtoVenta);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Via>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Vias_Cirugia>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Importe).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Via)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.totalafi).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.totalosp).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.xAfi).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.xOSP).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<VwAfiliado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAfiliados");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.EstadoCivil)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.SexoGenero)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoFamiliar)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAfiliadosDdjj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAfiliadosDdjj");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.EstadoCivil)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.SexoGenero)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoFamiliar)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAfiliadosDdjjFamiliar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAfiliadosDdjjFamiliar");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilaBuscar)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.EstadoCivil)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.SexoGenero)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoFamiliar)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAfiliadosFamiliar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAfiliadosFamiliar");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilaBuscar)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.EstadoCivil)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.MotivoBaja)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.SexoGenero)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoFamiliar)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nacionalidad)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAfiliadosIdTit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAfiliadosIdTit");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodArc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FecNacTit).HasColumnType("date");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.Fecha_CtaCTe).HasColumnType("datetime");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.LetArc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAfiliadosMaraton>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAfiliadosMaraton");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio).HasMaxLength(124);

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAlta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAltas");

                entity.Property(e => e.AuditaAlta)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.AutorizadoAlta).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ComplejidadNivel)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePrestador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NumeroAlta)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Obs_AuditaAlta)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.RespAuditorAlta)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Titular)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAltasImp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAltasImp");

                entity.Property(e => e.AuditaAlta)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.AutorizadoAlta).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ComplejidadNivel)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.NombrePrestador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NumeroAlta)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TipoAlta)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAutoMapa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAutoMapa");

                entity.Property(e => e.Auditado).HasColumnType("datetime");

                entity.Property(e => e.AuditadoAlta).HasColumnType("datetime");

                entity.Property(e => e.AuditorAlta)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.AuditorInternacion)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cargado).HasColumnType("datetime");

                entity.Property(e => e.CargadoAlta).HasColumnType("datetime");

                entity.Property(e => e.Estado).HasMaxLength(30);

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.MapaAlta)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MapaCarga)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MapaCargaAlta)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MapaInternacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.OperadorAlta)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorCarga)
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAutorizaMedicamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAutorizaMedicamentos");

                entity.Property(e => e.Autorizada)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Monodroga)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NomAut)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombreMedicamento)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Tamano)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwAutorizaPractica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAutorizaPracticas");

                entity.Property(e => e.Coseguro_Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro_Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetallePractica)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.EstadoAutorizacion)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.EstadoDetalle)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("date");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Motivo_Rechazo).IsUnicode(false);

                entity.Property(e => e.Motivo_Rechazo_Encabezado).IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Practica)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Prescriptor).HasMaxLength(200);

                entity.Property(e => e.Reconoce_Gastos).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Reconoce_Honorarios).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.matricula).HasMaxLength(9);
            });

            modelBuilder.Entity<VwAutorizarPractica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwAutorizarPracticas");

                entity.Property(e => e.Autorizacion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwCaja>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwCaja");

                entity.Property(e => e.Cajero)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Concepto)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Lugar)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Pagado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TipoCaja)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.comprobante_original)
                    .HasMaxLength(14)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwCajaConOrdene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwCajaConOrdenes");

                entity.Property(e => e.Cajero)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Concepto)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Lugar)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Pagado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.TipoCaja)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.comprobante_original)
                    .HasMaxLength(14)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwCisnero>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwCisnero");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwDdjj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwDdjj");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Quien)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwDiaInternado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwDiaInternado");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.DiaHora).HasColumnType("datetime");

                entity.Property(e => e.DiaHora_Anterior).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwDiagnostico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwDiagnosticos");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCapitulo)
                    .HasMaxLength(400)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwDomicilio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwDomicilios");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Provincia)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TipoDomicilio)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Zona)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.codigopostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.departamento)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.detalle)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.domicilio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.email)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.km)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.nropuerta)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.telefonocelular)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.telefonofijo)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.torre)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwDomicilioGrilla>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwDomicilioGrilla");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Departamento)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Km)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NroPuerta)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Provincia)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoFijo)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Torre)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwDomicilioGrillaDdjj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwDomicilioGrillaDdjj");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Departamento)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Km)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NroPuerta)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Provincia)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoFijo)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Torre)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwDroga>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwDrogas");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEntregaTurno>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEntregaTurnos");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodArc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilaBuscar)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.EstadoTarjeta)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.LetArc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEntregaTurnos1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEntregaTurnos1");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodArc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilaBuscar)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.EstadoTarjeta)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.LetArc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombreEstado)
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEntregaTurnos2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEntregaTurnos2");

                entity.Property(e => e.CuilABuscar)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.EstadoTarjeta)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.a_numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.codarc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.d_nro)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.d_tipo)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.delegacion)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.domicilio)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.dto)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.e_civil)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.fecha).HasColumnType("date");

                entity.Property(e => e.fecha_nacimiento).HasColumnType("date");

                entity.Property(e => e.i_fecha).HasColumnType("date");

                entity.Property(e => e.letarc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.localidad)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.piso).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.provincia)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.puerta).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.telefono)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.tipo_dom)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.v_fecha).HasColumnType("date");

                entity.Property(e => e.ven_fecha).HasColumnType("date");

                entity.Property(e => e.zona)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEnvioCredencialesxCorreo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEnvioCredencialesxCorreo");

                entity.Property(e => e.AfiliadoCuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.AfiliadoNroTarjetaNroTarjeta).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.AfiliadoNroTarjetaTarEstadoCodigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AfiliadoNroTarjetaTarEstadoDesde).HasColumnType("datetime");

                entity.Property(e => e.AfiliadoNroTarjetaTarEstadoHasta).HasColumnType("datetime");

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio).HasMaxLength(156);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.UserAC)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.a_numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.telefono)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEsqPlanxAfi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEsqPlanxAfi");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Fecha_Inicio).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.Inicio).HasColumnType("date");

                entity.Property(e => e.NombrePlan)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento).HasColumnType("date");
            });

            modelBuilder.Entity<VwEsquemaPracticas_output>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEsquemaPracticas_output");

                entity.Property(e => e.Coseguro).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Fecha_Inicio).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Practica)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwEsquemaProcedure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEsquemaProcedure");

                entity.Property(e => e.ConsultasReconoce).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ConsultasReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FarmaciaReconoce).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FarmaciaReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.FrecuenciaTipoConsulta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FrecuenciaTipoFarmacia)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.ValOrdenCon).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ValOrdenFar).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<VwEvolucion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwEvolucion");

                entity.Property(e => e.Evolucion).HasColumnType("ntext");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwFamiliaresBono>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwFamiliaresBono");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(20);

                entity.Property(e => e.Sexo).HasMaxLength(2);
            });

            modelBuilder.Entity<VwGetSectorxInternado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwGetSectorxInternado");

                entity.Property(e => e.Cama)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Denominacion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Pabellon)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwHistorialInternado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwHistorialInternados");

                entity.Property(e => e.Clinica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CodigoDiagnosticoAlta)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDiagnosticoIngreso)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoAlta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoIngreso)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.MedicoAlta)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.MedicoAltaNombre).HasMaxLength(50);

                entity.Property(e => e.MedicoIngreso)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.MedicoIngresoNombre).HasMaxLength(50);

                entity.Property(e => e.MotivoAlta).HasMaxLength(30);

                entity.Property(e => e.TipoInternacion).HasMaxLength(50);

                entity.Property(e => e.Trata).HasMaxLength(150);
            });

            modelBuilder.Entity<VwHistorialMedicamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwHistorialMedicamentos");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(36)
                    .IsFixedLength();

                entity.Property(e => e.DetalleMedicacion)
                    .HasMaxLength(36)
                    .IsFixedLength();

                entity.Property(e => e.Encabezado).HasMaxLength(58);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.MontoTotal).HasColumnType("decimal(37, 7)");

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Precio_venta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reconoce).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Sucursal)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwHistorialOrdene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwHistorialOrdenes");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Plan)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Practica)
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwHistorialOrdenes1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwHistorialOrdenes1");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Practica)
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwInfoInternadopAutMed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInfoInternadopAutMed");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sector)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoInternacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(150)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwInfoInternadopAutPra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInfoInternadopAutPra");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sector)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TipoInternacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(150)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwInicioAuditorium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInicioAuditoria");

                entity.Property(e => e.Clinica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Dia)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NumeroAlta)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NumeroInternacion)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Sector).HasMaxLength(30);
            });

            modelBuilder.Entity<VwIntHisCli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwIntHisCli");

                entity.Property(e => e.Antecedentes).HasColumnType("ntext");

                entity.Property(e => e.Diagnostico).HasColumnType("ntext");

                entity.Property(e => e.Estudios).HasColumnType("ntext");

                entity.Property(e => e.ExamenFisico).HasColumnType("ntext");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Modificaria).HasColumnType("ntext");

                entity.Property(e => e.Motivo).HasColumnType("ntext");

                entity.Property(e => e.NombrePractica).HasMaxLength(50);

                entity.Property(e => e.Practica)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwIntImp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwIntImp");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoAlta)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombreTitular)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Titular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.fecha_alta).HasColumnType("datetime");

                entity.Property(e => e.fecha_internacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwInterOtraClinica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInterOtraClinica");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.DiaHora).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombreClinica)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwInternado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInternados");

                entity.Property(e => e.Cama)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.Habitacion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePrestador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Obs_Auditor)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.RespAuditor)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Titular)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwInternadoEvolucion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInternadoEvolucion");

                entity.Property(e => e.Clinica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Derivado_a)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoAlta)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Prestador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.PrestadorAlta)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Sector).HasMaxLength(30);

                entity.Property(e => e.TipoInternacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TratamientoAlta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.fecha_alta).HasColumnType("datetime");

                entity.Property(e => e.fecha_internacion).HasColumnType("datetime");

                entity.Property(e => e.matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.matriculaalta)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.tratamiento)
                    .HasMaxLength(150)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwInternadosImp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInternadosImp");

                entity.Property(e => e.AuditorInternacion)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Autorizado).HasColumnType("datetime");

                entity.Property(e => e.Cama)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Clinica)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.Habitacion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombreClinica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NombrePrestador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NumeroInternacion)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.TipoInternacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwInternados_Alta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInternados_Altas");

                entity.Property(e => e.Codigo_prestador)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Cuil_Afiliado)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cuil_Titular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Estado_anterior)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Motivo_Alta)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Nombre_Afiliado)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Nombre_Titular)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Nombre_prestador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Obs_auditor)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_internacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.cama)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.fecha_alta).HasColumnType("datetime");

                entity.Property(e => e.habitacion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.respauditor)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwInternados_Auditorium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInternados_Auditoria");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil_Afiliado)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cuil_Titular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Estado_anterior)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Nombre_Afiliado)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Nombre_Titular)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Nombre_prestador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Internacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.cama)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.codigo_prestador)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.fecha_internacion).HasColumnType("datetime");

                entity.Property(e => e.habitacion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.obs_auditor)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.respAuditor)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.tratamiento)
                    .HasMaxLength(150)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwInternados_HistoriaClinicaPorAfiliado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwInternados_HistoriaClinicaPorAfiliado");

                entity.Property(e => e.Antecedentes).HasColumnType("ntext");

                entity.Property(e => e.Diagnostico).HasColumnType("ntext");

                entity.Property(e => e.Estudios).HasColumnType("ntext");

                entity.Property(e => e.ExamenFisico).HasColumnType("ntext");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Modificaria).HasColumnType("ntext");

                entity.Property(e => e.Motivo).HasColumnType("ntext");

                entity.Property(e => e.NombrePractica).HasMaxLength(50);

                entity.Property(e => e.Practica)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwNomenValore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwNomenValores");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwNomen_Valore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwNomen_Valores");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Desde).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hasta).HasColumnType("date");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwOrdene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwOrdenes");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vence).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePlan)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TipoReconoce)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwOrdenes1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwOrdenes1");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Fecha_Vence).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePlan)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperCuerpo).HasMaxLength(256);

                entity.Property(e => e.OperTroquel).HasMaxLength(256);

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TipoReconoce)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwOrdenesAnular>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwOrdenesAnular");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.DetallePractica)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OperAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Practica)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwOrdenesCaja>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwOrdenesCaja");

                entity.Property(e => e.Cajero)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Concepto)
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Lugar)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Pagado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TipoCaja)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwPesca>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwPesca");

                entity.Property(e => e.Carnet).HasColumnType("datetime");

                entity.Property(e => e.IdAfiliado).ValueGeneratedOnAdd();

                entity.Property(e => e.Turno1).HasColumnType("datetime");

                entity.Property(e => e.Turno2).HasColumnType("datetime");

                entity.Property(e => e.a_numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.familiar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.fecha).HasColumnType("date");

                entity.Property(e => e.nombre)
                    .HasMaxLength(45)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwPlanesNoGral_Sp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwPlanesNoGral_Sp");

                entity.Property(e => e.ConsultasReconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsultasReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FarmaciaReconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FarmaciaReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.FrecuenciaTipoConsulta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FrecuenciaTipoFarmacia)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Inicio).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.ValOrdenCon).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValOrdenFar).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vencimiento).HasColumnType("date");
            });

            modelBuilder.Entity<VwPlanes_Sp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwPlanes_Sp");

                entity.Property(e => e.ConsultasReconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsultasReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FarmaciaReconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FarmaciaReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.FrecuenciaTipoConsulta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FrecuenciaTipoFarmacia)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.ValOrdenCon).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValOrdenFar).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwPracticasHC>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwPracticasHC");

                entity.Property(e => e.autorizacion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.coseguro_gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.coseguro_honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.fecha_emision).HasColumnType("datetime");

                entity.Property(e => e.fecha_prescripcion).HasColumnType("date");

                entity.Property(e => e.fecha_vence).HasColumnType("date");

                entity.Property(e => e.gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.idautoriza).ValueGeneratedOnAdd();

                entity.Property(e => e.motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.observacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.reconoce_gastos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.reconoce_honorarios).HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<VwPracticasxImp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwPracticasxImp");

                entity.Property(e => e.Autorizacion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Practica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwPracxPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwPracxPlan");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Fecha_Inicio).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.Inicio).HasColumnType("date");

                entity.Property(e => e.NombrePlan)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Practica)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Vencimiento).HasColumnType("date");
            });

            modelBuilder.Entity<VwSector>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwSector");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwSolPra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwSolPra");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.DiaHora).HasColumnType("datetime");

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Titular)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwTipoUnidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwTipoUnidades");

                entity.Property(e => e.Año)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Cobertura).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaResolucion).HasColumnType("date");

                entity.Property(e => e.FinConvenio).HasColumnType("date");

                entity.Property(e => e.HonGas)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LetUni)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Letra)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.TipoCobertura)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.VigenciaDesde).HasColumnType("date");

                entity.Property(e => e.VigenciaHasta).HasColumnType("date");
            });

            modelBuilder.Entity<VwTurnosCentroMedico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwTurnosCentroMedico");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Hora).HasColumnType("smalldatetime");

                entity.Property(e => e.Hora_Atendido)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Hora_Llegada)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.NombreAfiliado)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePrestador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwTurnosMedico>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwTurnosMedicos");

                entity.Property(e => e.Desde)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Dia)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Hasta)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwVerQuirofano>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwVerQuirofano");

                entity.Property(e => e.Anestesista)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Ayudante1)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Ayudante2)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Biopsia)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CirQuirofano)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Cirujano)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Hemoterapia)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Instrumentador)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Laboratorio)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Laparoscopico)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Monitoraje)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Neonatologo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.Radiologo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Titular)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.Varios)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.nAnestesista)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nAyudante1)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nAyudante2)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nBiopsia)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nCirQuirofano)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nCirujano)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nHemoterapia)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nInstrumentador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nLaboratorio)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nLaparoscopico)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nMonitoraje)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nNeonatologo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nRadiologo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(45)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwVerifyDium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwVerifyDia");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.DiaHora).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Titular)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwVerifyQuirofano>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwVerifyQuirofano");
            });

            modelBuilder.Entity<Vw_Afiliado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Afiliados");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Nacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_AfiliadosDato>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AfiliadosDatos");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.codigopostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.departamento)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.domicilio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.dpto)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.km)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.nropuerta)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.provincia)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.torre)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.zona)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_AfiliadosEnTransito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AfiliadosEnTransito");

                entity.Property(e => e.A_Numero).HasMaxLength(18);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.LugarPago).HasMaxLength(57);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_AfiliadosExtranaJurisdiccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AfiliadosExtranaJurisdiccion");

                entity.Property(e => e.A_Numero).HasMaxLength(18);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.LugarPago).HasMaxLength(57);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_AfiliadosViewModel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AfiliadosViewModel");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodArc)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.Fecha_CtaCTe).HasColumnType("datetime");

                entity.Property(e => e.FechadeBaja).HasColumnType("date");

                entity.Property(e => e.FechadeNacimiento).HasColumnType("date");

                entity.Property(e => e.Fliar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.LetArc)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.TipoFamiliar)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_AportesMunicipio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AportesMunicipios");

                entity.Property(e => e.A_Numero).HasMaxLength(15);

                entity.Property(e => e.Afiliado).HasMaxLength(100);

                entity.Property(e => e.Aportes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CUIL).HasMaxLength(11);

                entity.Property(e => e.Fliar)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Municipio).HasMaxLength(11);

                entity.Property(e => e.Periodo).HasMaxLength(6);
            });

            modelBuilder.Entity<Vw_Autorizacione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Autorizaciones");

                entity.Property(e => e.Auditor_Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Practica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_AutorizacionesClinica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AutorizacionesClinicas");

                entity.Property(e => e.Auditor_Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdAutoriza)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.fecha_emision).HasColumnType("datetime");
            });

            modelBuilder.Entity<Vw_AutorizacionesMedicamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AutorizacionesMedicamentos");

                entity.Property(e => e.Auditor_Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha_Alta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Internacion).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.Medicamento)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_BonosFarmacium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_BonosFarmacia");

                entity.Property(e => e.ART)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.A_NUMERO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CAJA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CANTIDAD)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COBERTU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COBRADA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONSUMIDO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIAGNOSTIC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIAS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DIGI)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ECG)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EFECTOR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMISION_A)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMPRESA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ESTADO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EXCEPCION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EXE_TOPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FAMILIAR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_E)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_I)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_V)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F_COBRO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HORA_CARGA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HORA_CZA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_AFI_G)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_AFI_H)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_TOT_G)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_TOT_H)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INT_NRO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INT_SUC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LP_SU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NOMENCLADO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NRO_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPERADOR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPE_CZA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.O_SOCIAL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PRESCRIBE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMISOS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RX)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUC_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TIP_AUT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRANSAC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_ARANCEL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_COBERTU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_EMITE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.T_PRESTAC)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vw_Bonos_Practica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Bonos_Practica");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Edad).HasColumnType("date");

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombreTitular)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Practica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_ClinicaMedicamentosSolicitado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ClinicaMedicamentosSolicitados");

                entity.Property(e => e.Autorizacion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Institucion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Monodroga)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Motivo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombreMedicamento)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Tamano)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.nombretitular)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.titular)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_ClinicasPresupuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ClinicasPresupuestos");

                entity.Property(e => e.Auditor_Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodigoPractica)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCoseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalIosep).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Vw_ComprasFarmacium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ComprasFarmacia");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Monodroga)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NroLote)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.QR)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_ComprasListado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ComprasListado");

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Monodroga)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_CtaCteAfiliado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_CtaCteAfiliados");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Barrio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cupon_Coseguro)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Emision).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento1).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento2).HasColumnType("date");

                entity.Property(e => e.Importe_Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NroPuerta).HasMaxLength(10);

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Detalle)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_DetalleCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Movimiento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_MovimientoCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_CtaCteAfiliados1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_CtaCteAfiliados1");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cupon_Coseguro)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Emision).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento1).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento2).HasColumnType("date");

                entity.Property(e => e.Importe_Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NroPuerta)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Detalle)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_DetalleCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Movimiento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_MovimientoCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_CtaCteAfiliados2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_CtaCteAfiliados2");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Barrio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cupon_Coseguro)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Emision).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento1).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento2).HasColumnType("date");

                entity.Property(e => e.Importe_Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NroPuerta).HasMaxLength(10);

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Detalle)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_DetalleCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Movimiento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_MovimientoCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_CtaCteAfiliadosDH>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_CtaCteAfiliadosDH");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Cupon_coseguro)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_vencimiento1).HasColumnType("date");

                entity.Property(e => e.Fecha_vencimiento2).HasColumnType("date");

                entity.Property(e => e.Importe_Vencimiento1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_vencimiento2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Detalle)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_DetalleCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Movimiento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_MovimientoCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.fecha_emision).HasColumnType("date");

                entity.Property(e => e.numero_comprobante)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_CtaCteAnuladasAfiliado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_CtaCteAnuladasAfiliados");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Barrio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Cupon_Coseguro)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasMaxLength(10);

                entity.Property(e => e.Fecha_Emision).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento1).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento2).HasColumnType("date");

                entity.Property(e => e.Importe_Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Vencimiento2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NroPuerta).HasMaxLength(10);

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OperadorAnula).HasMaxLength(513);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Piso)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Detalle)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_DetalleCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Movimiento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_MovimientoCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_CtaCteEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_CtaCteEmpresas");

                entity.Property(e => e.CUIT)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CodigoBarra)
                    .HasMaxLength(42)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Importe_Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Detalle)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_DetalleCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_Movimiento)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_MovimientoCuenta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.cuota_afiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.cuota_afiliado_actual).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.fecha_emision).HasColumnType("date");

                entity.Property(e => e.fecha_vencimiento1).HasColumnType("date");

                entity.Property(e => e.fecha_vencimiento2).HasColumnType("date");

                entity.Property(e => e.importe_vencimiento1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.importe_vencimiento2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.numero_comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_DiagnosticoRelacionado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_DiagnosticoRelacionados");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoNomenclador)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.IdDiagnostico)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Monodroga)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCapitulo)
                    .HasMaxLength(400)
                    .IsFixedLength();

                entity.Property(e => e.NombreMedicamento).HasMaxLength(105);

                entity.Property(e => e.NombreNomenclador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Tamano)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Diagnosticos_Consulta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Diagnosticos_Consultas");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdDiagnostico).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vw_Empresas_Afiliado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Empresas_Afiliados");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuotaAfiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Empresas_Dato>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Empresas_Datos");

                entity.Property(e => e.CUIT)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CuotaAfiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Suma_Cuotas).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.fecha_fin).HasColumnType("date");

                entity.Property(e => e.fecha_inicio).HasColumnType("date");

                entity.Property(e => e.renovar_el).HasColumnType("date");
            });

            modelBuilder.Entity<Vw_Empresas_DatosDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Empresas_DatosDetalle");

                entity.Property(e => e.CUIT)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.IdEmpresa).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Suma_Cuotas).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.cuota_afiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.fecha_fin).HasColumnType("date");

                entity.Property(e => e.fecha_inicio).HasColumnType("date");

                entity.Property(e => e.renovar_el).HasColumnType("date");
            });

            modelBuilder.Entity<Vw_EsquemasMedicamentosDescuento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_EsquemasMedicamentosDescuentos");

                entity.Property(e => e.Coseguro).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Fecha_Inicio).HasColumnType("date");

                entity.Property(e => e.Fecha_Vencimiento).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reconoce).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_EstadisticasOrdene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_EstadisticasOrdenes");

                entity.Property(e => e.Afiliado).HasMaxLength(100);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha_Emision).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Plan)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vw_GetEsquema>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_GetEsquemas");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.IdEsquema).ValueGeneratedOnAdd();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Institucione>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Instituciones");

                entity.Property(e => e.CODIGO)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CONTACTO)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.DESCESP)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.DOMICILIO)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ESPECIAL)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.E_FECHA).HasColumnType("date");

                entity.Property(e => e.FECHACOL).HasColumnType("date");

                entity.Property(e => e.F_INACT).HasColumnType("date");

                entity.Property(e => e.GANANCIAS)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.GS_FECHA).HasColumnType("date");

                entity.Property(e => e.HS_FECHA).HasColumnType("date");

                entity.Property(e => e.INTERMEDIA)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.I_BRUTOS)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.I_FECHA).HasColumnType("date");

                entity.Property(e => e.LOCALIDAD)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.M_NRO)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.NRO_BRU)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.NRO_GAN)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.NRO_INSTI)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NRO_IVA)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.NRO_MUN)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OBS)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.PLUS_FECHA).HasColumnType("date");

                entity.Property(e => e.PLUS_NRO)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.PROVINCIA)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.TELEFONO)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ZONA)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.idprestador).ValueGeneratedOnAdd();

                entity.Property(e => e.matricula)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_ManualDatCobertura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ManualDatCobertura");

                entity.Property(e => e.Baja)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Cobertura_Internado).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cobertura_ambulatorio).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("datetime");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Laboratorio)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Marca)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Tamano)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.registro)
                    .HasMaxLength(5)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_ManualDatCobertura2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ManualDatCobertura2");

                entity.Property(e => e.Baja)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Cobertura_Internado).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Cobertura_ambulatorio).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("date");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Laboratorio)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Marca)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("numeric(9, 0)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Tamano)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.registro)
                    .HasMaxLength(5)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Medicamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Medicamentos");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Importe).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Laboratorio)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Monodroga)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Tamano)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Nomen_DatosNomenclador>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nomen_DatosNomenclador");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.tipo)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Nomen_Practica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nomen_Practica");

                entity.Property(e => e.NombreModalidad)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NombreTipoPractica)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Nomen_PracticasAsociada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nomen_PracticasAsociadas");

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Nomen_PracticasAsociadasPresupuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nomen_PracticasAsociadasPresupuesto");

                entity.Property(e => e.CodigoAsociado)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.NombreAsociado)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Nomen_PracticasNoAsociada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nomen_PracticasNoAsociadas");

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Nomen_PracticasNoAsociadasPresupuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nomen_PracticasNoAsociadasPresupuesto");

                entity.Property(e => e.CodigoNoAsociado)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.NombreNoAsociado)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Nomen_TipoUnidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nomen_TipoUnidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Nomenclador_feclisCC>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Nomenclador_feclisCC");

                entity.Property(e => e.Codigo_Convenio)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Tipo_nomenclador)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.anestesia).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_1).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_2).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_3).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.ayuda_4).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.cos_amb).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.cos_int).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.fijo).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.gastos).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.honorario).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.instrumen).HasColumnType("decimal(11, 4)");

                entity.Property(e => e.nombre)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.p_codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.v_fecha).HasColumnType("date");
            });

            modelBuilder.Entity<Vw_Plane>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Planes");

                entity.Property(e => e.ConsultasReconoce).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ConsultasReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FarmaciaReconoce).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.FarmaciaReconoceTipo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.FrecuenciaTipoConsulta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FrecuenciaTipoFarmacia)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Resolucion)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_Planes_Detalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Planes_Detalle");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.IdDetalle_Planes).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Vw_Prestadore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Prestadores");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoColegio).HasMaxLength(10);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Matricula)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vw_PrestadoresEspecialidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_PrestadoresEspecialidad");

                entity.Property(e => e.CodigoColegio).HasMaxLength(10);

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDesdeEspecialidad).HasMaxLength(20);

                entity.Property(e => e.FechaHastaEspecialidad).HasMaxLength(20);

                entity.Property(e => e.Matricula)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculaEspecialidad)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vw_Presupuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Presupuestos");

                entity.Property(e => e.Auditor_Porcentaje).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodigoPractica)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Fecha_Prescripcion).HasColumnType("date");

                entity.Property(e => e.FormaPagoDetalle)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCoseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalIosep).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Vw_PresupuestosComprobante>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_PresupuestosComprobantes");

                entity.Property(e => e.CodigoPractica)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormaPagoDetalle)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCoseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalIosep).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Vw_Proveedore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Proveedores");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_RelacionSectorPension>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_RelacionSectorPension");

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NombreSector)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.codigo)
                    .HasMaxLength(8)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_User_UsuariosyPerfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_User_UsuariosyPerfiles");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NombrePerfil)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_VentasFarmacium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_VentasFarmacia");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Coseguro).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ImporteActual).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Monodroga)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .IsFixedLength();

                entity.Property(e => e.NombreAfiliado)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Operador)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.QR)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Vw_VistaCobrosBanco>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_VistaCobrosBanco");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Importe_Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Numero_Comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Paga_Comprobante_Nro)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.comprobante)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.fecha_cobro).HasColumnType("date");

                entity.Property(e => e.importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.sucursal)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Z_VwObraSocial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VwObraSocial");

                entity.Property(e => e.Dni)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Os)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zona>(entity =>
            {
                entity.HasKey(e => e.idzona);

                entity.Property(e => e.codigo)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<__MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<aclisePrecio>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.vigencia).HasColumnType("date");
            });

            modelBuilder.Entity<aclisePreciosEnero>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aclisePreciosEnero");

                entity.Property(e => e.codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.vigencia).HasColumnType("date");
            });

            modelBuilder.Entity<aporte>(entity =>
            {
                entity.HasKey(e => e.AportesID)
                    .HasName("PK_Aportes_1");

                entity.Property(e => e.CodigoDescuento)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Contratado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Haberes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe_Descontado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Planta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.CodigoDescuentoNavigation)
                    .WithMany(p => p.aportes)
                    .HasForeignKey(d => d.CodigoDescuento)
                    .HasConstraintName("FK_Aportes_Tipo_DescuentoAportes");

                entity.HasOne(d => d.IdAfiliadoNavigation)
                    .WithMany(p => p.aportes)
                    .HasForeignKey(d => d.IdAfiliado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Aportes_Afiliados");

                entity.HasOne(d => d.LugarPago)
                    .WithMany(p => p.aportes)
                    .HasForeignKey(d => d.LugarPagoID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Aportes_Tipo_LugarPago");
            });

            modelBuilder.Entity<aux_i_autori>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aux_i_autori");

                entity.Property(e => e.AFICAR).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.A_NUMERO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CANTIDAD).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.COSEG_G).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.COSEG_H).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DIAGNOSTIC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.E_CAUSA)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.E_FECHA).HasColumnType("datetime");

                entity.Property(e => e.FAMILIAR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA).HasColumnType("date");

                entity.Property(e => e.GASTOS).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HONORARIO).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HORA_CARGA)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.INSTITUCIO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_AUT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.I_CAUSA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.I_TIPO).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NOMENCLADO)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NRO_AUT)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NUMERO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OBS)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OPERADOR)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.O_SOCIAL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PORCEN).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PORCENG).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PRESCRIBE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P_CODIGO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUC_AUT)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TIP_AUT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TOTAL).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.T_PRESTAC)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<comprobante>(entity =>
            {
                entity.HasKey(e => e.IdComprobante);

                entity.ToTable("comprobante", "iosepsalud");

                entity.HasIndex(e => new { e.IdAfiliado, e.Anulado, e.IdCtaCte }, "IndexClus_Imp_Det_Per");

                entity.Property(e => e.CodigoBarra)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detalle).HasMaxLength(50);

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<comprobanteDetalle>(entity =>
            {
                entity.HasKey(e => e.IdComprobanteDetalle);

                entity.ToTable("comprobanteDetalle", "iosepsalud");

                entity.Property(e => e.CuponCoseguro).HasMaxLength(50);

                entity.Property(e => e.Detalle).HasMaxLength(50);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.ImporteVence1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteVence2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Vencimiento1).HasColumnType("date");

                entity.Property(e => e.Vencimiento2).HasColumnType("date");

                entity.HasOne(d => d.IdComprobanteNavigation)
                    .WithMany(p => p.comprobanteDetalles)
                    .HasForeignKey(d => d.IdComprobante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_comprobanteDetalle_comprobante");
            });

            modelBuilder.Entity<comprobanteLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("comprobanteLog", "iosepsalud");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Operacion).HasMaxLength(50);

                entity.HasOne(d => d.IdCompronanteNavigation)
                    .WithMany(p => p.comprobanteLogs)
                    .HasForeignKey(d => d.IdCompronante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_comprobanteLog_comprobante");
            });

            modelBuilder.Entity<empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("empresa", "iosepsalud");

                entity.Property(e => e.Contacto).HasMaxLength(50);

                entity.Property(e => e.Cuit)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CuotaFija).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Domicilio).HasMaxLength(50);

                entity.Property(e => e.Fin).HasColumnType("date");

                entity.Property(e => e.Inicio).HasColumnType("date");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.PeriodoFacturado)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProntoPagoDescuento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProntoPagoImporte).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Renovar).HasColumnType("date");

                entity.Property(e => e.Resolucion).HasMaxLength(50);

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<empresaLog>(entity =>
            {
                entity.HasKey(e => e.IdEmpresaLog);

                entity.ToTable("empresaLog", "iosepsalud");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Operacion).HasMaxLength(50);

                entity.HasOne(d => d.IdEmpAfiNavigation)
                    .WithMany(p => p.empresaLogs)
                    .HasForeignKey(d => d.IdEmpAfi)
                    .HasConstraintName("FK_empresaLog_empresa_afiliado");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.empresaLogs)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_empresaLog_empresa");
            });

            modelBuilder.Entity<empresa_afiliado>(entity =>
            {
                entity.ToTable("empresa_afiliado", "iosepsalud");

                entity.Property(e => e.CuotaAfiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Motivo).HasMaxLength(50);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.empresa_afiliados)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_empresa_afiliado_empresa");
            });

            modelBuilder.Entity<gastosDiciembre20>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gastosDiciembre20");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.F5).HasMaxLength(255);

                entity.Property(e => e.F6).HasColumnType("money");

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.NuevoGastos).HasColumnType("money");

                entity.Property(e => e._No_column_name_)
                    .HasColumnType("datetime")
                    .HasColumnName("(No column name)");
            });

            modelBuilder.Entity<gastosEnero21>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gastosEnero21");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.NuevoGastos).HasColumnType("money");

                entity.Property(e => e._No_column_name_)
                    .HasColumnType("datetime")
                    .HasColumnName("(No column name)");
            });

            modelBuilder.Entity<honorariosDiciembre20>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("honorariosDiciembre20");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.F5).HasMaxLength(255);

                entity.Property(e => e.F6).HasColumnType("money");

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.NuevoHon).HasColumnType("money");

                entity.Property(e => e._No_column_name_)
                    .HasColumnType("datetime")
                    .HasColumnName("(No column name)");
            });

            modelBuilder.Entity<honorariosEnero21>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("honorariosEnero21");

                entity.Property(e => e.Codigo).HasMaxLength(255);

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.NuevoGastos).HasColumnType("money");

                entity.Property(e => e.NuevoHon).HasColumnType("money");

                entity.Property(e => e._No_column_name_)
                    .HasColumnType("datetime")
                    .HasColumnName("(No column name)");
            });

            modelBuilder.Entity<impactar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("impactar");

                entity.Property(e => e.codigo).HasMaxLength(255);

                entity.Property(e => e.gastos).HasMaxLength(255);

                entity.Property(e => e.hon).HasMaxLength(255);

                entity.Property(e => e.practica).HasMaxLength(255);
            });

            modelBuilder.Entity<impactarNuevosHon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("impactarNuevosHon");

                entity.Property(e => e.Gastos).HasMaxLength(255);

                entity.Property(e => e.Honorarios).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.codigo).HasMaxLength(255);
            });

            modelBuilder.Entity<impactarRadiol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("impactarRadiol");

                entity.Property(e => e.Gastos).HasMaxLength(255);

                entity.Property(e => e.Honorarios).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.codigo).HasMaxLength(255);
            });

            modelBuilder.Entity<iosepNomina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("iosepNomina");

                entity.Property(e => e.Datos)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<prueba>(entity =>
            {
                entity.ToTable("prueba");

                entity.HasIndex(e => new { e.nombre, e._int }, "IX_prueba")
                    .IsUnique();

                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e._int).HasColumnName("int");

                entity.Property(e => e.fecha).HasColumnType("date");

                entity.Property(e => e.fechahora).HasColumnType("datetime");

                entity.Property(e => e.general).HasColumnType("image");

                entity.Property(e => e.importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.memo).HasColumnType("ntext");

                entity.Property(e => e.money).HasColumnType("money");

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsFixedLength()
                    .HasComment("Descripción por Leonardo Illanez");
            });

            modelBuilder.Entity<socio>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.matricula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.nsocio)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tbl_App_Perfile>(entity =>
            {
                entity.HasKey(e => e.IdApp);

                entity.Property(e => e.Aplicacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.IdPerfilSupervisor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IdPerfiles).HasColumnType("ntext");
            });

            modelBuilder.Entity<testAut>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testAut");

                entity.Property(e => e.A_NUMERO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CONVENIO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DIAGNOSTIC)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FAMILIAR)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_E)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FECHA_V)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_AFI_G)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_AFI_H)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_TOT_G)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IMP_TOT_H)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.INT_NRO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.INT_SUC)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NOMENCLADO)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NRO_AUT)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OBS)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OPERADOR)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.O_SOCIAL)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PRESCRIBE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUC_AUT)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.T_EMITE)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tyoEnero>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tyoEnero");

                entity.Property(e => e.NombrePractica).HasMaxLength(255);

                entity.Property(e => e.Vigencia).HasColumnType("datetime");
            });

            modelBuilder.Entity<vw_AfiliadosDom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AfiliadosDom");

                entity.Property(e => e.A_Numero)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Barrio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CuilTitular)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.Fecha_CtaCTe).HasColumnType("datetime");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NroPuerta).HasMaxLength(10);

                entity.Property(e => e.Piso)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<zLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zLog");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Motivo).IsUnicode(false);

                entity.Property(e => e.Tabla)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<z_PROFE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_PROFE");

                entity.Property(e => e.ApeNom).HasMaxLength(30);

                entity.Property(e => e.Cod_Pos).HasMaxLength(8);

                entity.Property(e => e.Dom_Calle).HasMaxLength(50);

                entity.Property(e => e.Dom_Dpto).HasMaxLength(3);

                entity.Property(e => e.FeNac).HasColumnType("datetime");

                entity.Property(e => e.Fech_Alta).HasColumnType("datetime");

                entity.Property(e => e.LeyAplicada).HasMaxLength(2);

                entity.Property(e => e.Sexo).HasMaxLength(1);

                entity.Property(e => e.Tipo_Doc).HasMaxLength(2);
            });

            modelBuilder.Entity<z_exc_iosepSalud>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_exc_iosepSalud");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<z_ssm_afi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_ssm_afi");

                entity.Property(e => e.Column_0)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 0");

                entity.Property(e => e.Column_1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 1");

                entity.Property(e => e.Column_2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 2");

                entity.Property(e => e.Column_3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 3");

                entity.Property(e => e.Column_4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 4");

                entity.Property(e => e.Column_5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 5");

                entity.Property(e => e.Column_6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 6");

                entity.Property(e => e.Column_7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 7");

                entity.Property(e => e.Column_8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

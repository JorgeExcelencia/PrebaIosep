using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IOSEPwebContext : DbContext
    {
        public IOSEPwebContext()
        {
        }

        public IOSEPwebContext(DbContextOptions<IOSEPwebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActualizacionPreciosVademecum> ActualizacionPreciosVademecums { get; set; } = null!;
        public virtual DbSet<AfiJubilado> AfiJubilados { get; set; } = null!;
        public virtual DbSet<AfiliadoDato> AfiliadoDatos { get; set; } = null!;
        public virtual DbSet<Afiluga> Afilugas { get; set; } = null!;
        public virtual DbSet<AnaemnesisReducidum> AnaemnesisReducida { get; set; } = null!;
        public virtual DbSet<Anamnesi> Anamneses { get; set; } = null!;
        public virtual DbSet<AnamnesisDetalle> AnamnesisDetalles { get; set; } = null!;
        public virtual DbSet<AnamnesisRespuesta> AnamnesisRespuestas { get; set; } = null!;
        public virtual DbSet<Aplicacione> Aplicaciones { get; set; } = null!;
        public virtual DbSet<Aportadm> Aportadms { get; set; } = null!;
        public virtual DbSet<Aporte> Aportes { get; set; } = null!;
        public virtual DbSet<AportesAfiliado> AportesAfiliados { get; set; } = null!;
        public virtual DbSet<AportesDiosse> AportesDiosses { get; set; } = null!;
        public virtual DbSet<AportesMunicipio> AportesMunicipios { get; set; } = null!;
        public virtual DbSet<AportesSitaci> AportesSitacis { get; set; } = null!;
        public virtual DbSet<ArchivosSitaci> ArchivosSitacis { get; set; } = null!;
        public virtual DbSet<AspNetEvent> AspNetEvents { get; set; } = null!;
        public virtual DbSet<AspNetRole1> AspNetRoles1 { get; set; } = null!;
        public virtual DbSet<AspNetUser1> AspNetUsers1 { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; } = null!;
        public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; } = null!;
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } = null!;
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; } = null!;
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; } = null!;
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; } = null!;
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; } = null!;
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; } = null!;
        public virtual DbSet<AuditoriaConsulta> AuditoriaConsultas { get; set; } = null!;
        public virtual DbSet<AuditoriaPractica> AuditoriaPracticas { get; set; } = null!;
        public virtual DbSet<CalculoAuxiliar> CalculoAuxiliars { get; set; } = null!;
        public virtual DbSet<CentralAporte> CentralAportes { get; set; } = null!;
        public virtual DbSet<ConDetallePresentacion> ConDetallePresentacions { get; set; } = null!;
        public virtual DbSet<ConEncabezadoPresentacion> ConEncabezadoPresentacions { get; set; } = null!;
        public virtual DbSet<Consultorio> Consultorios { get; set; } = null!;
        public virtual DbSet<DetallePresentacionFarmacium> DetallePresentacionFarmacia { get; set; } = null!;
        public virtual DbSet<DetalleTipoRespuestum> DetalleTipoRespuesta { get; set; } = null!;
        public virtual DbSet<Dia> Dias { get; set; } = null!;
        public virtual DbSet<DiagnosticosConsulta> DiagnosticosConsultas { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<EncabezadoPresentacionFarmacium> EncabezadoPresentacionFarmacia { get; set; } = null!;
        public virtual DbSet<ErrorPresentacionFarmacium> ErrorPresentacionFarmacia { get; set; } = null!;
        public virtual DbSet<Especialidade> Especialidades { get; set; } = null!;
        public virtual DbSet<EventoDetalle> EventoDetalles { get; set; } = null!;
        public virtual DbSet<EventoEncabezado> EventoEncabezados { get; set; } = null!;
        public virtual DbSet<FarArticulosUltimoStock> FarArticulosUltimoStocks { get; set; } = null!;
        public virtual DbSet<FarArticulosUltimoStockDiario> FarArticulosUltimoStockDiarios { get; set; } = null!;
        public virtual DbSet<FarDetalleCompra> FarDetalleCompras { get; set; } = null!;
        public virtual DbSet<FarDetalleConsumo> FarDetalleConsumos { get; set; } = null!;
        public virtual DbSet<FarDetalleEntregaMedicacion> FarDetalleEntregaMedicacions { get; set; } = null!;
        public virtual DbSet<FarDetalleEntregaMedicacionPendiente> FarDetalleEntregaMedicacionPendientes { get; set; } = null!;
        public virtual DbSet<FarDetalleEntregaMedicamento> FarDetalleEntregaMedicamentos { get; set; } = null!;
        public virtual DbSet<FarDetallePresentacion> FarDetallePresentacions { get; set; } = null!;
        public virtual DbSet<FarDetalleVenta> FarDetalleVentas { get; set; } = null!;
        public virtual DbSet<FarDetalleVentaPendiente> FarDetalleVentaPendientes { get; set; } = null!;
        public virtual DbSet<FarEmPresentacion> FarEmPresentacions { get; set; } = null!;
        public virtual DbSet<FarEmPresentacionComprobante> FarEmPresentacionComprobantes { get; set; } = null!;
        public virtual DbSet<FarEmPresentacionComprobanteDetalle> FarEmPresentacionComprobanteDetalles { get; set; } = null!;
        public virtual DbSet<FarEncabezadoCompra> FarEncabezadoCompras { get; set; } = null!;
        public virtual DbSet<FarEncabezadoConsumo> FarEncabezadoConsumos { get; set; } = null!;
        public virtual DbSet<FarEncabezadoEntregaMedicamento> FarEncabezadoEntregaMedicamentos { get; set; } = null!;
        public virtual DbSet<FarEncabezadoPresentacion> FarEncabezadoPresentacions { get; set; } = null!;
        public virtual DbSet<FarEncabezadoVentum> FarEncabezadoVenta { get; set; } = null!;
        public virtual DbSet<FarEntregaMedicacion> FarEntregaMedicacions { get; set; } = null!;
        public virtual DbSet<FarEntregaMedicacionPendiente> FarEntregaMedicacionPendientes { get; set; } = null!;
        public virtual DbSet<FarEntregaMedicamentosPresentacione> FarEntregaMedicamentosPresentaciones { get; set; } = null!;
        public virtual DbSet<FarEntregaMedicamentosPresentacionesDetalle> FarEntregaMedicamentosPresentacionesDetalles { get; set; } = null!;
        public virtual DbSet<FarIdentificacionCompra> FarIdentificacionCompras { get; set; } = null!;
        public virtual DbSet<FarPresupuesto> FarPresupuestos { get; set; } = null!;
        public virtual DbSet<FarPresupuestoDetalle> FarPresupuestoDetalles { get; set; } = null!;
        public virtual DbSet<FarRemitoTemporalDetalle> FarRemitoTemporalDetalles { get; set; } = null!;
        public virtual DbSet<FarRemitoTemporalDetalleLoteVto> FarRemitoTemporalDetalleLoteVtos { get; set; } = null!;
        public virtual DbSet<FarRemitoTemporalEncabezado> FarRemitoTemporalEncabezados { get; set; } = null!;
        public virtual DbSet<FarRemitoTemporalPresentacione> FarRemitoTemporalPresentaciones { get; set; } = null!;
        public virtual DbSet<FarRemitoTemporalPresentacionesDetalle> FarRemitoTemporalPresentacionesDetalles { get; set; } = null!;
        public virtual DbSet<FarSucursale> FarSucursales { get; set; } = null!;
        public virtual DbSet<FarTipoMovimiento> FarTipoMovimientos { get; set; } = null!;
        public virtual DbSet<FarVentaPendiente> FarVentaPendientes { get; set; } = null!;
        public virtual DbSet<FarVentasPago> FarVentasPagos { get; set; } = null!;
        public virtual DbSet<Feriado> Feriados { get; set; } = null!;
        public virtual DbSet<FueraProvDetalleAutorizacion> FueraProvDetalleAutorizacions { get; set; } = null!;
        public virtual DbSet<FueraProvDetallePresentacion> FueraProvDetallePresentacions { get; set; } = null!;
        public virtual DbSet<FueraProvEncabezadoPresentacion> FueraProvEncabezadoPresentacions { get; set; } = null!;
        public virtual DbSet<FueraProvFactura> FueraProvFacturas { get; set; } = null!;
        public virtual DbSet<GrupoMedicamento> GrupoMedicamentos { get; set; } = null!;
        public virtual DbSet<GrupoMedicamentosDetalle> GrupoMedicamentosDetalles { get; set; } = null!;
        public virtual DbSet<ImpresionOrdene> ImpresionOrdenes { get; set; } = null!;
        public virtual DbSet<IncCampo> IncCampos { get; set; } = null!;
        public virtual DbSet<IncCamposGuardado> IncCamposGuardados { get; set; } = null!;
        public virtual DbSet<IncCamposValore> IncCamposValores { get; set; } = null!;
        public virtual DbSet<IncCategoriasProyecto> IncCategoriasProyectos { get; set; } = null!;
        public virtual DbSet<IncCategorium> IncCategoria { get; set; } = null!;
        public virtual DbSet<IncEstado> IncEstados { get; set; } = null!;
        public virtual DbSet<IncEstadosXproyecto> IncEstadosXproyectos { get; set; } = null!;
        public virtual DbSet<IncEtiqueta> IncEtiquetas { get; set; } = null!;
        public virtual DbSet<IncEtiquetasDetalle> IncEtiquetasDetalles { get; set; } = null!;
        public virtual DbSet<IncEvento> IncEventos { get; set; } = null!;
        public virtual DbSet<IncFlujodeTrabajo> IncFlujodeTrabajos { get; set; } = null!;
        public virtual DbSet<IncFlujosEsquema> IncFlujosEsquemas { get; set; } = null!;
        public virtual DbSet<IncFlujosMovimiento> IncFlujosMovimientos { get; set; } = null!;
        public virtual DbSet<IncIncidenciasxProyecto> IncIncidenciasxProyectos { get; set; } = null!;
        public virtual DbSet<IncMovComentario> IncMovComentarios { get; set; } = null!;
        public virtual DbSet<IncMovIncidencia> IncMovIncidencias { get; set; } = null!;
        public virtual DbSet<IncMovIncidenciaAdjunto> IncMovIncidenciaAdjuntos { get; set; } = null!;
        public virtual DbSet<IncMovIncidenciasHead> IncMovIncidenciasHeads { get; set; } = null!;
        public virtual DbSet<IncMovLog> IncMovLogs { get; set; } = null!;
        public virtual DbSet<IncPantalla> IncPantallas { get; set; } = null!;
        public virtual DbSet<IncPantallasEsquema> IncPantallasEsquemas { get; set; } = null!;
        public virtual DbSet<IncPantallasEsquemaRole> IncPantallasEsquemaRoles { get; set; } = null!;
        public virtual DbSet<IncPantallasxIncidencia> IncPantallasxIncidencias { get; set; } = null!;
        public virtual DbSet<IncPermiso> IncPermisos { get; set; } = null!;
        public virtual DbSet<IncPrioridad> IncPrioridads { get; set; } = null!;
        public virtual DbSet<IncProyecto> IncProyectos { get; set; } = null!;
        public virtual DbSet<IncProyectosDiasLaborable> IncProyectosDiasLaborables { get; set; } = null!;
        public virtual DbSet<IncProyectosDiasNoLaborable> IncProyectosDiasNoLaborables { get; set; } = null!;
        public virtual DbSet<IncProyectosHorasTrabajoUsuario> IncProyectosHorasTrabajoUsuarios { get; set; } = null!;
        public virtual DbSet<IncProyectosUsuario> IncProyectosUsuarios { get; set; } = null!;
        public virtual DbSet<IncRecordatorio> IncRecordatorios { get; set; } = null!;
        public virtual DbSet<IncResolucione> IncResoluciones { get; set; } = null!;
        public virtual DbSet<IncRole> IncRoles { get; set; } = null!;
        public virtual DbSet<IncRolesPermiso> IncRolesPermisos { get; set; } = null!;
        public virtual DbSet<IncRolesxProyecto> IncRolesxProyectos { get; set; } = null!;
        public virtual DbSet<IncSprint> IncSprints { get; set; } = null!;
        public virtual DbSet<IncSprintDetalle> IncSprintDetalles { get; set; } = null!;
        public virtual DbSet<IncTipoMovLog> IncTipoMovLogs { get; set; } = null!;
        public virtual DbSet<IncTipoMovLogAccion> IncTipoMovLogAccions { get; set; } = null!;
        public virtual DbSet<IncTiposCampo> IncTiposCampos { get; set; } = null!;
        public virtual DbSet<IncTiposIncidencia> IncTiposIncidencias { get; set; } = null!;
        public virtual DbSet<IncTiposProyecto> IncTiposProyectos { get; set; } = null!;
        public virtual DbSet<IncVoto> IncVotos { get; set; } = null!;
        public virtual DbSet<Indicadore> Indicadores { get; set; } = null!;
        public virtual DbSet<InsulinoLotesDetalle> InsulinoLotesDetalles { get; set; } = null!;
        public virtual DbSet<InsulinoLotesEncabezado> InsulinoLotesEncabezados { get; set; } = null!;
        public virtual DbSet<InterClinicaFactura> InterClinicaFacturas { get; set; } = null!;
        public virtual DbSet<InterDetalleAutorizacion> InterDetalleAutorizacions { get; set; } = null!;
        public virtual DbSet<InterDetalleAutorizacionAuditorium> InterDetalleAutorizacionAuditoria { get; set; } = null!;
        public virtual DbSet<InterDetalleMedicamento> InterDetalleMedicamentos { get; set; } = null!;
        public virtual DbSet<InterDetallePresentacion> InterDetallePresentacions { get; set; } = null!;
        public virtual DbSet<InterDetalleProtocolo> InterDetalleProtocolos { get; set; } = null!;
        public virtual DbSet<InterEncabezadoMedicamento> InterEncabezadoMedicamentos { get; set; } = null!;
        public virtual DbSet<InterEncabezadoPresentacion> InterEncabezadoPresentacions { get; set; } = null!;
        public virtual DbSet<InterHistoricoCambio> InterHistoricoCambios { get; set; } = null!;
        public virtual DbSet<Iosepfar> Iosepfars { get; set; } = null!;
        public virtual DbSet<ListaIndicadore> ListaIndicadores { get; set; } = null!;
        public virtual DbSet<MainMenuIosep> MainMenuIoseps { get; set; } = null!;
        public virtual DbSet<Memorandum> Memoranda { get; set; } = null!;
        public virtual DbSet<Mensaje> Mensajes { get; set; } = null!;
        public virtual DbSet<MensajesContacto> MensajesContactos { get; set; } = null!;
        public virtual DbSet<MensajesEstadosUsuario> MensajesEstadosUsuarios { get; set; } = null!;
        public virtual DbSet<MensajesGrupo> MensajesGrupos { get; set; } = null!;
        public virtual DbSet<MensajesGruposUsuario> MensajesGruposUsuarios { get; set; } = null!;
        public virtual DbSet<MensajesNotificacione> MensajesNotificaciones { get; set; } = null!;
        public virtual DbSet<MensajesNotificacionesBloqueado> MensajesNotificacionesBloqueados { get; set; } = null!;
        public virtual DbSet<MensajesNotificacionesPara> MensajesNotificacionesParas { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; } = null!;
        public virtual DbSet<NotificacionResolucion> NotificacionResolucions { get; set; } = null!;
        public virtual DbSet<Novedade> Novedades { get; set; } = null!;
        public virtual DbSet<OlimpiadasDetalleMovimiento> OlimpiadasDetalleMovimientos { get; set; } = null!;
        public virtual DbSet<OlimpiadasDisciplina> OlimpiadasDisciplinas { get; set; } = null!;
        public virtual DbSet<OlimpiadasEncabezado> OlimpiadasEncabezados { get; set; } = null!;
        public virtual DbSet<OlimpiadasMovimiento> OlimpiadasMovimientos { get; set; } = null!;
        public virtual DbSet<OlimpiadasPersona> OlimpiadasPersonas { get; set; } = null!;
        public virtual DbSet<OlimpiadasSede> OlimpiadasSedes { get; set; } = null!;
        public virtual DbSet<PlanillaTurno> PlanillaTurnos { get; set; } = null!;
        public virtual DbSet<PracDetalleOrden> PracDetalleOrdens { get; set; } = null!;
        public virtual DbSet<PracDetalleOrdenAuto> PracDetalleOrdenAutos { get; set; } = null!;
        public virtual DbSet<PracDetallePresentacion> PracDetallePresentacions { get; set; } = null!;
        public virtual DbSet<PracDetallePresentacionAuto> PracDetallePresentacionAutos { get; set; } = null!;
        public virtual DbSet<PracEncabezadoPresentacion> PracEncabezadoPresentacions { get; set; } = null!;
        public virtual DbSet<PracHistoricoCodigo> PracHistoricoCodigos { get; set; } = null!;
        public virtual DbSet<PracticasFactura> PracticasFacturas { get; set; } = null!;
        public virtual DbSet<PrefijoAlias> PrefijoAliases { get; set; } = null!;
        public virtual DbSet<PrestadorDia> PrestadorDias { get; set; } = null!;
        public virtual DbSet<PrestadoresServicio> PrestadoresServicios { get; set; } = null!;
        public virtual DbSet<PrestadoresTurno> PrestadoresTurnos { get; set; } = null!;
        public virtual DbSet<ProtesisGrupo> ProtesisGrupos { get; set; } = null!;
        public virtual DbSet<ProtesisPractica> ProtesisPracticas { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<Prueba1> Prueba1s { get; set; } = null!;
        public virtual DbSet<Prueba2> Prueba2s { get; set; } = null!;
        public virtual DbSet<RegistroActualizacion> RegistroActualizacions { get; set; } = null!;
        public virtual DbSet<RegistroAperturaLote> RegistroAperturaLotes { get; set; } = null!;
        public virtual DbSet<Resolucione> Resoluciones { get; set; } = null!;
        public virtual DbSet<RolesInMenu> RolesInMenus { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;
        public virtual DbSet<ServiciosDia> ServiciosDias { get; set; } = null!;
        public virtual DbSet<Sexo> Sexos { get; set; } = null!;
        public virtual DbSet<TablaAuxiliar> TablaAuxiliars { get; set; } = null!;
        public virtual DbSet<Tango> Tangos { get; set; } = null!;
        public virtual DbSet<TemporalDetalle> TemporalDetalles { get; set; } = null!;
        public virtual DbSet<Terapeutico> Terapeuticos { get; set; } = null!;
        public virtual DbSet<TerapeuticoMedicacion> TerapeuticoMedicacions { get; set; } = null!;
        public virtual DbSet<TipoActualizacion> TipoActualizacions { get; set; } = null!;
        public virtual DbSet<TipoAnamnesi> TipoAnamneses { get; set; } = null!;
        public virtual DbSet<TipoDato> TipoDatos { get; set; } = null!;
        public virtual DbSet<TipoEntidad> TipoEntidads { get; set; } = null!;
        public virtual DbSet<TipoEntregaMedicacion> TipoEntregaMedicacions { get; set; } = null!;
        public virtual DbSet<TipoEstadoRemito> TipoEstadoRemitos { get; set; } = null!;
        public virtual DbSet<TipoIndicador> TipoIndicadors { get; set; } = null!;
        public virtual DbSet<TipoPresentacion> TipoPresentacions { get; set; } = null!;
        public virtual DbSet<TipoResolucione> TipoResoluciones { get; set; } = null!;
        public virtual DbSet<TipoRespuestum> TipoRespuesta { get; set; } = null!;
        public virtual DbSet<TipoValor> TipoValors { get; set; } = null!;
        public virtual DbSet<TiposFeriado> TiposFeriados { get; set; } = null!;
        public virtual DbSet<Turno> Turnos { get; set; } = null!;
        public virtual DbSet<TurnosServicio> TurnosServicios { get; set; } = null!;
        public virtual DbSet<TurnosServicioHistorico> TurnosServicioHistoricos { get; set; } = null!;
        public virtual DbSet<TvMonitor> TvMonitors { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserFirmaDigital> UserFirmaDigitals { get; set; } = null!;
        public virtual DbSet<VacunasDetalleMovimiento> VacunasDetalleMovimientos { get; set; } = null!;
        public virtual DbSet<VacunasEncabezado> VacunasEncabezados { get; set; } = null!;
        public virtual DbSet<VacunasMovimiento> VacunasMovimientos { get; set; } = null!;
        public virtual DbSet<VacunasPersona> VacunasPersonas { get; set; } = null!;
        public virtual DbSet<VacunasPlan> VacunasPlans { get; set; } = null!;
        public virtual DbSet<VacunasRiesgo> VacunasRiesgos { get; set; } = null!;
        public virtual DbSet<VacunasSede> VacunasSedes { get; set; } = null!;
        public virtual DbSet<VwAportesAfiliado> VwAportesAfiliados { get; set; } = null!;
        public virtual DbSet<VwArticulo> VwArticulos { get; set; } = null!;
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; } = null!;
        public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; } = null!;
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; } = null!;
        public virtual DbSet<VwBajarConsulta> VwBajarConsultas { get; set; } = null!;
        public virtual DbSet<VwConsultasParaDevolucion> VwConsultasParaDevolucions { get; set; } = null!;
        public virtual DbSet<VwFormaPago> VwFormaPagos { get; set; } = null!;
        public virtual DbSet<VwOnlyUserName> VwOnlyUserNames { get; set; } = null!;
        public virtual DbSet<VwPresentacionFarmDetalle> VwPresentacionFarmDetalles { get; set; } = null!;
        public virtual DbSet<VwRolesMenu> VwRolesMenus { get; set; } = null!;
        public virtual DbSet<VwTurnosIosepSalud> VwTurnosIosepSaluds { get; set; } = null!;
        public virtual DbSet<ZLogEdgard> ZLogEdgards { get; set; } = null!;

        public virtual DbSet<RefreshToken> RefreshTokens { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActualizacionPreciosVademecum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Actualizacion_precios_vademecum");

                entity.Property(e => e.Barras)
                    .HasMaxLength(13)
                    .HasColumnName("barras")
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasMaxLength(8)
                    .HasColumnName("fecha")
                    .IsFixedLength();

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_actualizacion");

                entity.Property(e => e.Ioma)
                    .HasMaxLength(10)
                    .HasColumnName("ioma")
                    .IsFixedLength();

                entity.Property(e => e.Laborat)
                    .HasMaxLength(16)
                    .HasColumnName("laborat")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(44)
                    .HasColumnName("nombre")
                    .IsFixedLength();

                entity.Property(e => e.Precio)
                    .HasMaxLength(9)
                    .HasColumnName("precio")
                    .IsFixedLength();

                entity.Property(e => e.Precio2)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio2");

                entity.Property(e => e.Present)
                    .HasMaxLength(24)
                    .HasColumnName("present")
                    .IsFixedLength();

                entity.Property(e => e.Registro)
                    .HasMaxLength(5)
                    .HasColumnName("registro")
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .HasColumnName("troquel")
                    .IsFixedLength();
            });

            modelBuilder.Entity<AfiJubilado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("afi_jubilado");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoria");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Codigo2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo2");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cuil");

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("documento");

                entity.Property(e => e.Fecnac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecnac");

                entity.Property(e => e.Importe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("importe");

                entity.Property(e => e.Importe2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("importe2");

                entity.Property(e => e.Jubilado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mes");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nose)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nose");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sexo");

                entity.Property(e => e.Vacio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vacio");
            });

            modelBuilder.Entity<AfiliadoDato>(entity =>
            {
                entity.HasKey(e => new { e.TurnoId, e.AfiliadoDatoCuil })
                    .HasName("PK__Afiliado__F8D9CB2D07C12930");

                entity.ToTable("AfiliadoDato");

                entity.Property(e => e.AfiliadoDatoCuil).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.AfiliadoDatocelular).HasMaxLength(20);

                entity.Property(e => e.AfiliadoDatoemail).HasMaxLength(60);

                entity.Property(e => e.AfiliadoDatotelefono).HasMaxLength(20);

                entity.HasOne(d => d.Turno)
                    .WithMany(p => p.AfiliadoDatos)
                    .HasForeignKey(d => d.TurnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Turnos_AfiliadoDato");
            });

            modelBuilder.Entity<Afiluga>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("afiluga");

                entity.Property(e => e.ANumero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("a_numero");

                entity.Property(e => e.Adicional)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adicional");

                entity.Property(e => e.Adicional2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adicional2");

                entity.Property(e => e.AfAdic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("af_adic");

                entity.Property(e => e.Anses)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("anses");

                entity.Property(e => e.Aporte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aporte");

                entity.Property(e => e.Aportes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aportes");

                entity.Property(e => e.Comp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comp");

                entity.Property(e => e.Control)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("control");

                entity.Property(e => e.FReleva)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("f_releva");

                entity.Property(e => e.Familiar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("familiar");

                entity.Property(e => e.Familiares)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("familiares");

                entity.Property(e => e.Haber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("haber");

                entity.Property(e => e.Haberes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("haberes");

                entity.Property(e => e.Lugarpa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lugarpa");

                entity.Property(e => e.Nctrol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nctrol");

                entity.Property(e => e.Varios)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("varios");

                entity.Property(e => e.Veces)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("veces");

                entity.Property(e => e.Viejo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("viejo");

                entity.Property(e => e.Voluntar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voluntar");
            });

            modelBuilder.Entity<AnaemnesisReducidum>(entity =>
            {
                entity.HasKey(e => e.AnaemnesisReducidaId)
                    .HasName("PK_dbo.Anaemnesis_Reducida");

                entity.ToTable("Anaemnesis_Reducida");

                entity.Property(e => e.AnaemnesisReducidaId).HasColumnName("AnaemnesisReducidaID");

                entity.Property(e => e.EdadGestacional).HasColumnName("Edad_Gestacional");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FrecuenciaCardiaca).HasColumnName("Frecuencia_Cardiaca");

                entity.Property(e => e.FrecuenciaRespiratoria).HasColumnName("Frecuencia_Respiratoria");

                entity.Property(e => e.MasaCorporal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PacienteId).HasColumnName("PacienteID");

                entity.Property(e => e.Percentil).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PerimetroCefalico)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("Perimetro_Cefalico");

                entity.Property(e => e.Peso).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.Temperatura).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TurnoId).HasColumnName("TurnoID");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Anamnesi>(entity =>
            {
                entity.HasKey(e => e.AnamnesisId)
                    .HasName("PK_dbo.Anamnesis");

                entity.ToTable("Anamnesis");

                entity.Property(e => e.AnamnesisId).HasColumnName("AnamnesisID");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Egreso).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .HasColumnName("hora")
                    .IsFixedLength();

                entity.Property(e => e.IdAfiliado).HasColumnName("idAfiliado");

                entity.Property(e => e.Ingreso).HasColumnType("datetime");

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.TipoAnamnesisId).HasColumnName("TipoAnamnesisID");

                entity.Property(e => e.TurnoId).HasColumnName("TurnoID");

                entity.HasOne(d => d.TipoAnamnesis)
                    .WithMany(p => p.Anamnesis)
                    .HasForeignKey(d => d.TipoAnamnesisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Anamnesis_dbo.Tipo_Anamnesis_TipoAnamnesisID");
            });

            modelBuilder.Entity<AnamnesisDetalle>(entity =>
            {
                entity.ToTable("Anamnesis_Detalle");

                entity.Property(e => e.AnamnesisDetalleId).HasColumnName("AnamnesisDetalleID");

                entity.Property(e => e.Pregunta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAnamnesisId).HasColumnName("TipoAnamnesisID");

                entity.Property(e => e.TipoRespuestaId).HasColumnName("TipoRespuestaID");

                entity.Property(e => e.ValorMaximo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Valor_Maximo");

                entity.Property(e => e.ValorMinimo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Valor_Minimo");

                entity.HasOne(d => d.TipoAnamnesis)
                    .WithMany(p => p.AnamnesisDetalles)
                    .HasForeignKey(d => d.TipoAnamnesisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Anamnesis_Detalle_dbo.Tipo_Anamnesis_TipoAnamnesisID");

                entity.HasOne(d => d.TipoRespuesta)
                    .WithMany(p => p.AnamnesisDetalles)
                    .HasForeignKey(d => d.TipoRespuestaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Anamnesis_Detalle_dbo.Tipo_Respuesta_TipoRespuestaID");
            });

            modelBuilder.Entity<AnamnesisRespuesta>(entity =>
            {
                entity.HasKey(e => e.AnamnesisRespuestasId)
                    .HasName("PK_dbo.Anamnesis_Respuestas");

                entity.ToTable("Anamnesis_Respuestas");

                entity.Property(e => e.AnamnesisRespuestasId).HasColumnName("Anamnesis_RespuestasID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRespuestaId).HasColumnName("TipoRespuestaID");
            });

            modelBuilder.Entity<Aplicacione>(entity =>
            {
                entity.HasKey(e => e.IdAplicaciones);

                entity.Property(e => e.Logo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre).HasMaxLength(75);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<Aportadm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("APORTADM");

                entity.Property(e => e.ANumero)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("A_Numero");

                entity.Property(e => e.Aporte).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoJubilado)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Control)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CtaApo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Cta_Apo");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.HaberJubilado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Planta)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Aporte>(entity =>
            {
                entity.HasKey(e => e.IdAporte);

                entity.HasIndex(e => new { e.Cuil, e.Periodo }, "IndCuilPeriodo");

                entity.Property(e => e.ANumero)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("A_Numero");

                entity.Property(e => e.Afiliado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Aporte1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Aporte");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoJubilado)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Control)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.HaberJubilado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdAporte).ValueGeneratedOnAdd();

                entity.Property(e => e.LugarPago)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroBeneficio)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Otro)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Planta)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AportesAfiliado>(entity =>
            {
                entity.HasKey(e => e.AportesAfiliadosId);

                entity.HasIndex(e => e.Cuil, "IndexCuilAportes");

                entity.HasIndex(e => e.Periodo, "IndexPeriodo");

                entity.HasIndex(e => new { e.Codigo, e.Codigo2, e.Periodo }, "Index_AportesBeneficiarios");

                entity.HasIndex(e => new { e.Codigo, e.Codigo2, e.Periodo }, "Index_AportesCodigosPeriodo");

                entity.Property(e => e.AportesAfiliadosId).HasColumnName("AportesAfiliadosID");

                entity.Property(e => e.ANumero)
                    .HasMaxLength(8)
                    .HasColumnName("A_Numero");

                entity.Property(e => e.Aporte).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Codigo).HasMaxLength(3);

                entity.Property(e => e.Codigo2)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodigoJubilado).HasMaxLength(6);

                entity.Property(e => e.CuentaAporte).HasMaxLength(10);

                entity.Property(e => e.Cuil).HasMaxLength(11);

                entity.Property(e => e.FechaSubida)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_subida");

                entity.Property(e => e.HaberJubilado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LugarPagoId).HasColumnName("LugarPagoID");

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.Property(e => e.NumeroBeneficio)
                    .HasMaxLength(11)
                    .HasComment("(Control/Jubilado)");

                entity.Property(e => e.Periodo).HasMaxLength(6);
            });

            modelBuilder.Entity<AportesDiosse>(entity =>
            {
                entity.HasKey(e => e.IdAporteDiosse);

                entity.ToTable("AportesDiosse");

                entity.HasIndex(e => e.Cuil, "Index_AportesDiosseCuil");

                entity.Property(e => e.AnioLiquidacion)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoNombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.AporteAdicional).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AporteGrupo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AportePatronal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Desconocido)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.DescuentoCredito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.HaberCredito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HaberIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LugarPago)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.MesLiquidacion)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.NumeroControl)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Planta)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AportesMunicipio>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Cuil, "Index_AportesMunicipiosCuil");

                entity.Property(e => e.Aportes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Contrib).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cuil).HasMaxLength(11);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.IdAportesMunicipios).ValueGeneratedOnAdd();

                entity.Property(e => e.MuniComi).HasMaxLength(11);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea).HasMaxLength(11);

                entity.Property(e => e.Periodo).HasMaxLength(6);

                entity.Property(e => e.Presenta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sujeto).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AportesSitaci>(entity =>
            {
                entity.HasKey(e => e.IdAporteSitaci);

                entity.ToTable("AportesSitaci");

                entity.HasIndex(e => e.Cuil, "Index_SitaciCuil");

                entity.HasIndex(e => new { e.NumeroBeneficio, e.CodigoLiquidacion, e.Cuil }, "IndxAporNumCodCuil");

                entity.Property(e => e.AnioAporte)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ApellidoNombre)
                    .HasMaxLength(22)
                    .IsFixedLength();

                entity.Property(e => e.Aportes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodAnses)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CodArchivo).HasMaxLength(2);

                entity.Property(e => e.CodigoAnses)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.CodigoLiquidacion)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Documento)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Haber).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MesAporte)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.NumeroBeneficio)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ArchivosSitaci>(entity =>
            {
                entity.HasKey(e => e.IdArchivo);

                entity.ToTable("ArchivosSitaci");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(40);

                entity.Property(e => e.Habilitado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AspNetEvent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ChangeUser).HasMaxLength(256);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.NewUserName).HasMaxLength(256);

                entity.Property(e => e.OldUserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRole1>(entity =>
            {
                entity.ToTable("AspNetRoles");

                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Deleteable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Observacion).HasColumnType("ntext");
            });

            modelBuilder.Entity<AspNetUser1>(entity =>
            {
                entity.ToTable("AspNetUsers");

                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Alias).HasMaxLength(256);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FarSucursales)
                    .HasMaxLength(4)
                    .HasColumnName("Far_Sucursales");

                entity.Property(e => e.FechaAcepta).HasColumnType("datetime");

                entity.Property(e => e.IdDigitalizar).ValueGeneratedOnAdd();

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.OperadorActualiza).HasMaxLength(256);

                entity.Property(e => e.Sucursal).HasMaxLength(4);

                entity.Property(e => e.Token).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole1>().WithMany().HasForeignKey("RoleId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                        r => r.HasOne<AspNetUser1>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
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

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C98014935CB")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE40425A276")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__3091033107020F21")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D1FCDBCEB")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.Password).HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt).HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMemberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__21B6055D");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__22AA2996");
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5859063A47")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath).HasMaxLength(256);

                entity.Property(e => e.Path).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__5AEE82B9");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5960A75C0F");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings).HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__628FA481");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC06656C112C")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId }, "aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings).HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__68487DD7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__693CA210");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C36B12243");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames).HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary).HasColumnType("image");

                entity.Property(e => e.PropertyValuesString).HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__38996AB5");
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B4222D4EF")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__440B1D61");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC11367E606");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D0BC6C43E")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate }, "aspnet_Users_Index2");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__0DAF0CB0");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspnetUsersInRole",
                        l => l.HasOne<AspnetRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__RoleI__4AB81AF0"),
                        r => r.HasOne<AspnetUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__UserI__49C3F6B7"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760AD47DBAE45");

                            j.ToTable("aspnet_UsersInRoles");

                            j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                        });
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C810797309D9");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType).HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName).HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<AuditoriaConsulta>(entity =>
            {
                entity.HasKey(e => e.IdAuditoriaConsulta);

                entity.Property(e => e.Credito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditoCompartida).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito).HasMaxLength(200);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AuditoriaPractica>(entity =>
            {
                entity.HasKey(e => e.IdAuditoria);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CoseguroGastos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Gastos");

                entity.Property(e => e.CoseguroHonorarios)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Honorarios");

                entity.Property(e => e.Credito)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditoPendiente)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito).HasMaxLength(100);

                entity.Property(e => e.EncabezadoIdacredita).HasColumnName("EncabezadoIDAcredita");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombrePractica).HasMaxLength(150);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CalculoAuxiliar>(entity =>
            {
                entity.HasKey(e => e.IdCalculoAuxiliar);

                entity.ToTable("Calculo_Auxiliar");

                entity.Property(e => e.Detalle).HasMaxLength(50);
            });

            modelBuilder.Entity<CentralAporte>(entity =>
            {
                entity.HasKey(e => e.IdCentralAporte);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(150);
            });

            modelBuilder.Entity<ConDetallePresentacion>(entity =>
            {
                entity.HasKey(e => e.IdDetalleConsultas);

                entity.ToTable("Con_Detalle_Presentacion");

                entity.HasIndex(e => new { e.Anulado, e.FechaPractica }, "Index_ConDet_AnuladoFechaPractica");

                entity.HasIndex(e => new { e.NumeroComprobante, e.Anulado }, "Indice_ConsultasNumeroAnulado");

                entity.HasIndex(e => new { e.Anulado, e.FechaPractica }, "Tablero_Con_Detalle");

                entity.HasIndex(e => new { e.IdEncabezadoConsultas, e.Anulado, e.FechaPractica }, "Tablero_Con_Detalle2");

                entity.HasIndex(e => e.IdEncabezadoConsultas, "index_valCon1");

                entity.Property(e => e.IdDetalleConsultas).HasColumnName("IdDetalle_Consultas");

                entity.Property(e => e.ACompartida).HasColumnName("A_Compartida");

                entity.Property(e => e.Credito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditoCompartida).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_debito")
                    .IsFixedLength();

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaPractica).HasColumnType("date");

                entity.Property(e => e.IdTipoDebito).HasColumnName("IdTipo_debito");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(14)
                    .HasColumnName("Numero_Comprobante")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PeriodoDevolucion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_Devolucion")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.SugiereDebito).HasColumnName("Sugiere_Debito");
            });

            modelBuilder.Entity<ConEncabezadoPresentacion>(entity =>
            {
                entity.HasKey(e => e.IdEncabezadoConsultas);

                entity.ToTable("Con_Encabezado_Presentacion");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCierreAuditoria)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_CierreAuditoria");

                entity.Property(e => e.FechaCierreCompartida)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_CierreCompartida");

                entity.Property(e => e.FechaCierrePresentacion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_CierrePresentacion");

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .HasColumnName("Numero_Factura")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierreAuditoria)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierreAuditoria")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierreCompartida)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierreCompartida")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierrePresentacion)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierrePresentacion")
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_presentacion")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Consultorio>(entity =>
            {
                entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");

                entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TvMonitorId).HasColumnName("TvMonitorID");

                entity.HasOne(d => d.TvMonitor)
                    .WithMany(p => p.Consultorios)
                    .HasForeignKey(d => d.TvMonitorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Consultorios_TvMonitor");
            });

            modelBuilder.Entity<DetallePresentacionFarmacium>(entity =>
            {
                entity.HasKey(e => e.PresentacionId);

                entity.ToTable("Detalle_Presentacion_Farmacia");

                entity.HasIndex(e => e.EncabezadoId, "Index_Det_EncID");

                entity.Property(e => e.ACargoAfiliado1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("a_cargo_afiliado1");

                entity.Property(e => e.ACargoAfiliado2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("a_cargo_afiliado2");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.CantidadExpendida1).HasColumnName("Cantidad_expendida1");

                entity.Property(e => e.CantidadExpendida2).HasColumnName("Cantidad_expendida2");

                entity.Property(e => e.Chequeado).HasColumnName("chequeado");

                entity.Property(e => e.CiuFarmacia)
                    .HasMaxLength(10)
                    .HasColumnName("CIU_Farmacia")
                    .IsFixedLength();

                entity.Property(e => e.CiuInstitucion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cobertura1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cobertura2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodigoBarras1)
                    .HasMaxLength(13)
                    .HasColumnName("codigo_barras1")
                    .IsFixedLength();

                entity.Property(e => e.CodigoBarras2)
                    .HasMaxLength(13)
                    .HasColumnName("codigo_barras2")
                    .IsFixedLength();

                entity.Property(e => e.CodigoDiagnostico)
                    .HasMaxLength(5)
                    .HasColumnName("codigo_diagnostico")
                    .IsFixedLength();

                entity.Property(e => e.CodigoKairos1)
                    .HasMaxLength(8)
                    .HasColumnName("codigo_kairos1")
                    .IsFixedLength();

                entity.Property(e => e.CodigoKairos2)
                    .HasMaxLength(8)
                    .HasColumnName("codigo_kairos2")
                    .IsFixedLength();

                entity.Property(e => e.CodigoTroquel1)
                    .HasMaxLength(7)
                    .HasColumnName("codigo_troquel1")
                    .IsFixedLength();

                entity.Property(e => e.CodigoTroquel2)
                    .HasMaxLength(7)
                    .HasColumnName("codigo_troquel2")
                    .IsFixedLength();

                entity.Property(e => e.ConceptoPresentacion)
                    .HasMaxLength(1)
                    .HasColumnName("concepto_presentacion")
                    .IsFixedLength();

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debitado1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debitado2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EdadAfiliado).HasColumnName("edad_afiliado");

                entity.Property(e => e.FechaExpendio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_expendio");

                entity.Property(e => e.FechaPrescripcion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_prescripcion");

                entity.Property(e => e.GradoParentesco)
                    .HasMaxLength(2)
                    .HasColumnName("grado_parentesco")
                    .IsFixedLength();

                entity.Property(e => e.IdTipoDebito).HasColumnName("IdTipo_debito");

                entity.Property(e => e.IdTipoDebito1).HasColumnName("IdTipo_debito1");

                entity.Property(e => e.IdTipoDebito2).HasColumnName("IdTipo_debito2");

                entity.Property(e => e.ImporteCoseguroTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("importe_coseguro_total");

                entity.Property(e => e.ImporteMedicamento1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("importe_medicamento1");

                entity.Property(e => e.ImporteMedicamento2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("importe_medicamento2");

                entity.Property(e => e.NumeroAfiliado)
                    .HasMaxLength(15)
                    .HasColumnName("numero_afiliado")
                    .IsFixedLength();

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(8)
                    .HasColumnName("numero_autorizacion")
                    .IsFixedLength();

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(8)
                    .HasColumnName("numero_comprobante")
                    .IsFixedLength();

                entity.Property(e => e.NumeroSucursal)
                    .HasMaxLength(4)
                    .HasColumnName("numero_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("periodo_Presentacion")
                    .IsFixedLength();

                entity.Property(e => e.ProfesionalPrescriptor)
                    .HasMaxLength(10)
                    .HasColumnName("profesional_prescriptor")
                    .IsFixedLength();

                entity.Property(e => e.SexoAfiliado)
                    .HasMaxLength(1)
                    .HasColumnName("sexo_afiliado")
                    .IsFixedLength();

                entity.Property(e => e.SucursalAutorizacion)
                    .HasMaxLength(4)
                    .HasColumnName("sucursal_autorizacion")
                    .IsFixedLength();

                entity.Property(e => e.TipoChequera)
                    .HasMaxLength(2)
                    .HasColumnName("Tipo_Chequera")
                    .IsFixedLength();

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .HasColumnName("tipo_comprobante")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .HasColumnName("tipo_orden")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DetalleTipoRespuestum>(entity =>
            {
                entity.HasKey(e => e.DetalleTipoRespuestaId)
                    .HasName("PK_dbo.Detalle_TipoRespuesta");

                entity.ToTable("Detalle_TipoRespuesta");

                entity.Property(e => e.DetalleTipoRespuestaId).HasColumnName("Detalle_TipoRespuestaID");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.TipoRespuestaId).HasColumnName("TipoRespuestaID");

                entity.Property(e => e.TipoValorId).HasColumnName("TipoValorID");

                entity.Property(e => e.ValorMaximo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ValorMinimo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ValoraAlmacenar)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.HasOne(d => d.TipoRespuesta)
                    .WithMany(p => p.DetalleTipoRespuesta)
                    .HasForeignKey(d => d.TipoRespuestaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Detalle_TipoRespuesta_dbo.Tipo_Respuesta_TipoRespuestaID");

                entity.HasOne(d => d.TipoValor)
                    .WithMany(p => p.DetalleTipoRespuesta)
                    .HasForeignKey(d => d.TipoValorId)
                    .HasConstraintName("FK_dbo.Detalle_TipoRespuesta_dbo.Tipo_Valor_TipoValorID");
            });

            modelBuilder.Entity<Dia>(entity =>
            {
                entity.Property(e => e.DiaId).HasColumnName("DiaID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DiagnosticosConsulta>(entity =>
            {
                entity.HasKey(e => e.DiagnosticosConsultasId);

                entity.ToTable("Diagnosticos_Consultas");

                entity.Property(e => e.DiagnosticosConsultasId).HasColumnName("DiagnosticosConsultasID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.Property(e => e.Detalle).HasMaxLength(75);
            });

            modelBuilder.Entity<EncabezadoPresentacionFarmacium>(entity =>
            {
                entity.HasKey(e => e.EncabezadoId)
                    .HasName("PK_Encabezado_presentacion_farmacia");

                entity.ToTable("Encabezado_Presentacion_Farmacia");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.CantidadRegistros).HasColumnName("Cantidad_registros");

                entity.Property(e => e.Cerrado)
                    .HasColumnType("datetime")
                    .HasColumnName("cerrado");

                entity.Property(e => e.CiuInstitucion)
                    .HasMaxLength(10)
                    .HasColumnName("CIU_Institucion")
                    .IsFixedLength();

                entity.Property(e => e.ConceptoPresentacion)
                    .HasMaxLength(1)
                    .HasColumnName("Concepto_presentacion")
                    .IsFixedLength();

                entity.Property(e => e.CoseguroPresentado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_presentado");

                entity.Property(e => e.Debitado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("debitado");

                entity.Property(e => e.FechaCierreAuditoria).HasColumnType("datetime");

                entity.Property(e => e.FechaSubida)
                    .HasColumnType("date")
                    .HasColumnName("fecha_subida");

                entity.Property(e => e.ImportePresentado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Importe_presentado");

                entity.Property(e => e.IosepSalud).HasColumnName("Iosep_salud");

                entity.Property(e => e.NombreInstitucion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NumFactura)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierra)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierreAuditoria)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_presentacion")
                    .IsFixedLength();

                entity.Property(e => e.RegistrosCorrectos).HasColumnName("Registros_Correctos");

                entity.Property(e => e.RegistrosFallidos).HasColumnName("Registros_Fallidos");

                entity.Property(e => e.User)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ErrorPresentacionFarmacium>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK_Error_Presentacion_farmacia");

                entity.ToTable("Error_Presentacion_Farmacia");

                entity.Property(e => e.CiuFarmacia)
                    .HasMaxLength(10)
                    .HasColumnName("CIU_Farmacia")
                    .IsFixedLength();

                entity.Property(e => e.Ciuinstritucion)
                    .HasMaxLength(10)
                    .HasColumnName("CIUInstritucion")
                    .IsFixedLength();

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdTipoDebito).HasColumnName("IdTipo_Debito");

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NumeroOrden)
                    .HasMaxLength(14)
                    .HasColumnName("Numero_orden")
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Presentado).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.HasKey(e => e.EspecialidadId);

                entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EventoDetalle>(entity =>
            {
                entity.ToTable("Evento_Detalle");

                entity.Property(e => e.EventoDetalleId).HasColumnName("EventoDetalleID");

                entity.Property(e => e.AnamnesisDetalleId).HasColumnName("AnamnesisDetalleID");

                entity.Property(e => e.EventoEncabezadoId).HasColumnName("EventoEncabezadoID");

                entity.Property(e => e.ValorId).HasColumnName("ValorID");

                entity.HasOne(d => d.AnamnesisDetalle)
                    .WithMany(p => p.EventoDetalles)
                    .HasForeignKey(d => d.AnamnesisDetalleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Evento_Detalle_dbo.Anamnesis_Detalle_AnamnesisDetalleID");

                entity.HasOne(d => d.EventoEncabezado)
                    .WithMany(p => p.EventoDetalles)
                    .HasForeignKey(d => d.EventoEncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Evento_Detalle_dbo.Evento_Encabezado_EventoEncabezadoID");
            });

            modelBuilder.Entity<EventoEncabezado>(entity =>
            {
                entity.HasKey(e => e.EventoEncabezadoId)
                    .HasName("PK_dbo.Evento_Encabezado");

                entity.ToTable("Evento_Encabezado");

                entity.Property(e => e.EventoEncabezadoId).HasColumnName("EventoEncabezadoID");

                entity.Property(e => e.Crea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TipoAnamnesisId).HasColumnName("TipoAnamnesisID");

                entity.HasOne(d => d.TipoAnamnesis)
                    .WithMany(p => p.EventoEncabezados)
                    .HasForeignKey(d => d.TipoAnamnesisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Evento_Encabezado_dbo.Tipo_Anamnesis_TipoAnamnesisID");
            });

            modelBuilder.Entity<FarArticulosUltimoStock>(entity =>
            {
                entity.HasKey(e => e.IdUltimoStock);

                entity.ToTable("Far_Articulos_Ultimo_Stock");

                entity.HasIndex(e => e.NroRegistro, "IX_Far_Articulos_Ultimo_Stock");

                entity.HasIndex(e => e.SucursalId, "IX_Far_Articulos_Ultimo_Stock_1");

                entity.Property(e => e.IdUltimoStock).HasColumnName("IdUltimo_stock");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora).HasColumnType("time(0)");

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            });

            modelBuilder.Entity<FarArticulosUltimoStockDiario>(entity =>
            {
                entity.HasKey(e => e.IdUltimoStock)
                    .HasName("PK_Far_Articulos_Ultimo_StockTEST");

                entity.ToTable("Far_Articulos_Ultimo_StockDiario");

                entity.Property(e => e.IdUltimoStock).HasColumnName("IdUltimo_stock");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora).HasColumnType("time(0)");

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            });

            modelBuilder.Entity<FarDetalleCompra>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCompra);

                entity.ToTable("Far_Detalle_Compras");

                entity.HasIndex(e => e.Anulado, "IX_Articulos_Vto");

                entity.HasIndex(e => e.Anulado, "fr_id_1");

                entity.HasIndex(e => new { e.NroRegistro, e.Anulado }, "fr_ind_2");

                entity.Property(e => e.IdDetalleCompra).HasColumnName("IdDetalle_compra");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Codbarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.IdEncabezadoCompra).HasColumnName("IdEncabezado_compra");

                entity.Property(e => e.Impuestos).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PrecioCosto)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Precio_Costo");

                entity.Property(e => e.Vence)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEncabezadoCompraNavigation)
                    .WithMany(p => p.FarDetalleCompras)
                    .HasForeignKey(d => d.IdEncabezadoCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Detalle_Compras_Far_Encabezado_Compras");
            });

            modelBuilder.Entity<FarDetalleConsumo>(entity =>
            {
                entity.HasKey(e => e.IdDetalle);

                entity.ToTable("Far_DetalleConsumo");

                entity.Property(e => e.Cobertura).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.CodigoKairos)
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.CodigoTroquel)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.HasOne(d => d.IdEncabezadoNavigation)
                    .WithMany(p => p.FarDetalleConsumos)
                    .HasForeignKey(d => d.IdEncabezado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_DetalleConsumo_Far_EncabezadoConsumo");
            });

            modelBuilder.Entity<FarDetalleEntregaMedicacion>(entity =>
            {
                entity.ToTable("Far_Detalle_Entrega_Medicacion");

                entity.Property(e => e.FarDetalleEntregaMedicacionId).HasColumnName("FarDetalleEntregaMedicacionID");

                entity.Property(e => e.CantidadEntrega).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CantidadSolicita).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FarDetalleVentaId).HasColumnName("FarDetalleVentaID");

                entity.Property(e => e.FarEntregaMedicacionId).HasColumnName("FarEntregaMedicacionID");

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PrecioEntrega).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioVenta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.FarEntregaMedicacion)
                    .WithMany(p => p.FarDetalleEntregaMedicacions)
                    .HasForeignKey(d => d.FarEntregaMedicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Detalle_Entrega_Medicacion_Far_Entrega_Medicacion");
            });

            modelBuilder.Entity<FarDetalleEntregaMedicacionPendiente>(entity =>
            {
                entity.ToTable("Far_Detalle_Entrega_Medicacion_Pendiente");

                entity.Property(e => e.FarDetalleEntregaMedicacionPendienteId).HasColumnName("FarDetalleEntregaMedicacionPendienteID");

                entity.Property(e => e.CantidadEntrega).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CantidadSolicita).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FarDetalleVentaPendienteId).HasColumnName("FarDetalleVentaPendienteID");

                entity.Property(e => e.FarEntregaMedicacionPendienteId).HasColumnName("FarEntregaMedicacionPendienteID");

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PrecioEntrega).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.FarDetalleVentaPendiente)
                    .WithMany(p => p.FarDetalleEntregaMedicacionPendientes)
                    .HasForeignKey(d => d.FarDetalleVentaPendienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Detalle_Entrega_Medicacion_Pendiente_Far_Detalle_Venta_Pendiente");

                entity.HasOne(d => d.FarEntregaMedicacionPendiente)
                    .WithMany(p => p.FarDetalleEntregaMedicacionPendientes)
                    .HasForeignKey(d => d.FarEntregaMedicacionPendienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Detalle_Entrega_Medicacion_Pendiente_Far_Entrega_Medicacion_Pendiente");
            });

            modelBuilder.Entity<FarDetalleEntregaMedicamento>(entity =>
            {
                entity.HasKey(e => e.IdDetalleEntregaMedicamentos);

                entity.ToTable("Far_Detalle_EntregaMedicamentos");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CantidadEntregar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cantidad_Entregar");

                entity.Property(e => e.CantidadSolicitada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cantidad_Solicitada");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.IdDetalleVentas).HasColumnName("IdDetalle_Ventas");

                entity.Property(e => e.Lote)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Precio_Venta");

                entity.Property(e => e.Reconoce).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vence)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDetalleVentasNavigation)
                    .WithMany(p => p.FarDetalleEntregaMedicamentos)
                    .HasForeignKey(d => d.IdDetalleVentas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Detalle_EntregaMedicamentos_Far_Detalle_Ventas");

                entity.HasOne(d => d.IdEncabezadoEntregaMedicamentosNavigation)
                    .WithMany(p => p.FarDetalleEntregaMedicamentos)
                    .HasForeignKey(d => d.IdEncabezadoEntregaMedicamentos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Detalle_EntregaMedicamentos_Far_Encabezado_EntregaMedicamentos");
            });

            modelBuilder.Entity<FarDetallePresentacion>(entity =>
            {
                entity.HasKey(e => e.IdDetallePresentacion);

                entity.ToTable("Far_Detalle_Presentacion");

                entity.HasIndex(e => e.IdEncabezadoPresentacion, "Ind_2");

                entity.HasIndex(e => new { e.EncabezadoId, e.Anulado }, "Index_Det");

                entity.HasIndex(e => new { e.EncabezadoId, e.Anulado, e.NumReg }, "Index_paginar");

                entity.Property(e => e.IdDetallePresentacion).HasColumnName("IdDetalle_Presentacion");

                entity.Property(e => e.ACargoAfiliado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("a_cargo_afiliado");

                entity.Property(e => e.ACargoIosep)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("a_cargo_Iosep");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.CantidadExpendida).HasColumnName("Cantidad_expendida");

                entity.Property(e => e.Cobertura).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(13)
                    .HasColumnName("codigo_barras")
                    .IsFixedLength();

                entity.Property(e => e.CodigoKairos)
                    .HasMaxLength(8)
                    .HasColumnName("codigo_kairos")
                    .IsFixedLength();

                entity.Property(e => e.CodigoTroquel)
                    .HasMaxLength(7)
                    .HasColumnName("codigo_troquel")
                    .IsFixedLength();

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_debito")
                    .IsFixedLength();

                entity.Property(e => e.IdEncabezadoPresentacion).HasColumnName("IdEncabezado_Presentacion");

                entity.Property(e => e.IdTipoDebito).HasColumnName("IdTipo_debito");

                entity.Property(e => e.ImporteMedicamento)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("importe_medicamento");

                entity.Property(e => e.NombreMedicamento)
                    .HasMaxLength(80)
                    .HasColumnName("Nombre_Medicamento")
                    .IsFixedLength();

                entity.HasOne(d => d.IdEncabezadoPresentacionNavigation)
                    .WithMany(p => p.FarDetallePresentacions)
                    .HasForeignKey(d => d.IdEncabezadoPresentacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Detalle_Presentacion_Far_Encabezado_Presentacion");
            });

            modelBuilder.Entity<FarDetalleVenta>(entity =>
            {
                entity.HasKey(e => e.IdDetalleVentas);

                entity.ToTable("Far_Detalle_Ventas");

                entity.HasIndex(e => e.Anulado, "Index_FarDetalleAnulado");

                entity.HasIndex(e => new { e.IdEncabezadoVenta, e.Anulado }, "Index_Stock3");

                entity.HasIndex(e => new { e.NroRegistro, e.Anulado }, "Index_UltimoStockAuto");

                entity.HasIndex(e => e.Anulado, "Index_xStock");

                entity.HasIndex(e => new { e.NroRegistro, e.Anulado }, "index_stock5");

                entity.Property(e => e.IdDetalleVentas).HasColumnName("IdDetalle_Ventas");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CantidadEntregada).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.FechaProxEntrega).HasColumnType("datetime");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.IdEncabezadoVenta).HasColumnName("IdEncabezado_venta");

                entity.Property(e => e.Lote)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Precio_venta");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Vence)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEncabezadoVentaNavigation)
                    .WithMany(p => p.FarDetalleVenta)
                    .HasForeignKey(d => d.IdEncabezadoVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Detalle_Ventas_Far_Encabezado_Venta");
            });

            modelBuilder.Entity<FarDetalleVentaPendiente>(entity =>
            {
                entity.ToTable("Far_Detalle_Venta_Pendiente");

                entity.Property(e => e.FarDetalleVentaPendienteId).HasColumnName("FarDetalleVentaPendienteID");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.FarVentaPendienteId).HasColumnName("FarVentaPendienteID");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Lote)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PrecioVenta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Reconoce).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Vence)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.FarVentaPendiente)
                    .WithMany(p => p.FarDetalleVentaPendientes)
                    .HasForeignKey(d => d.FarVentaPendienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Detalle_Venta_Pendiente_Far_Venta_Pendiente");
            });

            modelBuilder.Entity<FarEmPresentacion>(entity =>
            {
                entity.ToTable("Far_EM_Presentacion");

                entity.Property(e => e.FarEmpresentacionId).HasColumnName("FarEMPresentacionID");

                entity.Property(e => e.CierreAuditoriaFecha).HasColumnType("datetime");

                entity.Property(e => e.CierreAuditoriaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CierreFecha).HasColumnType("datetime");

                entity.Property(e => e.CierreOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteCoseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteDebitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteDescuento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteIosepFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");

                entity.Property(e => e.NumeroFactura).HasMaxLength(20);

                entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.PorcentajeDescuento).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<FarEmPresentacionComprobante>(entity =>
            {
                entity.ToTable("Far_EM_Presentacion_Comprobante");

                entity.Property(e => e.FarEmpresentacionComprobanteId).HasColumnName("FarEMPresentacionComprobanteID");

                entity.Property(e => e.AfiliadoId).HasColumnName("AfiliadoID");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.DebitoDetalle).HasMaxLength(100);

                entity.Property(e => e.DebitoImporte)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FarEmpresentacionId).HasColumnName("FarEMPresentacionID");

                entity.Property(e => e.FarEntregaMedicacionId).HasColumnName("FarEntregaMedicacionID");

                entity.Property(e => e.FechaEmision).HasColumnType("date");

                entity.Property(e => e.FechaEntrega).HasColumnType("date");

                entity.Property(e => e.ImporteCoseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InstitucionId).HasColumnName("InstitucionID");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.NumeroTicket)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.TipoDebitoId).HasColumnName("TipoDebitoID");

                entity.HasOne(d => d.FarEmpresentacion)
                    .WithMany(p => p.FarEmPresentacionComprobantes)
                    .HasForeignKey(d => d.FarEmpresentacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_EM_Presentacion_Comprobante_Far_EM_Presentacion");

                entity.HasOne(d => d.FarEntregaMedicacion)
                    .WithMany(p => p.FarEmPresentacionComprobantes)
                    .HasForeignKey(d => d.FarEntregaMedicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_EM_Presentacion_Comprobante_Far_Entrega_Medicacion");
            });

            modelBuilder.Entity<FarEmPresentacionComprobanteDetalle>(entity =>
            {
                entity.ToTable("Far_EM_Presentacion_Comprobante_Detalle");

                entity.Property(e => e.FarEmpresentacionComprobanteDetalleId).HasColumnName("FarEMPresentacionComprobanteDetalleID");

                entity.Property(e => e.CantidadEntrega).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Cobertura).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.CoseguroAfiliado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CoseguroIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.DebitoDetalle).HasMaxLength(100);

                entity.Property(e => e.DebitoImporte)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FarDetalleEntregaMedicacionId).HasColumnName("FarDetalleEntregaMedicacionID");

                entity.Property(e => e.FarEmpresentacionComprobanteId).HasColumnName("FarEMPresentacionComprobanteID");

                entity.Property(e => e.FarEmpresentacionId).HasColumnName("FarEMPresentacionID");

                entity.Property(e => e.ImporteEntrega).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.TipoDebitoId).HasColumnName("TipoDebitoID");

                entity.HasOne(d => d.FarDetalleEntregaMedicacion)
                    .WithMany(p => p.FarEmPresentacionComprobanteDetalles)
                    .HasForeignKey(d => d.FarDetalleEntregaMedicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_EM_Presentacion_Comprobante_Detalle_Far_Detalle_Entrega_Medicacion");

                entity.HasOne(d => d.FarEmpresentacionComprobante)
                    .WithMany(p => p.FarEmPresentacionComprobanteDetalles)
                    .HasForeignKey(d => d.FarEmpresentacionComprobanteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_EM_Presentacion_Comprobante_Detalle_Far_EM_Presentacion_Comprobante");

                entity.HasOne(d => d.FarEmpresentacion)
                    .WithMany(p => p.FarEmPresentacionComprobanteDetalles)
                    .HasForeignKey(d => d.FarEmpresentacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_EM_Presentacion_Comprobante_Detalle_Far_EM_Presentacion");
            });

            modelBuilder.Entity<FarEncabezadoCompra>(entity =>
            {
                entity.HasKey(e => e.IdEncabezadoCompras);

                entity.ToTable("Far_Encabezado_Compras");

                entity.HasIndex(e => new { e.SucursalId, e.Anulado }, "Index_UltimoStockAuto");

                entity.Property(e => e.IdEncabezadoCompras).HasColumnName("IdEncabezado_Compras");

                entity.Property(e => e.CaiComprobante)
                    .HasMaxLength(50)
                    .HasColumnName("CAI_Comprobante")
                    .IsFixedLength();

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRecepcion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Recepcion");

                entity.Property(e => e.Gnl)
                    .HasMaxLength(14)
                    .HasColumnName("GNL")
                    .IsFixedLength();

                entity.Property(e => e.HoraRecepcion)
                    .HasMaxLength(4)
                    .HasColumnName("Hora_Recepcion")
                    .IsFixedLength();

                entity.Property(e => e.IdTipoComprobante).HasColumnName("IdTipo_Comprobante");

                entity.Property(e => e.ImporteComprobante)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(12)
                    .HasColumnName("Numero_Comprobante")
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.FarEncabezadoCompras)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Encabezado_Compras_Proveedores");

                entity.HasOne(d => d.IdTipoComprobanteNavigation)
                    .WithMany(p => p.FarEncabezadoCompras)
                    .HasForeignKey(d => d.IdTipoComprobante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Encabezado_Compras_Far_Tipo_Movimiento");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.FarEncabezadoCompras)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Encabezado_Compras_Far_Sucursales");
            });

            modelBuilder.Entity<FarEncabezadoConsumo>(entity =>
            {
                entity.HasKey(e => e.IdEncabezado);

                entity.ToTable("Far_EncabezadoConsumo");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaPrescripcion).HasColumnType("date");

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FarEncabezadoEntregaMedicamento>(entity =>
            {
                entity.HasKey(e => e.IdEncabezadoEntregaMedicamentos);

                entity.ToTable("Far_Encabezado_EntregaMedicamentos");

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.IdEncabezadoVenta).HasColumnName("IdEncabezado_Venta");

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(12)
                    .HasColumnName("Numero_Comprobante")
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEncabezadoVentaNavigation)
                    .WithMany(p => p.FarEncabezadoEntregaMedicamentos)
                    .HasForeignKey(d => d.IdEncabezadoVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Encabezado_EntregaMedicamentos_Far_Encabezado_Venta");
            });

            modelBuilder.Entity<FarEncabezadoPresentacion>(entity =>
            {
                entity.HasKey(e => e.IdEncabezadoPresentacion);

                entity.ToTable("Far_Encabezado_Presentacion");

                entity.HasIndex(e => new { e.EncabezadoId, e.Anulado }, "In_1");

                entity.HasIndex(e => new { e.EncabezadoId, e.Anulado }, "Index_Enca");

                entity.HasIndex(e => new { e.EncabezadoId, e.Anulado }, "_ix_1");

                entity.Property(e => e.IdEncabezadoPresentacion).HasColumnName("IdEncabezado_Presentacion");

                entity.Property(e => e.ACargoAfiliado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("a_cargo_afiliado");

                entity.Property(e => e.ACargoIosep)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("a_cargo_Iosep");

                entity.Property(e => e.Anulado).HasColumnName("anulado");

                entity.Property(e => e.Chequeado).HasColumnName("chequeado");

                entity.Property(e => e.CiuFarmacia)
                    .HasMaxLength(10)
                    .HasColumnName("CIU_Farmacia")
                    .IsFixedLength();

                entity.Property(e => e.CiuInstitucion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodigoDiagnostico)
                    .HasMaxLength(5)
                    .HasColumnName("codigo_diagnostico")
                    .IsFixedLength();

                entity.Property(e => e.ConceptoPresentacion)
                    .HasMaxLength(1)
                    .HasColumnName("concepto_presentacion")
                    .IsFixedLength();

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_debito")
                    .IsFixedLength();

                entity.Property(e => e.EdadAfiliado).HasColumnName("edad_afiliado");

                entity.Property(e => e.FechaExpendio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_expendio");

                entity.Property(e => e.FechaPrescripcion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_prescripcion");

                entity.Property(e => e.GradoParentesco)
                    .HasMaxLength(2)
                    .HasColumnName("grado_parentesco")
                    .IsFixedLength();

                entity.Property(e => e.IdTipoDebito).HasColumnName("IdTipo_debito");

                entity.Property(e => e.Idafiliado).HasColumnName("idafiliado");

                entity.Property(e => e.ImporteCoseguroTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("importe_coseguro_total");

                entity.Property(e => e.Modificado).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre")
                    .IsFixedLength();

                entity.Property(e => e.NumeroAfiliado)
                    .HasMaxLength(15)
                    .HasColumnName("numero_afiliado")
                    .IsFixedLength();

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(10)
                    .HasColumnName("numero_autorizacion")
                    .IsFixedLength();

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(8)
                    .HasColumnName("numero_comprobante")
                    .IsFixedLength();

                entity.Property(e => e.NumeroSucursal)
                    .HasMaxLength(4)
                    .HasColumnName("numero_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("periodo_Presentacion")
                    .IsFixedLength();

                entity.Property(e => e.ProfesionalPrescriptor)
                    .HasMaxLength(10)
                    .HasColumnName("profesional_prescriptor")
                    .IsFixedLength();

                entity.Property(e => e.SexoAfiliado)
                    .HasMaxLength(1)
                    .HasColumnName("sexo_afiliado")
                    .IsFixedLength();

                entity.Property(e => e.SucursalAutorizacion)
                    .HasMaxLength(4)
                    .HasColumnName("sucursal_autorizacion")
                    .IsFixedLength();

                entity.Property(e => e.TipoChequera)
                    .HasMaxLength(2)
                    .HasColumnName("Tipo_Chequera")
                    .IsFixedLength();

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .HasColumnName("tipo_comprobante")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .HasColumnName("tipo_orden")
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Encabezado)
                    .WithMany(p => p.FarEncabezadoPresentacions)
                    .HasForeignKey(d => d.EncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Encabezado_Presentacion_Encabezado_Presentacion_Farmacia");
            });

            modelBuilder.Entity<FarEncabezadoVentum>(entity =>
            {
                entity.HasKey(e => e.IdEncabezadoVenta);

                entity.ToTable("Far_Encabezado_Venta");

                entity.HasIndex(e => e.Fecha, "IndexFecha");

                entity.HasIndex(e => new { e.IdTipoComprobante, e.PlanId, e.Derivado, e.Anulado }, "Index_Far_IdTipoCompIdPlanDerivaAnul");

                entity.HasIndex(e => new { e.Derivado, e.Anulado, e.Fecha }, "Index_Stock");

                entity.HasIndex(e => new { e.SucursalId, e.Derivado, e.Anulado, e.Fecha }, "Index_Stock2");

                entity.Property(e => e.IdEncabezadoVenta).HasColumnName("IdEncabezado_Venta");

                entity.Property(e => e.Cobra).HasColumnType("datetime");

                entity.Property(e => e.ComprobanteOriginal)
                    .HasMaxLength(12)
                    .HasColumnName("Comprobante_Original")
                    .IsFixedLength();

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRestaura).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.IdTipoComprobante).HasColumnName("IdTipo_Comprobante");

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.MotivoAnulaId).HasColumnName("MotivoAnulaID");

                entity.Property(e => e.MotivoRestauraId).HasColumnName("MotivoRestauraID");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(12)
                    .HasColumnName("Numero_Comprobante")
                    .IsFixedLength();

                entity.Property(e => e.OpCobra)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperRestaura)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");

                entity.HasOne(d => d.IdTipoComprobanteNavigation)
                    .WithMany(p => p.FarEncabezadoVenta)
                    .HasForeignKey(d => d.IdTipoComprobante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Encabezado_Venta_Far_Tipo_Movimiento");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.FarEncabezadoVenta)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Encabezado_Venta_Far_Sucursales");
            });

            modelBuilder.Entity<FarEntregaMedicacion>(entity =>
            {
                entity.ToTable("Far_Entrega_Medicacion");

                entity.Property(e => e.FarEntregaMedicacionId).HasColumnName("FarEntregaMedicacionID");

                entity.Property(e => e.AfiliadoId).HasColumnName("AfiliadoID");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FarEncabezadoVentaId).HasColumnName("FarEncabezadoVentaID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.ImporteTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiOp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.NumeroTicket)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.TipoEntregaMedicacionId).HasColumnName("TipoEntregaMedicacionID");

                entity.HasOne(d => d.TipoEntregaMedicacion)
                    .WithMany(p => p.FarEntregaMedicacions)
                    .HasForeignKey(d => d.TipoEntregaMedicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Entrega_Medicacion_TipoEntregaMedicacion");
            });

            modelBuilder.Entity<FarEntregaMedicacionPendiente>(entity =>
            {
                entity.ToTable("Far_Entrega_Medicacion_Pendiente");

                entity.Property(e => e.FarEntregaMedicacionPendienteId).HasColumnName("FarEntregaMedicacionPendienteID");

                entity.Property(e => e.AfiliadoId).HasColumnName("AfiliadoID");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaOp)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.FarEncabezadoVentaId).HasColumnName("FarEncabezadoVentaID");

                entity.Property(e => e.FarVentaPendienteId).HasColumnName("FarVentaPendienteID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.ImporteTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiOp)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.NumeroComprobanteVenta)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");

                entity.Property(e => e.TipoEntregaMedicacionId).HasColumnName("TipoEntregaMedicacionID");

                entity.HasOne(d => d.FarVentaPendiente)
                    .WithMany(p => p.FarEntregaMedicacionPendientes)
                    .HasForeignKey(d => d.FarVentaPendienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Entrega_Medicacion_Pendiente_Far_Venta_Pendiente");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.FarEntregaMedicacionPendientes)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Entrega_Medicacion_Pendiente_Far_Sucursales");

                entity.HasOne(d => d.TipoEntregaMedicacion)
                    .WithMany(p => p.FarEntregaMedicacionPendientes)
                    .HasForeignKey(d => d.TipoEntregaMedicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Entrega_Medicacion_Pendiente_TipoEntregaMedicacion");
            });

            modelBuilder.Entity<FarEntregaMedicamentosPresentacione>(entity =>
            {
                entity.HasKey(e => e.IdEntregaMedicamentosPresentacion);

                entity.ToTable("Far_EntregaMedicamentos_Presentaciones");

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FarEntregaMedicamentosPresentacionesDetalle>(entity =>
            {
                entity.HasKey(e => e.IdEntregaMedicamentosDetallePresentacion);

                entity.ToTable("Far_EntregaMedicamentos_Presentaciones_Detalle");

                entity.HasOne(d => d.IdEncabezadoVentaNavigation)
                    .WithMany(p => p.FarEntregaMedicamentosPresentacionesDetalles)
                    .HasForeignKey(d => d.IdEncabezadoVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_EntregaMedicamentos_Presentaciones_Detalle_Far_Encabezado_Venta");

                entity.HasOne(d => d.IdEntregaMedicamentosPresentacionNavigation)
                    .WithMany(p => p.FarEntregaMedicamentosPresentacionesDetalles)
                    .HasForeignKey(d => d.IdEntregaMedicamentosPresentacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_EntregaMedicamentos_Presentaciones_Detalle_Far_EntregaMedicamentos_Presentaciones");
            });

            modelBuilder.Entity<FarIdentificacionCompra>(entity =>
            {
                entity.HasKey(e => e.IdIdentificacionCompras);

                entity.ToTable("Far_Identificacion_Compras");

                entity.Property(e => e.IdIdentificacionCompras).HasColumnName("IdIdentificacion_Compras");

                entity.Property(e => e.IdDetalleCompras).HasColumnName("IdDetalle_Compras");

                entity.Property(e => e.IdDetalleVentas).HasColumnName("IdDetalle_ventas");

                entity.Property(e => e.NroLote)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NroSerie)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Vence).HasColumnType("date");

                entity.HasOne(d => d.IdDetalleComprasNavigation)
                    .WithMany(p => p.FarIdentificacionCompras)
                    .HasForeignKey(d => d.IdDetalleCompras)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Identificacion_Compras_Far_Detalle_Compras");

                entity.HasOne(d => d.IdDetalleVentasNavigation)
                    .WithMany(p => p.FarIdentificacionCompras)
                    .HasForeignKey(d => d.IdDetalleVentas)
                    .HasConstraintName("FK_Far_Identificacion_Compras_Far_Detalle_Ventas");
            });

            modelBuilder.Entity<FarPresupuesto>(entity =>
            {
                entity.HasKey(e => e.PresupuestoId);

                entity.ToTable("Far_Presupuesto");

                entity.Property(e => e.PresupuestoId).HasColumnName("PresupuestoID");

                entity.Property(e => e.Crea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("date");
            });

            modelBuilder.Entity<FarPresupuestoDetalle>(entity =>
            {
                entity.HasKey(e => e.PresupuestoDetalleId);

                entity.ToTable("Far_PresupuestoDetalle");

                entity.Property(e => e.PresupuestoDetalleId).HasColumnName("PresupuestoDetalleID");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Coseguro).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Crea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.Iosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioVenta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.PresupuestoId).HasColumnName("PresupuestoID");

                entity.Property(e => e.Reconoce).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.Presupuesto)
                    .WithMany(p => p.FarPresupuestoDetalles)
                    .HasForeignKey(d => d.PresupuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_PresupuestoDetalle_Far_Presupuesto");
            });

            modelBuilder.Entity<FarRemitoTemporalDetalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalleTemporal);

                entity.ToTable("Far_RemitoTemporal_Detalle");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CantidadRecibida)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("Cantidad_Recibida");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Gtin)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Lote)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RemitoNumero)
                    .HasMaxLength(14)
                    .HasColumnName("Remito_Numero")
                    .IsFixedLength();

                entity.Property(e => e.Vence)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEncabezadoTemporalNavigation)
                    .WithMany(p => p.FarRemitoTemporalDetalles)
                    .HasForeignKey(d => d.IdEncabezadoTemporal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_RemitoTemporal_Detalle_Far_RemitoTemporal_Encabezado");
            });

            modelBuilder.Entity<FarRemitoTemporalDetalleLoteVto>(entity =>
            {
                entity.HasKey(e => e.IdDetalleTemporalLoteVto);

                entity.ToTable("Far_RemitoTemporal_Detalle_LoteVto");

                entity.Property(e => e.CantidadRecibida)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("Cantidad_Recibida");

                entity.Property(e => e.Lote)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Vence)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDetalleTemporalNavigation)
                    .WithMany(p => p.FarRemitoTemporalDetalleLoteVtos)
                    .HasForeignKey(d => d.IdDetalleTemporal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_RemitoTemporal_Detalle_LoteVto_Far_RemitoTemporal_Detalle");
            });

            modelBuilder.Entity<FarRemitoTemporalEncabezado>(entity =>
            {
                entity.HasKey(e => e.IdEncabezadoTemporal);

                entity.ToTable("Far_RemitoTemporal_Encabezado");

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRecibido)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Recibido");

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.HoraRecibido)
                    .HasMaxLength(4)
                    .HasColumnName("Hora_Recibido")
                    .IsFixedLength();

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .HasColumnName("OpMOdi")
                    .IsFixedLength();

                entity.Property(e => e.RecibidoFaltantes)
                    .HasColumnName("Recibido_Faltantes")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.FarRemitoTemporalEncabezados)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_RemitoTemporal_Encabezado_EstadoId");

                entity.HasOne(d => d.SucursalDestino)
                    .WithMany(p => p.FarRemitoTemporalEncabezadoSucursalDestinos)
                    .HasForeignKey(d => d.SucursalDestinoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_RemitoTemporal_Encabezado_SucursalDestinoId");

                entity.HasOne(d => d.SucursalOrigen)
                    .WithMany(p => p.FarRemitoTemporalEncabezadoSucursalOrigens)
                    .HasForeignKey(d => d.SucursalOrigenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_RemitoTemporal_Encabezado_SucursalOrigenId");
            });

            modelBuilder.Entity<FarRemitoTemporalPresentacione>(entity =>
            {
                entity.HasKey(e => e.IdPresentacionRemito);

                entity.ToTable("Far_RemitoTemporal_Presentaciones");

                entity.Property(e => e.Crea).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Modi).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FarRemitoTemporalPresentacionesDetalle>(entity =>
            {
                entity.HasKey(e => e.IdPresentacionRemitoDetalle);

                entity.ToTable("Far_RemitoTemporal_Presentaciones_Detalle");

                entity.HasOne(d => d.IdEncabezadoTemporalNavigation)
                    .WithMany(p => p.FarRemitoTemporalPresentacionesDetalles)
                    .HasForeignKey(d => d.IdEncabezadoTemporal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_RemitoTemporal_Presentaciones_Detalle_Far_RemitoTemporal_Encabezado");

                entity.HasOne(d => d.IdPresentacionRemitoNavigation)
                    .WithMany(p => p.FarRemitoTemporalPresentacionesDetalles)
                    .HasForeignKey(d => d.IdPresentacionRemito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_RemitoTemporal_Presentaciones_Detalle_Far_RemitoTemporal_Presentaciones");
            });

            modelBuilder.Entity<FarSucursale>(entity =>
            {
                entity.HasKey(e => e.SucursalId);

                entity.ToTable("Far_Sucursales");

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.PuntoVenta)
                    .HasMaxLength(4)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FarTipoMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdTipoMovimiento);

                entity.ToTable("Far_Tipo_Movimiento");

                entity.Property(e => e.IdTipoMovimiento).HasColumnName("IdTipo_Movimiento");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.VentaCompra)
                    .HasMaxLength(1)
                    .HasColumnName("Venta_Compra")
                    .HasDefaultValueSql("(N'A')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<FarVentaPendiente>(entity =>
            {
                entity.ToTable("Far_Venta_Pendiente");

                entity.Property(e => e.FarVentaPendienteId).HasColumnName("FarVentaPendienteID");

                entity.Property(e => e.AfiliadoId).HasColumnName("AfiliadoID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaModi).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.SucursalId).HasColumnName("SucursalID");

                entity.Property(e => e.TipoEntregaMedicacionId).HasColumnName("TipoEntregaMedicacionID");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.FarVentaPendientes)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Venta_Pendiente_Far_Sucursales");

                entity.HasOne(d => d.TipoEntregaMedicacion)
                    .WithMany(p => p.FarVentaPendientes)
                    .HasForeignKey(d => d.TipoEntregaMedicacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Venta_Pendiente_TipoEntregaMedicacion");
            });

            modelBuilder.Entity<FarVentasPago>(entity =>
            {
                entity.HasKey(e => e.IdExtraPagos);

                entity.ToTable("Far_Ventas_Pagos");

                entity.Property(e => e.IdExtraPagos).HasColumnName("IdExtra_Pagos");

                entity.Property(e => e.IdEncabezadoVenta).HasColumnName("IdEncabezado_venta");

                entity.Property(e => e.TotalCredito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCreditoSinInteres).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorCuota).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdEncabezadoVentaNavigation)
                    .WithMany(p => p.FarVentasPagos)
                    .HasForeignKey(d => d.IdEncabezadoVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Far_Ventas_Pagos_Far_Encabezado_Venta");
            });

            modelBuilder.Entity<Feriado>(entity =>
            {
                entity.ToTable("Feriado");

                entity.Property(e => e.FeriadoId).HasColumnName("FeriadoID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FeriadoFecha).HasColumnType("datetime");

                entity.Property(e => e.FeriadoHoraDesde)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FeriadoHoraHasta)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.TipoFeriadoId).HasColumnName("TipoFeriadoID");
            });

            modelBuilder.Entity<FueraProvDetalleAutorizacion>(entity =>
            {
                entity.HasKey(e => e.IdDetalleAutorizacion);

                entity.ToTable("FueraProv_DetalleAutorizacion");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CoseguroGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CoseguroHonorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditoGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditoHonorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitoGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitoHonorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaPrestacion).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Practica)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDetallePresentacionNavigation)
                    .WithMany(p => p.FueraProvDetalleAutorizacions)
                    .HasForeignKey(d => d.IdDetallePresentacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FueraProv_DetalleAutorizacion_FueraProv_DetallePresentacion");
            });

            modelBuilder.Entity<FueraProvDetallePresentacion>(entity =>
            {
                entity.HasKey(e => e.IdDetallePresentacion);

                entity.ToTable("FueraProv_DetallePresentacion");

                entity.Property(e => e.Art).HasColumnName("ART");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaInternacion).HasColumnType("datetime");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEncabezadoNavigation)
                    .WithMany(p => p.FueraProvDetallePresentacions)
                    .HasForeignKey(d => d.IdEncabezado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FueraProv_DetallePresentacion_FueraProv_EncabezadoPresentacion");
            });

            modelBuilder.Entity<FueraProvEncabezadoPresentacion>(entity =>
            {
                entity.HasKey(e => e.IdEncabezado);

                entity.ToTable("FueraProv_EncabezadoPresentacion");

                entity.Property(e => e.FechaCierreAuditoria).HasColumnType("datetime");

                entity.Property(e => e.FechaCierreCompartida).HasColumnType("datetime");

                entity.Property(e => e.FechaCierrePresentacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpCierreAuditoria)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCierreCompartida)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCierrePresentacion)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FueraProvFactura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("FueraProv_Facturas");

                entity.Property(e => e.Factura)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdEncabezadoNavigation)
                    .WithMany(p => p.FueraProvFacturas)
                    .HasForeignKey(d => d.IdEncabezado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FueraProv_Facturas_FueraProv_EncabezadoPresentacion");
            });

            modelBuilder.Entity<GrupoMedicamento>(entity =>
            {
                entity.HasKey(e => e.IdGrupoMedicamentos);

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NombreGrupo).HasMaxLength(150);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GrupoMedicamentosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdGrupoMedicamentosDetalle);

                entity.ToTable("GrupoMedicamentosDetalle");

                entity.Property(e => e.FechaAnula).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ImpresionOrdene>(entity =>
            {
                entity.HasKey(e => e.IdImpresion);

                entity.ToTable("Impresion_Ordenes");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IncCampo>(entity =>
            {
                entity.HasKey(e => e.CampoId);

                entity.ToTable("Inc_Campos");

                entity.Property(e => e.CampoId).HasColumnName("CampoID");

                entity.Property(e => e.Condicional).IsUnicode(false);

                entity.Property(e => e.Css).IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Style).IsUnicode(false);

                entity.Property(e => e.TipoCampoId).HasColumnName("TipoCampoID");

                entity.Property(e => e.ValorMaximo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorMinimo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoCampo)
                    .WithMany(p => p.IncCampos)
                    .HasForeignKey(d => d.TipoCampoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Campos_Inc_TiposCampos");
            });

            modelBuilder.Entity<IncCamposGuardado>(entity =>
            {
                entity.HasKey(e => e.CamposGuardadosId);

                entity.ToTable("Inc_CamposGuardados");

                entity.Property(e => e.CamposGuardadosId).HasColumnName("CamposGuardadosID");

                entity.Property(e => e.CampoId).HasColumnName("CampoID");

                entity.Property(e => e.MovIncidenciaHeadId).HasColumnName("MovIncidenciaHeadID");

                entity.Property(e => e.Texto).IsUnicode(false);

                entity.Property(e => e.Valor).IsUnicode(false);

                entity.HasOne(d => d.Campo)
                    .WithMany(p => p.IncCamposGuardados)
                    .HasForeignKey(d => d.CampoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_CamposGuardados_Inc_Campos");

                entity.HasOne(d => d.MovIncidenciaHead)
                    .WithMany(p => p.IncCamposGuardados)
                    .HasForeignKey(d => d.MovIncidenciaHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_CamposGuardados_Inc_MovIncidenciasHead");
            });

            modelBuilder.Entity<IncCamposValore>(entity =>
            {
                entity.HasKey(e => e.CampoValorId);

                entity.ToTable("Inc_CamposValores");

                entity.Property(e => e.CampoValorId).HasColumnName("CampoValorID");

                entity.Property(e => e.CampoId).HasColumnName("CampoID");

                entity.Property(e => e.IsDisabled).HasColumnName("isDisabled");

                entity.Property(e => e.RelacionModel).IsUnicode(false);

                entity.HasOne(d => d.Campo)
                    .WithMany(p => p.IncCamposValores)
                    .HasForeignKey(d => d.CampoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_CamposValores_Inc_Campos");
            });

            modelBuilder.Entity<IncCategoriasProyecto>(entity =>
            {
                entity.HasKey(e => e.CategoriaProyectoId);

                entity.ToTable("Inc_CategoriasProyectos");

                entity.Property(e => e.CategoriaProyectoId).HasColumnName("CategoriaProyectoID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IncCategorium>(entity =>
            {
                entity.HasKey(e => e.CategoriaId);

                entity.ToTable("Inc_Categoria");

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.Color)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncEstado>(entity =>
            {
                entity.HasKey(e => e.EstadoId);

                entity.ToTable("Inc_Estados");

                entity.Property(e => e.EstadoId).HasColumnName("EstadoID");

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.IncEstados)
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Estados_Inc_Categoria");
            });

            modelBuilder.Entity<IncEstadosXproyecto>(entity =>
            {
                entity.ToTable("Inc_EstadosXProyecto");

                entity.Property(e => e.IncEstadosXproyectoId).HasColumnName("Inc_EstadosXProyectoID");

                entity.Property(e => e.EstadoId).HasColumnName("EstadoID");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.UsuarioAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.IncEstadosXproyectos)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_EstadosXProyecto_Inc_Estados");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.IncEstadosXproyectos)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_EstadosXProyecto_Inc_Proyectos");
            });

            modelBuilder.Entity<IncEtiqueta>(entity =>
            {
                entity.HasKey(e => e.EtiquetaId);

                entity.ToTable("Inc_Etiquetas");

                entity.Property(e => e.EtiquetaId).HasColumnName("EtiquetaID");

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<IncEtiquetasDetalle>(entity =>
            {
                entity.HasKey(e => e.EtiquetaDetalleId);

                entity.ToTable("Inc_EtiquetasDetalle");

                entity.Property(e => e.EtiquetaDetalleId).HasColumnName("EtiquetaDetalleID");

                entity.Property(e => e.EtiquetaId).HasColumnName("EtiquetaID");

                entity.Property(e => e.MovIncidenciaHeadId).HasColumnName("MovIncidenciaHeadID");

                entity.HasOne(d => d.Etiqueta)
                    .WithMany(p => p.IncEtiquetasDetalles)
                    .HasForeignKey(d => d.EtiquetaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_EtiquetasDetalle_Inc_Etiquetas");

                entity.HasOne(d => d.MovIncidenciaHead)
                    .WithMany(p => p.IncEtiquetasDetalles)
                    .HasForeignKey(d => d.MovIncidenciaHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_EtiquetasDetalle_Inc_MovIncidenciasHead");
            });

            modelBuilder.Entity<IncEvento>(entity =>
            {
                entity.HasKey(e => e.EventoId);

                entity.ToTable("Inc_Eventos");

                entity.Property(e => e.EventoId).HasColumnName("EventoID");

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.EstadoId).HasColumnName("EstadoID");

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.Property(e => e.MovIncidenciaHeadId).HasColumnName("MovIncidenciaHeadID");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.IncEventos)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK_Inc_Eventos_Inc_Estados");
            });

            modelBuilder.Entity<IncFlujodeTrabajo>(entity =>
            {
                entity.HasKey(e => e.FlujodeTrabajoId);

                entity.ToTable("Inc_FlujodeTrabajo");

                entity.Property(e => e.FlujodeTrabajoId).HasColumnName("FlujodeTrabajoID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IncFlujosEsquema>(entity =>
            {
                entity.HasKey(e => e.FlujoEsquemaId);

                entity.ToTable("Inc_FlujosEsquemas");

                entity.Property(e => e.FlujoEsquemaId).HasColumnName("FlujoEsquemaID");

                entity.Property(e => e.FlujoMovimientoId).HasColumnName("FlujoMovimientoID");

                entity.HasOne(d => d.FlujoMovimiento)
                    .WithMany(p => p.IncFlujosEsquemas)
                    .HasForeignKey(d => d.FlujoMovimientoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_FlujosEsquemas_Inc_FlujosMovimientos");
            });

            modelBuilder.Entity<IncFlujosMovimiento>(entity =>
            {
                entity.HasKey(e => e.FlujoMovimientoId);

                entity.ToTable("Inc_FlujosMovimientos");

                entity.Property(e => e.FlujoMovimientoId).HasColumnName("FlujoMovimientoID");

                entity.Property(e => e.EstadoId).HasColumnName("EstadoID");

                entity.Property(e => e.FlujodeTrabajoId).HasColumnName("FlujodeTrabajoID");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.IncFlujosMovimientos)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_FlujosMovimientos_Inc_Estados");

                entity.HasOne(d => d.FlujodeTrabajo)
                    .WithMany(p => p.IncFlujosMovimientos)
                    .HasForeignKey(d => d.FlujodeTrabajoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_FlujosMovimientos_Inc_FlujodeTrabajo");
            });

            modelBuilder.Entity<IncIncidenciasxProyecto>(entity =>
            {
                entity.HasKey(e => e.IncidenciaId)
                    .HasName("PK_Inc_Incidencias");

                entity.ToTable("Inc_IncidenciasxProyecto");

                entity.Property(e => e.IncidenciaId).HasColumnName("IncidenciaID");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.TipoIncidenciaId).HasColumnName("TipoIncidenciaID");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.IncIncidenciasxProyectos)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Incidencias_Inc_Proyectos");
            });

            modelBuilder.Entity<IncMovComentario>(entity =>
            {
                entity.HasKey(e => e.MovComentarioId);

                entity.ToTable("Inc_MovComentarios");

                entity.Property(e => e.MovComentarioId).HasColumnName("MovComentarioID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.MovIncidenciaHeadId).HasColumnName("MovIncidenciaHeadID");

                entity.Property(e => e.RespuestaId).HasColumnName("RespuestaID");

                entity.HasOne(d => d.MovIncidenciaHead)
                    .WithMany(p => p.IncMovComentarios)
                    .HasForeignKey(d => d.MovIncidenciaHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovComentarios_Inc_MovIncidenciasHead");
            });

            modelBuilder.Entity<IncMovIncidencia>(entity =>
            {
                entity.HasKey(e => e.MovIncidenciaId);

                entity.ToTable("Inc_MovIncidencias");

                entity.Property(e => e.MovIncidenciaId).HasColumnName("MovIncidenciaID");

                entity.Property(e => e.EstadoId).HasColumnName("EstadoID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.MovIncidenciaHeadId).HasColumnName("MovIncidenciaHeadID");

                entity.Property(e => e.ResolucionId).HasColumnName("ResolucionID");

                entity.Property(e => e.Resumen).HasMaxLength(256);

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.IncMovIncidencia)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovIncidencias_Inc_Estados");

                entity.HasOne(d => d.MovIncidenciaHead)
                    .WithMany(p => p.IncMovIncidencia)
                    .HasForeignKey(d => d.MovIncidenciaHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovIncidencias_Inc_MovIncidenciasHead");

                entity.HasOne(d => d.Resolucion)
                    .WithMany(p => p.IncMovIncidencia)
                    .HasForeignKey(d => d.ResolucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovIncidencias_Inc_Resoluciones");
            });

            modelBuilder.Entity<IncMovIncidenciaAdjunto>(entity =>
            {
                entity.HasKey(e => e.MovAdjuntosId);

                entity.ToTable("Inc_MovIncidenciaAdjuntos");

                entity.Property(e => e.MovAdjuntosId).HasColumnName("MovAdjuntosID");

                entity.Property(e => e.FechaCreado).HasColumnType("datetime");

                entity.Property(e => e.Formato)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.MovIncidenciaHeadId).HasColumnName("MovIncidenciaHeadID");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.MovIncidenciaHead)
                    .WithMany(p => p.IncMovIncidenciaAdjuntos)
                    .HasForeignKey(d => d.MovIncidenciaHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovIncidenciaAdjuntos_Inc_MovIncidenciasHead");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.IncMovIncidenciaAdjuntos)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovIncidenciaAdjuntos_Inc_Proyectos_Usuarios");
            });

            modelBuilder.Entity<IncMovIncidenciasHead>(entity =>
            {
                entity.HasKey(e => e.MovIncidenciaHeadId);

                entity.ToTable("Inc_MovIncidenciasHead");

                entity.Property(e => e.MovIncidenciaHeadId).HasColumnName("MovIncidenciaHeadID");

                entity.Property(e => e.FechaCambio).HasColumnType("datetime");

                entity.Property(e => e.FechaCreado).HasColumnType("datetime");

                entity.Property(e => e.InformadorId).HasColumnName("InformadorID");

                entity.Property(e => e.PrioridadId).HasColumnName("PrioridadID");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.PuntoHistoria)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableId).HasColumnName("ResponsableID");

                entity.Property(e => e.TipoIncidenciaId).HasColumnName("TipoIncidenciaID");

                entity.HasOne(d => d.Informador)
                    .WithMany(p => p.IncMovIncidenciasHeadInformadors)
                    .HasForeignKey(d => d.InformadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovIncidenciasHead_Inc_Proyectos_Usuarios");

                entity.HasOne(d => d.Prioridad)
                    .WithMany(p => p.IncMovIncidenciasHeads)
                    .HasForeignKey(d => d.PrioridadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovIncidenciasHead_Inc_Prioridad");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.IncMovIncidenciasHeads)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovIncidenciasHead_Inc_Proyectos");

                entity.HasOne(d => d.Responsable)
                    .WithMany(p => p.IncMovIncidenciasHeadResponsables)
                    .HasForeignKey(d => d.ResponsableId)
                    .HasConstraintName("FK_Inc_MovIncidenciasHead_Inc_Proyectos_Usuarios1");

                entity.HasOne(d => d.TipoIncidencia)
                    .WithMany(p => p.IncMovIncidenciasHeads)
                    .HasForeignKey(d => d.TipoIncidenciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovIncidenciasHead_Inc_TiposIncidencias");
            });

            modelBuilder.Entity<IncMovLog>(entity =>
            {
                entity.HasKey(e => e.MovLogId);

                entity.ToTable("Inc_MovLog");

                entity.Property(e => e.MovLogId).HasColumnName("MovLogID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Tabla)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMovLogAccionId).HasColumnName("TipoMovLogAccionID");

                entity.Property(e => e.TipoMovLogId).HasColumnName("TipoMovLogID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.TipoMovLogAccion)
                    .WithMany(p => p.IncMovLogs)
                    .HasForeignKey(d => d.TipoMovLogAccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovLog_Inc_TipoMovLogAccion");

                entity.HasOne(d => d.TipoMovLog)
                    .WithMany(p => p.IncMovLogs)
                    .HasForeignKey(d => d.TipoMovLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_MovLog_Inc_TipoMovLog");
            });

            modelBuilder.Entity<IncPantalla>(entity =>
            {
                entity.HasKey(e => e.PantallaId)
                    .HasName("PK_Inc_TiposPantallas");

                entity.ToTable("Inc_Pantallas");

                entity.Property(e => e.PantallaId).HasColumnName("PantallaID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IncPantallasEsquema>(entity =>
            {
                entity.HasKey(e => e.PantallaEsquemaId)
                    .HasName("PK_Inc_PantallasEsquemas_1");

                entity.ToTable("Inc_PantallasEsquemas");

                entity.Property(e => e.PantallaEsquemaId).HasColumnName("PantallaEsquemaID");

                entity.Property(e => e.CampoId).HasColumnName("CampoID");

                entity.Property(e => e.CampoIdhabilita).HasColumnName("CampoIDHabilita");

                entity.Property(e => e.Mostrar)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PantallaId).HasColumnName("PantallaID");

                entity.Property(e => e.Tamano)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('col-md-12')");

                entity.HasOne(d => d.Campo)
                    .WithMany(p => p.IncPantallasEsquemas)
                    .HasForeignKey(d => d.CampoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_PantallasEsquemas_Inc_Campos");

                entity.HasOne(d => d.Pantalla)
                    .WithMany(p => p.IncPantallasEsquemas)
                    .HasForeignKey(d => d.PantallaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_PantallasEsquemas_Inc_Pantallas");
            });

            modelBuilder.Entity<IncPantallasEsquemaRole>(entity =>
            {
                entity.HasKey(e => e.RolesId);

                entity.ToTable("Inc_PantallasEsquemaRoles");

                entity.Property(e => e.RolesId).HasColumnName("RolesID");

                entity.Property(e => e.EsquemaId).HasColumnName("EsquemaID");

                entity.Property(e => e.Rol)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.HasOne(d => d.Esquema)
                    .WithMany(p => p.IncPantallasEsquemaRoles)
                    .HasForeignKey(d => d.EsquemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_PantallasEsquemaRoles_Inc_PantallasEsquemas");
            });

            modelBuilder.Entity<IncPantallasxIncidencia>(entity =>
            {
                entity.HasKey(e => e.PantallaxIncidenciaId);

                entity.ToTable("Inc_PantallasxIncidencias");

                entity.Property(e => e.PantallaxIncidenciaId).HasColumnName("PantallaxIncidenciaID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.PantallaId).HasColumnName("PantallaID");

                entity.Property(e => e.Tamano)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'col-md-12')");

                entity.Property(e => e.TipoIncidenciaId).HasColumnName("TipoIncidenciaID");

                entity.HasOne(d => d.Pantalla)
                    .WithMany(p => p.IncPantallasxIncidencia)
                    .HasForeignKey(d => d.PantallaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_PantallasxIncidencias_Inc_Pantallas");

                entity.HasOne(d => d.TipoIncidencia)
                    .WithMany(p => p.IncPantallasxIncidencia)
                    .HasForeignKey(d => d.TipoIncidenciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_PantallasxIncidencias_Inc_TiposIncidencias");
            });

            modelBuilder.Entity<IncPermiso>(entity =>
            {
                entity.HasKey(e => e.PermisoId);

                entity.ToTable("Inc_Permisos");

                entity.Property(e => e.PermisoId).HasColumnName("PermisoID");

                entity.Property(e => e.Codigo).HasMaxLength(7);

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<IncPrioridad>(entity =>
            {
                entity.HasKey(e => e.PrioridadId);

                entity.ToTable("Inc_Prioridad");

                entity.Property(e => e.PrioridadId).HasColumnName("PrioridadID");

                entity.Property(e => e.Color)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IncProyecto>(entity =>
            {
                entity.HasKey(e => e.ProyectoId);

                entity.ToTable("Inc_Proyectos");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.CategoriaProyectoId).HasColumnName("CategoriaProyectoID");

                entity.Property(e => e.Clave)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaUsuario)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.FlujodeTrabajoId).HasColumnName("FlujodeTrabajoID");

                entity.Property(e => e.Lider).HasMaxLength(128);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.TipoProyectoId).HasColumnName("TipoProyectoID");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.CategoriaProyecto)
                    .WithMany(p => p.IncProyectos)
                    .HasForeignKey(d => d.CategoriaProyectoId)
                    .HasConstraintName("FK_Inc_Proyectos_Inc_CategoriasProyectos");

                entity.HasOne(d => d.FlujodeTrabajo)
                    .WithMany(p => p.IncProyectos)
                    .HasForeignKey(d => d.FlujodeTrabajoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Proyectos_Inc_FlujodeTrabajo");

                entity.HasOne(d => d.TipoProyecto)
                    .WithMany(p => p.IncProyectos)
                    .HasForeignKey(d => d.TipoProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Proyectos_Inc_TiposProyectos");
            });

            modelBuilder.Entity<IncProyectosDiasLaborable>(entity =>
            {
                entity.HasKey(e => e.ProyectoDiaLaborableId);

                entity.ToTable("Inc_Proyectos_DiasLaborables");

                entity.Property(e => e.ProyectoDiaLaborableId).HasColumnName("ProyectoDiaLaborableID");

                entity.Property(e => e.Jueves)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lunes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Martes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Miercoles)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.Viernes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.IncProyectosDiasLaborables)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Proyectos_DiasLaborables_Inc_Proyectos");
            });

            modelBuilder.Entity<IncProyectosDiasNoLaborable>(entity =>
            {
                entity.HasKey(e => e.ProyectoDiaNoLaborableId);

                entity.ToTable("Inc_Proyectos_DiasNoLaborables");

                entity.Property(e => e.ProyectoDiaNoLaborableId).HasColumnName("ProyectoDiaNoLaborableID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.IncProyectosDiasNoLaborables)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Proyectos_DiasNoLaborables_Inc_Proyectos");
            });

            modelBuilder.Entity<IncProyectosHorasTrabajoUsuario>(entity =>
            {
                entity.HasKey(e => e.ProyectoHorasTrabajoUsuarioId);

                entity.ToTable("Inc_Proyectos_HorasTrabajoUsuario");

                entity.Property(e => e.ProyectoHorasTrabajoUsuarioId).HasColumnName("ProyectoHorasTrabajoUsuarioID");

                entity.Property(e => e.CantidadHoras).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.ProyectoUsuarioId).HasColumnName("ProyectoUsuarioID");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.IncProyectosHorasTrabajoUsuarios)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Proyectos_HorasTrabajoUsuario_Inc_Proyectos");

                entity.HasOne(d => d.ProyectoUsuario)
                    .WithMany(p => p.IncProyectosHorasTrabajoUsuarios)
                    .HasForeignKey(d => d.ProyectoUsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Proyectos_HorasTrabajoUsuario_Inc_Proyectos_Usuarios");
            });

            modelBuilder.Entity<IncProyectosUsuario>(entity =>
            {
                entity.HasKey(e => e.ProyectoUsuarioId);

                entity.ToTable("Inc_Proyectos_Usuarios");

                entity.Property(e => e.ProyectoUsuarioId).HasColumnName("ProyectoUsuarioID");

                entity.Property(e => e.FechaCrea).HasColumnType("date");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.Usuario).HasMaxLength(128);

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.IncProyectosUsuarios)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Proyectos_Usuarios_Inc_Proyectos");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.IncProyectosUsuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Proyectos_Usuarios_Inc_Roles");
            });

            modelBuilder.Entity<IncRecordatorio>(entity =>
            {
                entity.HasKey(e => e.RecordatorioId);

                entity.ToTable("Inc_Recordatorios");

                entity.Property(e => e.RecordatorioId).HasColumnName("RecordatorioID");

                entity.Property(e => e.Avisado).HasColumnType("datetime");

                entity.Property(e => e.EventoId).HasColumnName("EventoID");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.TipoTiempo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Visto).HasColumnType("datetime");

                entity.HasOne(d => d.Evento)
                    .WithMany(p => p.IncRecordatorios)
                    .HasForeignKey(d => d.EventoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Recordatorios_Inc_Eventos");
            });

            modelBuilder.Entity<IncResolucione>(entity =>
            {
                entity.HasKey(e => e.ResolucionesId);

                entity.ToTable("Inc_Resoluciones");

                entity.Property(e => e.ResolucionesId).HasColumnName("ResolucionesID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IncRole>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.ToTable("Inc_Roles");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<IncRolesPermiso>(entity =>
            {
                entity.HasKey(e => e.RolPermisoId);

                entity.ToTable("Inc_Roles_Permisos");

                entity.Property(e => e.RolPermisoId).HasColumnName("RolPermisoID");

                entity.Property(e => e.PermisoId).HasColumnName("PermisoID");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.HasOne(d => d.Permiso)
                    .WithMany(p => p.IncRolesPermisos)
                    .HasForeignKey(d => d.PermisoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Roles_Permisos_Inc_Permisos");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.IncRolesPermisos)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Roles_Permisos_Inc_Roles");
            });

            modelBuilder.Entity<IncRolesxProyecto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inc_RolesxProyecto");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(128)
                    .HasColumnName("RoleID");

                entity.HasOne(d => d.Proyecto)
                    .WithMany()
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_RolesxProyecto_Inc_Proyectos");
            });

            modelBuilder.Entity<IncSprint>(entity =>
            {
                entity.HasKey(e => e.SprintId);

                entity.ToTable("Inc_Sprint");

                entity.Property(e => e.SprintId).HasColumnName("SprintID");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaUsuarioId).HasColumnName("CreaUsuarioID");

                entity.Property(e => e.DuracionSemanas).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FechaFinAsignada).HasColumnType("datetime");

                entity.Property(e => e.FechaFinReal).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioAsignada).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioReal).HasColumnType("datetime");

                entity.Property(e => e.Meta).HasMaxLength(200);

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiUsuarioId).HasColumnName("ModiUsuarioID");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");

                entity.HasOne(d => d.CreaUsuario)
                    .WithMany(p => p.IncSprintCreaUsuarios)
                    .HasForeignKey(d => d.CreaUsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Sprint_Inc_Proyectos_Usuarios");

                entity.HasOne(d => d.ModiUsuario)
                    .WithMany(p => p.IncSprintModiUsuarios)
                    .HasForeignKey(d => d.ModiUsuarioId)
                    .HasConstraintName("FK_Inc_Sprint_Inc_Proyectos_Usuarios1");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.IncSprints)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Sprint_Inc_Proyectos");
            });

            modelBuilder.Entity<IncSprintDetalle>(entity =>
            {
                entity.HasKey(e => e.SprintDetalleId);

                entity.ToTable("Inc_SprintDetalle");

                entity.Property(e => e.SprintDetalleId).HasColumnName("SprintDetalleID");

                entity.Property(e => e.CreaFecha).HasColumnType("datetime");

                entity.Property(e => e.CreaUsuarioId).HasColumnName("CreaUsuarioID");

                entity.Property(e => e.Estado).HasMaxLength(20);

                entity.Property(e => e.ModiFecha).HasColumnType("datetime");

                entity.Property(e => e.ModiUsuarioId).HasColumnName("ModiUsuarioID");

                entity.Property(e => e.MovIncidenciaHeadId).HasColumnName("MovIncidenciaHeadID");

                entity.Property(e => e.SprintId).HasColumnName("SprintID");

                entity.HasOne(d => d.CreaUsuario)
                    .WithMany(p => p.IncSprintDetalleCreaUsuarios)
                    .HasForeignKey(d => d.CreaUsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_SprintDetalle_Inc_Proyectos_Usuarios");

                entity.HasOne(d => d.ModiUsuario)
                    .WithMany(p => p.IncSprintDetalleModiUsuarios)
                    .HasForeignKey(d => d.ModiUsuarioId)
                    .HasConstraintName("FK_Inc_SprintDetalle_Inc_Proyectos_Usuarios1");

                entity.HasOne(d => d.MovIncidenciaHead)
                    .WithMany(p => p.IncSprintDetalles)
                    .HasForeignKey(d => d.MovIncidenciaHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_SprintDetalle_Inc_MovIncidenciasHead");

                entity.HasOne(d => d.Sprint)
                    .WithMany(p => p.IncSprintDetalles)
                    .HasForeignKey(d => d.SprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_SprintDetalle_Inc_Sprint");
            });

            modelBuilder.Entity<IncTipoMovLog>(entity =>
            {
                entity.HasKey(e => e.TipoMovLogId);

                entity.ToTable("Inc_TipoMovLog");

                entity.Property(e => e.TipoMovLogId).HasColumnName("TipoMovLogID");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<IncTipoMovLogAccion>(entity =>
            {
                entity.HasKey(e => e.TipoMovLogAccionId);

                entity.ToTable("Inc_TipoMovLogAccion");

                entity.Property(e => e.TipoMovLogAccionId).HasColumnName("TipoMovLogAccionID");

                entity.Property(e => e.Accion).HasMaxLength(20);

                entity.Property(e => e.Codigo).HasMaxLength(15);

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<IncTiposCampo>(entity =>
            {
                entity.HasKey(e => e.TipoCampoId);

                entity.ToTable("Inc_TiposCampos");

                entity.Property(e => e.TipoCampoId).HasColumnName("TipoCampoID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Objeto)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IncTiposIncidencia>(entity =>
            {
                entity.HasKey(e => e.TipoIncidenciaId);

                entity.ToTable("Inc_TiposIncidencias");

                entity.Property(e => e.TipoIncidenciaId).HasColumnName("TipoIncidenciaID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IncTiposProyecto>(entity =>
            {
                entity.HasKey(e => e.TipoProyectoId);

                entity.ToTable("Inc_TiposProyectos");

                entity.Property(e => e.TipoProyectoId).HasColumnName("TipoProyectoID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IncVoto>(entity =>
            {
                entity.HasKey(e => e.VotosId);

                entity.ToTable("Inc_Votos");

                entity.Property(e => e.VotosId).HasColumnName("VotosID");

                entity.Property(e => e.MovIncidenciaHeadId).HasColumnName("MovIncidenciaHeadID");

                entity.HasOne(d => d.MovIncidenciaHead)
                    .WithMany(p => p.IncVotos)
                    .HasForeignKey(d => d.MovIncidenciaHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inc_Votos_Inc_MovIncidenciasHead");
            });

            modelBuilder.Entity<Indicadore>(entity =>
            {
                entity.HasKey(e => e.IdIndicador);

                entity.Property(e => e.BaseDeDatos).HasMaxLength(50);

                entity.Property(e => e.Detalle).HasMaxLength(75);

                entity.Property(e => e.FormulaDenominador)
                    .HasMaxLength(250)
                    .HasColumnName("Formula_Denominador");

                entity.Property(e => e.FormulaNumerador)
                    .HasMaxLength(250)
                    .HasColumnName("Formula_Numerador");

                entity.Property(e => e.IpBaseDeDatos).HasMaxLength(50);

                entity.Property(e => e.MultiplicadorCociente)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Multiplicador_Cociente");

                entity.Property(e => e.PasswordBaseDeDatos).HasMaxLength(50);

                entity.Property(e => e.UsuarioBaseDeDatos).HasMaxLength(50);

                entity.HasOne(d => d.IdCalculoAuxiliarNavigation)
                    .WithMany(p => p.Indicadores)
                    .HasForeignKey(d => d.IdCalculoAuxiliar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Indicadores_Calculo_Auxiliar");

                entity.HasOne(d => d.IdTipoDatoDenominadorNavigation)
                    .WithMany(p => p.IndicadoreIdTipoDatoDenominadorNavigations)
                    .HasForeignKey(d => d.IdTipoDatoDenominador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Indicadores_Tipo_Dato1");

                entity.HasOne(d => d.IdTipoDatoNumeradorNavigation)
                    .WithMany(p => p.IndicadoreIdTipoDatoNumeradorNavigations)
                    .HasForeignKey(d => d.IdTipoDatoNumerador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Indicadores_Tipo_Dato");

                entity.HasOne(d => d.IdTipoIndicadorNavigation)
                    .WithMany(p => p.Indicadores)
                    .HasForeignKey(d => d.IdTipoIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Indicadores_Tipo_Indicador");
            });

            modelBuilder.Entity<InsulinoLotesDetalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle);

                entity.ToTable("InsulinoLotes_Detalle");

                entity.Property(e => e.IdDetalle).HasColumnName("Id_Detalle");

                entity.Property(e => e.AfiliadoCuil)
                    .HasMaxLength(11)
                    .HasColumnName("Afiliado_cuil")
                    .IsFixedLength();

                entity.Property(e => e.CodFarmacia)
                    .HasMaxLength(20)
                    .HasColumnName("Cod_Farmacia");

                entity.Property(e => e.Codigo).HasMaxLength(20);

                entity.Property(e => e.CodigoIosep)
                    .HasMaxLength(12)
                    .HasColumnName("Codigo_iosep")
                    .IsFixedLength();

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.ImporteCoseguroAfiliado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Importe_Coseguro_Afiliado");

                entity.Property(e => e.MatriculaMedico)
                    .HasMaxLength(9)
                    .HasColumnName("Matricula_medico");

                entity.Property(e => e.Monodroga)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(44)
                    .HasColumnName("Nombre_comercial")
                    .IsFixedLength();

                entity.Property(e => e.NombreFarmacia)
                    .HasMaxLength(50)
                    .HasColumnName("Nombre_Farmacia")
                    .IsFixedLength();

                entity.Property(e => e.NombreMedico)
                    .HasMaxLength(200)
                    .HasColumnName("Nombre_Medico");

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InsulinoLotesEncabezado>(entity =>
            {
                entity.HasKey(e => e.EncabezadoId)
                    .HasName("PK__Insulino__97BF6E686F26FC3B");

                entity.ToTable("InsulinoLotes_Encabezado");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.Cae)
                    .HasMaxLength(14)
                    .HasColumnName("CAE");

                entity.Property(e => e.Cuit)
                    .HasMaxLength(15)
                    .HasColumnName("CUIT");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCierreAuditoria)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_CierreAuditoria");

                entity.Property(e => e.FechaCierrePresentacion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_CierrePresentacion");

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .HasColumnName("Numero_Factura")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierreAuditoria)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierreAuditoria")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierrePresentacion)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierrePresentacion")
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_Presentacion")
                    .IsFixedLength();

                entity.Property(e => e.TotalPresentado).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InterClinicaFactura>(entity =>
            {
                entity.HasKey(e => e.IdClinicaFactura);

                entity.ToTable("Inter_ClinicaFactura");

                entity.Property(e => e.IdClinicaFactura).HasColumnName("Id_ClinicaFactura");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.Factura)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Encabezado)
                    .WithMany(p => p.InterClinicaFacturas)
                    .HasForeignKey(d => d.EncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inter_ClinicaFactura_Inter_EncabezadoPresentacion");
            });

            modelBuilder.Entity<InterDetalleAutorizacion>(entity =>
            {
                entity.HasKey(e => e.IdDetalleAutorizacion);

                entity.ToTable("Inter_DetalleAutorizacion");

                entity.HasIndex(e => new { e.IdPractica, e.FechaPrestacion, e.Anulado }, "Index");

                entity.HasIndex(e => new { e.Codigo, e.Anulado, e.FechaPrestacion }, "Index_Inter_DetAutCodigoAnulFecha");

                entity.HasIndex(e => new { e.IdDetalleProtocolo, e.Anulado }, "ResumenDiscriminadoPorClinca4");

                entity.HasIndex(e => e.Anulado, "ResumenDiscriminadoPorClinica");

                entity.Property(e => e.IdDetalleAutorizacion).HasColumnName("Id_DetalleAutorizacion");

                entity.Property(e => e.ACompartida).HasColumnName("A_Compartida");

                entity.Property(e => e.AcreditaGastosPendiente).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AcreditaHonorariosPendiente).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CoseguroGastos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Gastos");

                entity.Property(e => e.CoseguroHonorarios)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Honorarios");

                entity.Property(e => e.CreditoGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditoHonorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitoGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitoHonorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_Debito");

                entity.Property(e => e.EncabezadoIdAcredita).HasColumnName("EncabezadoID_Acredita");

                entity.Property(e => e.FacturaGastos)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("Factura_Gastos");

                entity.Property(e => e.FacturaHonorarios)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("Factura_Honorarios");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaPrestacion).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdDetalleProtocolo).HasColumnName("Id_DetalleProtocolo");

                entity.Property(e => e.NombrePractica).HasMaxLength(175);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ReconoceGastos)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("Reconoce_Gastos");

                entity.Property(e => e.ReconoceHonorarios)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("Reconoce_Honorarios");

                entity.HasOne(d => d.IdDetalleProtocoloNavigation)
                    .WithMany(p => p.InterDetalleAutorizacions)
                    .HasForeignKey(d => d.IdDetalleProtocolo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inter_DetalleAutorizacion_Inter_DetalleProtocolo");
            });

            modelBuilder.Entity<InterDetalleAutorizacionAuditorium>(entity =>
            {
                entity.HasKey(e => e.IdDetalleAutorizacionAuditoria);

                entity.ToTable("Inter_DetalleAutorizacionAuditoria");

                entity.HasIndex(e => new { e.IdDetalleAutorizacion, e.Codigo, e.OpCrea }, "Index_IdDetalleCodigoOpCrea");

                entity.Property(e => e.IdDetalleAutorizacionAuditoria).HasColumnName("Id_DetalleAutorizacionAuditoria");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.CreditoGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditoHonorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitoGastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitoHonorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FacturaGastos)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("Factura_Gastos");

                entity.Property(e => e.FacturaHonorarios)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("Factura_Honorarios");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdDetalleAutorizacion).HasColumnName("Id_DetalleAutorizacion");

                entity.Property(e => e.NombrePractica).HasMaxLength(175);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InterDetalleMedicamento>(entity =>
            {
                entity.HasKey(e => e.IdDetalleMedicamentos);

                entity.ToTable("Inter_DetalleMedicamentos");

                entity.HasIndex(e => e.Anulado, "ResumenDiscriminadoPorClinca5");

                entity.HasIndex(e => new { e.IdEncabezadoMedicamento, e.Anulado }, "ResumenDiscriminadoPorClinca6");

                entity.Property(e => e.IdDetalleMedicamentos).HasColumnName("Id_DetalleMedicamentos");

                entity.Property(e => e.ACompartida).HasColumnName("A_Compartida");

                entity.Property(e => e.AcreditaPendiente).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Credito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_Debito");

                entity.Property(e => e.Dosis).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EncabezadoIdAcredita).HasColumnName("EncabezadoID_Acredita");

                entity.Property(e => e.Factura)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.IdEncabezadoMedicamento).HasColumnName("Id_EncabezadoMedicamento");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdEncabezadoMedicamentoNavigation)
                    .WithMany(p => p.InterDetalleMedicamentos)
                    .HasForeignKey(d => d.IdEncabezadoMedicamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inter_DetalleMedicamentos_Inter_EncabezadoMedicamentos");
            });

            modelBuilder.Entity<InterDetallePresentacion>(entity =>
            {
                entity.HasKey(e => e.IdDetallePresentacion);

                entity.ToTable("Inter_DetallePresentacion");

                entity.HasIndex(e => new { e.EncabezadoId, e.Anulado }, "InternadosResumenDiscriminadoDebitos");

                entity.Property(e => e.IdDetallePresentacion).HasColumnName("Id_DetallePresentacion");

                entity.Property(e => e.ACompartida).HasColumnName("A_Compartida");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaInternacion).HasColumnType("datetime");

                entity.Property(e => e.NumeroInternado)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Observacion).HasMaxLength(1000);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TipoInternacionId).HasColumnName("TipoInternacionID");

                entity.HasOne(d => d.Encabezado)
                    .WithMany(p => p.InterDetallePresentacions)
                    .HasForeignKey(d => d.EncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inter_DetallePresentacion_Inter_EncabezadoPresentacion");
            });

            modelBuilder.Entity<InterDetalleProtocolo>(entity =>
            {
                entity.HasKey(e => e.IdDetalleProtocolo);

                entity.ToTable("Inter_DetalleProtocolo");

                entity.HasIndex(e => new { e.NumeroAutorizacion, e.Anulado }, "Indice_InternadoNumeroAnulado");

                entity.HasIndex(e => e.Anulado, "ResumenDiscriminadoPorClinca2");

                entity.HasIndex(e => new { e.IdDetallePresentacion, e.Anulado }, "ResumenDiscriminadoPorClinca3");

                entity.Property(e => e.IdDetalleProtocolo).HasColumnName("Id_DetalleProtocolo");

                entity.Property(e => e.ACompartida).HasColumnName("A_Compartida");

                entity.Property(e => e.CoseguroGastos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Gastos");

                entity.Property(e => e.CoseguroHonorarios)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Honorarios");

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_Debito");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdDetallePresentacion).HasColumnName("Id_DetallePresentacion");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperadorCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.SugiereDebito).HasColumnName("Sugiere_Debito");

                entity.HasOne(d => d.IdDetallePresentacionNavigation)
                    .WithMany(p => p.InterDetalleProtocolos)
                    .HasForeignKey(d => d.IdDetallePresentacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inter_DetalleProtocolo_Inter_DetallePresentacion");
            });

            modelBuilder.Entity<InterEncabezadoMedicamento>(entity =>
            {
                entity.HasKey(e => e.IdEncabezadoMedicamento);

                entity.ToTable("Inter_EncabezadoMedicamentos");

                entity.Property(e => e.IdEncabezadoMedicamento).HasColumnName("Id_EncabezadoMedicamento");

                entity.Property(e => e.ACompartida).HasColumnName("A_Compartida");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.IdDetallePresentacion).HasColumnName("Id_DetallePresentacion");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDetallePresentacionNavigation)
                    .WithMany(p => p.InterEncabezadoMedicamentos)
                    .HasForeignKey(d => d.IdDetallePresentacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inter_EncabezadoMedicamentos_Inter_DetallePresentacion");
            });

            modelBuilder.Entity<InterEncabezadoPresentacion>(entity =>
            {
                entity.HasKey(e => e.EncabezadoId);

                entity.ToTable("Inter_EncabezadoPresentacion");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCierreAuditoria)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_CierreAuditoria");

                entity.Property(e => e.FechaCierreCompartida)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_CierreCompartida");

                entity.Property(e => e.FechaCierrePresentacion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_CierrePresentacion");

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .HasColumnName("Numero_Factura")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierreAuditoria)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierreAuditoria")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierreCompartida)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierreCompartida")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierrePresentacion)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierrePresentacion")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InterHistoricoCambio>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoCambios);

                entity.ToTable("Inter_HistoricoCambios");

                entity.Property(e => e.IdHistoricoCambios).HasColumnName("Id_HistoricoCambios");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdDetalleProtocolo).HasColumnName("Id_DetalleProtocolo");

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Practica).HasMaxLength(250);
            });

            modelBuilder.Entity<Iosepfar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IOSEPFAR");

                entity.Property(e => e.ANumero)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("A.Numero");

                entity.Property(e => e.Acargo1)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ACargo1");

                entity.Property(e => e.Acargo2)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ACargo2");

                entity.Property(e => e.Barras1)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Barras2)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad1)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad2)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Concepto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("concepto");

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("diagnostico");

                entity.Property(e => e.Edad)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Farmacia)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("farmacia");

                entity.Property(e => e.FecExpe)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Expe");

                entity.Property(e => e.FecPres)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fec_pres");

                entity.Property(e => e.Final)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IcosTotal)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ICosTotal");

                entity.Property(e => e.Importe1)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Importe2)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Institucion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("institucion");

                entity.Property(e => e.NroAut)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Nro_aut");

                entity.Property(e => e.NroComp)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Nro_comp");

                entity.Property(e => e.Numreg)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("numreg");

                entity.Property(e => e.Parent)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("periodo");

                entity.Property(e => e.Prescriptor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Registro1)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Registro2)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SucAut)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("suc_aut");

                entity.Property(e => e.SucComp)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Suc_comp");

                entity.Property(e => e.TipoComp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tipo_comp");

                entity.Property(e => e.Tipoorden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipoorden");

                entity.Property(e => e.Troquel1)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Troquel2)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListaIndicadore>(entity =>
            {
                entity.HasKey(e => e.IdListaIndicador);

                entity.ToTable("Lista_Indicadores");

                entity.Property(e => e.Agrupa)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(75);

                entity.HasOne(d => d.IdCalculoAuxiliarNavigation)
                    .WithMany(p => p.ListaIndicadores)
                    .HasForeignKey(d => d.IdCalculoAuxiliar)
                    .HasConstraintName("FK_Lista_Indicadores_Calculo_Auxiliar");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.ListaIndicadores)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lista_Indicadores_Empresas");

                entity.HasOne(d => d.IdIndicadorNavigation)
                    .WithMany(p => p.ListaIndicadores)
                    .HasForeignKey(d => d.IdIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lista_Indicadores_Indicadores");
            });

            modelBuilder.Entity<MainMenuIosep>(entity =>
            {
                entity.HasKey(e => e.IdMenu);

                entity.ToTable("MainMenuIosep");

                entity.HasIndex(e => e.Orden, "IX_MainMenuIosep")
                    .IsUnique();

                entity.Property(e => e.Action)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Memorandum>(entity =>
            {
                entity.ToTable("Memorandum");

                entity.Property(e => e.MemorandumId).HasColumnName("MemorandumID");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaMemo).HasColumnType("datetime");

                entity.Property(e => e.UsuarioCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mensaje>(entity =>
            {
                entity.Property(e => e.MensajeId).HasColumnName("MensajeID");

                entity.Property(e => e.Enviado).HasColumnType("datetime");

                entity.Property(e => e.From)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Leido).HasColumnType("datetime");

                entity.Property(e => e.Mensaje1).HasColumnName("Mensaje");

                entity.Property(e => e.Recibido).HasColumnType("datetime");

                entity.Property(e => e.To)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.Mensajes)
                    .HasForeignKey(d => d.GrupoId)
                    .HasConstraintName("FK_Mensajes_Mensajes_Grupos");
            });

            modelBuilder.Entity<MensajesContacto>(entity =>
            {
                entity.HasKey(e => e.ContantoId);

                entity.ToTable("Mensajes_Contactos");

                entity.Property(e => e.ContantoId).HasColumnName("ContantoID");

                entity.Property(e => e.Adherido).HasColumnType("datetime");

                entity.Property(e => e.Bloqueado).HasColumnType("datetime");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eliminado).HasColumnType("datetime");

                entity.Property(e => e.MeBloqueo).HasColumnType("datetime");

                entity.Property(e => e.Notificaciones)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sonido)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.MensajesContactos)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mensajes_Contactos_Mensajes_EstadosUsuarios");
            });

            modelBuilder.Entity<MensajesEstadosUsuario>(entity =>
            {
                entity.HasKey(e => e.Usuario);

                entity.ToTable("Mensajes_EstadosUsuarios");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Notificaciones)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sonido)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MensajesGrupo>(entity =>
            {
                entity.HasKey(e => e.GrupoId);

                entity.ToTable("Mensajes_Grupos");

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Creado).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MensajesGruposUsuario>(entity =>
            {
                entity.HasKey(e => e.GruposId);

                entity.ToTable("Mensajes_Grupos_Usuarios");

                entity.Property(e => e.GruposId).HasColumnName("GruposID");

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Ingreso).HasColumnType("datetime");

                entity.Property(e => e.Salio).HasColumnType("datetime");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.MensajesGruposUsuarios)
                    .HasForeignKey(d => d.GrupoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mensajes_Grupos_Usuarios_Mensajes_Grupos");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.MensajesGruposUsuarios)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mensajes_Grupos_Usuarios_Mensajes_EstadosUsuarios");
            });

            modelBuilder.Entity<MensajesNotificacione>(entity =>
            {
                entity.HasKey(e => e.NotificacionId);

                entity.ToTable("Mensajes_Notificaciones");

                entity.Property(e => e.NotificacionId).HasColumnName("NotificacionID");

                entity.Property(e => e.Enviado).HasColumnType("datetime");

                entity.Property(e => e.EnviadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'T')")
                    .IsFixedLength()
                    .HasComment("T = TEXTO;\r\nC = NUEVO CONTACTO;\r\nR = RESOLUCION\r\nH = HTML");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MensajesNotificacionesBloqueado>(entity =>
            {
                entity.HasKey(e => e.BloqueoId);

                entity.ToTable("Mensajes_Notificaciones_Bloqueados");

                entity.Property(e => e.BloqueoId).HasColumnName("BloqueoID");

                entity.Property(e => e.Bloqueado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.MensajesNotificacionesBloqueados)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mensajes_Notificaciones_Bloqueados_Mensajes_EstadosUsuarios");
            });

            modelBuilder.Entity<MensajesNotificacionesPara>(entity =>
            {
                entity.HasKey(e => e.NotificacionparaId);

                entity.ToTable("Mensajes_Notificaciones_Para");

                entity.Property(e => e.NotificacionparaId).HasColumnName("NotificacionparaID");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaRespuesta).HasColumnType("datetime");

                entity.Property(e => e.NotificacionId).HasColumnName("NotificacionID");

                entity.Property(e => e.Recibido).HasColumnType("datetime");

                entity.Property(e => e.Respuesta)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Notificacion)
                    .WithMany(p => p.MensajesNotificacionesParas)
                    .HasForeignKey(d => d.NotificacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mensajes_Notificaciones_Para_Mensajes_Notificaciones");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.MensajesNotificacionesParas)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mensajes_Notificaciones_Para_Mensajes_EstadosUsuarios");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.IdMenu);

                entity.ToTable("Menu");

                entity.Property(e => e.Action)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Imagen)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<NotificacionResolucion>(entity =>
            {
                entity.ToTable("Notificacion_Resolucion");

                entity.Property(e => e.NotificacionResolucionId).HasColumnName("NotificacionResolucionID");

                entity.Property(e => e.FechaNotif).HasColumnType("datetime");

                entity.Property(e => e.FechaNotificacion).HasColumnType("date");

                entity.Property(e => e.OperNotif)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.ResolucionId).HasColumnName("ResolucionID");

                entity.Property(e => e.TipoLugarId).HasColumnName("TipoLugarID");

                entity.HasOne(d => d.Resolucion)
                    .WithMany(p => p.NotificacionResolucions)
                    .HasForeignKey(d => d.ResolucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notificacion_Resolucion_Resoluciones");
            });

            modelBuilder.Entity<Novedade>(entity =>
            {
                entity.HasKey(e => e.NovedadId);

                entity.Property(e => e.NovedadId).HasColumnName("NovedadID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Detalle).HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Icono).HasMaxLength(50);

                entity.Property(e => e.Titulo).HasMaxLength(50);
            });

            modelBuilder.Entity<OlimpiadasDetalleMovimiento>(entity =>
            {
                entity.HasKey(e => e.DetalleMovimientoId);

                entity.ToTable("OlimpiadasDetalleMovimiento");

                entity.Property(e => e.DetalleMovimientoId).HasColumnName("DetalleMovimientoID");

                entity.Property(e => e.DisciplinaId).HasColumnName("DisciplinaID");

                entity.Property(e => e.FeCrea).HasColumnType("datetime");

                entity.Property(e => e.FeModi).HasColumnType("datetime");

                entity.Property(e => e.MovimientoId).HasColumnName("MovimientoID");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Disciplina)
                    .WithMany(p => p.OlimpiadasDetalleMovimientos)
                    .HasForeignKey(d => d.DisciplinaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OlimpiadasDetalleMovimiento_OlimpiadasDisciplina");

                entity.HasOne(d => d.Movimiento)
                    .WithMany(p => p.OlimpiadasDetalleMovimientos)
                    .HasForeignKey(d => d.MovimientoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OlimpiadasDetalleMovimiento_OlimpiadasMovimiento");
            });

            modelBuilder.Entity<OlimpiadasDisciplina>(entity =>
            {
                entity.HasKey(e => e.DisciplinaId);

                entity.ToTable("OlimpiadasDisciplina");

                entity.Property(e => e.DisciplinaId).HasColumnName("DisciplinaID");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OlimpiadasEncabezado>(entity =>
            {
                entity.HasKey(e => e.EncabezadoId);

                entity.ToTable("OlimpiadasEncabezado");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FeCrea).HasColumnType("datetime");

                entity.Property(e => e.FeModi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.SedeId).HasColumnName("SedeID");

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.OlimpiadasEncabezados)
                    .HasForeignKey(d => d.SedeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OlimpiadasEncabezado_OlimpiadasSede");
            });

            modelBuilder.Entity<OlimpiadasMovimiento>(entity =>
            {
                entity.HasKey(e => e.MovimientoId);

                entity.ToTable("OlimpiadasMovimiento");

                entity.Property(e => e.MovimientoId).HasColumnName("MovimientoID");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.FeCrea).HasColumnType("datetime");

                entity.Property(e => e.FeModi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.HasOne(d => d.Encabezado)
                    .WithMany(p => p.OlimpiadasMovimientos)
                    .HasForeignKey(d => d.EncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OlimpiadasMovimiento_OlimpiadasEncabezado");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.OlimpiadasMovimientos)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OlimpiadasMovimiento_OlimpiadasPersona");
            });

            modelBuilder.Entity<OlimpiadasPersona>(entity =>
            {
                entity.HasKey(e => e.PersonaId);

                entity.ToTable("OlimpiadasPersona");

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasMaxLength(8)
                    .HasColumnName("DNI")
                    .IsFixedLength();

                entity.Property(e => e.FeCrea).HasColumnType("datetime");

                entity.Property(e => e.FeModi).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OlimpiadasSede>(entity =>
            {
                entity.HasKey(e => e.SedeId);

                entity.ToTable("OlimpiadasSede");

                entity.Property(e => e.SedeId).HasColumnName("SedeID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlanillaTurno>(entity =>
            {
                entity.ToTable("Planilla_Turnos");

                entity.Property(e => e.PlanillaTurnoId).HasColumnName("Planilla_TurnoID");

                entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Opcrea)
                    .HasMaxLength(11)
                    .HasColumnName("opcrea")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Opmodifica)
                    .HasMaxLength(11)
                    .HasColumnName("opmodifica")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.ServicioId).HasColumnName("ServicioID");

                entity.Property(e => e.Turno).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Consultorio)
                    .WithMany(p => p.PlanillaTurnos)
                    .HasForeignKey(d => d.ConsultorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planilla_Turnos_Consultorios");

                entity.HasOne(d => d.Servicio)
                    .WithMany(p => p.PlanillaTurnos)
                    .HasForeignKey(d => d.ServicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Planilla_Turnos_Servicios");
            });

            modelBuilder.Entity<PracDetalleOrden>(entity =>
            {
                entity.HasKey(e => e.IdDetalleOrden);

                entity.ToTable("Prac_DetalleOrden");

                entity.HasIndex(e => new { e.EncabezadoId, e.Anulado }, "Index_PracticaDetalle");

                entity.HasIndex(e => e.Anulado, "Indice_PracticaDetalleOrdenHonGas");

                entity.HasIndex(e => new { e.IdDetallePresentacion, e.Anulado }, "Indice_PracticaDetalleOrdenHonGasAnulado");

                entity.Property(e => e.ACompartida).HasColumnName("A_Compartida");

                entity.Property(e => e.CodigoPractica)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.CoseguroGastos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Gastos");

                entity.Property(e => e.CoseguroHonorarios)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Honorarios");

                entity.Property(e => e.Credito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditoPendiente)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Debitado)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_Debito")
                    .IsFixedLength();

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.EncabezadoIdacredita).HasColumnName("EncabezadoIDAcredita");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdDetallePresentacion).HasColumnName("Id_DetallePresentacion");

                entity.Property(e => e.NombrePractica)
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.ReconoceGastos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Reconoce_Gastos");

                entity.Property(e => e.ReconoceHonorarios)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Reconoce_Honorarios");

                entity.HasOne(d => d.IdDetallePresentacionNavigation)
                    .WithMany(p => p.PracDetalleOrdens)
                    .HasForeignKey(d => d.IdDetallePresentacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prac_DetalleOrden_Prac_DetallePresentacion");
            });

            modelBuilder.Entity<PracDetalleOrdenAuto>(entity =>
            {
                entity.HasKey(e => e.IdDetalleOrdenAuto);

                entity.ToTable("Prac_DetalleOrdenAuto");

                entity.Property(e => e.CodigoPractica).HasMaxLength(10);

                entity.Property(e => e.Credito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdDetallePresentacionAutoNavigation)
                    .WithMany(p => p.PracDetalleOrdenAutos)
                    .HasForeignKey(d => d.IdDetallePresentacionAuto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prac_DetalleOrdenAuto_Prac_DetallePresentacionAuto");
            });

            modelBuilder.Entity<PracDetallePresentacion>(entity =>
            {
                entity.HasKey(e => e.IdDetallePresentacion);

                entity.ToTable("Prac_DetallePresentacion");

                entity.HasIndex(e => new { e.EncabezadoId, e.OperadorCrea, e.Anulado }, "DetallePracticasAnulacion");

                entity.HasIndex(e => e.Anulado, "Index");

                entity.HasIndex(e => new { e.Anulado, e.FechaPractica }, "IndexDetAnuladoFecha");

                entity.HasIndex(e => new { e.EncabezadoId, e.Anulado }, "Index_PracDetallePresentacionAgrupado");

                entity.HasIndex(e => new { e.NumeroComprobante, e.Anulado }, "Indice_PracticasNumeroAnulado");

                entity.Property(e => e.IdDetallePresentacion).HasColumnName("Id_DetallePresentacion");

                entity.Property(e => e.ACompartida).HasColumnName("A_Compartida");

                entity.Property(e => e.CoseguroGastos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Gastos");

                entity.Property(e => e.CoseguroHonorarios)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_Honorarios");

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_Debito")
                    .IsFixedLength();

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaPractica).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Internado).HasDefaultValueSql("((0))");

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(14)
                    .HasColumnName("Numero_Comprobante")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PeriodoDevolucion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_Devolucion")
                    .IsFixedLength();

                entity.Property(e => e.SugiereDebito).HasColumnName("Sugiere_Debito");

                entity.HasOne(d => d.Encabezado)
                    .WithMany(p => p.PracDetallePresentacions)
                    .HasForeignKey(d => d.EncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prac_DetallePresentacion_Prac_EncabezadoPresentacion");
            });

            modelBuilder.Entity<PracDetallePresentacionAuto>(entity =>
            {
                entity.HasKey(e => e.IdDetallePresentacionAuto);

                entity.ToTable("Prac_DetallePresentacionAuto");

                entity.Property(e => e.ACompartida).HasColumnName("A_Compartida");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaPractica).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero)
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.Encabezado)
                    .WithMany(p => p.PracDetallePresentacionAutos)
                    .HasForeignKey(d => d.EncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prac_DetallePresentacionAuto_Prac_EncabezadoPresentacion");
            });

            modelBuilder.Entity<PracEncabezadoPresentacion>(entity =>
            {
                entity.HasKey(e => e.EncabezadoId)
                    .HasName("PK_Pra_Encabezado_Temp");

                entity.ToTable("Prac_EncabezadoPresentacion");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.Cae)
                    .HasMaxLength(14)
                    .HasColumnName("CAE");

                entity.Property(e => e.Capitado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cartera).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cuit)
                    .HasMaxLength(15)
                    .HasColumnName("CUIT");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCierreAuditoria)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_CierreAuditoria");

                entity.Property(e => e.FechaCierreCompartida)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_CierreCompartida");

                entity.Property(e => e.FechaCierrePresentacion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_CierrePresentacion");

                entity.Property(e => e.ImagenCreditos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImagenDebitos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .HasColumnName("Numero_Factura")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierreAuditoria)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierreAuditoria")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierreCompartida)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierreCompartida")
                    .IsFixedLength();

                entity.Property(e => e.OperadorCierrePresentacion)
                    .HasMaxLength(11)
                    .HasColumnName("Operador_CierrePresentacion")
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_presentacion")
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NORMAL')");

                entity.Property(e => e.TotalCreditos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDebitos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPresentado).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PracHistoricoCodigo>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoCodigos);

                entity.ToTable("Prac_HistoricoCodigos");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.FechaAnula).HasColumnType("datetime");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.Gastos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombrePractica).HasMaxLength(100);

                entity.Property(e => e.OpAnula)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.HasOne(d => d.IdDetalleOrdenNavigation)
                    .WithMany(p => p.PracHistoricoCodigos)
                    .HasForeignKey(d => d.IdDetalleOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prac_HistoricoCodigos_Prac_DetalleOrden");
            });

            modelBuilder.Entity<PracticasFactura>(entity =>
            {
                entity.HasKey(e => e.IdPracticasFacturas);

                entity.Property(e => e.Cae)
                    .HasMaxLength(20)
                    .HasColumnName("CAE");

                entity.Property(e => e.Cuit)
                    .HasMaxLength(15)
                    .HasColumnName("CUIT");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.NumeroFactura).HasMaxLength(15);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrefijoAlias>(entity =>
            {
                entity.ToTable("PrefijoAlias");

                entity.Property(e => e.PrefijoAliasId).HasColumnName("PrefijoAliasID");

                entity.Property(e => e.Descripcion).HasMaxLength(300);

                entity.Property(e => e.Prefijo)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrestadorDia>(entity =>
            {
                entity.HasKey(e => e.PrestadorDiasId)
                    .HasName("PK_PresatdorDias");

                entity.Property(e => e.PrestadorDiasId).HasColumnName("PrestadorDiasID");

                entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");

                entity.Property(e => e.DiaId).HasColumnName("DiaID");

                entity.Property(e => e.Frecuencia)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('15')")
                    .IsFixedLength();

                entity.Property(e => e.MDesde)
                    .HasMaxLength(4)
                    .HasColumnName("M_Desde")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.MHasta)
                    .HasMaxLength(4)
                    .HasColumnName("M_Hasta")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.NDesde)
                    .HasMaxLength(4)
                    .HasColumnName("N_Desde")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.NHasta)
                    .HasMaxLength(4)
                    .HasColumnName("N_Hasta")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.ServicioId).HasColumnName("ServicioID");

                entity.Property(e => e.TDesde)
                    .HasMaxLength(4)
                    .HasColumnName("T_Desde")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.THasta)
                    .HasMaxLength(4)
                    .HasColumnName("T_Hasta")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.HasOne(d => d.Dia)
                    .WithMany(p => p.PrestadorDia)
                    .HasForeignKey(d => d.DiaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadorDias_Dias");
            });

            modelBuilder.Entity<PrestadoresServicio>(entity =>
            {
                entity.HasKey(e => e.PrestadoresServiciosId);

                entity.Property(e => e.PrestadoresServiciosId)
                    .ValueGeneratedNever()
                    .HasColumnName("PrestadoresServiciosID");

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.ServicioId).HasColumnName("ServicioID");

                entity.HasOne(d => d.Servicio)
                    .WithMany(p => p.PrestadoresServicios)
                    .HasForeignKey(d => d.ServicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadoresServicios_Servicios");
            });

            modelBuilder.Entity<PrestadoresTurno>(entity =>
            {
                entity.HasKey(e => e.PrestadorId)
                    .HasName("PK_Prestadores");

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.EspecialidadId).HasColumnName("EspecialidadID");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.HasOne(d => d.Especialidad)
                    .WithMany(p => p.PrestadoresTurnos)
                    .HasForeignKey(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrestadoresTurnos_Especialidades");
            });

            modelBuilder.Entity<ProtesisGrupo>(entity =>
            {
                entity.HasKey(e => e.GrupoId);

                entity.ToTable("ProtesisGrupo");

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProtesisPractica>(entity =>
            {
                entity.HasKey(e => e.ProtesisId);

                entity.ToTable("Protesis_Practicas");

                entity.Property(e => e.ProtesisId).HasColumnName("ProtesisID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Familia)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.GrupoId).HasColumnName("GrupoID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .IsFixedLength();

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.ProtesisPracticas)
                    .HasForeignKey(d => d.GrupoId)
                    .HasConstraintName("FK_Protesis_Practicas_ProtesisGrupo");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.HasIndex(e => e.Cuit, "proveedores");

                entity.Property(e => e.Cbu)
                    .HasMaxLength(50)
                    .HasColumnName("CBU")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Cuit)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Gnl)
                    .HasMaxLength(14)
                    .HasColumnName("GNL")
                    .IsFixedLength();

                entity.Property(e => e.IdPais).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdProvincia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(600)
                    .IsFixedLength();

                entity.Property(e => e.NombreFantasia)
                    .HasMaxLength(600)
                    .IsFixedLength();

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Prueba1>(entity =>
            {
                entity.ToTable("Prueba1");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Prueba2>(entity =>
            {
                entity.ToTable("Prueba2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdPruebaNavigation)
                    .WithMany(p => p.Prueba2s)
                    .HasForeignKey(d => d.IdPrueba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prueba2_Prueba1");
            });

            modelBuilder.Entity<RegistroActualizacion>(entity =>
            {
                entity.ToTable("RegistroActualizacion");

                entity.Property(e => e.RegistroActualizacionId).HasColumnName("RegistroActualizacionID");

                entity.Property(e => e.DescripcionActualizacion).HasMaxLength(1000);

                entity.Property(e => e.EntidadActualizadaId)
                    .HasMaxLength(128)
                    .HasColumnName("EntidadActualizadaID");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.OperadorActualiza).HasMaxLength(256);

                entity.Property(e => e.TipoActualizacionId).HasColumnName("TipoActualizacionID");

                entity.Property(e => e.TipoEntidadId).HasColumnName("TipoEntidadID");

                entity.HasOne(d => d.TipoActualizacion)
                    .WithMany(p => p.RegistroActualizacions)
                    .HasForeignKey(d => d.TipoActualizacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistroActualizacion_TipoActualizacion");

                entity.HasOne(d => d.TipoEntidad)
                    .WithMany(p => p.RegistroActualizacions)
                    .HasForeignKey(d => d.TipoEntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistroActualizacion_TipoEntidad");
            });

            modelBuilder.Entity<RegistroAperturaLote>(entity =>
            {
                entity.ToTable("RegistroAperturaLote");

                entity.Property(e => e.RegistroAperturaLoteId).HasColumnName("RegistroAperturaLoteID");

                entity.Property(e => e.FechaApertura).HasColumnType("datetime");

                entity.Property(e => e.FechaCierreComp).HasColumnType("date");

                entity.Property(e => e.FechaCierrePresentacion).HasColumnType("date");

                entity.Property(e => e.MotivoApertura).HasMaxLength(300);

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.OpeCierreComp)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpeCierrePresentacion)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OperApertura)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Resolucione>(entity =>
            {
                entity.HasKey(e => e.ResolucionId);

                entity.Property(e => e.ResolucionId).HasColumnName("ResolucionID");

                entity.Property(e => e.Caratula).HasMaxLength(250);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCrea).HasColumnType("date");

                entity.Property(e => e.FechaResolucion).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.NroExpediente).HasMaxLength(50);

                entity.Property(e => e.NroResolReemplaza)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.OperCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Referencia).HasMaxLength(500);

                entity.Property(e => e.ReferenciaExpediente)
                    .HasMaxLength(500)
                    .HasColumnName("Referencia_Expediente");

                entity.Property(e => e.Serie)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.SerieReemplaza)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.TipoResolucionId).HasColumnName("TipoResolucionID");
            });

            modelBuilder.Entity<RolesInMenu>(entity =>
            {
                entity.HasKey(e => e.IdRolesInMenu);

                entity.ToTable("RolesInMenu");

                entity.Property(e => e.RoleId).HasMaxLength(128);
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.Property(e => e.ServicioId).HasColumnName("ServicioID");

                entity.Property(e => e.EspecilidadId).HasColumnName("EspecilidadID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.TipoPedidoId).HasColumnName("TipoPedidoID");

                entity.Property(e => e.TvMonitorId).HasColumnName("TvMonitorID");

                entity.HasOne(d => d.Especilidad)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.EspecilidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servicios_Especialidades");
            });

            modelBuilder.Entity<ServiciosDia>(entity =>
            {
                entity.HasKey(e => e.ServiociosDiasId);

                entity.Property(e => e.ServiociosDiasId).HasColumnName("ServiociosDiasID");

                entity.Property(e => e.CantidadConsultorios)
                    .HasColumnName("Cantidad_Consultorios")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Demanda).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiaId).HasColumnName("DiaID");

                entity.Property(e => e.Frecuencia)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('15')")
                    .IsFixedLength();

                entity.Property(e => e.Frecuencia2)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Frecuencia3)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.MDesde)
                    .HasMaxLength(4)
                    .HasColumnName("M_Desde")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.MHasta)
                    .HasMaxLength(4)
                    .HasColumnName("M_Hasta")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.NDesde)
                    .HasMaxLength(4)
                    .HasColumnName("N_Desde")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.NHasta)
                    .HasMaxLength(4)
                    .HasColumnName("N_Hasta")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.ServicioId).HasColumnName("ServicioID");

                entity.Property(e => e.TDesde)
                    .HasMaxLength(4)
                    .HasColumnName("T_Desde")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.THasta)
                    .HasMaxLength(4)
                    .HasColumnName("T_Hasta")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Turnos).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Dia)
                    .WithMany(p => p.ServiciosDia)
                    .HasForeignKey(d => d.DiaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiciosDias_Dias");

                entity.HasOne(d => d.Servicio)
                    .WithMany(p => p.ServiciosDia)
                    .HasForeignKey(d => d.ServicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiciosDias_Servicios");
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

            modelBuilder.Entity<TablaAuxiliar>(entity =>
            {
                entity.ToTable("TablaAuxiliar");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Tango>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tango");

                entity.Property(e => e.CPostal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_POSTAL");

                entity.Property(e => e.CodProvee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COD_PROVEE");

                entity.Property(e => e.CondIva)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COND_IVA");

                entity.Property(e => e.Cuit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUIT");

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOMICILIO");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCALIDAD");

                entity.Property(e => e.NomProvee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM_PROVEE");

                entity.Property(e => e.Teléfono1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELÉFONO_1");

                entity.Property(e => e.Teléfono2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELÉFONO_2");
            });

            modelBuilder.Entity<TemporalDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temporal_Detalle");

                entity.Property(e => e.ACargoAfiliado1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("a_cargo_afiliado1");

                entity.Property(e => e.ACargoAfiliado2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("a_cargo_afiliado2");

                entity.Property(e => e.CantidadExpendida1).HasColumnName("Cantidad_expendida1");

                entity.Property(e => e.CantidadExpendida2).HasColumnName("Cantidad_expendida2");

                entity.Property(e => e.CiuFarmacia)
                    .HasMaxLength(10)
                    .HasColumnName("CIU_Farmacia")
                    .IsFixedLength();

                entity.Property(e => e.CiuInstitucion)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodigoBarras1)
                    .HasMaxLength(14)
                    .HasColumnName("codigo_barras1")
                    .IsFixedLength();

                entity.Property(e => e.CodigoBarras2)
                    .HasMaxLength(14)
                    .HasColumnName("codigo_barras2")
                    .IsFixedLength();

                entity.Property(e => e.CodigoDiagnostico)
                    .HasMaxLength(5)
                    .HasColumnName("codigo_diagnostico")
                    .IsFixedLength();

                entity.Property(e => e.CodigoKairos1)
                    .HasMaxLength(8)
                    .HasColumnName("codigo_kairos1")
                    .IsFixedLength();

                entity.Property(e => e.CodigoKairos2)
                    .HasMaxLength(8)
                    .HasColumnName("codigo_kairos2")
                    .IsFixedLength();

                entity.Property(e => e.CodigoTroquel1)
                    .HasMaxLength(8)
                    .HasColumnName("codigo_troquel1")
                    .IsFixedLength();

                entity.Property(e => e.CodigoTroquel2)
                    .HasMaxLength(8)
                    .HasColumnName("codigo_troquel2")
                    .IsFixedLength();

                entity.Property(e => e.ConceptoPresentacion)
                    .HasMaxLength(1)
                    .HasColumnName("concepto_presentacion")
                    .IsFixedLength();

                entity.Property(e => e.EdadAfiliado).HasColumnName("edad_afiliado");

                entity.Property(e => e.FechaExpendio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_expendio");

                entity.Property(e => e.FechaPrescripcion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_prescripcion");

                entity.Property(e => e.GradoParentesco)
                    .HasMaxLength(2)
                    .HasColumnName("grado_parentesco")
                    .IsFixedLength();

                entity.Property(e => e.ImporteCoseguroTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("importe_coseguro_total");

                entity.Property(e => e.ImporteMedicamento1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("importe_medicamento1");

                entity.Property(e => e.ImporteMedicamento2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("importe_medicamento2");

                entity.Property(e => e.NumeroAfiliado)
                    .HasMaxLength(15)
                    .HasColumnName("numero_afiliado")
                    .IsFixedLength();

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(8)
                    .HasColumnName("numero_autorizacion")
                    .IsFixedLength();

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(8)
                    .HasColumnName("numero_comprobante")
                    .IsFixedLength();

                entity.Property(e => e.NumeroSucursal)
                    .HasMaxLength(4)
                    .HasColumnName("numero_sucursal")
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("periodo_Presentacion")
                    .IsFixedLength();

                entity.Property(e => e.ProfesionalPrescriptor)
                    .HasMaxLength(10)
                    .HasColumnName("profesional_prescriptor")
                    .IsFixedLength();

                entity.Property(e => e.SexoAfiliado)
                    .HasMaxLength(1)
                    .HasColumnName("sexo_afiliado")
                    .IsFixedLength();

                entity.Property(e => e.SucursalAutorizacion)
                    .HasMaxLength(4)
                    .HasColumnName("sucursal_autorizacion")
                    .IsFixedLength();

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(2)
                    .HasColumnName("tipo_comprobante")
                    .IsFixedLength();

                entity.Property(e => e.TipoOrden)
                    .HasMaxLength(1)
                    .HasColumnName("tipo_orden")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Terapeutico>(entity =>
            {
                entity.ToTable("Terapeutico");

                entity.Property(e => e.TerapeuticoId).HasColumnName("TerapeuticoID");

                entity.Property(e => e.Creada).HasColumnType("datetime");

                entity.Property(e => e.DiagnosticoId1).HasColumnName("DiagnosticoID1");

                entity.Property(e => e.DiagnosticoId2).HasColumnName("DiagnosticoID2");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.MedicoId).HasColumnName("MedicoID");

                entity.Property(e => e.Modifica).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Peso).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TerapeuticoMedicacion>(entity =>
            {
                entity.ToTable("Terapeutico_Medicacion");

                entity.Property(e => e.TerapeuticoMedicacionId).HasColumnName("Terapeutico_MedicacionID");

                entity.Property(e => e.Autorizado)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.DosisDiariaMg).HasColumnName("DosisDiaria_mg");

                entity.Property(e => e.FechaExpendio).HasColumnType("datetime");

                entity.Property(e => e.OpExpende)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.TeraputicoId).HasColumnName("TeraputicoID");

                entity.Property(e => e.Vigencia).HasColumnType("date");

                entity.HasOne(d => d.Teraputico)
                    .WithMany(p => p.TerapeuticoMedicacions)
                    .HasForeignKey(d => d.TeraputicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terapeutico_Medicacion_Terapeutico");
            });

            modelBuilder.Entity<TipoActualizacion>(entity =>
            {
                entity.ToTable("TipoActualizacion");

                entity.Property(e => e.TipoActualizacionId).HasColumnName("TipoActualizacionID");

                entity.Property(e => e.DescripcionActualizacion)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoAnamnesi>(entity =>
            {
                entity.HasKey(e => e.TipoAnamnesisId)
                    .HasName("PK_dbo.Tipo_Anamnesis");

                entity.ToTable("Tipo_Anamnesis");

                entity.Property(e => e.TipoAnamnesisId).HasColumnName("TipoAnamnesisID");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AsociadaId).HasColumnName("AsociadaID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.ServicioId).HasColumnName("ServicioID");

                entity.Property(e => e.Tabla)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDato>(entity =>
            {
                entity.HasKey(e => e.IdTipoDato);

                entity.ToTable("Tipo_Dato");

                entity.Property(e => e.Detalle).HasMaxLength(75);
            });

            modelBuilder.Entity<TipoEntidad>(entity =>
            {
                entity.ToTable("TipoEntidad");

                entity.Property(e => e.TipoEntidadId).HasColumnName("TipoEntidadID");

                entity.Property(e => e.DescripcionEntidad)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoEntregaMedicacion>(entity =>
            {
                entity.ToTable("TipoEntregaMedicacion");

                entity.Property(e => e.TipoEntregaMedicacionId).HasColumnName("TipoEntregaMedicacionID");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoEstadoRemito>(entity =>
            {
                entity.HasKey(e => e.EstadoId);

                entity.ToTable("Tipo_EstadoRemito");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoIndicador>(entity =>
            {
                entity.HasKey(e => e.IdTipoIndicador);

                entity.ToTable("Tipo_Indicador");

                entity.Property(e => e.Detalle).HasMaxLength(75);
            });

            modelBuilder.Entity<TipoPresentacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoPresentacion);

                entity.ToTable("TipoPresentacion");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoResolucione>(entity =>
            {
                entity.HasKey(e => e.TipoResolucionId);

                entity.Property(e => e.TipoResolucionId).HasColumnName("TipoResolucionID");

                entity.Property(e => e.Nombre).HasMaxLength(250);
            });

            modelBuilder.Entity<TipoRespuestum>(entity =>
            {
                entity.HasKey(e => e.TipoRespuestaId)
                    .HasName("PK_dbo.Tipo_Respuesta");

                entity.ToTable("Tipo_Respuesta");

                entity.Property(e => e.TipoRespuestaId).HasColumnName("TipoRespuestaID");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TablaExterna)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoValorId).HasColumnName("TipoValorID");

                entity.Property(e => e.ValoraAlmacenar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValoraMostrar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoValor)
                    .WithMany(p => p.TipoRespuesta)
                    .HasForeignKey(d => d.TipoValorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Tipo_Respuesta_dbo.Tipo_Valor_TipoValorID");
            });

            modelBuilder.Entity<TipoValor>(entity =>
            {
                entity.ToTable("Tipo_Valor");

                entity.Property(e => e.TipoValorId).HasColumnName("TipoValorID");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tabla)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposFeriado>(entity =>
            {
                entity.HasKey(e => e.TipoFeriadoId);

                entity.Property(e => e.TipoFeriadoId).HasColumnName("TipoFeriadoID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.Property(e => e.TurnoId).ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.TurnoAfiliadoCuil).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.TurnoFechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.TurnoFechaAsignacion).HasColumnType("datetime");

                entity.Property(e => e.TurnoFechaAtencion).HasColumnType("datetime");

                entity.Property(e => e.TurnoFechaTurno).HasColumnType("datetime");

                entity.Property(e => e.TurnoHoraTurno)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.TurnoUsuarioCuilAtencion).HasColumnType("decimal(11, 0)");
            });

            modelBuilder.Entity<TurnosServicio>(entity =>
            {
                entity.HasKey(e => e.TurnoId);

                entity.ToTable("TurnosServicio");

                entity.Property(e => e.TurnoId).HasColumnName("TurnoID");

                entity.Property(e => e.Admisionado)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AnterirorId).HasColumnName("AnterirorID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Atendido).HasColumnType("smalldatetime");

                entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");

                entity.Property(e => e.Documento)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.EmergenciaId).HasColumnName("EmergenciaID");

                entity.Property(e => e.FecModifica).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Hora");

                entity.Property(e => e.HoraHasta)
                    .HasMaxLength(4)
                    .HasColumnName("Hora_Hasta")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.Llamado).HasColumnType("smalldatetime");

                entity.Property(e => e.Llegada)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NoAtendido).HasColumnType("smalldatetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.PacienteId).HasColumnName("PacienteID");

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.ServicioId).HasColumnName("ServicioID");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.Servicio)
                    .WithMany(p => p.TurnosServicios)
                    .HasForeignKey(d => d.ServicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TurnosServicio_Servicios");
            });

            modelBuilder.Entity<TurnosServicioHistorico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TurnosServicio_Historico");

                entity.Property(e => e.AnterirorId).HasColumnName("AnterirorID");

                entity.Property(e => e.Atendido).HasColumnType("smalldatetime");

                entity.Property(e => e.ConsultorioId).HasColumnName("ConsultorioID");

                entity.Property(e => e.EmergenciaId).HasColumnName("EmergenciaID");

                entity.Property(e => e.FecModifica).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Fecha_Hora");

                entity.Property(e => e.HoraHasta)
                    .HasMaxLength(4)
                    .HasColumnName("Hora_Hasta")
                    .IsFixedLength();

                entity.Property(e => e.Llamado).HasColumnType("smalldatetime");

                entity.Property(e => e.Llegada).HasColumnType("smalldatetime");

                entity.Property(e => e.NoAtendido).HasColumnType("smalldatetime");

                entity.Property(e => e.ObraSocialId).HasColumnName("ObraSocialID");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModifica)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Orden)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.PacienteId).HasColumnName("PacienteID");

                entity.Property(e => e.PrestadorId).HasColumnName("PrestadorID");

                entity.Property(e => e.ServicioId).HasColumnName("ServicioID");

                entity.Property(e => e.TurnoId).HasColumnName("TurnoID");
            });

            modelBuilder.Entity<TvMonitor>(entity =>
            {
                entity.ToTable("TvMonitor");

                entity.Property(e => e.TvMonitorId).HasColumnName("TvMonitorID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "User_Email_Index")
                    .IsUnique();

                entity.Property(e => e.Cuil).HasMaxLength(11);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(20);
            });

            modelBuilder.Entity<UserFirmaDigital>(entity =>
            {
                entity.HasKey(e => e.IdUserFirmaDigital);

                entity.ToTable("UserFirmaDigital");

                entity.Property(e => e.FechaRegistra).HasColumnType("datetime");

                entity.Property(e => e.InfoId).HasColumnName("InfoID");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VacunasDetalleMovimiento>(entity =>
            {
                entity.HasKey(e => e.DetalleMovimientoId);

                entity.ToTable("VacunasDetalleMovimiento");

                entity.Property(e => e.DetalleMovimientoId).HasColumnName("DetalleMovimientoID");

                entity.Property(e => e.Delegacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelegacionId).HasColumnName("DelegacionID");

                entity.Property(e => e.FeCrea).HasColumnType("datetime");

                entity.Property(e => e.FeModi).HasColumnType("datetime");

                entity.Property(e => e.FechaAplica).HasColumnType("datetime");

                entity.Property(e => e.MovimientoId).HasColumnName("MovimientoID");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Vacuna)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Movimiento)
                    .WithMany(p => p.VacunasDetalleMovimientos)
                    .HasForeignKey(d => d.MovimientoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacunasDetalleMovimiento_VacunasMovimiento");
            });

            modelBuilder.Entity<VacunasEncabezado>(entity =>
            {
                entity.HasKey(e => e.EncabezadoId);

                entity.ToTable("VacunasEncabezado");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FeCrea).HasColumnType("datetime");

                entity.Property(e => e.FeModi).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.SedeId).HasColumnName("SedeID");

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.VacunasEncabezados)
                    .HasForeignKey(d => d.SedeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacunasEncabezado_VacunasSede");
            });

            modelBuilder.Entity<VacunasMovimiento>(entity =>
            {
                entity.HasKey(e => e.MovimientoId);

                entity.ToTable("VacunasMovimiento");

                entity.Property(e => e.MovimientoId).HasColumnName("MovimientoID");

                entity.Property(e => e.AfiliadoId).HasColumnName("AfiliadoID");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.FeCrea).HasColumnType("datetime");

                entity.Property(e => e.FeModi).HasColumnType("datetime");

                entity.Property(e => e.FecNac).HasColumnType("datetime");

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.RiesgoId).HasColumnName("RiesgoID");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.HasOne(d => d.Encabezado)
                    .WithMany(p => p.VacunasMovimientos)
                    .HasForeignKey(d => d.EncabezadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacunasMovimiento_VacunasEncabezado");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.VacunasMovimientos)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacunasMovimiento_VacunasPersona");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.VacunasMovimientos)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacunasMovimiento_VacunasPlan");

                entity.HasOne(d => d.Riesgo)
                    .WithMany(p => p.VacunasMovimientos)
                    .HasForeignKey(d => d.RiesgoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VacunasMovimiento_VacunasRiesgo");
            });

            modelBuilder.Entity<VacunasPersona>(entity =>
            {
                entity.HasKey(e => e.PersonaId);

                entity.ToTable("VacunasPersona");

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasMaxLength(8)
                    .HasColumnName("DNI")
                    .IsFixedLength();

                entity.Property(e => e.FeCrea).HasColumnType("datetime");

                entity.Property(e => e.FeModi).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpCrea)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.OpModi)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VacunasPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("VacunasPlan");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelacionId).HasColumnName("RelacionID");
            });

            modelBuilder.Entity<VacunasRiesgo>(entity =>
            {
                entity.HasKey(e => e.RiesgoId);

                entity.ToTable("VacunasRiesgo");

                entity.Property(e => e.RiesgoId).HasColumnName("RiesgoID");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IosepMsalud)
                    .HasMaxLength(1)
                    .HasColumnName("IosepMSalud")
                    .HasDefaultValueSql("(N'A')")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMeses)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VacunasSede>(entity =>
            {
                entity.HasKey(e => e.SedeId);

                entity.ToTable("VacunasSede");

                entity.Property(e => e.SedeId).HasColumnName("SedeID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAportesAfiliado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AportesAfiliados");

                entity.Property(e => e.Afiliado).HasMaxLength(50);

                entity.Property(e => e.AporteAdicional).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AporteGrupo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodArchivo).HasMaxLength(10);

                entity.Property(e => e.CodigoLiquidacion).HasMaxLength(9);

                entity.Property(e => e.Cuil).HasMaxLength(11);

                entity.Property(e => e.HaberCredito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HaberIosep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LugarPago).HasMaxLength(11);

                entity.Property(e => e.NumeroBeneficio).HasMaxLength(11);

                entity.Property(e => e.NumeroControl).HasMaxLength(8);

                entity.Property(e => e.Periodo).HasMaxLength(6);
            });

            modelBuilder.Entity<VwArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Articulos");

                entity.Property(e => e.Articulo).HasMaxLength(1);

                entity.Property(e => e.Codbarras)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Heladera)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .IsFixedLength();

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Presentacion).HasMaxLength(256);

                entity.Property(e => e.Troquel)
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Unidades).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath).HasMaxLength(256);

                entity.Property(e => e.Path).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwBajarConsulta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwBajar_Consultas");

                entity.Property(e => e.CodigoColegio)
                    .HasMaxLength(4)
                    .HasColumnName("Codigo_Colegio")
                    .IsFixedLength();

                entity.Property(e => e.CodigoDebito)
                    .HasMaxLength(8)
                    .HasColumnName("Codigo_Debito")
                    .IsFixedLength();

                entity.Property(e => e.CodigoPractica)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColegioLiquida)
                    .HasMaxLength(4)
                    .HasColumnName("Colegio_Liquida")
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_Debito")
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Efector).HasMaxLength(9);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaPractica).HasColumnType("date");

                entity.Property(e => e.Gastos).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Honorarios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdDetalleConsultas).HasColumnName("IdDetalle_Consultas");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(14)
                    .HasColumnName("Numero_Comprobante")
                    .IsFixedLength();

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(25)
                    .HasColumnName("Numero_Factura")
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_presentacion")
                    .IsFixedLength();

                entity.Property(e => e.PorcentajeCategoria)
                    .HasColumnType("numeric(2, 2)")
                    .HasColumnName("Porcentaje_Categoria");

                entity.Property(e => e.Prestador).HasMaxLength(9);
            });

            modelBuilder.Entity<VwConsultasParaDevolucion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Consultas_ParaDevolucion");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CodigoDebito)
                    .HasMaxLength(8)
                    .HasColumnName("Codigo_Debito")
                    .IsFixedLength();

                entity.Property(e => e.Cuil)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DetalleDebito)
                    .HasMaxLength(100)
                    .HasColumnName("Detalle_Debito")
                    .IsFixedLength();

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.DiagnosticosConsultasId).HasColumnName("DiagnosticosConsultasID");

                entity.Property(e => e.FechaPractica).HasColumnType("date");

                entity.Property(e => e.IdDetalleConsultas).HasColumnName("IdDetalle_Consultas");

                entity.Property(e => e.IdTipoDebito).HasColumnName("IdTipo_debito");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(6)
                    .HasColumnName("matricula")
                    .IsFixedLength();

                entity.Property(e => e.NombreAfiliado)
                    .HasMaxLength(100)
                    .HasColumnName("Nombre_Afiliado")
                    .IsFixedLength();

                entity.Property(e => e.NombrePrestador)
                    .HasMaxLength(50)
                    .HasColumnName("Nombre_Prestador")
                    .IsFixedLength();

                entity.Property(e => e.NumeroComprobante)
                    .HasMaxLength(14)
                    .HasColumnName("Numero_Comprobante")
                    .IsFixedLength();

                entity.Property(e => e.PeriodoDevolucion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_Devolucion")
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_presentacion")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwFormaPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwFormaPago");

                entity.Property(e => e.Credito)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CuentaContable)
                    .HasMaxLength(20)
                    .HasColumnName("Cuenta_Contable")
                    .IsFixedLength();

                entity.Property(e => e.IdTipoFormaPago).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwOnlyUserName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwOnlyUserName");

                entity.Property(e => e.Nombre).HasMaxLength(4000);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwPresentacionFarmDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_PresentacionFarmDetalle");

                entity.Property(e => e.CantidadRegistros).HasColumnName("Cantidad_registros");

                entity.Property(e => e.CiuFarmacia)
                    .HasMaxLength(10)
                    .HasColumnName("CIU_Farmacia")
                    .IsFixedLength();

                entity.Property(e => e.CiuInstitucion)
                    .HasMaxLength(10)
                    .HasColumnName("CIU_Institucion")
                    .IsFixedLength();

                entity.Property(e => e.ConceptoPresentacion)
                    .HasMaxLength(1)
                    .HasColumnName("Concepto_presentacion")
                    .IsFixedLength();

                entity.Property(e => e.CoseguroPresentado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Coseguro_presentado");

                entity.Property(e => e.Debitado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EncabezadoId).HasColumnName("EncabezadoID");

                entity.Property(e => e.FechaSubida)
                    .HasColumnType("date")
                    .HasColumnName("fecha_subida");

                entity.Property(e => e.ImportePresentado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Importe_presentado");

                entity.Property(e => e.IosepSalud).HasColumnName("Iosep_salud");

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.NombreInstitucion)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.NumeroOrden)
                    .HasMaxLength(14)
                    .HasColumnName("Numero_orden")
                    .IsFixedLength();

                entity.Property(e => e.Periodo)
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.PeriodoPresentacion)
                    .HasMaxLength(6)
                    .HasColumnName("Periodo_presentacion")
                    .IsFixedLength();

                entity.Property(e => e.Presentado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegistrosCorrectos).HasColumnName("Registros_Correctos");

                entity.Property(e => e.RegistrosFallidos).HasColumnName("Registros_Fallidos");

                entity.Property(e => e.TotalDebitado).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwRolesMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwRolesMenu");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.RoleId).HasMaxLength(128);
            });

            modelBuilder.Entity<VwTurnosIosepSalud>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwTurnosIosepSalud");

                entity.Property(e => e.Estado)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre")
                    .IsFixedLength();

                entity.Property(e => e.TurnoAfiliadoCuil).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.TurnoFechaTurno).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZLogEdgard>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("zLog_edgard");
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("RefreshToken");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

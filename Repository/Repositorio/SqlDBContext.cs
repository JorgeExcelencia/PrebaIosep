using ApiIosep.Models.CtaCte;
using ApiIosep.Models.Persona;
using Microsoft.EntityFrameworkCore;
using ApiIosep.Models.CtaCte.MovDet;
using ApiIosep.Models.StoreProcedures;
using ApiIosep.Models.CtaCte.Empresa;
using ApiIosep.Models.Persona.Geo;
using ApiIosep.Models.CtaCte.Afiliado;

namespace ApiIosep.Repositories
{
    public class SqlDBContext : DbContext
    {
        public SqlDBContext(DbContextOptions<SqlDBContext> options)
            : base(options)
        {
           
        }

        #region A
        public virtual DbSet<Afiliados> Afiliados { get; set; }
        #endregion
        #region C
        public virtual DbSet<Comprobante> Comprobante { get; set; }
        public virtual DbSet<ComprobanteVM> ComprobanteVM { get; set; }
        public virtual DbSet<DetalleMovimiento> DetalleMovimiento { get; set; }
        public virtual DbSet<ComprobanteDetalle> ComprobanteDetalle { get; set; }
        public virtual DbSet<ComprobanteLog> ComprobanteLog { get; set; }
        public virtual DbSet<CuotaVM> CuotaVM { get; set; }
        #endregion
        #region E
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Empresa_Afiliado> Empresa_Afiliado { get; set; }
        public virtual DbSet<EmpresaLog> EmpresaLog { get; set; }

        #endregion
        #region I
        public virtual DbSet<Imprimir> Imprimir { get; set; }
        public virtual DbSet<imprimir_ctacteVW> ImprimirCtaCte { get; set; }
        public virtual DbSet<imprimir_PeriodoPago> ImprimirPeriodo { get; set; }
        public virtual DbSet<imprimir_PagoCtaCte> ImprimirPagoCtaCte { get; set; }
        #endregion
        #region L
        public virtual DbSet<LocalidadDB> Localidades { get; set; }
        #endregion
        #region M
        public virtual DbSet<MovimientoDetalle> MovimientoDetalle { get; set; }
        #endregion
        #region N
        public virtual DbSet<NotaCredito> NotaCreditos { get; set; }
        public virtual DbSet<NotaCreditoEmpresa> NotaCreditoEmpresas { get; set; }
        #endregion
        #region P
        public virtual DbSet<Paises> Pais { get; set; }
        public virtual DbSet<Provincias> Provincia { get; set; }
        #endregion
        #region S
        public virtual DbSet<Sexo> Sexo { get; set; }
        #endregion
        #region T
        public virtual DbSet<TipoFamiliar> TipoFamiliar { get; set; }
        #endregion
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Vencimientos> Vencimientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Afiliados>(entity =>
            {
                entity.HasOne(d => d.Sexo)
                        .WithMany(p => p.Afiliados)
                        .HasForeignKey(d => d.IdSexo);
                entity.HasOne(t => t.TipoFamiliar)
                        .WithMany(m => m.Afiliados)
                        .HasForeignKey(k => k.IdTipoFamiliar);
            });
            modelBuilder.Entity<ComprobanteDetalle>(entity =>
            {
                entity.HasOne(d => d.Comprobante)
                        .WithMany(p => p.ComprobanteDetalle)
                        .HasForeignKey(d => d.IdComprobante);
                entity.Property(p => p.ImporteVence1).HasColumnType("decimal(18,2)");
            });
            modelBuilder.Entity<ComprobanteLog>(entity =>
            {
                entity.HasOne(d => d.Comprobante)
                        .WithMany(p => p.ComprobanteLog)
                        .HasForeignKey(d => d.IdComprobante);
            });

            modelBuilder.Entity<Empresa_Afiliado>(entity =>
            {
                entity.HasOne(d => d.Empresa)
                        .WithMany(p => p.Empresa_Afiliado)
                        .HasForeignKey(d => d.IdEmpresa);
            });
            modelBuilder.Entity<EmpresaLog>(entity =>
            {
                entity.HasOne(d => d.Empresa)
                        .WithMany(p => p.EmpresaLog)
                        .HasForeignKey(d => d.IdEmpresa);
            });

            modelBuilder.Entity<LocalidadDB>(entity =>
            {
                entity.HasOne(h => h.Provincia)
                        .WithMany(m => m.Localidades)
                        .HasForeignKey(k => k.IdProvincia);
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasOne(h => h.Pais)
                        .WithMany(m => m.Provincia)
                        .HasForeignKey(k => k.IdPais);
            });

            modelBuilder.Entity<User>().ToView(null, schema: "usuario");

            modelBuilder.Entity<EmpresaDetalleVW>().HasNoKey().ToView(null);

            modelBuilder.Entity<AfiliadoDetalleVW>().HasNoKey().ToView(null);

    }

        public DbSet<ApiIosep.Models.CtaCte.Cuotas> Cuotas { get; set; }
    }
}

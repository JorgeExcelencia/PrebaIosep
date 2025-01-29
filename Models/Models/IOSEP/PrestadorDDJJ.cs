using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class PrestadorDDJJ
    {
        public PrestadorDDJJ()
        {
            PrestadorDDJJAcreditacionMedicas = new HashSet<PrestadorDDJJAcreditacionMedica>();
            PrestadorDDJJDomiciliosHabilitados = new HashSet<PrestadorDDJJDomiciliosHabilitado>();
            PrestadorDDJJEquiposPracticas = new HashSet<PrestadorDDJJEquiposPractica>();
            PrestadorDDJJGerenciadors = new HashSet<PrestadorDDJJGerenciador>();
            PrestadorDDJJReclamos = new HashSet<PrestadorDDJJReclamo>();
            PrestadorDDJJServicioCentroPrestadorDDJJIDaCargoNavigations = new HashSet<PrestadorDDJJServicioCentro>();
            PrestadorDDJJServicioCentroPrestadorDDJJs = new HashSet<PrestadorDDJJServicioCentro>();
            PrestadorDDJJServicioRealizas = new HashSet<PrestadorDDJJServicioRealiza>();
            PrestadorDDJJSuspendidos = new HashSet<PrestadorDDJJSuspendido>();
            PrestadorEspecialidadDDJJs = new HashSet<PrestadorEspecialidadDDJJ>();
            PrestadorEstadoHistoricos = new HashSet<PrestadorEstadoHistorico>();
            PrestadorHabilitacions = new HashSet<PrestadorHabilitacion>();
            ProfesionalXFarmacia = new HashSet<ProfesionalXFarmacium>();
            SeguroMalaPraxis = new HashSet<SeguroMalaPraxi>();
        }

        public int PrestadorDDJJID { get; set; }
        public string Cuil { get; set; } = null!;
        public string? Apellido { get; set; }
        public string Nombre { get; set; } = null!;
        public string DomicilioParticular { get; set; } = null!;
        public string? CelularParticular { get; set; }
        public string? TelFijoParticular { get; set; }
        public string? Email { get; set; }
        public int LocalidadID { get; set; }
        public bool Anulado { get; set; }
        public int PrestadorEstadoID { get; set; }
        public bool SinRevalidad { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public string MatriculaProfesional { get; set; } = null!;
        public int? TituloProfesionalID { get; set; }
        public string? NumExpediente { get; set; }
        public string? RefExpediente { get; set; }
        public string CIU { get; set; } = null!;
        public string? CodigoColegio { get; set; }
        public int TipoPrestadorID { get; set; }
        public bool Prescriptor { get; set; }
        public bool FirmaNoCobroPlus { get; set; }
        public int? TipoCondicionIvaID { get; set; }
        public bool Bloqueado { get; set; }
        public string? UsuarioModEstado { get; set; }
        public DateTime? FechaModEstado { get; set; }

        public virtual PrestadorEstado PrestadorEstado { get; set; } = null!;
        public virtual TipoCondicionIVA? TipoCondicionIva { get; set; }
        public virtual TipoPrestadorDDJJ TipoPrestador { get; set; } = null!;
        public virtual TituloProfesional? TituloProfesional { get; set; }
        public virtual ICollection<PrestadorDDJJAcreditacionMedica> PrestadorDDJJAcreditacionMedicas { get; set; }
        public virtual ICollection<PrestadorDDJJDomiciliosHabilitado> PrestadorDDJJDomiciliosHabilitados { get; set; }
        public virtual ICollection<PrestadorDDJJEquiposPractica> PrestadorDDJJEquiposPracticas { get; set; }
        public virtual ICollection<PrestadorDDJJGerenciador> PrestadorDDJJGerenciadors { get; set; }
        public virtual ICollection<PrestadorDDJJReclamo> PrestadorDDJJReclamos { get; set; }
        public virtual ICollection<PrestadorDDJJServicioCentro> PrestadorDDJJServicioCentroPrestadorDDJJIDaCargoNavigations { get; set; }
        public virtual ICollection<PrestadorDDJJServicioCentro> PrestadorDDJJServicioCentroPrestadorDDJJs { get; set; }
        public virtual ICollection<PrestadorDDJJServicioRealiza> PrestadorDDJJServicioRealizas { get; set; }
        public virtual ICollection<PrestadorDDJJSuspendido> PrestadorDDJJSuspendidos { get; set; }
        public virtual ICollection<PrestadorEspecialidadDDJJ> PrestadorEspecialidadDDJJs { get; set; }
        public virtual ICollection<PrestadorEstadoHistorico> PrestadorEstadoHistoricos { get; set; }
        public virtual ICollection<PrestadorHabilitacion> PrestadorHabilitacions { get; set; }
        public virtual ICollection<ProfesionalXFarmacium> ProfesionalXFarmacia { get; set; }
        public virtual ICollection<SeguroMalaPraxi> SeguroMalaPraxis { get; set; }
    }
}

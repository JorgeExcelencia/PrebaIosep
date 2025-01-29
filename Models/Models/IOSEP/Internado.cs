using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Internado
    {
        public Internado()
        {
            Encabezado_Autorizaciones = new HashSet<Encabezado_Autorizacione>();
            InternadosControls = new HashSet<InternadosControl>();
            InternadosEstudios = new HashSet<InternadosEstudio>();
            InternadosEvolucions = new HashSet<InternadosEvolucion>();
            InternadosMedicamentos = new HashSet<InternadosMedicamento>();
            InternadosQuirofanos = new HashSet<InternadosQuirofano>();
            MovimientosInternados = new HashSet<MovimientosInternado>();
            Quirofanos = new HashSet<Quirofano>();
        }

        public int IdInternado { get; set; }
        public int IdAfiliado { get; set; }
        public int IdTitular { get; set; }
        public int IdClinica { get; set; }
        public int IdDiagnostico { get; set; }
        public int? IdPlan { get; set; }
        public DateTime Fecha_Internacion { get; set; }
        public byte Edad { get; set; }
        public bool Hijo { get; set; }
        public bool Art { get; set; }
        public bool AccidenteTansito { get; set; }
        public bool Psiquiatrica { get; set; }
        public bool Anulada { get; set; }
        public string? UserCrea { get; set; }
        public DateTime? FechaCrea { get; set; }
        public string? OpAnula { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? MotivoAnula { get; set; }
        public string? Observaciones { get; set; }
        public int? IdEstadoConsultaWS { get; set; }
        public DateTime? FechaUltimaConsulta { get; set; }

        public virtual Diagnostico IdDiagnosticoNavigation { get; set; } = null!;
        public virtual ICollection<Encabezado_Autorizacione> Encabezado_Autorizaciones { get; set; }
        public virtual ICollection<InternadosControl> InternadosControls { get; set; }
        public virtual ICollection<InternadosEstudio> InternadosEstudios { get; set; }
        public virtual ICollection<InternadosEvolucion> InternadosEvolucions { get; set; }
        public virtual ICollection<InternadosMedicamento> InternadosMedicamentos { get; set; }
        public virtual ICollection<InternadosQuirofano> InternadosQuirofanos { get; set; }
        public virtual ICollection<MovimientosInternado> MovimientosInternados { get; set; }
        public virtual ICollection<Quirofano> Quirofanos { get; set; }
    }
}

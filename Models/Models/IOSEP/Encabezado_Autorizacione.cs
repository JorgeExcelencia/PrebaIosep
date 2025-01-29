using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Encabezado_Autorizacione
    {
        public Encabezado_Autorizacione()
        {
            Detalle_Autorizaciones = new HashSet<Detalle_Autorizacione>();
        }

        public int AutorizacionesId { get; set; }
        public int IdAfiliado { get; set; }
        public int IdPlan { get; set; }
        public int? IdInternado { get; set; }
        public string Numero { get; set; } = null!;
        public string? Numero_Internacion { get; set; }
        public short IdDelegacion { get; set; }
        public int IdMedico_Prescriptor { get; set; }
        public int? IdEfector { get; set; }
        public int? IdInstitucion { get; set; }
        public int IdDiagnostico { get; set; }
        public DateTime Fecha_Prescripcion { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public DateTime? Fecha_Vencimiento { get; set; }
        public string Operador { get; set; } = null!;
        public string? Observaciones { get; set; }
        public string? Motivo_Rechazo { get; set; }
        /// <summary>
        /// P - &apos; &apos; Pendiente De Autorizar/E-Enviada a IOSEP/R-Con Respuesta a Institucion/X-Rechazada/A-Autorizada/H-Pide Historia Clinica/S-Solicita Aclaracion a la Institucion/O-Aclaracion Enviada
        /// </summary>
        public string EstadoAutorizacion { get; set; } = null!;
        public bool Anulada { get; set; }
        public string? OperAnula { get; set; }
        public DateTime? Modifica { get; set; }
        public bool IosepSalud { get; set; }
        public byte IdLugar { get; set; }
        public bool? Marca { get; set; }
        public bool? Remiso { get; set; }
        public DateTime? FechaRemiso { get; set; }
        public string? OperRemiso { get; set; }
        public bool? RemisoCobrado { get; set; }
        public bool FueraProvincia { get; set; }
        public int CartaPresentacionID { get; set; }
        public int? IdGrupoPractica { get; set; }
        public int? IdCentroAfiliado { get; set; }
        public int? IdCentroImpresion { get; set; }
        public bool? CambioCentro { get; set; }
        public int? IdDelegacionImp { get; set; }
        public string? UsuarioImprime { get; set; }
        public DateTime? FechaImprime { get; set; }

        public virtual Afiliado IdAfiliadoNavigation { get; set; } = null!;
        public virtual Delegacione IdDelegacionNavigation { get; set; } = null!;
        public virtual Diagnostico IdDiagnosticoNavigation { get; set; } = null!;
        public virtual Prestadore? IdEfectorNavigation { get; set; }
        public virtual Internado? IdInternadoNavigation { get; set; }
        public virtual Prestadore IdMedico_PrescriptorNavigation { get; set; } = null!;
        public virtual Plane IdPlanNavigation { get; set; } = null!;
        public virtual ICollection<Detalle_Autorizacione> Detalle_Autorizaciones { get; set; }
    }
}

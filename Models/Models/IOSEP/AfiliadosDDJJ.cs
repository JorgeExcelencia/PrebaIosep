using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class AfiliadosDDJJ
    {
        public AfiliadosDDJJ()
        {
            DomiciliosDDJJs = new HashSet<DomiciliosDDJJ>();
            EmpresasAfiliadosDDJJs = new HashSet<EmpresasAfiliadosDDJJ>();
            LugarPagoDDJJs = new HashSet<LugarPagoDDJJ>();
            PapelesDDJJs = new HashSet<PapelesDDJJ>();
        }

        public int IdDdjj { get; set; }
        public int IdDdjjHeader { get; set; }
        public int? IdAfiliado { get; set; }
        public string Cuil { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public byte IdTipoDocumento { get; set; }
        public string Documento { get; set; } = null!;
        public string? ApellidoMaterno { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string Nombre { get; set; } = null!;
        public string A_Numero { get; set; } = null!;
        public string Fliar { get; set; } = null!;
        public int IdNacionalidad { get; set; }
        public byte IdSexo { get; set; }
        public byte? IdSexoGenero { get; set; }
        public byte? IdEstadoCivil { get; set; }
        public DateTime FechadeNacimiento { get; set; }
        public short? IdDelegacion { get; set; }
        /// <summary>
        /// Esta fecha indica hasta cuando el afiliado puede operar en el sistema.
        /// Si se encuentra vacio tiene uso de la obra social ilimitado.
        /// </summary>
        public DateTime? FechaVigencia { get; set; }
        public short IdMotivoBaja { get; set; }
        public DateTime? FechadeBaja { get; set; }
        public DateTime FechaIngreso { get; set; }
        public byte IdTipoFamiliar { get; set; }
        public short? IdCategoria { get; set; }
        public bool IosepSalud { get; set; }
        public int? IdTipoIngresoAfiliacion { get; set; }
        public int IdCosspra { get; set; }
        public bool Anulado { get; set; }
        public int? MotivoID { get; set; }
        public string? Motivo { get; set; }
        public DateTime? FechaAnula { get; set; }
        public string? OperAnula { get; set; }
        public bool? Estudiante { get; set; }
        public int? TipoVencimientoID { get; set; }
        public DateTime? FechaVenceAfiliacion { get; set; }
        public string? Observaciones { get; set; }

        public virtual Cosspra IdCosspraNavigation { get; set; } = null!;
        public virtual Ddjj_Header IdDdjjHeaderNavigation { get; set; } = null!;
        public virtual EstadoCivil? IdEstadoCivilNavigation { get; set; }
        public virtual Paise IdNacionalidadNavigation { get; set; } = null!;
        public virtual Sexo IdSexoNavigation { get; set; } = null!;
        public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
        public virtual TipoFamiliar IdTipoFamiliarNavigation { get; set; } = null!;
        public virtual Tipo_IngresoAfiliacion? IdTipoIngresoAfiliacionNavigation { get; set; }
        public virtual ICollection<DomiciliosDDJJ> DomiciliosDDJJs { get; set; }
        public virtual ICollection<EmpresasAfiliadosDDJJ> EmpresasAfiliadosDDJJs { get; set; }
        public virtual ICollection<LugarPagoDDJJ> LugarPagoDDJJs { get; set; }
        public virtual ICollection<PapelesDDJJ> PapelesDDJJs { get; set; }
    }
}

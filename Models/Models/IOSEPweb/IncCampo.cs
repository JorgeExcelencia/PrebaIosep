using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncCampo
    {
        public IncCampo()
        {
            IncCamposGuardados = new HashSet<IncCamposGuardado>();
            IncCamposValores = new HashSet<IncCamposValore>();
            IncPantallasEsquemas = new HashSet<IncPantallasEsquema>();
        }

        public int CampoId { get; set; }
        public int TipoCampoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool ReadOnly { get; set; }
        public bool Default { get; set; }
        public string? ValorMaximo { get; set; }
        public string? ValorMinimo { get; set; }
        public string? Condicional { get; set; }
        public string? Style { get; set; }
        public string? Css { get; set; }
        public bool Anulado { get; set; }

        public virtual IncTiposCampo TipoCampo { get; set; } = null!;
        public virtual ICollection<IncCamposGuardado> IncCamposGuardados { get; set; }
        public virtual ICollection<IncCamposValore> IncCamposValores { get; set; }
        public virtual ICollection<IncPantallasEsquema> IncPantallasEsquemas { get; set; }
    }
}

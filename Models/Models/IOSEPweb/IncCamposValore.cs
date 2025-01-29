using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class IncCamposValore
    {
        public int CampoValorId { get; set; }
        public int CampoId { get; set; }
        public string? RelacionModel { get; set; }
        public string? Texto { get; set; }
        public string? Valor { get; set; }
        public byte[]? Adjunto { get; set; }
        public bool Default { get; set; }
        public bool IsDisabled { get; set; }
        public bool Anulado { get; set; }

        public virtual IncCampo Campo { get; set; } = null!;
    }
}

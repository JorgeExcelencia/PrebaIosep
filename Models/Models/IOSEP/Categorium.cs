using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Categorium
    {
        public Categorium()
        {
            CategoriaPapeles = new HashSet<CategoriaPapele>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Aporte { get; set; }
        public decimal Adicional { get; set; }
        public bool aTitular { get; set; }
        public bool aBeneficiario { get; set; }
        public byte HastaEdadFemenino { get; set; }
        public byte HastaEdadMasculino { get; set; }
        public bool IosepSalud { get; set; }
        public bool Anulado { get; set; }

        public virtual ICollection<CategoriaPapele> CategoriaPapeles { get; set; }
    }
}

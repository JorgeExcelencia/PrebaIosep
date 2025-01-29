using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class TurnosPrestadore
    {
        public long idturnoprestador { get; set; }
        public int idprestador { get; set; }
        public string dia { get; set; } = null!;
        public string desde { get; set; } = null!;
        public string hasta { get; set; } = null!;
        public short incremento { get; set; }
        public bool? anulado { get; set; }

        public virtual Prestadore idprestadorNavigation { get; set; } = null!;
    }
}

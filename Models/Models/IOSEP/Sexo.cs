﻿using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Sexo
    {
        public Sexo()
        {
            Afiliados = new HashSet<Afiliado>();
            AfiliadosDDJJs = new HashSet<AfiliadosDDJJ>();
            Ddjjs = new HashSet<Ddjj>();
        }

        public byte IdSexo { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }

        public virtual ICollection<Afiliado> Afiliados { get; set; }
        public virtual ICollection<AfiliadosDDJJ> AfiliadosDDJJs { get; set; }
        public virtual ICollection<Ddjj> Ddjjs { get; set; }
    }
}

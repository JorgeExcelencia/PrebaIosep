using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Reparticione
    {
        public int idreparticiones { get; set; }
        public short codigo { get; set; }
        public string nombre { get; set; } = null!;
        public bool? activa { get; set; }
    }
}

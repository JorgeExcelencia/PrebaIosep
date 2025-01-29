using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class CronogramaModificacione
    {
        public int CronogramaModifID { get; set; }
        public string usuario { get; set; } = null!;
        public string tabla { get; set; } = null!;
        public string operacion { get; set; } = null!;
        public string datos { get; set; } = null!;
        public DateTime fechaMod { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class UserFirmaDigital
    {
        public int IdUserFirmaDigital { get; set; }
        public string UserName { get; set; } = null!;
        public bool Registra { get; set; }
        public long InfoId { get; set; }
        public DateTime FechaRegistra { get; set; }
        public bool Anulado { get; set; }
    }
}

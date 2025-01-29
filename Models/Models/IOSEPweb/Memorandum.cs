using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class Memorandum
    {
        public int MemorandumId { get; set; }
        public int ProducidoPor { get; set; }
        public int ParaConocimientoDe { get; set; }
        public DateTime FechaMemo { get; set; }
        public int NotificarPor { get; set; }
        public string Asunto { get; set; } = null!;
        public string? Resumen { get; set; }
        public bool Digitalizado { get; set; }
        public string UsuarioCrea { get; set; } = null!;
        public DateTime FechaCrea { get; set; }
        public bool Anulado { get; set; }
    }
}

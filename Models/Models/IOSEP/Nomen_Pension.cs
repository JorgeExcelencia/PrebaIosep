using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Nomen_Pension
    {
        public int IdPension { get; set; }
        public int IdInternadoSector { get; set; }
        public int IdNomenclador { get; set; }
        public string Codigo { get; set; } = null!;
        public int dias { get; set; }
        public decimal Importe100 { get; set; }
        public decimal Importe80 { get; set; }
    }
}

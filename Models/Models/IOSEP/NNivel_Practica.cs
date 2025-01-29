using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class NNivel_Practica
    {
        public int IdNivel_Nomenclador { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Anulado { get; set; }
    }
}

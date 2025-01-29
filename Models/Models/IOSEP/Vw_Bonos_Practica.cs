using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Vw_Bonos_Practica
    {
        public string codigo { get; set; } = null!;
        public byte? Cantidad { get; set; }
        public string Practica { get; set; } = null!;
        public string CuilTitular { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public DateTime? Fecha_Emision { get; set; }
        public string Numero { get; set; } = null!;
        public string Cuil { get; set; } = null!;
        public string NombreTitular { get; set; } = null!;
        public int IdAutoriza { get; set; }
        public string Sexo { get; set; } = null!;
        public DateTime Edad { get; set; }
    }
}

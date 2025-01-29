using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwIntHisCli
    {
        public int IdInternado { get; set; }
        public string? Antecedentes { get; set; }
        public string? ExamenFisico { get; set; }
        public string? Estudios { get; set; }
        public string? Diagnostico { get; set; }
        public string? Motivo { get; set; }
        public string? Modificaria { get; set; }
        public string matricula { get; set; } = null!;
        public string nombre { get; set; } = null!;
        public int IdMedico { get; set; }
        public string? Practica { get; set; }
        public string? NombrePractica { get; set; }
        public DateTime Fecha { get; set; }
        public int IdHistoria { get; set; }
        public byte? cantidad { get; set; }
    }
}

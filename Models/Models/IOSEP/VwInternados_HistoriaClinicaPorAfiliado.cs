using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwInternados_HistoriaClinicaPorAfiliado
    {
        public int idafiliado { get; set; }
        public string? Antecedentes { get; set; }
        public string? ExamenFisico { get; set; }
        public string? Estudios { get; set; }
        public string? Diagnostico { get; set; }
        public string? Motivo { get; set; }
        public string? Modificaria { get; set; }
        public string matricula { get; set; } = null!;
        public string nombre { get; set; } = null!;
        public string? Practica { get; set; }
        public string? NombrePractica { get; set; }
        public DateTime Fecha { get; set; }
        public byte? cantidad { get; set; }
    }
}

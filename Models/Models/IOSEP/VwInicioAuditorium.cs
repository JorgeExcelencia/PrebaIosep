using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwInicioAuditorium
    {
        public int IdInternado { get; set; }
        public string Cuil { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public DateTime Fecha_Internacion { get; set; }
        public string? Diagnostico { get; set; }
        public DateTime? Fecha_Alta { get; set; }
        public string? NumeroInternacion { get; set; }
        public string? NumeroAlta { get; set; }
        public short IdEstado { get; set; }
        public int IdQuirofano { get; set; }
        public int IdClinica { get; set; }
        public bool? EsAlta { get; set; }
        public string? Dia { get; set; }
        public long? IdDiaInternado { get; set; }
        public string? Sector { get; set; }
        public int Evo { get; set; }
        public byte IdSector { get; set; }
        public int HC { get; set; }
        public string Clinica { get; set; } = null!;
        public bool? quirofano { get; set; }
    }
}

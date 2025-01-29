using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class VwInternadosImp
    {
        public int IdInternado { get; set; }
        public int IdAfiliado { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdClinica { get; set; }
        public int IdDiagnostico { get; set; }
        public string Codigo { get; set; } = null!;
        public string Diagnostico { get; set; } = null!;
        public short? IdTipoInternacion { get; set; }
        public int? IdPrestador { get; set; }
        public string? matricula { get; set; }
        public string? NombrePrestador { get; set; }
        public DateTime Fecha_Internacion { get; set; }
        public string? Habitacion { get; set; }
        public string? Cama { get; set; }
        public byte Edad { get; set; }
        public bool Hijo { get; set; }
        public string? Tratamiento { get; set; }
        public short IdEstado { get; set; }
        public string Cuil { get; set; } = null!;
        public bool Anulada { get; set; }
        public string NombreClinica { get; set; } = null!;
        public string Clinica { get; set; } = null!;
        public string? NumeroInternacion { get; set; }
        public DateTime? Autorizado { get; set; }
        public int IdTitular { get; set; }
        public string TipoInternacion { get; set; } = null!;
        public string? AuditorInternacion { get; set; }
    }
}

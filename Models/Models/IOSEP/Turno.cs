using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEP
{
    public partial class Turno
    {
        public int IdTurnos { get; set; }
        public int IdPrestador { get; set; }
        public string Fecha { get; set; } = null!;
        public string? Hora { get; set; }
        public string? Hora_Inici { get; set; }
        public string? Llego { get; set; }
        public string? Cuil { get; set; }
        public string? Telefono { get; set; }
        public string? Nombre { get; set; }
        public string? Detalle { get; set; }
        public string? NoDar { get; set; }
        public string? Operador { get; set; }
        public string? FecDia { get; set; }
        public string? Oper_Inic { get; set; }
        public string? Primera { get; set; }
        public string? Anterior { get; set; }
        public string? Tiempo { get; set; }
        public byte? Buffet { get; set; }
        public string? Cambiar { get; set; }
        public bool Anulado { get; set; }
    }
}
